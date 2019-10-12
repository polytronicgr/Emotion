﻿#region Using

using System;
using System.Diagnostics;
using System.Linq;

#endregion

namespace Emotion.Standard.Image
{
    public static class ImageUtil
    {
        /// <summary>
        /// Convert an image from a single component (assumed to be alpha) to a four component image.
        /// </summary>
        /// <param name="pixels">The single component pixel data.</param>
        /// <returns>The four component pixel data.</returns>
        public static byte[] AToRgba(byte[] pixels)
        {
            if (pixels == null) return null;

            var output = new byte[pixels.Length * 4];

            for (var p = 0; p < pixels.Length * 4; p += 4)
            {
                output[p] = 255;
                output[p + 1] = 255;
                output[p + 2] = 255;
                output[p + 3] = pixels[p / 4];
            }

            return output;
        }

        /// <summary>
        /// Inverts an image.
        /// </summary>
        /// <param name="imageData">The image pixels.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        public static unsafe void InvertImage(byte[] imageData, int width, int height)
        {
            int bytesPerRow = imageData.Length / height;

            fixed (void* dataPtr = &imageData[0])
            {
                // Used to temporary hold a row.
                var arr = new byte[bytesPerRow];
                var copyRow = new Span<byte>(arr);

                var buffer = new Span<byte>(dataPtr, imageData.Length);
                for (var y = 0; y < height / 2; y++)
                {
                    Span<byte> row = buffer.Slice(y * bytesPerRow, bytesPerRow);
                    int invertedY = height - 1 - y;
                    Span<byte> reverseRow = buffer.Slice(invertedY * bytesPerRow, bytesPerRow);

                    row.CopyTo(copyRow);
                    reverseRow.CopyTo(row);
                    copyRow.CopyTo(reverseRow);
                }
            }
        }

        /// <summary>
        /// Invert the endianess of pixels who are made up of four bytes.
        /// This can be used to convert RGBA to BGRA or in reverse.
        /// </summary>
        /// <param name="imageData">The pixel data to invert.</param>
        public static unsafe void InvertEndian32Bpp(byte[] imageData)
        {
            const int components = 4;

            Debug.Assert(imageData.Length % 4 == 0);

            fixed (byte* dataPtr = &imageData[0])
            {
                for (var pixelOffset = 0; pixelOffset < imageData.Length; pixelOffset += components)
                {
                    byte b = dataPtr[pixelOffset];
                    byte g = dataPtr[pixelOffset + 1];
                    byte r = dataPtr[pixelOffset + 2];
                    byte a = dataPtr[pixelOffset + 3];

                    dataPtr[pixelOffset] = r;
                    dataPtr[pixelOffset + 1] = g;
                    dataPtr[pixelOffset + 2] = b;
                    dataPtr[pixelOffset + 3] = a;
                }
            }
        }

        /// <summary>
        /// Converts byte array to a new array where each value in the original array is represented
        /// by a specified number of bits.
        /// </summary>
        /// <param name="bytes">The bytes to convert from. Cannot be null.</param>
        /// <param name="bits">The number of bits per value.</param>
        /// <returns>The resulting byte array. Is never null.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="bytes" /> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="bits" /> is greater or equals than zero.</exception>
        public static Span<byte> ToArrayByBitsLength(Span<byte> bytes, int bits)
        {
            Span<byte> result;
            if (bits < 8)
            {
                result = new byte[bytes.Length * 8 / bits];

                int factor = (int) Math.Pow(2, bits) - 1;
                int mask = 0xFF >> (8 - bits);
                var resultOffset = 0;

                for (var i = 0; i < bytes.Length; i++)
                {
                    for (var shift = 0; shift < 8; shift += bits)
                    {
                        int colorIndex = ((i >> (8 - bits - shift)) & mask) * (255 / factor);

                        result[resultOffset] = (byte) colorIndex;

                        resultOffset++;
                    }
                }
            }
            else
            {
                result = bytes;
            }

            return result;
        }

        /// <summary>
        /// Applies a 3x3 box filter to an image.
        /// </summary>
        /// <param name="pixels">The image pixels.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        /// <param name="kernel">The box filter kernel. Only 3x3 kernels are supported.</param>
        /// <returns></returns>
        public static byte[] BoxFilter3X3(byte[] pixels, int width, int height, float[] kernel)
        {
            var result = new byte[width * height];
            int[] indices =
            {
                -(width + 1), -width, -(width - 1),
                -1, 0, +1,
                width - 1, width, width + 1
            };

            float denominator = kernel.Sum();
            if (denominator == 0.0f) denominator = 1.0f;

            for (var i = 1; i < height - 1; i++)
            {
                for (var j = 1; j < width - 1; j++)
                {
                    var value = 0f;
                    int indexOffset = i * width + j;
                    for (var k = 0; k < kernel.Length; k++)
                    {
                        byte valueA = pixels[indexOffset + indices[k]];
                        value += valueA * kernel[k];
                    }

                    result[indexOffset] = (byte) (value / denominator);
                }
            }

            return result;
        }
    }
}
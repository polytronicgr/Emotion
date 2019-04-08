#region Using

using System;
using System.Drawing;
using System.Runtime.InteropServices;

#endregion

namespace FreeImageAPI
{
    /// <summary>
    /// The <b>FIRGBAF</b> structure describes a color consisting of relative
    /// intensities of red, green, blue and alpha value. Each single color
    /// component consumes 32 bits and takes values in the range from 0 to 1.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///     The <b>FIRGBAF</b> structure provides access to an underlying FreeImage <b>FIRGBAF</b>
    ///     structure. To determine the alpha, red, green or blue component of a color,
    ///     use the alpha, red, green or blue fields, respectively.
    ///     </para>
    ///     <para>
    ///     For easy integration of the underlying structure into the .NET framework,
    ///     the <b>FIRGBAF</b> structure implements implicit conversion operators to
    ///     convert the represented color to and from the <see cref="System.Drawing.Color" />
    ///     type. This makes the <see cref="System.Drawing.Color" /> type a real replacement
    ///     for the <b>FIRGBAF</b> structure and my be used in all situations which require
    ///     an <b>FIRGBAF</b> type.
    ///     </para>
    ///     <para>
    ///     Each color component alpha, red, green or blue of <b>FIRGBAF</b> is translated
    ///     into it's corresponding color component A, R, G or B of
    ///     <see cref="System.Drawing.Color" /> by linearly mapping the values of one range
    ///     into the other range and vice versa.
    ///     </para>
    ///     <para>
    ///         <b>Conversion from System.Drawing.Color to FIRGBAF</b>
    ///     </para>
    ///     <c>FIRGBAF.component = (float)Color.component / 255f</c>
    ///     <para>
    ///         <b>Conversion from FIRGBAF to System.Drawing.Color</b>
    ///     </para>
    ///     <c>Color.component = (int)(FIRGBAF.component * 255f)</c>
    ///     <para>
    ///     The same conversion is also applied when the <see cref="FreeImageAPI.FIRGBAF.Color" />
    ///     property or the <see cref="FreeImageAPI.FIRGBAF(System.Drawing.Color)" /> constructor
    ///     is invoked.
    ///     </para>
    /// </remarks>
    /// <example>
    /// The following code example demonstrates the various conversions between the
    /// <b>FIRGBAF</b> structure and the <see cref="System.Drawing.Color" /> structure.
    /// <code>
    /// FIRGBAF firgbaf;
    /// // Initialize the structure using a native .NET Color structure.
    /// firgbaf = new FIRGBAF(Color.Indigo);
    /// // Initialize the structure using the implicit operator.
    /// firgbaf = Color.DarkSeaGreen;
    /// // Convert the FIRGBAF instance into a native .NET Color
    /// // using its implicit operator.
    /// Color color = firgbaf;
    /// // Using the structure's Color property for converting it
    /// // into a native .NET Color.
    /// Color another = firgbaf.Color;
    /// </code>
    /// </example>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct FIRGBAF : IComparable, IComparable<FIRGBAF>, IEquatable<FIRGBAF>
    {
        /// <summary>
        /// The red color component.
        /// </summary>
        public float red;

        /// <summary>
        /// The green color component.
        /// </summary>
        public float green;

        /// <summary>
        /// The blue color component.
        /// </summary>
        public float blue;

        /// <summary>
        /// The alpha color component.
        /// </summary>
        public float alpha;

        /// <summary>
        /// Initializes a new instance based on the specified <see cref="System.Drawing.Color" />.
        /// </summary>
        /// <param name="color"><see cref="System.Drawing.Color" /> to initialize with.</param>
        public FIRGBAF(Color color)
        {
            red = color.R / 255f;
            green = color.G / 255f;
            blue = color.B / 255f;
            alpha = color.A / 255f;
        }

        /// <summary>
        /// Tests whether two specified <see cref="FIRGBAF" /> structures are equivalent.
        /// </summary>
        /// <param name="left">The <see cref="FIRGBAF" /> that is to the left of the equality operator.</param>
        /// <param name="right">The <see cref="FIRGBAF" /> that is to the right of the equality operator.</param>
        /// <returns>
        /// <b>true</b> if the two <see cref="FIRGBAF" /> structures are equal; otherwise, <b>false</b>.
        /// </returns>
        public static bool operator ==(FIRGBAF left, FIRGBAF right)
        {
            return
                left.alpha == right.alpha &&
                left.blue == right.blue &&
                left.green == right.green &&
                left.red == right.red;
        }

        /// <summary>
        /// Tests whether two specified <see cref="FIRGBAF" /> structures are different.
        /// </summary>
        /// <param name="left">The <see cref="FIRGBAF" /> that is to the left of the inequality operator.</param>
        /// <param name="right">The <see cref="FIRGBAF" /> that is to the right of the inequality operator.</param>
        /// <returns>
        /// <b>true</b> if the two <see cref="FIRGBAF" /> structures are different; otherwise, <b>false</b>.
        /// </returns>
        public static bool operator !=(FIRGBAF left, FIRGBAF right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts the value of a <see cref="System.Drawing.Color" /> structure to a <see cref="FIRGBAF" /> structure.
        /// </summary>
        /// <param name="value">A <see cref="System.Drawing.Color" /> structure.</param>
        /// <returns>A new instance of <see cref="FIRGBAF" /> initialized to <paramref name="value" />.</returns>
        public static implicit operator FIRGBAF(Color value)
        {
            return new FIRGBAF(value);
        }

        /// <summary>
        /// Converts the value of a <see cref="FIRGBAF" /> structure to a <see cref="System.Drawing.Color" /> structure.
        /// </summary>
        /// <param name="value">A <see cref="FIRGBAF" /> structure.</param>
        /// <returns>A new instance of <see cref="System.Drawing.Color" /> initialized to <paramref name="value" />.</returns>
        public static implicit operator Color(FIRGBAF value)
        {
            return value.Color;
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Drawing.Color" /> of the structure.
        /// </summary>
        public Color Color
        {
            get =>
                Color.FromArgb(
                    (int) (alpha * 255f),
                    (int) (red * 255f),
                    (int) (green * 255f),
                    (int) (blue * 255f));
            set
            {
                red = value.R / 255f;
                green = value.G / 255f;
                blue = value.B / 255f;
                alpha = value.A / 255f;
            }
        }

        /// <summary>
        /// Compares this instance with a specified <see cref="Object" />.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>A 32-bit signed integer indicating the lexical relationship between the two comparands.</returns>
        /// <exception cref="ArgumentException"><paramref name="obj" /> is not a <see cref="FIRGBAF" />.</exception>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (!(obj is FIRGBAF)) throw new ArgumentException("obj");

            return CompareTo((FIRGBAF) obj);
        }

        /// <summary>
        /// Compares this instance with a specified <see cref="FIRGBAF" /> object.
        /// </summary>
        /// <param name="other">A <see cref="FIRGBAF" /> to compare.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance
        /// and <paramref name="other" />.
        /// </returns>
        public int CompareTo(FIRGBAF other)
        {
            return Color.ToArgb().CompareTo(other.Color.ToArgb());
        }

        /// <summary>
        /// Tests whether the specified object is a <see cref="FIRGBAF" /> structure
        /// and is equivalent to this <see cref="FIRGBAF" /> structure.
        /// </summary>
        /// <param name="obj">The object to test.</param>
        /// <returns>
        /// <b>true</b> if <paramref name="obj" /> is a <see cref="FIRGBAF" /> structure
        /// equivalent to this <see cref="FIRGBAF" /> structure; otherwise, <b>false</b>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj is FIRGBAF && this == (FIRGBAF) obj;
        }

        /// <summary>
        /// Tests whether the specified <see cref="FIRGBAF" /> structure is equivalent to this <see cref="FIRGBAF" /> structure.
        /// </summary>
        /// <param name="other">A <see cref="FIRGBAF" /> structure to compare to this instance.</param>
        /// <returns>
        /// <b>true</b> if <paramref name="obj" /> is a <see cref="FIRGBAF" /> structure
        /// equivalent to this <see cref="FIRGBAF" /> structure; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(FIRGBAF other)
        {
            return this == other;
        }

        /// <summary>
        /// Returns a hash code for this <see cref="FIRGBAF" /> structure.
        /// </summary>
        /// <returns>An integer value that specifies the hash code for this <see cref="FIRGBAF" />.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Converts the numeric value of the <see cref="FIRGBAF" /> object
        /// to its equivalent string representation.
        /// </summary>
        /// <returns>The string representation of the value of this instance.</returns>
        public override string ToString()
        {
            return FreeImage.ColorToString(Color);
        }
    }
}
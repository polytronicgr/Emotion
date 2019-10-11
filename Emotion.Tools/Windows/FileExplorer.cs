﻿#region Using

using System;
using System.IO;
using System.Linq;
using Emotion.Common;
using Emotion.Graphics;
using Emotion.IO;
using Emotion.Plugins.ImGuiNet.Windowing;
using ImGuiNET;

#endregion

namespace Emotion.Tools.Windows
{
    public class FileExplorer<T> : ImGuiWindow where T : Asset, new()
    {
        private Action<T> _fileSelected;
        private string _customFile = "";

        /// <summary>
        /// Create a file explorer dialog.
        /// </summary>
        /// <param name="fileSelected">The callback to receive the selected file.</param>
        public FileExplorer(Action<T> fileSelected) : base($"Pick a [{typeof(T)}]")
        {
            _fileSelected = fileSelected;
        }

        protected override void RenderContent(RenderComposer composer)
        {
            // Add custom path option.
            ImGui.InputText("Custom File: ", ref _customFile, 300);
            ImGui.SameLine();
            if (ImGui.Button("Load") && File.Exists(_customFile))
            {
                T file = ExplorerLoadAsset(_customFile);
                _fileSelected?.Invoke(file);
                Open = false;
                return;
            }

            // Get all available assets.
            string[] assets = Engine.AssetLoader.AllAssets;
            assets = assets.OrderBy(x => Path.GetDirectoryName(x)).ToArray();
            string directory = null;
            var nodeOpen = false;
            foreach (string asset in assets)
            {
                string curDirectory = Path.GetDirectoryName(asset);
                // If the next asset is from a different directory, swap the tree node.
                if (curDirectory != directory)
                {
                    if (nodeOpen) ImGui.TreePop();
                    nodeOpen = ImGui.TreeNode(string.IsNullOrEmpty(curDirectory) ? "/" : curDirectory);
                    directory = curDirectory;
                }

                if (!nodeOpen) continue;
                if (!ImGui.Button(Path.GetFileName(asset))) continue;
                // Load the asset custom so the asset loader's caching doesn't get in the way.
                T file = ExplorerLoadAsset(asset);
                if (file == null) continue;
                _fileSelected?.Invoke(file);
                Open = false;
                return;
            }

            if (nodeOpen) ImGui.TreePop();
        }

        public override void Update()
        {
        }

        public static T ExplorerLoadAsset(string name)
        {
            // Try to load through the asset loader.
            AssetSource source = Engine.AssetLoader.GetSource(name);
            if (source == null)
            {
                // Try the file system.
                if (!File.Exists(name)) return default;
                var file = new T
                {
                    Name = name
                };
                file.Create(File.ReadAllBytes(name));
                return file;

                // Not found
            }

            {
                var file = new T
                {
                    Name = name
                };
                file.Create(source.GetAsset(name));
                return file;
            }
        }
    }
}
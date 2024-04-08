﻿using System.Collections.Generic;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using MonoGame.Extended.Tiled.Serialization;

namespace MonoGame.Extended.Content.Pipeline.Tiled
{
    public static class ContentWriterExtensions
    {
        // ReSharper disable once SuggestBaseTypeForParameter
        public static void WriteTiledMapProperties(this ContentWriter writer, IReadOnlyCollection<TiledMapPropertyContent> value)
        {
            if (value == null)
            {
                writer.Write(0);
                return;
            }
            writer.Write(value.Count);
            foreach (var property in value)
            {
                writer.Write(property.Name);
                writer.Write(property.Value ?? string.Empty);
<<<<<<< HEAD
                writer.Write(property.Type ?? string.Empty);
                writer.Write(property.PropertyType ?? string.Empty);
=======
>>>>>>> bde79b89970010e29e2204042ac717246b20073b
                WriteTiledMapProperties(writer, property.Properties);
            }
        }
    }
}

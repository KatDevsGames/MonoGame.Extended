using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame.Extended.Tiled
{
    public class TiledMapImageLayer : TiledMapLayer, IMovable
    {
        public TiledMapImageLayer(string name, string type, Texture2D image, Vector2? position = null, Vector2? offset = null, Vector2? parallaxFactor = null, float opacity = 1.0f, bool repeatX = false, bool repeatY = false, bool isVisible = true)
            : base(name, type, offset, parallaxFactor, opacity, isVisible)
        {
            Image = image;
            Position = position ?? Vector2.Zero;
            RepeatX = repeatX;
            RepeatY = repeatY;
        }

        public Texture2D Image { get; }
        public Vector2 Position { get; set; }
        public bool RepeatX { get; set; }
        public bool RepeatY { get; set; }
    }
}

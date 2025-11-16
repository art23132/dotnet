

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Objects
{

    // create obj Cats
    public class Sprite_cat 
    {
        public Texture2D texture; 
        public Vector2 position;

        public Sprite_cat(Texture2D texture, Vector2 position)
        {
            this.texture = texture; 
            this.position = position;
        }
        
    }

    public class ScaledSprite : Sprite_cat
    {
        public Rectangle Rect 
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, 32,32);
            }
        }

        public ScaledSprite(Texture2D texture, Vector2 position) : base (texture,position) {}
    }


    // create obj Futa
    public class Sprite_Fut
    {
        public Texture2D texture; 
        public Vector2 position;

        public Sprite_Fut(Texture2D texture, Vector2 position)
        {
            this.texture = texture; 
            this.position = position;
        }
    }
}

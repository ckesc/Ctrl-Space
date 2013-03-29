using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Ctrl_Space
{
    public class TextureManager
    {
        public Texture2D ShipTexture { get; set; }
        public Texture2D ShipOffTexture { get; set; }
        public Texture2D RocketTexture { get; set; }
        public Texture2D AsteroidTexture { get; set; }
        public Texture2D SpeedBonusTexture { get; set; }
        public Texture2D SpaceTexture { get; set; }
        public Texture2D PlasmaBulletTexture { get; set; }

        public TextureManager(ContentManager contentManaget)
        {
            ShipTexture = contentManaget.Load<Texture2D>("Ship");
            ShipOffTexture = contentManaget.Load<Texture2D>("Ship-off");
            AsteroidTexture = contentManaget.Load<Texture2D>("Asteroid");
            RocketTexture = contentManaget.Load<Texture2D>("Rocket");
            SpeedBonusTexture = contentManaget.Load<Texture2D>("SpeedBonus");
            SpaceTexture = contentManaget.Load<Texture2D>("Space");
            PlasmaBulletTexture = contentManaget.Load<Texture2D>("PlasmaBullet");
        }
    }
}
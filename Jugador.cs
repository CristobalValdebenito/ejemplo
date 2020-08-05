using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clase_1
{
    public class Jugador
    {
        SpriteFont TextoPuntaje;
        public int puntaje { private set; get; }
        public Jugador(ContentManager Content)
        {
            TextoPuntaje = Content.Load<SpriteFont>("FontExample");
        }
        public void AddPuntos()
        {
            puntaje++;
        }
        public void ResetPuntos()
        {
            puntaje = 0;
        }
        public void Draw(SpriteBatch SB)
        {
            Vector2 TextoPos = new Vector2(SB.GraphicsDevice.Viewport.Width / 2, SB.GraphicsDevice.Viewport.Height / 10);
            string Mensaje = "Puntaje: " + puntaje;
            Vector2 TextCenter = TextoPuntaje.MeasureString(Mensaje) / 2;
            SB.DrawString(TextoPuntaje, Mensaje, TextoPos, Color.Black, 0, TextCenter, 1, SpriteEffects.None, 0);
        }
    }
}

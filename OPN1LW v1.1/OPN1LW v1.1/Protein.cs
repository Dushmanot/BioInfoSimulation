using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OPN1LW_v1._1
{
    public class Protein
    {
        public float X { get; set; }
        public float Y { get; set; }

        public float Radius { get; set; }

        public float Velocity { get; set; }
        public float Angle { get; set; }

        private float velocityX;
        private float velocityY;

        private Graphics g;
        private Brush brush;

        public Protein(float x, float y, float radius, float velocity, float angle)
        {
            X = x;
            Y = y;
            Radius = radius;
            Velocity = velocity;
            Angle = angle;

            velocityX = (float)Math.Cos(Angle) * Velocity;
            velocityY = (float)Math.Sin(Angle) * Velocity;
        }

        public void Draw(Brush brush, Graphics g)
        {
            this.g = g;
            this.brush = brush;
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}

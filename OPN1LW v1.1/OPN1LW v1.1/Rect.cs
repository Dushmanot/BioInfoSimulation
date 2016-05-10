using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OPN1LW_v1._1
{
    public class Rect
    {
        private Rectangle rect { get; set; }
        private Brush brush { get; set; }
        
        public Rect(Brush brush, Rectangle rect)
        {
            this.rect = rect;
            this.brush = brush;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(brush, rect); 
        }

        public void Zoom()
        {

        }

        public void MoveToMiddle()
        {

        }
    }
}

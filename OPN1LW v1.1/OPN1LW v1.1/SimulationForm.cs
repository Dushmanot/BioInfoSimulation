using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPN1LW_v1._1
{
    public partial class SimulationForm : Form
    {

        private Protein p300;
        private Protein arnt;
        private Protein FOX04;
        private Protein STAT1;
        private Graphics g;

        public SimulationForm()
        {
            InitializeComponent();
            p300 = new Protein(20, 20, 10, 10, 30);
            arnt = new Protein(50, 20, 10, 10, 30);
            FOX04 = new Protein(80, 20, 10, 10, 30);
            STAT1 = new Protein(110, 20, 10, 10, 30);
            g = CreateGraphics();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Brush brush = new SolidBrush(Color.Black);
            for (int i=0; i<15; i++)
            {
                Rectangle rect = new Rectangle(100+i*50, 50, 50, 50);
                if (i % 2 == 0)
                    brush = new SolidBrush(Color.Red);
                else
                    brush = new SolidBrush(Color.Green);

                g.DrawRectangle(new Pen(brush), rect);
                g.FillRectangle(brush, rect);
            }

            p300.Draw(new SolidBrush(Color.MediumOrchid), g);
            arnt.Draw(new SolidBrush(Color.Tan), g);
            FOX04.Draw(new SolidBrush(Color.Bisque), g);
            STAT1.Draw(new SolidBrush(Color.Gainsboro), g);




            brush.Dispose();
            
           

          
        }
    }
}

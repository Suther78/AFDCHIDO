using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSM_Simple
{
    public partial class Dibujo : Form
    {
        public Button button1;
        public Dibujo()
        {
           
          
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Dibujo dib = new Dibujo();
            System.Drawing.Graphics newGraphics;
            newGraphics = dib.CreateGraphics();
            Pen penStroke = new Pen(System.Drawing.Color.Red, 7);
            Rectangle aRectangle = new Rectangle(30, 10, 400, 400);

            newGraphics.DrawEllipse(penStroke, aRectangle);
        }

    }
}

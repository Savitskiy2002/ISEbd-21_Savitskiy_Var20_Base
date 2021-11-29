using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCatamarans
{
    public partial class FormCatamarans : Form
    {
        private ITransport cat;
        public FormCatamarans()
        {
            InitializeComponent();
        }

        public void setCat(ITransport cat)
        {
            this.cat = cat;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCatamarans.Width, pictureBoxCatamarans.Height);
            Graphics gr = Graphics.FromImage(bmp);
            cat.DrawCatamaran(gr);
            pictureBoxCatamarans.Image = bmp;
        }

        private void buttonCreateCatamaran_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            cat = new CarCat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            cat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamarans.Width, pictureBoxCatamarans.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    cat.MoveBoat(Direction.Up);
                    break;
                case "buttonDown":
                    cat.MoveBoat(Direction.Down);
                    break;
                case "buttonLeft":
                    cat.MoveBoat(Direction.Left);
                    break;
                case "buttonRight":
                    cat.MoveBoat(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateBoat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            cat = new CatamaranGrade(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true);
            cat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamarans.Width, pictureBoxCatamarans.Height);
            Draw();
        }
    }
}
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
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;

        public FormParking()

        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;

        }

        private void buttonParkBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var cat = new CarCat(100, 1000, dialog.Color);
                if (parking + cat> -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена!");
                }
            }
        }

        private void buttonParkCatamaran_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var cat = new CatamaranGrade(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + cat > -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена!");
                    }
                }
            }
        }

        private void buttonTakeOff_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxParking.Text != "")
            {
                var cat = parking - Convert.ToInt32(maskedTextBoxParking.Text);
                if (cat != null)
                {
                    FormCatamarans form = new FormCatamarans();
                    form.setCat(cat);
                    form.ShowDialog();
                }
                maskedTextBoxParking.Text = "";
                Draw();
            }
        }
    }
}
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
        private ParkingCollection parkingColl;

        public FormParking()

        {
            InitializeComponent();
            parkingColl = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }

        private void ReloadLevels()
        {
            int index = lBParking.SelectedIndex;
            lBParking.Items.Clear();
            for (int i = 0; i < parkingColl.Keys.Count; i++)
            {
                lBParking.Items.Add(parkingColl.Keys[i]);
            }
            if (lBParking.Items.Count > 0 && (index == -1 || index >= lBParking.Items.Count))
            {
                lBParking.SelectedIndex = 0;
            }
            else if (lBParking.Items.Count > 0 && index > -1 && index < lBParking.Items.Count)
            {
                lBParking.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parkingColl[lBParking.SelectedItem.ToString()].Draw(gr);
            pictureBoxParking.Image = bmp;

        }

        private void btnParkAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBParkName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingColl.AddParking(tBParkName.Text);
            ReloadLevels();
        }

        private void btnRemovePark_Click(object sender, EventArgs e)
        {
            if (lBParking.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { lBParking.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingColl.DelParking(lBParking.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void buttonParkBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var cat = new CarCat(100, 1000, dialog.Color);
                if (parkingColl[lBParking.SelectedItem.ToString()] + cat)
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
                    if (parkingColl[lBParking.SelectedItem.ToString()] + cat)
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
                var cat = parkingColl[lBParking.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxParking.Text);
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

        private void lBParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void AddCar(CarCat car)
        {
            if (car != null && lBParking.SelectedIndex > -1)
            {
                if ((parkingColl[lBParking.SelectedItem.ToString()]) + car)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormCarConfig();
            formCarConfig.AddEvent(AddCar);
            formCarConfig.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (parkingColl.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (parkingColl.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsCatamarans
{
    public partial class FormParking : Form
    {
        private readonly ParkingCollection parkingColl;
        private readonly Logger logger;

        public FormParking()

        {
            InitializeComponent();
            parkingColl = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                logger.Warn("Не введено название парковки!");
                return;
            }
            logger.Info($"Добавили парковку {tBParkName.Text}");
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
                    logger.Info($"Удалили парковку {lBParking.SelectedItem.ToString()}");
                    ReloadLevels();
                }
            }
        }

        private void buttonTakeOff_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxParking.Text != "" && lBParking.SelectedIndex > -1)
            {
                try
                {
                    var cat = parkingColl[lBParking.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxParking.Text);
                    if (cat != null)
                    {
                        FormCatamarans form = new FormCatamarans();
                        form.setCat(cat);
                        form.ShowDialog();
                        logger.Info($"Изъят транспорт {cat} с места {maskedTextBoxParking.Text}");
                    }
                    maskedTextBoxParking.Text = "";
                    Draw();
                }
                catch (ParkingNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }

        private void lBParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {lBParking.SelectedItem.ToString()}");
            Draw();
        }

        private void AddCar(CarCat car)
        {
            if (car != null && lBParking.SelectedIndex > -1)
            {
                try
                {
                    if ((parkingColl[lBParking.SelectedItem.ToString()]) + car)
                    {
                        Draw();
                        logger.Info($"Добавлен транспорт {car}");
                    }
                    else
                    {
                        MessageBox.Show("Машину не удалось поставить");
                    }
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
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
                try
                {
                    parkingColl.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingColl.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }
    }
}
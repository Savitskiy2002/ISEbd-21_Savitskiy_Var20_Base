namespace WindowsFormsCatamarans
{
    partial class FormParking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.buttonTakeOff = new System.Windows.Forms.Button();
            this.maskedTextBoxParking = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemovePark = new System.Windows.Forms.Button();
            this.btnParkAdd = new System.Windows.Forms.Button();
            this.tBParkName = new System.Windows.Forms.TextBox();
            this.lBParking = new System.Windows.Forms.ListBox();
            this.lParking = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(750, 497);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.buttonTakeOff);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxParking);
            this.groupBoxParking.Controls.Add(this.label1);
            this.groupBoxParking.Location = new System.Drawing.Point(760, 272);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(134, 80);
            this.groupBoxParking.TabIndex = 3;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать лодку";
            // 
            // buttonTakeOff
            // 
            this.buttonTakeOff.Location = new System.Drawing.Point(0, 50);
            this.buttonTakeOff.Name = "buttonTakeOff";
            this.buttonTakeOff.Size = new System.Drawing.Size(123, 23);
            this.buttonTakeOff.TabIndex = 2;
            this.buttonTakeOff.Text = "Забрать";
            this.buttonTakeOff.UseVisualStyleBackColor = true;
            this.buttonTakeOff.Click += new System.EventHandler(this.buttonTakeOff_Click);
            // 
            // maskedTextBoxParking
            // 
            this.maskedTextBoxParking.Location = new System.Drawing.Point(65, 24);
            this.maskedTextBoxParking.Name = "maskedTextBoxParking";
            this.maskedTextBoxParking.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBoxParking.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // btnRemovePark
            // 
            this.btnRemovePark.Location = new System.Drawing.Point(760, 198);
            this.btnRemovePark.Name = "btnRemovePark";
            this.btnRemovePark.Size = new System.Drawing.Size(134, 23);
            this.btnRemovePark.TabIndex = 13;
            this.btnRemovePark.Text = "Удалить парковку";
            this.btnRemovePark.UseVisualStyleBackColor = true;
            this.btnRemovePark.Click += new System.EventHandler(this.btnRemovePark_Click);
            // 
            // btnParkAdd
            // 
            this.btnParkAdd.Location = new System.Drawing.Point(760, 67);
            this.btnParkAdd.Name = "btnParkAdd";
            this.btnParkAdd.Size = new System.Drawing.Size(134, 23);
            this.btnParkAdd.TabIndex = 12;
            this.btnParkAdd.Text = "Добавить парковку";
            this.btnParkAdd.UseVisualStyleBackColor = true;
            this.btnParkAdd.Click += new System.EventHandler(this.btnParkAdd_Click);
            // 
            // tBParkName
            // 
            this.tBParkName.Location = new System.Drawing.Point(760, 40);
            this.tBParkName.Name = "tBParkName";
            this.tBParkName.Size = new System.Drawing.Size(134, 20);
            this.tBParkName.TabIndex = 11;
            // 
            // lBParking
            // 
            this.lBParking.FormattingEnabled = true;
            this.lBParking.Location = new System.Drawing.Point(760, 96);
            this.lBParking.Name = "lBParking";
            this.lBParking.Size = new System.Drawing.Size(134, 95);
            this.lBParking.TabIndex = 10;
            this.lBParking.SelectedIndexChanged += new System.EventHandler(this.lBParking_SelectedIndexChanged);
            // 
            // lParking
            // 
            this.lParking.AutoSize = true;
            this.lParking.Location = new System.Drawing.Point(796, 24);
            this.lParking.Name = "lParking";
            this.lParking.Size = new System.Drawing.Size(57, 13);
            this.lParking.TabIndex = 9;
            this.lParking.Text = "Парковки";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(760, 227);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(134, 39);
            this.btnChoose.TabIndex = 14;
            this.btnChoose.Text = "Добавить";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 521);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnRemovePark);
            this.Controls.Add(this.btnParkAdd);
            this.Controls.Add(this.tBParkName);
            this.Controls.Add(this.lBParking);
            this.Controls.Add(this.lParking);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonTakeOff;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemovePark;
        private System.Windows.Forms.Button btnParkAdd;
        private System.Windows.Forms.TextBox tBParkName;
        private System.Windows.Forms.ListBox lBParking;
        private System.Windows.Forms.Label lParking;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
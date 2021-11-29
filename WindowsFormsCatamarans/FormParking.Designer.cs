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
            this.buttonParkBoat = new System.Windows.Forms.Button();
            this.buttonParkCatamaran = new System.Windows.Forms.Button();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.buttonTakeOff = new System.Windows.Forms.Button();
            this.maskedTextBoxParking = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemovePark = new System.Windows.Forms.Button();
            this.btnParkAdd = new System.Windows.Forms.Button();
            this.tBParkName = new System.Windows.Forms.TextBox();
            this.lBParking = new System.Windows.Forms.ListBox();
            this.lParking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(750, 461);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkBoat
            // 
            this.buttonParkBoat.Location = new System.Drawing.Point(763, 212);
            this.buttonParkBoat.Name = "buttonParkBoat";
            this.buttonParkBoat.Size = new System.Drawing.Size(134, 39);
            this.buttonParkBoat.TabIndex = 1;
            this.buttonParkBoat.Text = "Припарковать лодку";
            this.buttonParkBoat.UseVisualStyleBackColor = true;
            this.buttonParkBoat.Click += new System.EventHandler(this.buttonParkBoat_Click);
            // 
            // buttonParkCatamaran
            // 
            this.buttonParkCatamaran.Location = new System.Drawing.Point(763, 257);
            this.buttonParkCatamaran.Name = "buttonParkCatamaran";
            this.buttonParkCatamaran.Size = new System.Drawing.Size(134, 39);
            this.buttonParkCatamaran.TabIndex = 2;
            this.buttonParkCatamaran.Text = "Припарковать катамаран";
            this.buttonParkCatamaran.UseVisualStyleBackColor = true;
            this.buttonParkCatamaran.Click += new System.EventHandler(this.buttonParkCatamaran_Click);
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.buttonTakeOff);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxParking);
            this.groupBoxParking.Controls.Add(this.label1);
            this.groupBoxParking.Location = new System.Drawing.Point(763, 302);
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
            this.btnRemovePark.Location = new System.Drawing.Point(763, 183);
            this.btnRemovePark.Name = "btnRemovePark";
            this.btnRemovePark.Size = new System.Drawing.Size(134, 23);
            this.btnRemovePark.TabIndex = 13;
            this.btnRemovePark.Text = "Удалить парковку";
            this.btnRemovePark.UseVisualStyleBackColor = true;
            this.btnRemovePark.Click += new System.EventHandler(this.btnRemovePark_Click);
            // 
            // btnParkAdd
            // 
            this.btnParkAdd.Location = new System.Drawing.Point(763, 52);
            this.btnParkAdd.Name = "btnParkAdd";
            this.btnParkAdd.Size = new System.Drawing.Size(134, 23);
            this.btnParkAdd.TabIndex = 12;
            this.btnParkAdd.Text = "Добавить парковку";
            this.btnParkAdd.UseVisualStyleBackColor = true;
            this.btnParkAdd.Click += new System.EventHandler(this.btnParkAdd_Click);
            // 
            // tBParkName
            // 
            this.tBParkName.Location = new System.Drawing.Point(763, 25);
            this.tBParkName.Name = "tBParkName";
            this.tBParkName.Size = new System.Drawing.Size(134, 20);
            this.tBParkName.TabIndex = 11;
            // 
            // lBParking
            // 
            this.lBParking.FormattingEnabled = true;
            this.lBParking.Location = new System.Drawing.Point(763, 81);
            this.lBParking.Name = "lBParking";
            this.lBParking.Size = new System.Drawing.Size(134, 95);
            this.lBParking.TabIndex = 10;
            this.lBParking.SelectedIndexChanged += new System.EventHandler(this.lBParking_SelectedIndexChanged);
            // 
            // lParking
            // 
            this.lParking.AutoSize = true;
            this.lParking.Location = new System.Drawing.Point(801, 9);
            this.lParking.Name = "lParking";
            this.lParking.Size = new System.Drawing.Size(57, 13);
            this.lParking.TabIndex = 9;
            this.lParking.Text = "Парковки";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 461);
            this.Controls.Add(this.btnRemovePark);
            this.Controls.Add(this.btnParkAdd);
            this.Controls.Add(this.tBParkName);
            this.Controls.Add(this.lBParking);
            this.Controls.Add(this.lParking);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.buttonParkCatamaran);
            this.Controls.Add(this.buttonParkBoat);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkBoat;
        private System.Windows.Forms.Button buttonParkCatamaran;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonTakeOff;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemovePark;
        private System.Windows.Forms.Button btnParkAdd;
        private System.Windows.Forms.TextBox tBParkName;
        private System.Windows.Forms.ListBox lBParking;
        private System.Windows.Forms.Label lParking;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxParking = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeOff = new System.Windows.Forms.Button();
            this.pictureBoxParkingS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParkingS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(753, 461);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkBoat
            // 
            this.buttonParkBoat.Location = new System.Drawing.Point(773, 12);
            this.buttonParkBoat.Name = "buttonParkBoat";
            this.buttonParkBoat.Size = new System.Drawing.Size(99, 69);
            this.buttonParkBoat.TabIndex = 1;
            this.buttonParkBoat.Text = "Припарковать лодку";
            this.buttonParkBoat.UseVisualStyleBackColor = true;
            this.buttonParkBoat.Click += new System.EventHandler(this.buttonParkBoat_Click);
            // 
            // buttonParkCatamaran
            // 
            this.buttonParkCatamaran.Location = new System.Drawing.Point(773, 87);
            this.buttonParkCatamaran.Name = "buttonParkCatamaran";
            this.buttonParkCatamaran.Size = new System.Drawing.Size(99, 69);
            this.buttonParkCatamaran.TabIndex = 2;
            this.buttonParkCatamaran.Text = "Припарковать катамаран";
            this.buttonParkCatamaran.UseVisualStyleBackColor = true;
            this.buttonParkCatamaran.Click += new System.EventHandler(this.buttonParkCatamaran_Click);
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.pictureBoxParkingS);
            this.groupBoxParking.Controls.Add(this.buttonTakeOff);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxParking);
            this.groupBoxParking.Controls.Add(this.label1);
            this.groupBoxParking.Location = new System.Drawing.Point(773, 183);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(99, 163);
            this.groupBoxParking.TabIndex = 3;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать лодку";
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
            // maskedTextBoxParking
            // 
            this.maskedTextBoxParking.Location = new System.Drawing.Point(53, 24);
            this.maskedTextBoxParking.Name = "maskedTextBoxParking";
            this.maskedTextBoxParking.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBoxParking.TabIndex = 1;
            // 
            // buttonTakeOff
            // 
            this.buttonTakeOff.Location = new System.Drawing.Point(9, 50);
            this.buttonTakeOff.Name = "buttonTakeOff";
            this.buttonTakeOff.Size = new System.Drawing.Size(84, 23);
            this.buttonTakeOff.TabIndex = 2;
            this.buttonTakeOff.Text = "Забрать";
            this.buttonTakeOff.UseVisualStyleBackColor = true;
            this.buttonTakeOff.Click += new System.EventHandler(this.buttonTakeOff_Click);
            // 
            // pictureBoxParkingS
            // 
            this.pictureBoxParkingS.Location = new System.Drawing.Point(6, 79);
            this.pictureBoxParkingS.Name = "pictureBoxParkingS";
            this.pictureBoxParkingS.Size = new System.Drawing.Size(93, 78);
            this.pictureBoxParkingS.TabIndex = 3;
            this.pictureBoxParkingS.TabStop = false;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.buttonParkCatamaran);
            this.Controls.Add(this.buttonParkBoat);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParkingS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkBoat;
        private System.Windows.Forms.Button buttonParkCatamaran;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.PictureBox pictureBoxParkingS;
        private System.Windows.Forms.Button buttonTakeOff;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxParking;
        private System.Windows.Forms.Label label1;
    }
}
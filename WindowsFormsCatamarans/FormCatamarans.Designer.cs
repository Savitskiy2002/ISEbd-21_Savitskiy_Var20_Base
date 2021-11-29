namespace WindowsFormsCatamarans
{
    partial class FormCatamarans
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
            this.pictureBoxCatamarans = new System.Windows.Forms.PictureBox();
            this.buttonCreateCatamaran = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCreateBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatamarans)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCatamarans
            // 
            this.pictureBoxCatamarans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCatamarans.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCatamarans.Name = "pictureBoxCatamarans";
            this.pictureBoxCatamarans.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxCatamarans.TabIndex = 0;
            this.pictureBoxCatamarans.TabStop = false;
            // 
            // buttonCreateCatamaran
            // 
            this.buttonCreateCatamaran.Location = new System.Drawing.Point(22, 13);
            this.buttonCreateCatamaran.Name = "buttonCreateCatamaran";
            this.buttonCreateCatamaran.Size = new System.Drawing.Size(122, 23);
            this.buttonCreateCatamaran.TabIndex = 1;
            this.buttonCreateCatamaran.Text = "Создать лодку";
            this.buttonCreateCatamaran.UseVisualStyleBackColor = true;
            this.buttonCreateCatamaran.Click += new System.EventHandler(this.buttonCreateCatamaran_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsCatamarans.Properties.Resources.Зелёная_стрелка1;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(724, 364);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsCatamarans.Properties.Resources.Зелёная_стрелка2;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(724, 400);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsCatamarans.Properties.Resources.Зелёная_стрелка3;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(688, 400);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsCatamarans.Properties.Resources.Зелёная_стрелка4;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(760, 400);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateBoat
            // 
            this.buttonCreateBoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCreateBoat.Location = new System.Drawing.Point(150, 13);
            this.buttonCreateBoat.Name = "buttonCreateBoat";
            this.buttonCreateBoat.Size = new System.Drawing.Size(120, 23);
            this.buttonCreateBoat.TabIndex = 6;
            this.buttonCreateBoat.Text = "Создать катамаран";
            this.buttonCreateBoat.UseVisualStyleBackColor = true;
            this.buttonCreateBoat.Click += new System.EventHandler(this.buttonCreateBoat_Click);
            // 
            // FormCatamarans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateBoat);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateCatamaran);
            this.Controls.Add(this.pictureBoxCatamarans);
            this.Name = "FormCatamarans";
            this.Text = "Катамаран";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatamarans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCatamarans;
        private System.Windows.Forms.Button buttonCreateCatamaran;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCreateBoat;
    }
}
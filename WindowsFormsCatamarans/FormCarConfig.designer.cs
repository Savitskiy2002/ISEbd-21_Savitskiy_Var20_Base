namespace WindowsFormsCatamarans
{
    partial class FormCarConfig
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
            this.gBTypes = new System.Windows.Forms.GroupBox();
            this.lAdditional = new System.Windows.Forms.Label();
            this.lBase = new System.Windows.Forms.Label();
            this.gBProps = new System.Windows.Forms.GroupBox();
            this.cBsail = new System.Windows.Forms.CheckBox();
            this.cBmotor = new System.Windows.Forms.CheckBox();
            this.nUDWeight = new System.Windows.Forms.NumericUpDown();
            this.nUDMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBpreview = new System.Windows.Forms.PictureBox();
            this.pPicBox = new System.Windows.Forms.Panel();
            this.gBColors = new System.Windows.Forms.GroupBox();
            this.lDopCol = new System.Windows.Forms.Label();
            this.lMainCol = new System.Windows.Forms.Label();
            this.pBlue = new System.Windows.Forms.Panel();
            this.pBlack = new System.Windows.Forms.Panel();
            this.pGreen = new System.Windows.Forms.Panel();
            this.pOrange = new System.Windows.Forms.Panel();
            this.pYellow = new System.Windows.Forms.Panel();
            this.pWhite = new System.Windows.Forms.Panel();
            this.pGray = new System.Windows.Forms.Panel();
            this.pRed = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBTypes.SuspendLayout();
            this.gBProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpreview)).BeginInit();
            this.pPicBox.SuspendLayout();
            this.gBColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTypes
            // 
            this.gBTypes.Controls.Add(this.lAdditional);
            this.gBTypes.Controls.Add(this.lBase);
            this.gBTypes.Location = new System.Drawing.Point(13, 12);
            this.gBTypes.Name = "gBTypes";
            this.gBTypes.Size = new System.Drawing.Size(136, 95);
            this.gBTypes.TabIndex = 0;
            this.gBTypes.TabStop = false;
            this.gBTypes.Text = "Тип транспорта";
            // 
            // lAdditional
            // 
            this.lAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lAdditional.Location = new System.Drawing.Point(10, 59);
            this.lAdditional.Name = "lAdditional";
            this.lAdditional.Size = new System.Drawing.Size(120, 23);
            this.lAdditional.TabIndex = 1;
            this.lAdditional.Text = "Катамаран";
            this.lAdditional.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lAdditional_MouseDown);
            // 
            // lBase
            // 
            this.lBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBase.Location = new System.Drawing.Point(10, 27);
            this.lBase.Name = "lBase";
            this.lBase.Size = new System.Drawing.Size(120, 23);
            this.lBase.TabIndex = 0;
            this.lBase.Text = "Судно";
            this.lBase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lBase_MouseDown);
            // 
            // gBProps
            // 
            this.gBProps.Controls.Add(this.cBsail);
            this.gBProps.Controls.Add(this.cBmotor);
            this.gBProps.Controls.Add(this.nUDWeight);
            this.gBProps.Controls.Add(this.nUDMaxSpeed);
            this.gBProps.Controls.Add(this.label2);
            this.gBProps.Controls.Add(this.label1);
            this.gBProps.Location = new System.Drawing.Point(13, 178);
            this.gBProps.Name = "gBProps";
            this.gBProps.Size = new System.Drawing.Size(297, 74);
            this.gBProps.TabIndex = 1;
            this.gBProps.TabStop = false;
            this.gBProps.Text = "Параметры";
            // 
            // cBsail
            // 
            this.cBsail.AutoSize = true;
            this.cBsail.Location = new System.Drawing.Point(162, 38);
            this.cBsail.Name = "cBsail";
            this.cBsail.Size = new System.Drawing.Size(57, 17);
            this.cBsail.TabIndex = 5;
            this.cBsail.Text = "Седло";
            this.cBsail.UseVisualStyleBackColor = true;
            // 
            // cBmotor
            // 
            this.cBmotor.AutoSize = true;
            this.cBmotor.Location = new System.Drawing.Point(162, 15);
            this.cBmotor.Name = "cBmotor";
            this.cBmotor.Size = new System.Drawing.Size(58, 17);
            this.cBmotor.TabIndex = 4;
            this.cBmotor.Text = "Мотор";
            this.cBmotor.UseVisualStyleBackColor = true;
            // 
            // nUDWeight
            // 
            this.nUDWeight.Location = new System.Drawing.Point(100, 46);
            this.nUDWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUDWeight.Name = "nUDWeight";
            this.nUDWeight.Size = new System.Drawing.Size(55, 20);
            this.nUDWeight.TabIndex = 3;
            this.nUDWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nUDMaxSpeed
            // 
            this.nUDMaxSpeed.Location = new System.Drawing.Point(100, 20);
            this.nUDMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUDMaxSpeed.Name = "nUDMaxSpeed";
            this.nUDMaxSpeed.Size = new System.Drawing.Size(55, 20);
            this.nUDMaxSpeed.TabIndex = 2;
            this.nUDMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс скорость";
            // 
            // pBpreview
            // 
            this.pBpreview.Location = new System.Drawing.Point(3, 3);
            this.pBpreview.Name = "pBpreview";
            this.pBpreview.Size = new System.Drawing.Size(239, 154);
            this.pBpreview.TabIndex = 2;
            this.pBpreview.TabStop = false;
            // 
            // pPicBox
            // 
            this.pPicBox.AllowDrop = true;
            this.pPicBox.Controls.Add(this.pBpreview);
            this.pPicBox.Location = new System.Drawing.Point(155, 12);
            this.pPicBox.Name = "pPicBox";
            this.pPicBox.Size = new System.Drawing.Size(245, 160);
            this.pPicBox.TabIndex = 3;
            this.pPicBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pPicBox_DragDrop);
            this.pPicBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pPicBox_DragEnter);
            // 
            // gBColors
            // 
            this.gBColors.Controls.Add(this.lDopCol);
            this.gBColors.Controls.Add(this.lMainCol);
            this.gBColors.Controls.Add(this.pBlue);
            this.gBColors.Controls.Add(this.pBlack);
            this.gBColors.Controls.Add(this.pGreen);
            this.gBColors.Controls.Add(this.pOrange);
            this.gBColors.Controls.Add(this.pYellow);
            this.gBColors.Controls.Add(this.pWhite);
            this.gBColors.Controls.Add(this.pGray);
            this.gBColors.Controls.Add(this.pRed);
            this.gBColors.Location = new System.Drawing.Point(406, 12);
            this.gBColors.Name = "gBColors";
            this.gBColors.Size = new System.Drawing.Size(234, 157);
            this.gBColors.TabIndex = 4;
            this.gBColors.TabStop = false;
            this.gBColors.Text = "Цвета";
            // 
            // lDopCol
            // 
            this.lDopCol.AllowDrop = true;
            this.lDopCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lDopCol.Location = new System.Drawing.Point(120, 16);
            this.lDopCol.Name = "lDopCol";
            this.lDopCol.Size = new System.Drawing.Size(106, 23);
            this.lDopCol.TabIndex = 4;
            this.lDopCol.Text = "Доп цвет";
            this.lDopCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.lDopCol_DragDrop);
            this.lDopCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.lMainCol_DragEnter);
            // 
            // lMainCol
            // 
            this.lMainCol.AllowDrop = true;
            this.lMainCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lMainCol.Location = new System.Drawing.Point(6, 16);
            this.lMainCol.Name = "lMainCol";
            this.lMainCol.Size = new System.Drawing.Size(108, 23);
            this.lMainCol.TabIndex = 3;
            this.lMainCol.Text = "Основной цвет";
            this.lMainCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.lMainCol_DragDrop);
            this.lMainCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.lMainCol_DragEnter);
            // 
            // pBlue
            // 
            this.pBlue.BackColor = System.Drawing.Color.Blue;
            this.pBlue.Location = new System.Drawing.Point(176, 101);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(50, 50);
            this.pBlue.TabIndex = 1;
            // 
            // pBlack
            // 
            this.pBlack.BackColor = System.Drawing.Color.Black;
            this.pBlack.Location = new System.Drawing.Point(120, 45);
            this.pBlack.Name = "pBlack";
            this.pBlack.Size = new System.Drawing.Size(50, 50);
            this.pBlack.TabIndex = 1;
            // 
            // pGreen
            // 
            this.pGreen.BackColor = System.Drawing.Color.Lime;
            this.pGreen.Location = new System.Drawing.Point(120, 101);
            this.pGreen.Name = "pGreen";
            this.pGreen.Size = new System.Drawing.Size(50, 50);
            this.pGreen.TabIndex = 1;
            // 
            // pOrange
            // 
            this.pOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pOrange.Location = new System.Drawing.Point(64, 101);
            this.pOrange.Name = "pOrange";
            this.pOrange.Size = new System.Drawing.Size(50, 50);
            this.pOrange.TabIndex = 1;
            // 
            // pYellow
            // 
            this.pYellow.BackColor = System.Drawing.Color.Yellow;
            this.pYellow.Location = new System.Drawing.Point(64, 45);
            this.pYellow.Name = "pYellow";
            this.pYellow.Size = new System.Drawing.Size(50, 50);
            this.pYellow.TabIndex = 1;
            // 
            // pWhite
            // 
            this.pWhite.BackColor = System.Drawing.Color.White;
            this.pWhite.Location = new System.Drawing.Point(176, 45);
            this.pWhite.Name = "pWhite";
            this.pWhite.Size = new System.Drawing.Size(50, 50);
            this.pWhite.TabIndex = 2;
            // 
            // pGray
            // 
            this.pGray.BackColor = System.Drawing.Color.Gray;
            this.pGray.Location = new System.Drawing.Point(6, 101);
            this.pGray.Name = "pGray";
            this.pGray.Size = new System.Drawing.Size(50, 50);
            this.pGray.TabIndex = 1;
            // 
            // pRed
            // 
            this.pRed.BackColor = System.Drawing.Color.Red;
            this.pRed.Location = new System.Drawing.Point(6, 45);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(50, 50);
            this.pRed.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(476, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 254);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gBColors);
            this.Controls.Add(this.pPicBox);
            this.Controls.Add(this.gBProps);
            this.Controls.Add(this.gBTypes);
            this.Name = "FormCarConfig";
            this.Text = "Выбор транспорта";
            this.gBTypes.ResumeLayout(false);
            this.gBProps.ResumeLayout(false);
            this.gBProps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpreview)).EndInit();
            this.pPicBox.ResumeLayout(false);
            this.gBColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBTypes;
        private System.Windows.Forms.Label lAdditional;
        private System.Windows.Forms.Label lBase;
        private System.Windows.Forms.GroupBox gBProps;
        private System.Windows.Forms.NumericUpDown nUDWeight;
        private System.Windows.Forms.NumericUpDown nUDMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBpreview;
        private System.Windows.Forms.Panel pPicBox;
        private System.Windows.Forms.CheckBox cBmotor;
        private System.Windows.Forms.CheckBox cBsail;
        private System.Windows.Forms.GroupBox gBColors;
        private System.Windows.Forms.Label lDopCol;
        private System.Windows.Forms.Label lMainCol;
        private System.Windows.Forms.Panel pBlue;
        private System.Windows.Forms.Panel pBlack;
        private System.Windows.Forms.Panel pGreen;
        private System.Windows.Forms.Panel pOrange;
        private System.Windows.Forms.Panel pYellow;
        private System.Windows.Forms.Panel pWhite;
        private System.Windows.Forms.Panel pGray;
        private System.Windows.Forms.Panel pRed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}
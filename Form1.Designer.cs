namespace DosagePrinter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panelStickerPreview = new Panel();
            pictureBoxLogo = new PictureBox();
            btnPrint = new Button();
            listBoxStickers = new ListBox();
            label6 = new Label();
            btnAddSticker = new Button();
            groupBox1 = new GroupBox();
            lstDosage = new ListBox();
            lstTiming = new ListBox();
            lstFrequency = new ListBox();
            lstDuration = new ListBox();
            label7 = new Label();
            btnClear = new Button();
            btnClearAll = new Button();
            numericUpDown1 = new NumericUpDown();
            prntPrevw = new Button();
            numericUpDownW = new NumericUpDown();
            numericUpDownH = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            numRightMargin = new NumericUpDown();
            label10 = new Label();
            lblSize = new Label();
            panelStickerPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRightMargin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 19);
            label1.Name = "label1";
            label1.Size = new Size(446, 38);
            label1.TabIndex = 0;
            label1.Text = "Dosage Sticker Printer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(604, 11);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 5;
            label2.Text = "Frequency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 11);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 6;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 11);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Timing";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 11);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 8;
            label5.Text = "Dosage";
            // 
            // panelStickerPreview
            // 
            panelStickerPreview.Controls.Add(pictureBoxLogo);
            panelStickerPreview.Location = new Point(66, 520);
            panelStickerPreview.Name = "panelStickerPreview";
            panelStickerPreview.Size = new Size(465, 190);
            panelStickerPreview.TabIndex = 9;
            panelStickerPreview.Paint += panelStickerPreview_Paint;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.White;
            pictureBoxLogo.ErrorImage = null;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = null;
            pictureBoxLogo.Location = new Point(33, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(390, 22);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Visible = false;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(737, 597);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(118, 35);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "Print ";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // listBoxStickers
            // 
            listBoxStickers.FormattingEnabled = true;
            listBoxStickers.Location = new Point(737, 99);
            listBoxStickers.Name = "listBoxStickers";
            listBoxStickers.Size = new Size(428, 484);
            listBoxStickers.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(1006, 76);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 14;
            label6.Text = "Print List";
            // 
            // btnAddSticker
            // 
            btnAddSticker.Location = new Point(66, 733);
            btnAddSticker.Name = "btnAddSticker";
            btnAddSticker.Size = new Size(135, 35);
            btnAddSticker.TabIndex = 15;
            btnAddSticker.Text = "Add To Print List";
            btnAddSticker.UseVisualStyleBackColor = true;
            btnAddSticker.Click += btnAddSticker_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstDosage);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lstTiming);
            groupBox1.Controls.Add(lstFrequency);
            groupBox1.Controls.Add(lstDuration);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(-5, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 418);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // lstDosage
            // 
            lstDosage.FormattingEnabled = true;
            lstDosage.Items.AddRange(new object[] { "عضل ", "وريد", "شراب", "بعد اختبار حساسية" });
            lstDosage.Location = new Point(0, 44);
            lstDosage.Name = "lstDosage";
            lstDosage.Size = new Size(150, 364);
            lstDosage.TabIndex = 20;
            // 
            // lstTiming
            // 
            lstTiming.FormattingEnabled = true;
            lstTiming.Items.AddRange(new object[] { "قبل الاكل ", "بعد الاكل ", "مع الاكل ", "باستمرار" });
            lstTiming.Location = new Point(181, 44);
            lstTiming.Name = "lstTiming";
            lstTiming.Size = new Size(150, 364);
            lstTiming.TabIndex = 19;
            // 
            // lstFrequency
            // 
            lstFrequency.FormattingEnabled = true;
            lstFrequency.Items.AddRange(new object[] { "عند اللزوم", "مرة ", "مرتين", "ثلاث مرات", "اربع مرات" });
            lstFrequency.Location = new Point(547, 44);
            lstFrequency.Name = "lstFrequency";
            lstFrequency.Size = new Size(150, 364);
            lstFrequency.TabIndex = 9;
            // 
            // lstDuration
            // 
            lstDuration.FormattingEnabled = true;
            lstDuration.Items.AddRange(new object[] { "قبل الفطار ", "بعد السحور" });
            lstDuration.Location = new Point(359, 44);
            lstDuration.Name = "lstDuration";
            lstDuration.Size = new Size(150, 364);
            lstDuration.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Britannic Bold", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 65);
            label7.Name = "label7";
            label7.Size = new Size(170, 20);
            label7.TabIndex = 17;
            label7.Text = "Dosage Information";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(895, 597);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 35);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(1046, 597);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(119, 35);
            btnClearAll.TabIndex = 20;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(441, 738);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 25);
            numericUpDown1.TabIndex = 21;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.KeyPress += numericUpDown1_KeyPress;
            // 
            // prntPrevw
            // 
            prntPrevw.Location = new Point(737, 658);
            prntPrevw.Name = "prntPrevw";
            prntPrevw.Size = new Size(118, 35);
            prntPrevw.TabIndex = 22;
            prntPrevw.Text = "Print Preview";
            prntPrevw.UseVisualStyleBackColor = true;
            prntPrevw.Click += prntPrevw_Click;
            // 
            // numericUpDownW
            // 
            numericUpDownW.Location = new Point(989, 658);
            numericUpDownW.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownW.Name = "numericUpDownW";
            numericUpDownW.Size = new Size(90, 25);
            numericUpDownW.TabIndex = 23;
            numericUpDownW.Value = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownW.ValueChanged += numericUpDownW_ValueChanged;
            // 
            // numericUpDownH
            // 
            numericUpDownH.Location = new Point(989, 700);
            numericUpDownH.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownH.Name = "numericUpDownH";
            numericUpDownH.Size = new Size(90, 25);
            numericUpDownH.TabIndex = 24;
            numericUpDownH.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownH.ValueChanged += numericUpDownH_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1120, 703);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 25;
            label8.Text = "Height";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1120, 665);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 26;
            label9.Text = "Width";
            // 
            // numRightMargin
            // 
            numRightMargin.Location = new Point(989, 743);
            numRightMargin.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numRightMargin.Name = "numRightMargin";
            numRightMargin.Size = new Size(90, 25);
            numRightMargin.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1085, 743);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 29;
            label10.Text = "Right margin";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(905, 762);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(0, 20);
            lblSize.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 791);
            Controls.Add(lblSize);
            Controls.Add(label10);
            Controls.Add(numRightMargin);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(numericUpDownH);
            Controls.Add(numericUpDownW);
            Controls.Add(prntPrevw);
            Controls.Add(numericUpDown1);
            Controls.Add(btnClearAll);
            Controls.Add(btnClear);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(btnAddSticker);
            Controls.Add(label6);
            Controls.Add(listBoxStickers);
            Controls.Add(btnPrint);
            Controls.Add(panelStickerPreview);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            panelStickerPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownW).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownH).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRightMargin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panelStickerPreview;
        private PictureBox pictureBoxLogo;
        private Button btnPrint;
        private ListBox listBoxStickers;
        private Label label6;
        private Button btnAddSticker;
        private GroupBox groupBox1;
        private Label label7;
        private ListBox lstFrequency;
        private ListBox lstDuration;
        private ListBox lstTiming;
        private ListBox lstDosage;
        private Button btnClear;
        private Button btnClearAll;
        private NumericUpDown numericUpDown1;
        private Button prntPrevw;
        private NumericUpDown numericUpDownW;
        private NumericUpDown numericUpDownH;
        private Label label8;
        private Label label9;
        private NumericUpDown numRightMargin;
        private Label label10;
        private Label lblSize;
    }
}

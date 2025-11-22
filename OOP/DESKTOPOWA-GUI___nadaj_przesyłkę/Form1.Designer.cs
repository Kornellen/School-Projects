namespace DESKTOPOWA_GUI___nadaj_przesyłkę
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
            groupBox1 = new GroupBox();
            paczkaRBtn = new RadioButton();
            listRBtn = new RadioButton();
            pocztowkaRBtn = new RadioButton();
            sprawdzCeneBtn = new Button();
            ikonaImage = new PictureBox();
            cenaLbl = new Label();
            groupBox2 = new GroupBox();
            miastoTBox = new TextBox();
            label4 = new Label();
            kodPocztowyTBox = new TextBox();
            label3 = new Label();
            ulicaTbox = new TextBox();
            label2 = new Label();
            zatwierdzBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ikonaImage).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(paczkaRBtn);
            groupBox1.Controls.Add(listRBtn);
            groupBox1.Controls.Add(pocztowkaRBtn);
            groupBox1.Location = new Point(39, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj przesyłki";
            // 
            // paczkaRBtn
            // 
            paczkaRBtn.AutoSize = true;
            paczkaRBtn.Location = new Point(19, 98);
            paczkaRBtn.Name = "paczkaRBtn";
            paczkaRBtn.Size = new Size(61, 19);
            paczkaRBtn.TabIndex = 2;
            paczkaRBtn.Text = "Paczka";
            paczkaRBtn.UseVisualStyleBackColor = true;
            // 
            // listRBtn
            // 
            listRBtn.AutoSize = true;
            listRBtn.Location = new Point(19, 58);
            listRBtn.Name = "listRBtn";
            listRBtn.Size = new Size(43, 19);
            listRBtn.TabIndex = 1;
            listRBtn.Text = "List";
            listRBtn.UseVisualStyleBackColor = true;
            // 
            // pocztowkaRBtn
            // 
            pocztowkaRBtn.AutoSize = true;
            pocztowkaRBtn.Checked = true;
            pocztowkaRBtn.Location = new Point(19, 22);
            pocztowkaRBtn.Name = "pocztowkaRBtn";
            pocztowkaRBtn.Size = new Size(82, 19);
            pocztowkaRBtn.TabIndex = 0;
            pocztowkaRBtn.TabStop = true;
            pocztowkaRBtn.Text = "Pocztówka";
            pocztowkaRBtn.UseVisualStyleBackColor = true;
            // 
            // sprawdzCeneBtn
            // 
            sprawdzCeneBtn.Location = new Point(39, 174);
            sprawdzCeneBtn.Name = "sprawdzCeneBtn";
            sprawdzCeneBtn.Size = new Size(232, 30);
            sprawdzCeneBtn.TabIndex = 1;
            sprawdzCeneBtn.Text = "Sprawdź Cenę";
            sprawdzCeneBtn.UseVisualStyleBackColor = true;
            sprawdzCeneBtn.Click += sprawdzCeneBtn_Click;
            // 
            // ikonaImage
            // 
            ikonaImage.Image = Properties.Resources.pocztowka;
            ikonaImage.Location = new Point(39, 240);
            ikonaImage.Name = "ikonaImage";
            ikonaImage.Size = new Size(133, 89);
            ikonaImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ikonaImage.TabIndex = 2;
            ikonaImage.TabStop = false;
            // 
            // cenaLbl
            // 
            cenaLbl.AutoSize = true;
            cenaLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cenaLbl.Location = new Point(191, 251);
            cenaLbl.Name = "cenaLbl";
            cenaLbl.Size = new Size(102, 25);
            cenaLbl.TabIndex = 3;
            cenaLbl.Text = "Cena:  1 zł";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(miastoTBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(kodPocztowyTBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(ulicaTbox);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(353, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 239);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe";
            // 
            // miastoTBox
            // 
            miastoTBox.Location = new Point(30, 194);
            miastoTBox.Name = "miastoTBox";
            miastoTBox.Size = new Size(239, 23);
            miastoTBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 176);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Miasto";
            // 
            // kodPocztowyTBox
            // 
            kodPocztowyTBox.Location = new Point(30, 110);
            kodPocztowyTBox.Name = "kodPocztowyTBox";
            kodPocztowyTBox.Size = new Size(105, 23);
            kodPocztowyTBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 83);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Kod pocztowy";
            // 
            // ulicaTbox
            // 
            ulicaTbox.Location = new Point(30, 42);
            ulicaTbox.Name = "ulicaTbox";
            ulicaTbox.Size = new Size(239, 23);
            ulicaTbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 24);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "Ulica z numerem";
            // 
            // zatwierdzBtn
            // 
            zatwierdzBtn.Location = new Point(39, 349);
            zatwierdzBtn.Name = "zatwierdzBtn";
            zatwierdzBtn.Size = new Size(600, 28);
            zatwierdzBtn.TabIndex = 5;
            zatwierdzBtn.Text = "Zatwierdź";
            zatwierdzBtn.UseVisualStyleBackColor = true;
            zatwierdzBtn.Click += zatwierdzBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 383);
            Controls.Add(zatwierdzBtn);
            Controls.Add(groupBox2);
            Controls.Add(cenaLbl);
            Controls.Add(ikonaImage);
            Controls.Add(sprawdzCeneBtn);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nadaj Przesyłkę";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ikonaImage).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton paczkaRBtn;
        private RadioButton listRBtn;
        private RadioButton pocztowkaRBtn;
        private Button sprawdzCeneBtn;
        private PictureBox ikonaImage;
        private Label cenaLbl;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private TextBox ulicaTbox;
        private TextBox miastoTBox;
        private Label label4;
        private TextBox kodPocztowyTBox;
        private Button zatwierdzBtn;
    }
}

namespace DESKTOPOWA_GUI___dodaj_pracownika_generowanie_hasła
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
            stanowiskoCBox = new ComboBox();
            lastNameTB = new TextBox();
            firstNameTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            genPasswdBtn = new Button();
            isSpecialChars = new CheckBox();
            isDigits = new CheckBox();
            isUpperLowerLetters = new CheckBox();
            passwdLengthTB = new TextBox();
            label4 = new Label();
            addWorkerBtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stanowiskoCBox);
            groupBox1.Controls.Add(lastNameTB);
            groupBox1.Controls.Add(firstNameTB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane Pracownika";
            // 
            // stanowiskoCBox
            // 
            stanowiskoCBox.FormattingEnabled = true;
            stanowiskoCBox.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            stanowiskoCBox.Location = new Point(123, 123);
            stanowiskoCBox.Name = "stanowiskoCBox";
            stanowiskoCBox.Size = new Size(121, 23);
            stanowiskoCBox.TabIndex = 5;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(123, 80);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(121, 23);
            lastNameTB.TabIndex = 4;
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(123, 40);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(121, 23);
            firstNameTB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 126);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Stanowisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(genPasswdBtn);
            groupBox2.Controls.Add(isSpecialChars);
            groupBox2.Controls.Add(isDigits);
            groupBox2.Controls.Add(isUpperLowerLetters);
            groupBox2.Controls.Add(passwdLengthTB);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(464, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie Hasła";
            // 
            // genPasswdBtn
            // 
            genPasswdBtn.BackColor = Color.SteelBlue;
            genPasswdBtn.ForeColor = Color.White;
            genPasswdBtn.Location = new Point(91, 178);
            genPasswdBtn.Name = "genPasswdBtn";
            genPasswdBtn.Size = new Size(105, 31);
            genPasswdBtn.TabIndex = 5;
            genPasswdBtn.Text = "Generuj hasło";
            genPasswdBtn.UseVisualStyleBackColor = false;
            genPasswdBtn.Click += genPasswdBtn_Click;
            // 
            // isSpecialChars
            // 
            isSpecialChars.AutoSize = true;
            isSpecialChars.Location = new Point(36, 129);
            isSpecialChars.Name = "isSpecialChars";
            isSpecialChars.Size = new Size(107, 19);
            isSpecialChars.TabIndex = 4;
            isSpecialChars.Text = "Znaki specjalne";
            isSpecialChars.UseVisualStyleBackColor = true;
            // 
            // isDigits
            // 
            isDigits.AutoSize = true;
            isDigits.Location = new Point(36, 104);
            isDigits.Name = "isDigits";
            isDigits.Size = new Size(54, 19);
            isDigits.TabIndex = 3;
            isDigits.Text = "Cyfry";
            isDigits.UseVisualStyleBackColor = true;
            // 
            // isUpperLowerLetters
            // 
            isUpperLowerLetters.AutoSize = true;
            isUpperLowerLetters.Checked = true;
            isUpperLowerLetters.CheckState = CheckState.Checked;
            isUpperLowerLetters.Location = new Point(36, 79);
            isUpperLowerLetters.Name = "isUpperLowerLetters";
            isUpperLowerLetters.Size = new Size(128, 19);
            isUpperLowerLetters.TabIndex = 2;
            isUpperLowerLetters.Text = "Małe i Wielkie litery";
            isUpperLowerLetters.UseVisualStyleBackColor = true;
            // 
            // passwdLengthTB
            // 
            passwdLengthTB.Location = new Point(147, 37);
            passwdLengthTB.Name = "passwdLengthTB";
            passwdLengthTB.Size = new Size(100, 23);
            passwdLengthTB.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 40);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Ile znaków?";
            // 
            // addWorkerBtn
            // 
            addWorkerBtn.BackColor = Color.SteelBlue;
            addWorkerBtn.ForeColor = Color.White;
            addWorkerBtn.Location = new Point(272, 355);
            addWorkerBtn.Name = "addWorkerBtn";
            addWorkerBtn.Size = new Size(222, 33);
            addWorkerBtn.TabIndex = 2;
            addWorkerBtn.Text = "Zatwierdź";
            addWorkerBtn.UseVisualStyleBackColor = false;
            addWorkerBtn.Click += addWorkerBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(addWorkerBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj Pracownika";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox stanowiskoCBox;
        private TextBox lastNameTB;
        private TextBox firstNameTB;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox isUpperLowerLetters;
        private TextBox passwdLengthTB;
        private Label label4;
        private CheckBox isSpecialChars;
        private CheckBox isDigits;
        private Button genPasswdBtn;
        private Button addWorkerBtn;
    }
}

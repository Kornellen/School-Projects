namespace fibonacci_rekurencja_i_petla
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.historyRTBox = new System.Windows.Forms.RichTextBox();
            this.inputLbl = new System.Windows.Forms.Label();
            this.inputTBox = new System.Windows.Forms.TextBox();
            this.resultTitleLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.recursionBtn = new System.Windows.Forms.Button();
            this.iterationBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.historyLbl = new System.Windows.Forms.Label();
            this.recursionBtnLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLbl.Location = new System.Drawing.Point(211, 9);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(1105, 73);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Ciąg Fibonacciego rekurencją i pętlą";
            // 
            // historyRTBox
            // 
            this.historyRTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.historyRTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyRTBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.historyRTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyRTBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.historyRTBox.Location = new System.Drawing.Point(894, 147);
            this.historyRTBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.historyRTBox.Name = "historyRTBox";
            this.historyRTBox.ReadOnly = true;
            this.historyRTBox.Size = new System.Drawing.Size(508, 591);
            this.historyRTBox.TabIndex = 1;
            this.historyRTBox.Text = "";
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.inputLbl.Location = new System.Drawing.Point(30, 238);
            this.inputLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(404, 24);
            this.inputLbl.TabIndex = 2;
            this.inputLbl.Text = "Który wyraz ciągu Fibonacciego cię interesuje?";
            // 
            // inputTBox
            // 
            this.inputTBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputTBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.inputTBox.Location = new System.Drawing.Point(446, 228);
            this.inputTBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputTBox.Name = "inputTBox";
            this.inputTBox.Size = new System.Drawing.Size(202, 38);
            this.inputTBox.TabIndex = 3;
            // 
            // resultTitleLbl
            // 
            this.resultTitleLbl.AutoSize = true;
            this.resultTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTitleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.resultTitleLbl.Location = new System.Drawing.Point(30, 634);
            this.resultTitleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultTitleLbl.Name = "resultTitleLbl";
            this.resultTitleLbl.Size = new System.Drawing.Size(109, 33);
            this.resultTitleLbl.TabIndex = 4;
            this.resultTitleLbl.Text = "Wynik:";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.resultLbl.Location = new System.Drawing.Point(170, 634);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 33);
            this.resultLbl.TabIndex = 5;
            // 
            // recursionBtn
            // 
            this.recursionBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recursionBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.recursionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recursionBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recursionBtn.Location = new System.Drawing.Point(446, 313);
            this.recursionBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recursionBtn.Name = "recursionBtn";
            this.recursionBtn.Size = new System.Drawing.Size(202, 42);
            this.recursionBtn.TabIndex = 6;
            this.recursionBtn.Text = "Oblicz Rekurencją";
            this.recursionBtn.UseVisualStyleBackColor = false;
            this.recursionBtn.Click += new System.EventHandler(this.recursionBtn_Click);
            // 
            // iterationBtn
            // 
            this.iterationBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iterationBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.iterationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iterationBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iterationBtn.Location = new System.Drawing.Point(446, 416);
            this.iterationBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.iterationBtn.Name = "iterationBtn";
            this.iterationBtn.Size = new System.Drawing.Size(202, 42);
            this.iterationBtn.TabIndex = 7;
            this.iterationBtn.Text = "Oblicz Pętlą";
            this.iterationBtn.UseVisualStyleBackColor = false;
            this.iterationBtn.Click += new System.EventHandler(this.iterationBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(446, 521);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(202, 42);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Wyczyść";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // historyLbl
            // 
            this.historyLbl.AutoSize = true;
            this.historyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.historyLbl.Location = new System.Drawing.Point(1092, 110);
            this.historyLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.historyLbl.Name = "historyLbl";
            this.historyLbl.Size = new System.Drawing.Size(115, 31);
            this.historyLbl.TabIndex = 9;
            this.historyLbl.Text = "Historia";
            // 
            // recursionBtnLbl
            // 
            this.recursionBtnLbl.AutoSize = true;
            this.recursionBtnLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.recursionBtnLbl.Location = new System.Drawing.Point(30, 322);
            this.recursionBtnLbl.Name = "recursionBtnLbl";
            this.recursionBtnLbl.Size = new System.Drawing.Size(237, 24);
            this.recursionBtnLbl.TabIndex = 10;
            this.recursionBtnLbl.Text = "Wersja Klasyczna (Wolniej)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wersja Zoptymalizowana (Szybciej)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recursionBtnLbl);
            this.Controls.Add(this.historyLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.iterationBtn);
            this.Controls.Add(this.recursionBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.resultTitleLbl);
            this.Controls.Add(this.inputTBox);
            this.Controls.Add(this.inputLbl);
            this.Controls.Add(this.historyRTBox);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Ciąg Fibonacciego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.RichTextBox historyRTBox;
        private System.Windows.Forms.Label inputLbl;
        private System.Windows.Forms.TextBox inputTBox;
        private System.Windows.Forms.Label resultTitleLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button recursionBtn;
        private System.Windows.Forms.Button iterationBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label historyLbl;
        private System.Windows.Forms.Label recursionBtnLbl;
        private System.Windows.Forms.Label label1;
    }
}


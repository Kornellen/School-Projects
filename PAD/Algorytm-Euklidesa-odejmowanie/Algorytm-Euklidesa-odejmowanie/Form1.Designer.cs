namespace Algorytm_Euklidesa_odejmowanie
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
            this.resultLbl = new System.Windows.Forms.Label();
            this.resultTitleLbl = new System.Windows.Forms.Label();
            this.historyLBox = new System.Windows.Forms.ListBox();
            this.historyLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.numBTBox = new System.Windows.Forms.TextBox();
            this.numATBox = new System.Windows.Forms.TextBox();
            this.numBLbl = new System.Windows.Forms.Label();
            this.numALbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLbl.Location = new System.Drawing.Point(297, 477);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 23);
            this.resultLbl.TabIndex = 22;
            // 
            // resultTitleLbl
            // 
            this.resultTitleLbl.AutoSize = true;
            this.resultTitleLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTitleLbl.Location = new System.Drawing.Point(65, 477);
            this.resultTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultTitleLbl.Name = "resultTitleLbl";
            this.resultTitleLbl.Size = new System.Drawing.Size(68, 23);
            this.resultTitleLbl.TabIndex = 21;
            this.resultTitleLbl.Text = "Wynik";
            // 
            // historyLBox
            // 
            this.historyLBox.FormattingEnabled = true;
            this.historyLBox.Location = new System.Drawing.Point(614, 117);
            this.historyLBox.Margin = new System.Windows.Forms.Padding(4);
            this.historyLBox.Name = "historyLBox";
            this.historyLBox.Size = new System.Drawing.Size(323, 290);
            this.historyLBox.TabIndex = 20;
            // 
            // historyLbl
            // 
            this.historyLbl.AutoSize = true;
            this.historyLbl.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyLbl.Location = new System.Drawing.Point(684, 84);
            this.historyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.historyLbl.Name = "historyLbl";
            this.historyLbl.Size = new System.Drawing.Size(118, 29);
            this.historyLbl.TabIndex = 19;
            this.historyLbl.Text = "Historia";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(288, 272);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Wyczyść";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(180, 272);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 28);
            this.calculateBtn.TabIndex = 17;
            this.calculateBtn.Text = "Oblicz NWD";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // numBTBox
            // 
            this.numBTBox.Location = new System.Drawing.Point(276, 199);
            this.numBTBox.Margin = new System.Windows.Forms.Padding(4);
            this.numBTBox.Name = "numBTBox";
            this.numBTBox.Size = new System.Drawing.Size(132, 20);
            this.numBTBox.TabIndex = 16;
            // 
            // numATBox
            // 
            this.numATBox.Location = new System.Drawing.Point(276, 149);
            this.numATBox.Margin = new System.Windows.Forms.Padding(4);
            this.numATBox.Name = "numATBox";
            this.numATBox.Size = new System.Drawing.Size(132, 20);
            this.numATBox.TabIndex = 15;
            // 
            // numBLbl
            // 
            this.numBLbl.AutoSize = true;
            this.numBLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numBLbl.Location = new System.Drawing.Point(170, 199);
            this.numBLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numBLbl.Name = "numBLbl";
            this.numBLbl.Size = new System.Drawing.Size(99, 23);
            this.numBLbl.TabIndex = 14;
            this.numBLbl.Text = "Liczba B:";
            // 
            // numALbl
            // 
            this.numALbl.AutoSize = true;
            this.numALbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numALbl.Location = new System.Drawing.Point(169, 149);
            this.numALbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numALbl.Name = "numALbl";
            this.numALbl.Size = new System.Drawing.Size(99, 23);
            this.numALbl.TabIndex = 13;
            this.numALbl.Text = "Liczba A:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLbl.Location = new System.Drawing.Point(174, 26);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(528, 35);
            this.titleLbl.TabIndex = 12;
            this.titleLbl.Text = "Algorytm Euklidesa - Odejmowanie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 578);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.resultTitleLbl);
            this.Controls.Add(this.historyLBox);
            this.Controls.Add(this.historyLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.numBTBox);
            this.Controls.Add(this.numATBox);
            this.Controls.Add(this.numBLbl);
            this.Controls.Add(this.numALbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label resultTitleLbl;
        private System.Windows.Forms.ListBox historyLBox;
        private System.Windows.Forms.Label historyLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox numBTBox;
        private System.Windows.Forms.TextBox numATBox;
        private System.Windows.Forms.Label numBLbl;
        private System.Windows.Forms.Label numALbl;
        private System.Windows.Forms.Label titleLbl;
    }
}


namespace Algorytm_Euklidesa_reszta_z_dzielenia
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
            this.numALbl = new System.Windows.Forms.Label();
            this.numBLbl = new System.Windows.Forms.Label();
            this.numATBox = new System.Windows.Forms.TextBox();
            this.numBTBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.historyLbl = new System.Windows.Forms.Label();
            this.historyLBox = new System.Windows.Forms.ListBox();
            this.resultTitleLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLbl.Location = new System.Drawing.Point(255, 25);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(587, 35);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Algorytm Euklidesa - Reszta z dzielenia";
            // 
            // numALbl
            // 
            this.numALbl.AutoSize = true;
            this.numALbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numALbl.Location = new System.Drawing.Point(250, 148);
            this.numALbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numALbl.Name = "numALbl";
            this.numALbl.Size = new System.Drawing.Size(99, 23);
            this.numALbl.TabIndex = 1;
            this.numALbl.Text = "Liczba A:";
            // 
            // numBLbl
            // 
            this.numBLbl.AutoSize = true;
            this.numBLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numBLbl.Location = new System.Drawing.Point(251, 198);
            this.numBLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numBLbl.Name = "numBLbl";
            this.numBLbl.Size = new System.Drawing.Size(99, 23);
            this.numBLbl.TabIndex = 2;
            this.numBLbl.Text = "Liczba B:";
            // 
            // numATBox
            // 
            this.numATBox.Location = new System.Drawing.Point(357, 148);
            this.numATBox.Margin = new System.Windows.Forms.Padding(4);
            this.numATBox.Name = "numATBox";
            this.numATBox.Size = new System.Drawing.Size(132, 23);
            this.numATBox.TabIndex = 3;
            // 
            // numBTBox
            // 
            this.numBTBox.Location = new System.Drawing.Point(357, 198);
            this.numBTBox.Margin = new System.Windows.Forms.Padding(4);
            this.numBTBox.Name = "numBTBox";
            this.numBTBox.Size = new System.Drawing.Size(132, 23);
            this.numBTBox.TabIndex = 4;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(261, 271);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 28);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "Oblicz NWD";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(369, 271);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Wyczyść";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // historyLbl
            // 
            this.historyLbl.AutoSize = true;
            this.historyLbl.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyLbl.Location = new System.Drawing.Point(765, 83);
            this.historyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.historyLbl.Name = "historyLbl";
            this.historyLbl.Size = new System.Drawing.Size(118, 29);
            this.historyLbl.TabIndex = 8;
            this.historyLbl.Text = "Historia";
            // 
            // historyLBox
            // 
            this.historyLBox.FormattingEnabled = true;
            this.historyLBox.ItemHeight = 16;
            this.historyLBox.Location = new System.Drawing.Point(695, 116);
            this.historyLBox.Margin = new System.Windows.Forms.Padding(4);
            this.historyLBox.Name = "historyLBox";
            this.historyLBox.Size = new System.Drawing.Size(323, 292);
            this.historyLBox.TabIndex = 9;
            // 
            // resultTitleLbl
            // 
            this.resultTitleLbl.AutoSize = true;
            this.resultTitleLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTitleLbl.Location = new System.Drawing.Point(146, 476);
            this.resultTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultTitleLbl.Name = "resultTitleLbl";
            this.resultTitleLbl.Size = new System.Drawing.Size(68, 23);
            this.resultTitleLbl.TabIndex = 10;
            this.resultTitleLbl.Text = "Wynik";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLbl.Location = new System.Drawing.Point(250, 476);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 23);
            this.resultLbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Algorytm Euklidesa v1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label numALbl;
        private System.Windows.Forms.Label numBLbl;
        private System.Windows.Forms.TextBox numATBox;
        private System.Windows.Forms.TextBox numBTBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label historyLbl;
        private System.Windows.Forms.ListBox historyLBox;
        private System.Windows.Forms.Label resultTitleLbl;
        private System.Windows.Forms.Label resultLbl;
    }
}


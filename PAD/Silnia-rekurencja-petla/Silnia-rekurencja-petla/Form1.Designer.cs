namespace Silnia_rekurencja_petla
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
            this.numLbl = new System.Windows.Forms.Label();
            this.numTBox = new System.Windows.Forms.TextBox();
            this.recursionBtn = new System.Windows.Forms.Button();
            this.LoopBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.resultTitleLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.stepHistoryRTBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLbl.Location = new System.Drawing.Point(358, 9);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(535, 35);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Silnia Rekurencyjnie i poprzez Pętlę";
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numLbl.Location = new System.Drawing.Point(168, 120);
            this.numLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(116, 26);
            this.numLbl.TabIndex = 1;
            this.numLbl.Text = "Liczba n!:";
            // 
            // numTBox
            // 
            this.numTBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numTBox.Location = new System.Drawing.Point(296, 117);
            this.numTBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.numTBox.Name = "numTBox";
            this.numTBox.Size = new System.Drawing.Size(164, 33);
            this.numTBox.TabIndex = 2;
            // 
            // recursionBtn
            // 
            this.recursionBtn.Location = new System.Drawing.Point(27, 179);
            this.recursionBtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.recursionBtn.Name = "recursionBtn";
            this.recursionBtn.Size = new System.Drawing.Size(260, 36);
            this.recursionBtn.TabIndex = 3;
            this.recursionBtn.Text = "Oblicz rekurencją";
            this.recursionBtn.UseVisualStyleBackColor = true;
            this.recursionBtn.Click += new System.EventHandler(this.recursionBtn_Click);
            // 
            // LoopBtn
            // 
            this.LoopBtn.Location = new System.Drawing.Point(349, 179);
            this.LoopBtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.LoopBtn.Name = "LoopBtn";
            this.LoopBtn.Size = new System.Drawing.Size(260, 36);
            this.LoopBtn.TabIndex = 4;
            this.LoopBtn.Text = "Oblicz pętlą";
            this.LoopBtn.UseVisualStyleBackColor = true;
            this.LoopBtn.Click += new System.EventHandler(this.LoopBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(27, 251);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(126, 36);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Wyczyść";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // resultTitleLbl
            // 
            this.resultTitleLbl.AutoSize = true;
            this.resultTitleLbl.Location = new System.Drawing.Point(203, 264);
            this.resultTitleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultTitleLbl.Name = "resultTitleLbl";
            this.resultTitleLbl.Size = new System.Drawing.Size(66, 20);
            this.resultTitleLbl.TabIndex = 6;
            this.resultTitleLbl.Text = "Wynik:";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoEllipsis = true;
            this.resultLbl.Location = new System.Drawing.Point(325, 259);
            this.resultLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(311, 349);
            this.resultLbl.TabIndex = 7;
            // 
            // stepHistoryRTBox
            // 
            this.stepHistoryRTBox.Location = new System.Drawing.Point(726, 175);
            this.stepHistoryRTBox.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.stepHistoryRTBox.Name = "stepHistoryRTBox";
            this.stepHistoryRTBox.ReadOnly = true;
            this.stepHistoryRTBox.Size = new System.Drawing.Size(407, 341);
            this.stepHistoryRTBox.TabIndex = 8;
            this.stepHistoryRTBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 617);
            this.Controls.Add(this.stepHistoryRTBox);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.resultTitleLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.LoopBtn);
            this.Controls.Add(this.recursionBtn);
            this.Controls.Add(this.numTBox);
            this.Controls.Add(this.numLbl);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Silnia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label numLbl;
        private System.Windows.Forms.TextBox numTBox;
        private System.Windows.Forms.Button recursionBtn;
        private System.Windows.Forms.Button LoopBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label resultTitleLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.RichTextBox stepHistoryRTBox;
    }
}


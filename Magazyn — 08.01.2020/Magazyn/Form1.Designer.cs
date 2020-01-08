namespace Magazyn
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
            this.lbMainTitle = new System.Windows.Forms.Label();
            this.btnMainComponents = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMainTitle
            // 
            this.lbMainTitle.AutoSize = true;
            this.lbMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMainTitle.Location = new System.Drawing.Point(9, 7);
            this.lbMainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMainTitle.Name = "lbMainTitle";
            this.lbMainTitle.Size = new System.Drawing.Size(434, 31);
            this.lbMainTitle.TabIndex = 0;
            this.lbMainTitle.Text = "Magazyn części komputerowych";
            // 
            // btnMainComponents
            // 
            this.btnMainComponents.Location = new System.Drawing.Point(9, 328);
            this.btnMainComponents.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainComponents.Name = "btnMainComponents";
            this.btnMainComponents.Size = new System.Drawing.Size(191, 102);
            this.btnMainComponents.TabIndex = 1;
            this.btnMainComponents.Text = "Komponenty/Części komputerowe";
            this.btnMainComponents.UseVisualStyleBackColor = true;
            this.btnMainComponents.Click += new System.EventHandler(this.btnMainComponents_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.Location = new System.Drawing.Point(543, 328);
            this.btnMainExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(196, 102);
            this.btnMainExit.TabIndex = 3;
            this.btnMainExit.Text = "Wyjście";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 440);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnMainComponents);
            this.Controls.Add(this.lbMainTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMainTitle;
        private System.Windows.Forms.Button btnMainComponents;
        private System.Windows.Forms.Button btnMainExit;
    }
}


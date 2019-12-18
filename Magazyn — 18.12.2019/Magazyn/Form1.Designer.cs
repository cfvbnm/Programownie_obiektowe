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
            this.btnMainProvider = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMainTitle
            // 
            this.lbMainTitle.AutoSize = true;
            this.lbMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMainTitle.Location = new System.Drawing.Point(12, 9);
            this.lbMainTitle.Name = "lbMainTitle";
            this.lbMainTitle.Size = new System.Drawing.Size(519, 38);
            this.lbMainTitle.TabIndex = 0;
            this.lbMainTitle.Text = "Magazyn części komputerowych";
            // 
            // btnMainComponents
            // 
            this.btnMainComponents.Location = new System.Drawing.Point(12, 404);
            this.btnMainComponents.Name = "btnMainComponents";
            this.btnMainComponents.Size = new System.Drawing.Size(255, 126);
            this.btnMainComponents.TabIndex = 1;
            this.btnMainComponents.Text = "Komponenty/Części komputerowe";
            this.btnMainComponents.UseVisualStyleBackColor = true;
            this.btnMainComponents.Click += new System.EventHandler(this.btnMainComponents_Click);
            // 
            // btnMainProvider
            // 
            this.btnMainProvider.Location = new System.Drawing.Point(353, 404);
            this.btnMainProvider.Name = "btnMainProvider";
            this.btnMainProvider.Size = new System.Drawing.Size(276, 126);
            this.btnMainProvider.TabIndex = 2;
            this.btnMainProvider.Text = "Lista dostawców";
            this.btnMainProvider.UseVisualStyleBackColor = true;
            this.btnMainProvider.Click += new System.EventHandler(this.btnMainProvider_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.Location = new System.Drawing.Point(724, 404);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(261, 126);
            this.btnMainExit.TabIndex = 3;
            this.btnMainExit.Text = "Wyjście";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 542);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnMainProvider);
            this.Controls.Add(this.btnMainComponents);
            this.Controls.Add(this.lbMainTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMainTitle;
        private System.Windows.Forms.Button btnMainComponents;
        private System.Windows.Forms.Button btnMainProvider;
        private System.Windows.Forms.Button btnMainExit;
    }
}


namespace Magazyn
{
    partial class Form2
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
            this.lbProviderTitle = new System.Windows.Forms.Label();
            this.listBoxProvider = new System.Windows.Forms.ListBox();
            this.lbSelectProvider = new System.Windows.Forms.Label();
            this.lbProviderName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbProviderID = new System.Windows.Forms.Label();
            this.btnProviderPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProviderTitle
            // 
            this.lbProviderTitle.AutoSize = true;
            this.lbProviderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbProviderTitle.Location = new System.Drawing.Point(9, 7);
            this.lbProviderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProviderTitle.Name = "lbProviderTitle";
            this.lbProviderTitle.Size = new System.Drawing.Size(251, 31);
            this.lbProviderTitle.TabIndex = 0;
            this.lbProviderTitle.Text = "Lista dowstawców";
            // 
            // listBoxProvider
            // 
            this.listBoxProvider.FormattingEnabled = true;
            this.listBoxProvider.Location = new System.Drawing.Point(14, 80);
            this.listBoxProvider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxProvider.Name = "listBoxProvider";
            this.listBoxProvider.Size = new System.Drawing.Size(179, 277);
            this.listBoxProvider.TabIndex = 1;
            // 
            // lbSelectProvider
            // 
            this.lbSelectProvider.AutoSize = true;
            this.lbSelectProvider.Location = new System.Drawing.Point(12, 55);
            this.lbSelectProvider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelectProvider.Name = "lbSelectProvider";
            this.lbSelectProvider.Size = new System.Drawing.Size(97, 13);
            this.lbSelectProvider.TabIndex = 2;
            this.lbSelectProvider.Text = "Wybierz dostawcę:";
            // 
            // lbProviderName
            // 
            this.lbProviderName.AutoSize = true;
            this.lbProviderName.Location = new System.Drawing.Point(419, 80);
            this.lbProviderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProviderName.Name = "lbProviderName";
            this.lbProviderName.Size = new System.Drawing.Size(32, 13);
            this.lbProviderName.TabIndex = 3;
            this.lbProviderName.Text = "Imię: ";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(419, 106);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(56, 13);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "Naziwsko:";
            // 
            // lbProviderID
            // 
            this.lbProviderID.AutoSize = true;
            this.lbProviderID.Location = new System.Drawing.Point(419, 131);
            this.lbProviderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProviderID.Name = "lbProviderID";
            this.lbProviderID.Size = new System.Drawing.Size(55, 13);
            this.lbProviderID.TabIndex = 5;
            this.lbProviderID.Text = "Numer ID:";
            // 
            // btnProviderPrevious
            // 
            this.btnProviderPrevious.Location = new System.Drawing.Point(521, 318);
            this.btnProviderPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProviderPrevious.Name = "btnProviderPrevious";
            this.btnProviderPrevious.Size = new System.Drawing.Size(70, 37);
            this.btnProviderPrevious.TabIndex = 6;
            this.btnProviderPrevious.Text = "Wróć";
            this.btnProviderPrevious.UseVisualStyleBackColor = true;
            this.btnProviderPrevious.Click += new System.EventHandler(this.btnProviderPrevious_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnProviderPrevious);
            this.Controls.Add(this.lbProviderID);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbProviderName);
            this.Controls.Add(this.lbSelectProvider);
            this.Controls.Add(this.listBoxProvider);
            this.Controls.Add(this.lbProviderTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProviderTitle;
        private System.Windows.Forms.ListBox listBoxProvider;
        private System.Windows.Forms.Label lbSelectProvider;
        private System.Windows.Forms.Label lbProviderName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbProviderID;
        private System.Windows.Forms.Button btnProviderPrevious;
    }
}
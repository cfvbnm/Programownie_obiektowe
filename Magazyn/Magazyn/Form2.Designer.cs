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
            this.SuspendLayout();
            // 
            // lbProviderTitle
            // 
            this.lbProviderTitle.AutoSize = true;
            this.lbProviderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbProviderTitle.Location = new System.Drawing.Point(12, 9);
            this.lbProviderTitle.Name = "lbProviderTitle";
            this.lbProviderTitle.Size = new System.Drawing.Size(385, 49);
            this.lbProviderTitle.TabIndex = 0;
            this.lbProviderTitle.Text = "Lista dowstawców";
            // 
            // listBoxProvider
            // 
            this.listBoxProvider.FormattingEnabled = true;
            this.listBoxProvider.ItemHeight = 16;
            this.listBoxProvider.Items.AddRange(new object[] {
            "Dostawca x",
            "Dostawca y",
            "Dostawca Mati"});
            this.listBoxProvider.Location = new System.Drawing.Point(19, 98);
            this.listBoxProvider.Name = "listBoxProvider";
            this.listBoxProvider.Size = new System.Drawing.Size(237, 340);
            this.listBoxProvider.TabIndex = 1;
            // 
            // lbSelectProvider
            // 
            this.lbSelectProvider.AutoSize = true;
            this.lbSelectProvider.Location = new System.Drawing.Point(16, 68);
            this.lbSelectProvider.Name = "lbSelectProvider";
            this.lbSelectProvider.Size = new System.Drawing.Size(158, 21);
            this.lbSelectProvider.TabIndex = 2;
            this.lbSelectProvider.Text = "Wybierz dostawcę:";
            // 
            // lbProviderName
            // 
            this.lbProviderName.AutoSize = true;
            this.lbProviderName.Location = new System.Drawing.Point(559, 98);
            this.lbProviderName.Name = "lbProviderName";
            this.lbProviderName.Size = new System.Drawing.Size(51, 21);
            this.lbProviderName.TabIndex = 3;
            this.lbProviderName.Text = "Imię: ";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(559, 130);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 17);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "Naziwsko:";
            // 
            // lbProviderID
            // 
            this.lbProviderID.AutoSize = true;
            this.lbProviderID.Location = new System.Drawing.Point(559, 161);
            this.lbProviderID.Name = "lbProviderID";
            this.lbProviderID.Size = new System.Drawing.Size(71, 17);
            this.lbProviderID.TabIndex = 5;
            this.lbProviderID.Text = "Numer ID:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbProviderID);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbProviderName);
            this.Controls.Add(this.lbSelectProvider);
            this.Controls.Add(this.listBoxProvider);
            this.Controls.Add(this.lbProviderTitle);
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
    }
}
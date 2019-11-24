namespace Magazyn
{
    partial class Form4
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
            this.lbComponentsBuyNew = new System.Windows.Forms.Label();
            this.listBoxComponentsBuyType = new System.Windows.Forms.ListBox();
            this.lbComponentsBuyType = new System.Windows.Forms.Label();
            this.lbComponentsBuyName = new System.Windows.Forms.Label();
            this.lbComponentName = new System.Windows.Forms.Label();
            this.lbComponentPrize = new System.Windows.Forms.Label();
            this.lbPrize = new System.Windows.Forms.Label();
            this.lbComponentCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbComponentsBuyNew
            // 
            this.lbComponentsBuyNew.AutoSize = true;
            this.lbComponentsBuyNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbComponentsBuyNew.Location = new System.Drawing.Point(12, 9);
            this.lbComponentsBuyNew.Name = "lbComponentsBuyNew";
            this.lbComponentsBuyNew.Size = new System.Drawing.Size(510, 58);
            this.lbComponentsBuyNew.TabIndex = 0;
            this.lbComponentsBuyNew.Text = "Zakup komponentów";
            // 
            // listBoxComponentsBuyType
            // 
            this.listBoxComponentsBuyType.FormattingEnabled = true;
            this.listBoxComponentsBuyType.ItemHeight = 16;
            this.listBoxComponentsBuyType.Items.AddRange(new object[] {
            "Element 1",
            "Element 2",
            "Element3"});
            this.listBoxComponentsBuyType.Location = new System.Drawing.Point(137, 115);
            this.listBoxComponentsBuyType.Name = "listBoxComponentsBuyType";
            this.listBoxComponentsBuyType.Size = new System.Drawing.Size(120, 20);
            this.listBoxComponentsBuyType.TabIndex = 1;
            // 
            // lbComponentsBuyType
            // 
            this.lbComponentsBuyType.AutoSize = true;
            this.lbComponentsBuyType.Location = new System.Drawing.Point(25, 115);
            this.lbComponentsBuyType.Name = "lbComponentsBuyType";
            this.lbComponentsBuyType.Size = new System.Drawing.Size(106, 17);
            this.lbComponentsBuyType.TabIndex = 2;
            this.lbComponentsBuyType.Text = "Wybierz rodzaj:";
            // 
            // lbComponentsBuyName
            // 
            this.lbComponentsBuyName.AutoSize = true;
            this.lbComponentsBuyName.Location = new System.Drawing.Point(25, 150);
            this.lbComponentsBuyName.Name = "lbComponentsBuyName";
            this.lbComponentsBuyName.Size = new System.Drawing.Size(54, 17);
            this.lbComponentsBuyName.TabIndex = 3;
            this.lbComponentsBuyName.Text = "Nazwa:";
            // 
            // lbComponentName
            // 
            this.lbComponentName.AutoSize = true;
            this.lbComponentName.Location = new System.Drawing.Point(85, 150);
            this.lbComponentName.Name = "lbComponentName";
            this.lbComponentName.Size = new System.Drawing.Size(165, 21);
            this.lbComponentName.TabIndex = 4;
            this.lbComponentName.Text = "Nazwa komponentu";
            // 
            // lbComponentPrize
            // 
            this.lbComponentPrize.AutoSize = true;
            this.lbComponentPrize.Location = new System.Drawing.Point(25, 187);
            this.lbComponentPrize.Name = "lbComponentPrize";
            this.lbComponentPrize.Size = new System.Drawing.Size(56, 21);
            this.lbComponentPrize.TabIndex = 5;
            this.lbComponentPrize.Text = "Cena:";
            // 
            // lbPrize
            // 
            this.lbPrize.AutoSize = true;
            this.lbPrize.Location = new System.Drawing.Point(87, 187);
            this.lbPrize.Name = "lbPrize";
            this.lbPrize.Size = new System.Drawing.Size(154, 21);
            this.lbPrize.TabIndex = 6;
            this.lbPrize.Text = "Cena komponentu";
            // 
            // lbComponentCount
            // 
            this.lbComponentCount.AutoSize = true;
            this.lbComponentCount.Location = new System.Drawing.Point(25, 220);
            this.lbComponentCount.Name = "lbComponentCount";
            this.lbComponentCount.Size = new System.Drawing.Size(50, 21);
            this.lbComponentCount.TabIndex = 7;
            this.lbComponentCount.Text = "Ilość:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(88, 217);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(149, 22);
            this.textBoxCount.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.lbComponentCount);
            this.Controls.Add(this.lbPrize);
            this.Controls.Add(this.lbComponentPrize);
            this.Controls.Add(this.lbComponentName);
            this.Controls.Add(this.lbComponentsBuyName);
            this.Controls.Add(this.lbComponentsBuyType);
            this.Controls.Add(this.listBoxComponentsBuyType);
            this.Controls.Add(this.lbComponentsBuyNew);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbComponentsBuyNew;
        private System.Windows.Forms.ListBox listBoxComponentsBuyType;
        private System.Windows.Forms.Label lbComponentsBuyType;
        private System.Windows.Forms.Label lbComponentsBuyName;
        private System.Windows.Forms.Label lbComponentName;
        private System.Windows.Forms.Label lbComponentPrize;
        private System.Windows.Forms.Label lbPrize;
        private System.Windows.Forms.Label lbComponentCount;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}
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
            this.lbComponentsBuyName = new System.Windows.Forms.Label();
            this.lbComponentName = new System.Windows.Forms.Label();
            this.lbComponentPrize = new System.Windows.Forms.Label();
            this.lbPrize = new System.Windows.Forms.Label();
            this.lbComponentCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.btnBuyComponentsPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFinalPrize = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbComponentsBuyNew
            // 
            this.lbComponentsBuyNew.AutoSize = true;
            this.lbComponentsBuyNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbComponentsBuyNew.Location = new System.Drawing.Point(9, 7);
            this.lbComponentsBuyNew.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentsBuyNew.Name = "lbComponentsBuyNew";
            this.lbComponentsBuyNew.Size = new System.Drawing.Size(333, 37);
            this.lbComponentsBuyNew.TabIndex = 0;
            this.lbComponentsBuyNew.Text = "Zakup komponentów";
            // 
            // lbComponentsBuyName
            // 
            this.lbComponentsBuyName.AutoSize = true;
            this.lbComponentsBuyName.Location = new System.Drawing.Point(19, 122);
            this.lbComponentsBuyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentsBuyName.Name = "lbComponentsBuyName";
            this.lbComponentsBuyName.Size = new System.Drawing.Size(43, 13);
            this.lbComponentsBuyName.TabIndex = 3;
            this.lbComponentsBuyName.Text = "Nazwa:";
            // 
            // lbComponentName
            // 
            this.lbComponentName.AutoSize = true;
            this.lbComponentName.Location = new System.Drawing.Point(64, 122);
            this.lbComponentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentName.Name = "lbComponentName";
            this.lbComponentName.Size = new System.Drawing.Size(102, 13);
            this.lbComponentName.TabIndex = 4;
            this.lbComponentName.Text = "Nazwa komponentu";
            // 
            // lbComponentPrize
            // 
            this.lbComponentPrize.AutoSize = true;
            this.lbComponentPrize.Location = new System.Drawing.Point(19, 152);
            this.lbComponentPrize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentPrize.Name = "lbComponentPrize";
            this.lbComponentPrize.Size = new System.Drawing.Size(35, 13);
            this.lbComponentPrize.TabIndex = 5;
            this.lbComponentPrize.Text = "Cena:";
            // 
            // lbPrize
            // 
            this.lbPrize.AutoSize = true;
            this.lbPrize.Location = new System.Drawing.Point(65, 152);
            this.lbPrize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrize.Name = "lbPrize";
            this.lbPrize.Size = new System.Drawing.Size(94, 13);
            this.lbPrize.TabIndex = 6;
            this.lbPrize.Text = "Cena komponentu";
            // 
            // lbComponentCount
            // 
            this.lbComponentCount.AutoSize = true;
            this.lbComponentCount.Location = new System.Drawing.Point(19, 179);
            this.lbComponentCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentCount.Name = "lbComponentCount";
            this.lbComponentCount.Size = new System.Drawing.Size(32, 13);
            this.lbComponentCount.TabIndex = 7;
            this.lbComponentCount.Text = "Ilość:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(66, 176);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(113, 20);
            this.textBoxCount.TabIndex = 8;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // btnBuyComponentsPrevious
            // 
            this.btnBuyComponentsPrevious.Location = new System.Drawing.Point(510, 308);
            this.btnBuyComponentsPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuyComponentsPrevious.Name = "btnBuyComponentsPrevious";
            this.btnBuyComponentsPrevious.Size = new System.Drawing.Size(81, 48);
            this.btnBuyComponentsPrevious.TabIndex = 9;
            this.btnBuyComponentsPrevious.Text = "Wróć";
            this.btnBuyComponentsPrevious.UseVisualStyleBackColor = true;
            this.btnBuyComponentsPrevious.Click += new System.EventHandler(this.btnBuyComponentsPrevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cena finalna:";
            // 
            // lbFinalPrize
            // 
            this.lbFinalPrize.AutoSize = true;
            this.lbFinalPrize.Location = new System.Drawing.Point(123, 292);
            this.lbFinalPrize.Name = "lbFinalPrize";
            this.lbFinalPrize.Size = new System.Drawing.Size(13, 13);
            this.lbFinalPrize.TabIndex = 11;
            this.lbFinalPrize.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbFinalPrize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuyComponentsPrevious);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.lbComponentCount);
            this.Controls.Add(this.lbPrize);
            this.Controls.Add(this.lbComponentPrize);
            this.Controls.Add(this.lbComponentName);
            this.Controls.Add(this.lbComponentsBuyName);
            this.Controls.Add(this.lbComponentsBuyNew);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbComponentsBuyNew;
        private System.Windows.Forms.Label lbComponentsBuyName;
        private System.Windows.Forms.Label lbComponentName;
        private System.Windows.Forms.Label lbComponentPrize;
        private System.Windows.Forms.Label lbPrize;
        private System.Windows.Forms.Label lbComponentCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button btnBuyComponentsPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFinalPrize;
        private System.Windows.Forms.Button btnAdd;
    }
}
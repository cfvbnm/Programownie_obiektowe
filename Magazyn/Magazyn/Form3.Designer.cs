namespace Magazyn
{
    partial class Form3
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
            this.lbComponentsTitle = new System.Windows.Forms.Label();
            this.lbComponentSelect = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxComponentSelect = new System.Windows.Forms.ComboBox();
            this.lbComponentSelect2 = new System.Windows.Forms.Label();
            this.listBoxComponentsInfo = new System.Windows.Forms.ListBox();
            this.lbComponentInfo = new System.Windows.Forms.Label();
            this.btnComponentsBuy = new System.Windows.Forms.Button();
            this.btnComponentsDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbComponentsTitle
            // 
            this.lbComponentsTitle.AutoSize = true;
            this.lbComponentsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbComponentsTitle.Location = new System.Drawing.Point(12, 9);
            this.lbComponentsTitle.Name = "lbComponentsTitle";
            this.lbComponentsTitle.Size = new System.Drawing.Size(279, 32);
            this.lbComponentsTitle.TabIndex = 0;
            this.lbComponentsTitle.Text = "Komponenty/części";
            // 
            // lbComponentSelect
            // 
            this.lbComponentSelect.AutoSize = true;
            this.lbComponentSelect.Location = new System.Drawing.Point(15, 83);
            this.lbComponentSelect.Name = "lbComponentSelect";
            this.lbComponentSelect.Size = new System.Drawing.Size(106, 17);
            this.lbComponentSelect.TabIndex = 1;
            this.lbComponentSelect.Text = "Wybierz rodzaj:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Element 1",
            "Element2",
            "Element3"});
            this.listBox1.Location = new System.Drawing.Point(18, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(103, 276);
            this.listBox1.TabIndex = 2;
            // 
            // comboBoxComponentSelect
            // 
            this.comboBoxComponentSelect.FormattingEnabled = true;
            this.comboBoxComponentSelect.Items.AddRange(new object[] {
            "Element 1",
            "Element2",
            "Element3"});
            this.comboBoxComponentSelect.Location = new System.Drawing.Point(274, 117);
            this.comboBoxComponentSelect.Name = "comboBoxComponentSelect";
            this.comboBoxComponentSelect.Size = new System.Drawing.Size(157, 24);
            this.comboBoxComponentSelect.TabIndex = 3;
            // 
            // lbComponentSelect2
            // 
            this.lbComponentSelect2.AutoSize = true;
            this.lbComponentSelect2.Location = new System.Drawing.Point(271, 83);
            this.lbComponentSelect2.Name = "lbComponentSelect2";
            this.lbComponentSelect2.Size = new System.Drawing.Size(117, 17);
            this.lbComponentSelect2.TabIndex = 4;
            this.lbComponentSelect2.Text = "Wybierz element:";
            // 
            // listBoxComponentsInfo
            // 
            this.listBoxComponentsInfo.FormattingEnabled = true;
            this.listBoxComponentsInfo.ItemHeight = 16;
            this.listBoxComponentsInfo.Location = new System.Drawing.Point(576, 117);
            this.listBoxComponentsInfo.Name = "listBoxComponentsInfo";
            this.listBoxComponentsInfo.Size = new System.Drawing.Size(212, 276);
            this.listBoxComponentsInfo.TabIndex = 5;
            // 
            // lbComponentInfo
            // 
            this.lbComponentInfo.AutoSize = true;
            this.lbComponentInfo.Location = new System.Drawing.Point(573, 83);
            this.lbComponentInfo.Name = "lbComponentInfo";
            this.lbComponentInfo.Size = new System.Drawing.Size(221, 21);
            this.lbComponentInfo.TabIndex = 6;
            this.lbComponentInfo.Text = "Informacje o komponencie:";
            // 
            // btnComponentsBuy
            // 
            this.btnComponentsBuy.Location = new System.Drawing.Point(160, 323);
            this.btnComponentsBuy.Name = "btnComponentsBuy";
            this.btnComponentsBuy.Size = new System.Drawing.Size(131, 70);
            this.btnComponentsBuy.TabIndex = 7;
            this.btnComponentsBuy.Text = "Kup komponenty";
            this.btnComponentsBuy.UseVisualStyleBackColor = true;
            // 
            // btnComponentsDelete
            // 
            this.btnComponentsDelete.Location = new System.Drawing.Point(313, 325);
            this.btnComponentsDelete.Name = "btnComponentsDelete";
            this.btnComponentsDelete.Size = new System.Drawing.Size(145, 68);
            this.btnComponentsDelete.TabIndex = 8;
            this.btnComponentsDelete.Text = "Usuń komponent z magazynu";
            this.btnComponentsDelete.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.btnComponentsDelete);
            this.Controls.Add(this.btnComponentsBuy);
            this.Controls.Add(this.lbComponentInfo);
            this.Controls.Add(this.listBoxComponentsInfo);
            this.Controls.Add(this.lbComponentSelect2);
            this.Controls.Add(this.comboBoxComponentSelect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbComponentSelect);
            this.Controls.Add(this.lbComponentsTitle);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbComponentsTitle;
        private System.Windows.Forms.Label lbComponentSelect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBoxComponentSelect;
        private System.Windows.Forms.Label lbComponentSelect2;
        private System.Windows.Forms.ListBox listBoxComponentsInfo;
        private System.Windows.Forms.Label lbComponentInfo;
        private System.Windows.Forms.Button btnComponentsBuy;
        private System.Windows.Forms.Button btnComponentsDelete;
    }
}
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Procesory"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Karty Graficzne"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ramy"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Płyty Główne"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Zasilacze"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dyski"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.lbComponentsTitle = new System.Windows.Forms.Label();
            this.lbComponentSelect = new System.Windows.Forms.Label();
            this.lbComponentSelect2 = new System.Windows.Forms.Label();
            this.lbComponentInfo = new System.Windows.Forms.Label();
            this.btnComponentsBuy = new System.Windows.Forms.Button();
            this.btnComponentsPrevious = new System.Windows.Forms.Button();
            this.lvComponentType = new System.Windows.Forms.ListView();
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvComponentInfo = new System.Windows.Forms.ListView();
            this.lvComponentsOfType = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbComponentsTitle
            // 
            this.lbComponentsTitle.AutoSize = true;
            this.lbComponentsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbComponentsTitle.Location = new System.Drawing.Point(9, 7);
            this.lbComponentsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentsTitle.Name = "lbComponentsTitle";
            this.lbComponentsTitle.Size = new System.Drawing.Size(219, 26);
            this.lbComponentsTitle.TabIndex = 0;
            this.lbComponentsTitle.Text = "Komponenty/części";
            // 
            // lbComponentSelect
            // 
            this.lbComponentSelect.AutoSize = true;
            this.lbComponentSelect.Location = new System.Drawing.Point(11, 67);
            this.lbComponentSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentSelect.Name = "lbComponentSelect";
            this.lbComponentSelect.Size = new System.Drawing.Size(79, 13);
            this.lbComponentSelect.TabIndex = 1;
            this.lbComponentSelect.Text = "Wybierz rodzaj:";
            // 
            // lbComponentSelect2
            // 
            this.lbComponentSelect2.AutoSize = true;
            this.lbComponentSelect2.Location = new System.Drawing.Point(171, 67);
            this.lbComponentSelect2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentSelect2.Name = "lbComponentSelect2";
            this.lbComponentSelect2.Size = new System.Drawing.Size(88, 13);
            this.lbComponentSelect2.TabIndex = 4;
            this.lbComponentSelect2.Text = "Wybierz element:";
            // 
            // lbComponentInfo
            // 
            this.lbComponentInfo.AutoSize = true;
            this.lbComponentInfo.Location = new System.Drawing.Point(349, 67);
            this.lbComponentInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComponentInfo.Name = "lbComponentInfo";
            this.lbComponentInfo.Size = new System.Drawing.Size(135, 13);
            this.lbComponentInfo.TabIndex = 6;
            this.lbComponentInfo.Text = "Informacje o komponencie:";
            // 
            // btnComponentsBuy
            // 
            this.btnComponentsBuy.Location = new System.Drawing.Point(430, 334);
            this.btnComponentsBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnComponentsBuy.Name = "btnComponentsBuy";
            this.btnComponentsBuy.Size = new System.Drawing.Size(98, 37);
            this.btnComponentsBuy.TabIndex = 7;
            this.btnComponentsBuy.Text = "Kup komponenty";
            this.btnComponentsBuy.UseVisualStyleBackColor = true;
            this.btnComponentsBuy.Click += new System.EventHandler(this.btnComponentsBuy_Click);
            // 
            // btnComponentsPrevious
            // 
            this.btnComponentsPrevious.Location = new System.Drawing.Point(532, 334);
            this.btnComponentsPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnComponentsPrevious.Name = "btnComponentsPrevious";
            this.btnComponentsPrevious.Size = new System.Drawing.Size(84, 37);
            this.btnComponentsPrevious.TabIndex = 9;
            this.btnComponentsPrevious.Text = "Wróć";
            this.btnComponentsPrevious.UseVisualStyleBackColor = true;
            this.btnComponentsPrevious.Click += new System.EventHandler(this.btnComponentsPrevious_Click);
            // 
            // lvComponentType
            // 
            this.lvComponentType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chType});
            this.lvComponentType.GridLines = true;
            this.lvComponentType.HideSelection = false;
            this.lvComponentType.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lvComponentType.Location = new System.Drawing.Point(13, 84);
            this.lvComponentType.Name = "lvComponentType";
            this.lvComponentType.Size = new System.Drawing.Size(120, 239);
            this.lvComponentType.TabIndex = 10;
            this.lvComponentType.UseCompatibleStateImageBehavior = false;
            this.lvComponentType.View = System.Windows.Forms.View.List;
            this.lvComponentType.SelectedIndexChanged += new System.EventHandler(this.lvComponentType_SelectedIndexChanged);
            // 
            // chType
            // 
            this.chType.Width = 120;
            // 
            // lvComponentInfo
            // 
            this.lvComponentInfo.HideSelection = false;
            this.lvComponentInfo.Location = new System.Drawing.Point(352, 84);
            this.lvComponentInfo.Name = "lvComponentInfo";
            this.lvComponentInfo.Size = new System.Drawing.Size(262, 239);
            this.lvComponentInfo.TabIndex = 11;
            this.lvComponentInfo.UseCompatibleStateImageBehavior = false;
            // 
            // lvComponentsOfType
            // 
            this.lvComponentsOfType.HideSelection = false;
            this.lvComponentsOfType.Location = new System.Drawing.Point(174, 84);
            this.lvComponentsOfType.Name = "lvComponentsOfType";
            this.lvComponentsOfType.Size = new System.Drawing.Size(138, 239);
            this.lvComponentsOfType.TabIndex = 12;
            this.lvComponentsOfType.UseCompatibleStateImageBehavior = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 381);
            this.Controls.Add(this.lvComponentsOfType);
            this.Controls.Add(this.lvComponentInfo);
            this.Controls.Add(this.lvComponentType);
            this.Controls.Add(this.btnComponentsPrevious);
            this.Controls.Add(this.btnComponentsBuy);
            this.Controls.Add(this.lbComponentInfo);
            this.Controls.Add(this.lbComponentSelect2);
            this.Controls.Add(this.lbComponentSelect);
            this.Controls.Add(this.lbComponentsTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbComponentsTitle;
        private System.Windows.Forms.Label lbComponentSelect;
        private System.Windows.Forms.Label lbComponentSelect2;
        private System.Windows.Forms.Label lbComponentInfo;
        private System.Windows.Forms.Button btnComponentsBuy;
        private System.Windows.Forms.Button btnComponentsPrevious;
        private System.Windows.Forms.ListView lvComponentType;
        private System.Windows.Forms.ListView lvComponentInfo;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ListView lvComponentsOfType;
    }
}
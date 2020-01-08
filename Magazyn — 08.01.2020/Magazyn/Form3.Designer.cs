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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Procesory"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Karty Graficzne"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ramy"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Płyty Główne"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Zasilacze"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dyski"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.lbComponentsTitle = new System.Windows.Forms.Label();
            this.lbComponentSelect = new System.Windows.Forms.Label();
            this.lbComponentSelect2 = new System.Windows.Forms.Label();
            this.lbComponentInfo = new System.Windows.Forms.Label();
            this.btnComponentsBuy = new System.Windows.Forms.Button();
            this.btnComponentsPrevious = new System.Windows.Forms.Button();
            this.lvComponentType = new System.Windows.Forms.ListView();
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvComponentsOfType = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrize = new System.Windows.Forms.Label();
            this.lbParam1 = new System.Windows.Forms.Label();
            this.lbParam2 = new System.Windows.Forms.Label();
            this.lbParam3 = new System.Windows.Forms.Label();
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
            this.btnComponentsBuy.Location = new System.Drawing.Point(550, 334);
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
            this.btnComponentsPrevious.Location = new System.Drawing.Point(652, 334);
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
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
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
            // lvComponentsOfType
            // 
            this.lvComponentsOfType.HideSelection = false;
            this.lvComponentsOfType.Location = new System.Drawing.Point(174, 84);
            this.lvComponentsOfType.Name = "lvComponentsOfType";
            this.lvComponentsOfType.Size = new System.Drawing.Size(138, 239);
            this.lvComponentsOfType.TabIndex = 12;
            this.lvComponentsOfType.UseCompatibleStateImageBehavior = false;
            this.lvComponentsOfType.View = System.Windows.Forms.View.List;
            this.lvComponentsOfType.SelectedIndexChanged += new System.EventHandler(this.lvComponentsOfType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parametry:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(445, 99);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(10, 13);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "-";
            // 
            // lbPrize
            // 
            this.lbPrize.AutoSize = true;
            this.lbPrize.Location = new System.Drawing.Point(445, 137);
            this.lbPrize.Name = "lbPrize";
            this.lbPrize.Size = new System.Drawing.Size(10, 13);
            this.lbPrize.TabIndex = 19;
            this.lbPrize.Text = "-";
            // 
            // lbParam1
            // 
            this.lbParam1.AutoSize = true;
            this.lbParam1.Location = new System.Drawing.Point(445, 173);
            this.lbParam1.Name = "lbParam1";
            this.lbParam1.Size = new System.Drawing.Size(10, 13);
            this.lbParam1.TabIndex = 20;
            this.lbParam1.Text = "-";
            // 
            // lbParam2
            // 
            this.lbParam2.AutoSize = true;
            this.lbParam2.Location = new System.Drawing.Point(445, 201);
            this.lbParam2.Name = "lbParam2";
            this.lbParam2.Size = new System.Drawing.Size(10, 13);
            this.lbParam2.TabIndex = 21;
            this.lbParam2.Text = "-";
            // 
            // lbParam3
            // 
            this.lbParam3.AutoSize = true;
            this.lbParam3.Location = new System.Drawing.Point(445, 227);
            this.lbParam3.Name = "lbParam3";
            this.lbParam3.Size = new System.Drawing.Size(10, 13);
            this.lbParam3.TabIndex = 22;
            this.lbParam3.Text = "-";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 381);
            this.Controls.Add(this.lbParam3);
            this.Controls.Add(this.lbParam2);
            this.Controls.Add(this.lbParam1);
            this.Controls.Add(this.lbPrize);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvComponentsOfType);
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
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ListView lvComponentsOfType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrize;
        private System.Windows.Forms.Label lbParam1;
        private System.Windows.Forms.Label lbParam2;
        private System.Windows.Forms.Label lbParam3;
    }
}
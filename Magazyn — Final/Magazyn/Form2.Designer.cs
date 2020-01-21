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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnParagonReturn = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwa,
            this.Ilosc,
            this.Cena});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa";
            this.Nazwa.Width = 272;
            // 
            // Ilosc
            // 
            this.Ilosc.Text = "Ilość";
            this.Ilosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ilosc.Width = 125;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cena.Width = 108;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(636, 101);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(152, 46);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Wczytaj listę zakupów";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(636, 153);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(152, 46);
            this.btnSerialize.TabIndex = 3;
            this.btnSerialize.Text = "Zapisz listę";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnParagonReturn
            // 
            this.btnParagonReturn.Location = new System.Drawing.Point(636, 372);
            this.btnParagonReturn.Name = "btnParagonReturn";
            this.btnParagonReturn.Size = new System.Drawing.Size(152, 66);
            this.btnParagonReturn.TabIndex = 5;
            this.btnParagonReturn.Text = "Wróć";
            this.btnParagonReturn.UseVisualStyleBackColor = true;
            this.btnParagonReturn.Click += new System.EventHandler(this.btnParagonReturn_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(633, 227);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(62, 13);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Do zapłaty:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(633, 250);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(13, 13);
            this.lb2.TabIndex = 7;
            this.lb2.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnParagonReturn);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnParagonReturn;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Ilosc;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
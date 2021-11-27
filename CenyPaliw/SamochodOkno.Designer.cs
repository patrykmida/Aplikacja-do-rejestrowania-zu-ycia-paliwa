
namespace CenyPaliw
{
    partial class SamochodOkno
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPojemnosc = new System.Windows.Forms.TextBox();
            this.comboBoxRodzajPaliwa = new System.Windows.Forms.ComboBox();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBoxSpalanie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(139, 6);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(120, 20);
            this.textBoxMarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pojemność silnika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Spalanie na 100 km:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rodzaj paliwa:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(139, 32);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(120, 20);
            this.textBoxModel.TabIndex = 6;
            // 
            // textBoxPojemnosc
            // 
            this.textBoxPojemnosc.Location = new System.Drawing.Point(139, 58);
            this.textBoxPojemnosc.Name = "textBoxPojemnosc";
            this.textBoxPojemnosc.Size = new System.Drawing.Size(120, 20);
            this.textBoxPojemnosc.TabIndex = 8;
            // 
            // comboBoxRodzajPaliwa
            // 
            this.comboBoxRodzajPaliwa.FormattingEnabled = true;
            this.comboBoxRodzajPaliwa.Location = new System.Drawing.Point(138, 110);
            this.comboBoxRodzajPaliwa.Name = "comboBoxRodzajPaliwa";
            this.comboBoxRodzajPaliwa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRodzajPaliwa.TabIndex = 11;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(126, 164);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 13;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(207, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBoxSpalanie
            // 
            this.textBoxSpalanie.Location = new System.Drawing.Point(138, 84);
            this.textBoxSpalanie.Name = "textBoxSpalanie";
            this.textBoxSpalanie.Size = new System.Drawing.Size(120, 20);
            this.textBoxSpalanie.TabIndex = 14;
            // 
            // SamochodOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 199);
            this.Controls.Add(this.textBoxSpalanie);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.comboBoxRodzajPaliwa);
            this.Controls.Add(this.textBoxPojemnosc);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.label1);
            this.Name = "SamochodOkno";
            this.Text = "SamochodOkno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPojemnosc;
        private System.Windows.Forms.ComboBox comboBoxRodzajPaliwa;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBoxSpalanie;
    }
}
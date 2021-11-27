
namespace CenyPaliw
{
    partial class CenyPaliwOkno
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxRopa = new System.Windows.Forms.TextBox();
            this.textBoxGaz = new System.Windows.Forms.TextBox();
            this.textBoxPb95 = new System.Windows.Forms.TextBox();
            this.textBoxPb98 = new System.Windows.Forms.TextBox();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cena ropy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cena gazu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "cena pb95:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "cena pb98:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(94, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // textBoxRopa
            // 
            this.textBoxRopa.Location = new System.Drawing.Point(93, 29);
            this.textBoxRopa.Name = "textBoxRopa";
            this.textBoxRopa.Size = new System.Drawing.Size(100, 20);
            this.textBoxRopa.TabIndex = 6;
            // 
            // textBoxGaz
            // 
            this.textBoxGaz.Location = new System.Drawing.Point(93, 55);
            this.textBoxGaz.Name = "textBoxGaz";
            this.textBoxGaz.Size = new System.Drawing.Size(100, 20);
            this.textBoxGaz.TabIndex = 7;
            // 
            // textBoxPb95
            // 
            this.textBoxPb95.Location = new System.Drawing.Point(93, 81);
            this.textBoxPb95.Name = "textBoxPb95";
            this.textBoxPb95.Size = new System.Drawing.Size(100, 20);
            this.textBoxPb95.TabIndex = 8;
            // 
            // textBoxPb98
            // 
            this.textBoxPb98.Location = new System.Drawing.Point(94, 107);
            this.textBoxPb98.Name = "textBoxPb98";
            this.textBoxPb98.Size = new System.Drawing.Size(100, 20);
            this.textBoxPb98.TabIndex = 9;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(55, 156);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 17;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(136, 156);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CenyPaliwOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 191);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxPb98);
            this.Controls.Add(this.textBoxPb95);
            this.Controls.Add(this.textBoxGaz);
            this.Controls.Add(this.textBoxRopa);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CenyPaliwOkno";
            this.Text = "CenyPaliwOkno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxRopa;
        private System.Windows.Forms.TextBox textBoxGaz;
        private System.Windows.Forms.TextBox textBoxPb95;
        private System.Windows.Forms.TextBox textBoxPb98;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnOK;
    }
}
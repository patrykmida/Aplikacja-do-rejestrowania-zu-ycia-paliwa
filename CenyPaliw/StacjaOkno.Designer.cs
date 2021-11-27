
namespace CenyPaliw
{
    partial class StacjaOkno
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
            this.comboBoxProducenci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNr = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.btnDodajCene = new System.Windows.Forms.Button();
            this.btnUsunCene = new System.Windows.Forms.Button();
            this.btnEdytujCene = new System.Windows.Forms.Button();
            this.listViewCenyPaliw = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDodajProducenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxProducenci
            // 
            this.comboBoxProducenci.FormattingEnabled = true;
            this.comboBoxProducenci.Location = new System.Drawing.Point(93, 12);
            this.comboBoxProducenci.Name = "comboBoxProducenci";
            this.comboBoxProducenci.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProducenci.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ulica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nr";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNr);
            this.groupBox1.Controls.Add(this.textBoxUlica);
            this.groupBox1.Controls.Add(this.textBoxMiasto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(317, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres";
            // 
            // textBoxNr
            // 
            this.textBoxNr.Location = new System.Drawing.Point(65, 77);
            this.textBoxNr.Name = "textBoxNr";
            this.textBoxNr.Size = new System.Drawing.Size(174, 20);
            this.textBoxNr.TabIndex = 6;
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Location = new System.Drawing.Point(65, 51);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(174, 20);
            this.textBoxUlica.TabIndex = 5;
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.Location = new System.Drawing.Point(65, 25);
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(174, 20);
            this.textBoxMiasto.TabIndex = 3;
            // 
            // btnDodajCene
            // 
            this.btnDodajCene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajCene.Location = new System.Drawing.Point(12, 372);
            this.btnDodajCene.Name = "btnDodajCene";
            this.btnDodajCene.Size = new System.Drawing.Size(75, 23);
            this.btnDodajCene.TabIndex = 10;
            this.btnDodajCene.Text = "Dodaj";
            this.btnDodajCene.UseVisualStyleBackColor = true;
            this.btnDodajCene.Click += new System.EventHandler(this.btnDodajCene_Click);
            // 
            // btnUsunCene
            // 
            this.btnUsunCene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsunCene.Location = new System.Drawing.Point(174, 372);
            this.btnUsunCene.Name = "btnUsunCene";
            this.btnUsunCene.Size = new System.Drawing.Size(75, 23);
            this.btnUsunCene.TabIndex = 9;
            this.btnUsunCene.Text = "Usuń";
            this.btnUsunCene.UseVisualStyleBackColor = true;
            this.btnUsunCene.Click += new System.EventHandler(this.btnUsunCene_Click);
            // 
            // btnEdytujCene
            // 
            this.btnEdytujCene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdytujCene.Location = new System.Drawing.Point(93, 372);
            this.btnEdytujCene.Name = "btnEdytujCene";
            this.btnEdytujCene.Size = new System.Drawing.Size(75, 23);
            this.btnEdytujCene.TabIndex = 8;
            this.btnEdytujCene.Text = "Edytuj";
            this.btnEdytujCene.UseVisualStyleBackColor = true;
            this.btnEdytujCene.Click += new System.EventHandler(this.btnEdytujCene_Click);
            // 
            // listViewCenyPaliw
            // 
            this.listViewCenyPaliw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCenyPaliw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.listViewCenyPaliw.FullRowSelect = true;
            this.listViewCenyPaliw.HideSelection = false;
            this.listViewCenyPaliw.Location = new System.Drawing.Point(12, 129);
            this.listViewCenyPaliw.MultiSelect = false;
            this.listViewCenyPaliw.Name = "listViewCenyPaliw";
            this.listViewCenyPaliw.Size = new System.Drawing.Size(559, 237);
            this.listViewCenyPaliw.TabIndex = 7;
            this.listViewCenyPaliw.UseCompatibleStateImageBehavior = false;
            this.listViewCenyPaliw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Data";
            this.columnHeader9.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cena PB95";
            this.columnHeader6.Width = 79;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cena PB98";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cena ropy";
            this.columnHeader8.Width = 67;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cena gazu";
            this.columnHeader10.Width = 74;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnuluj.Location = new System.Drawing.Point(413, 403);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 15;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(494, 403);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDodajProducenta
            // 
            this.btnDodajProducenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajProducenta.Location = new System.Drawing.Point(88, 39);
            this.btnDodajProducenta.Name = "btnDodajProducenta";
            this.btnDodajProducenta.Size = new System.Drawing.Size(205, 23);
            this.btnDodajProducenta.TabIndex = 16;
            this.btnDodajProducenta.Text = "DodajProducenta";
            this.btnDodajProducenta.UseVisualStyleBackColor = true;
            this.btnDodajProducenta.Click += new System.EventHandler(this.btnDodajProducenta_Click);
            // 
            // StacjaOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 438);
            this.Controls.Add(this.btnDodajProducenta);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDodajCene);
            this.Controls.Add(this.btnUsunCene);
            this.Controls.Add(this.btnEdytujCene);
            this.Controls.Add(this.listViewCenyPaliw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProducenci);
            this.Name = "StacjaOkno";
            this.Text = "StacjaOkno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProducenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNr;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.Button btnDodajCene;
        private System.Windows.Forms.Button btnUsunCene;
        private System.Windows.Forms.Button btnEdytujCene;
        private System.Windows.Forms.ListView listViewCenyPaliw;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDodajProducenta;
    }
}
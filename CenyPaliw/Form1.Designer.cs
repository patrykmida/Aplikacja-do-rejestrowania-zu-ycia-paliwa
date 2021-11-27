
namespace CenyPaliw
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDodajsamochod = new System.Windows.Forms.Button();
            this.buttonUsunSamochod = new System.Windows.Forms.Button();
            this.buttonEdytujSamochod = new System.Windows.Forms.Button();
            this.listViewSamochody = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDodajStacje = new System.Windows.Forms.Button();
            this.buttonUsunStacje = new System.Windows.Forms.Button();
            this.buttonEdytujStacje = new System.Windows.Forms.Button();
            this.listViewStacje = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 361);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDodajsamochod);
            this.tabPage1.Controls.Add(this.buttonUsunSamochod);
            this.tabPage1.Controls.Add(this.buttonEdytujSamochod);
            this.tabPage1.Controls.Add(this.listViewSamochody);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1086, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Samochody";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDodajsamochod
            // 
            this.buttonDodajsamochod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodajsamochod.Location = new System.Drawing.Point(843, 306);
            this.buttonDodajsamochod.Name = "buttonDodajsamochod";
            this.buttonDodajsamochod.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajsamochod.TabIndex = 3;
            this.buttonDodajsamochod.Text = "Dodaj";
            this.buttonDodajsamochod.UseVisualStyleBackColor = true;
            this.buttonDodajsamochod.Click += new System.EventHandler(this.buttonDodajsamochod_Click);
            // 
            // buttonUsunSamochod
            // 
            this.buttonUsunSamochod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUsunSamochod.Location = new System.Drawing.Point(1005, 306);
            this.buttonUsunSamochod.Name = "buttonUsunSamochod";
            this.buttonUsunSamochod.Size = new System.Drawing.Size(75, 23);
            this.buttonUsunSamochod.TabIndex = 2;
            this.buttonUsunSamochod.Text = "Usuń";
            this.buttonUsunSamochod.UseVisualStyleBackColor = true;
            this.buttonUsunSamochod.Click += new System.EventHandler(this.buttonUsunSamochod_Click);
            // 
            // buttonEdytujSamochod
            // 
            this.buttonEdytujSamochod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdytujSamochod.Location = new System.Drawing.Point(924, 306);
            this.buttonEdytujSamochod.Name = "buttonEdytujSamochod";
            this.buttonEdytujSamochod.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytujSamochod.TabIndex = 1;
            this.buttonEdytujSamochod.Text = "Edytuj";
            this.buttonEdytujSamochod.UseVisualStyleBackColor = true;
            this.buttonEdytujSamochod.Click += new System.EventHandler(this.buttonEdytujSamochod_Click);
            // 
            // listViewSamochody
            // 
            this.listViewSamochody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSamochody.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader12});
            this.listViewSamochody.FullRowSelect = true;
            this.listViewSamochody.HideSelection = false;
            this.listViewSamochody.Location = new System.Drawing.Point(6, 6);
            this.listViewSamochody.MultiSelect = false;
            this.listViewSamochody.Name = "listViewSamochody";
            this.listViewSamochody.Size = new System.Drawing.Size(1074, 294);
            this.listViewSamochody.TabIndex = 0;
            this.listViewSamochody.UseCompatibleStateImageBehavior = false;
            this.listViewSamochody.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marka";
            this.columnHeader3.Width = 146;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 204;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pojemność silnika";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Spalanie na 100 km";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Rodzaj paliwa";
            this.columnHeader12.Width = 95;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDodajStacje);
            this.tabPage2.Controls.Add(this.buttonUsunStacje);
            this.tabPage2.Controls.Add(this.buttonEdytujStacje);
            this.tabPage2.Controls.Add(this.listViewStacje);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1086, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aktualne ceny paliw na stacjach";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDodajStacje
            // 
            this.buttonDodajStacje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodajStacje.Location = new System.Drawing.Point(841, 306);
            this.buttonDodajStacje.Name = "buttonDodajStacje";
            this.buttonDodajStacje.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajStacje.TabIndex = 6;
            this.buttonDodajStacje.Text = "Dodaj";
            this.buttonDodajStacje.UseVisualStyleBackColor = true;
            this.buttonDodajStacje.Click += new System.EventHandler(this.buttonDodajStacje_Click);
            // 
            // buttonUsunStacje
            // 
            this.buttonUsunStacje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUsunStacje.Location = new System.Drawing.Point(1003, 306);
            this.buttonUsunStacje.Name = "buttonUsunStacje";
            this.buttonUsunStacje.Size = new System.Drawing.Size(75, 23);
            this.buttonUsunStacje.TabIndex = 5;
            this.buttonUsunStacje.Text = "Usuń";
            this.buttonUsunStacje.UseVisualStyleBackColor = true;
            this.buttonUsunStacje.Click += new System.EventHandler(this.buttonUsunStacje_Click);
            // 
            // buttonEdytujStacje
            // 
            this.buttonEdytujStacje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdytujStacje.Location = new System.Drawing.Point(922, 306);
            this.buttonEdytujStacje.Name = "buttonEdytujStacje";
            this.buttonEdytujStacje.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytujStacje.TabIndex = 4;
            this.buttonEdytujStacje.Text = "Edytuj";
            this.buttonEdytujStacje.UseVisualStyleBackColor = true;
            this.buttonEdytujStacje.Click += new System.EventHandler(this.buttonEdytujStacje_Click);
            // 
            // listViewStacje
            // 
            this.listViewStacje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStacje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewStacje.FullRowSelect = true;
            this.listViewStacje.HideSelection = false;
            this.listViewStacje.Location = new System.Drawing.Point(6, 6);
            this.listViewStacje.MultiSelect = false;
            this.listViewStacje.Name = "listViewStacje";
            this.listViewStacje.Size = new System.Drawing.Size(1074, 294);
            this.listViewStacje.TabIndex = 1;
            this.listViewStacje.UseCompatibleStateImageBehavior = false;
            this.listViewStacje.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Producent";
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
            // columnHeader11
            // 
            this.columnHeader11.Text = "Adres stacji";
            this.columnHeader11.Width = 330;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonDodajsamochod;
        private System.Windows.Forms.Button buttonUsunSamochod;
        private System.Windows.Forms.Button buttonEdytujSamochod;
        private System.Windows.Forms.ListView listViewSamochody;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDodajStacje;
        private System.Windows.Forms.Button buttonUsunStacje;
        private System.Windows.Forms.Button buttonEdytujStacje;
        private System.Windows.Forms.ListView listViewStacje;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}


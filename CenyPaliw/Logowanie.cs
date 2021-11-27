using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenyPaliw
{
    public partial class Logowanie : Form
    {
        string login;
        string haslo;

        public Logowanie()
        {
            InitializeComponent();
            login = "";
            haslo = "";
        }
      
        public string Login
        {
            get => login;
        }
        public string Haslo
        {
            get => haslo;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            login = textBoxLogin.Text;
            haslo = textBoxHaslo.Text;
            this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

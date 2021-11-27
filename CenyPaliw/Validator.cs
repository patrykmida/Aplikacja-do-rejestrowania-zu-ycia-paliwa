using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenyPaliw
{
    class Validator
    {
        bool poprawne;
        public Validator()
        {
            poprawne = true;
        }

        public void PoleWymagane(TextBox textBox, string pole)
        {
            if(!poprawne)
            {
                return;
            }
            if(textBox.Text.Length == 0)
            {
                MessageBox.Show(string.Format("pole {0} jest wymagane", pole));
                poprawne = false;
            }
        }

        public void PoleWymagane(ComboBox comboBox, string pole)
        {
            if (!poprawne)
            {
                return;
            }
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show(string.Format("pole {0} jest wymagane", pole));
                poprawne = false;
            }
        }


        public void PoleWymaganeFloat(TextBox textBox, string pole)
        {
            if (!poprawne)
            {
                return;
            }
            PoleWymagane(textBox, pole);
            float liczba;
            if(!float.TryParse(textBox.Text, out liczba))
            {
                MessageBox.Show(string.Format("nie poprawny format pola {0}.", pole));
                poprawne = false;
            }
        }

        public bool Poprawne
        {
            get
            {
                return poprawne;
            }
        }
    }
}

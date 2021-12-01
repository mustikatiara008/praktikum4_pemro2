using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_3_1204027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

               private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "!");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if ((txtAngka.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(txtAngka, "Betul!");
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
            }
            else
            {
                epCorrect.SetError(txtAngka, "");
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
        }
    }
}

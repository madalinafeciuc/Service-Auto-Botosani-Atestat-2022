using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;

namespace Service_Auto_Atestat_2022
{
    public partial class Programare : Form
    {
        public Programare()
        {
            InitializeComponent();
        }

        int cnt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void program_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage(email_txtBox.Text, "ionutachitei19@gmail.com");
                msg.Subject = "Programare pentru " + nume_txtBox.Text + " " + prenume_txtBox.Text;
                msg.Body = "S-a efectuat o programare pentru " + nume_txtBox.Text + " " + prenume_txtBox.Text +
                    ". " + "Probleme intalnite la " + piesa_txtBox.Text + " la masina " + brand_txtBox.Text + " " + model_txtBox.Text + " " + motor_txtBox.Text + ". Numarul de telefon al clientului este: " + tel_txtBox.Text;


                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                NetworkCredential nc = new NetworkCredential(email_txtBox.Text, pass_txtBox.Text);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(msg);

                MessageBox.Show("Programare inscrisa cu succes. Asteptati confirmarea service-ului.");
                Menu menu = new Menu();
                this.Hide();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare! Verificati daca ati completat corect fiecare camp!");
            }

           


        }

        private void tel_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void nume_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void prenume_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tel_txtBox_Click(object sender, EventArgs e)
        {
            
            
            if (cnt < 1)
            {
                MessageBox.Show("Parola nu va fi salvata de aplicatie.");
                cnt = 1;

            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass_txtBox.UseSystemPasswordChar = false;
            }
            else
                pass_txtBox.UseSystemPasswordChar = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Auto_Atestat_2022
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void program_btn_Click(object sender, EventArgs e)
        {
            Programare progr = new Programare();
            this.Hide();
            progr.Closed += (s, args) => this.Close();
            progr.Show();
        }

        private void Credits_btn_Click(object sender, EventArgs e)
        {
            Credite credits = new Credite();
            this.Hide();
            credits.Closed += (s, args) => this.Close();
            credits.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        public Result(Question f)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            newForm.Show();
            this.Hide();
        }

        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

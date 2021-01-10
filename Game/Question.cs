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
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
        }

        public Question(Start f)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result newForm = new Result();
            newForm.Show();
            this.Hide();
        }

        private void Question_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

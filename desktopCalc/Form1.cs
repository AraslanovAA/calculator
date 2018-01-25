using calc220118;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopCalc
{
    public partial class Form1 : Form
    {
        private Calc Calc { get; set; }
        public Form1()
        {
            InitializeComponent();
            Calc = new Calc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LbOperations_old.Items.Clear();
            LbOperations_old.Items.AddRange(Calc.ShowOperations());//в чем ошибка?!
        }



        private void lbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInPut.Enabled = LbOperations_old.SelectedItem != null;
        }

        private void tbInPut_TextChanged(object sender, EventArgs e)
        {
            btnCalc.Enabled = !string.IsNullOrWhiteSpace(tbInPut.Text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (LbOperations_old.SelectedItem == null)
            {
                return;
            }
            var oper = LbOperations_old.SelectedItem.ToString();

            var result = Calc.Exec(oper, tbInPut.Text.Trim().Split(' '));//погуглить
            label3.Text = result.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flat1_Load(object sender, EventArgs e)
        {

        }
    }
}

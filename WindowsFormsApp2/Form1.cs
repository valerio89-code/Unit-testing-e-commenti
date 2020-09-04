using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Code;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Conto Conto = new Conto(10000);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_preleva_Click(object sender, EventArgs e)
        {
            Conto.PrelevaSoldi(int.Parse(textBox1.Text));
            lbl_saldo.Text = Conto.Saldo.ToString();
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_saldo.Text = Conto.Saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saldo = Conto.RecuperaSaldoInDollari(3, true);
            MessageBox.Show($"Il tuo conto in dollari vale: {saldo}");
        }
    }
}

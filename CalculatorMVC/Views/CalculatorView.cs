using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMVC.Models;
using CalculatorMVC.Controllers;
using System.Windows.Forms;

namespace CalculatorMVC.Views {
    public partial class CalculatorView : Form {
        private static CalculatorController ctrl;
        public CalculatorView()
        {
            InitializeComponent();
            ctrl = new CalculatorController();
        }

        private void tambah_Click(object sender, EventArgs e)
        {

            ctrl.CheckData(textBox1.Text.ToString(), textBox2.Text.ToString());
            if(ctrl._flag == true)
            {   
                ctrl.setNomor1(textBox1.Text.ToString());
                ctrl.setNomor2(textBox2.Text.ToString());
                textBox3.Text = ctrl.getValueOperateTambah().ToString();
            }
            else
            {
                MessageBox.Show("Harap Lengkapi Data !");
            }
        }

        private void kali_Click(object sender, EventArgs e)
        {
            ctrl.CheckData(textBox1.Text.ToString(), textBox2.Text.ToString());
            if (ctrl._flag == true)
            {
                ctrl.setNomor1(textBox1.Text.ToString());
                ctrl.setNomor2(textBox2.Text.ToString());
                textBox3.Text = ctrl.getValueOperatePerkalian().ToString();
            }
            else
            {
                MessageBox.Show("Harap Lengkapi Data !");
            }

        }

        private void kurang_Click(object sender, EventArgs e)
        {
            ctrl.CheckData(textBox1.Text.ToString(), textBox2.Text.ToString());
            if (ctrl._flag == true)
            {
                ctrl.setNomor1(textBox1.Text.ToString());
                ctrl.setNomor2(textBox2.Text.ToString());
                textBox3.Text = ctrl.getValueOperateKurang().ToString();
            }
            else
            {
                MessageBox.Show("Harap Lengkapi Data !");
            }
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            ctrl.CheckData(textBox1.Text.ToString(), textBox2.Text.ToString());
            if (ctrl._flag == true)
            {
                ctrl.setNomor1(textBox1.Text.ToString());
                ctrl.setNomor2(textBox2.Text.ToString());
                textBox3.Text = ctrl.getValueOperateBagi().ToString();
            }
            else
            {
                MessageBox.Show("Harap Lengkapi Data !");
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

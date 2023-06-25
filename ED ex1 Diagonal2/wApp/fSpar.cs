using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cApp;

namespace wApp
{
    public partial class fSpar : Form
    {
        public fSpar()
        {
            InitializeComponent();
        }

        int[,] A = {
                     { 0, 1, 0 , 0, 0, 0 , 0},           
                     { 0, 0, 1 , 0, 0, 1 , 0}, 
                     { 0, 0, 0 , 3, 0, 0 , 1},
                     { 0, 0, 0 , 0, 0, 0 , 2},
                     { 0, 0, 1 , 5, 0, 0 , 0},
                     { 0, 0, 0 , 0, 0, 1 , 0},
                     { 2, 0, 0 , 0, 0, 0 , 0},
                   };

        clsSpar SP = new clsSpar();
        clsCola Q = new clsCola();
        private void fSpar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SP.n = 7;
            SP.m = 7;
            label1.Text = SP.MostraArreglo(A);
            label7.Text = "Fernando Anguloo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SP.Sparce(A);
            label2.Text = SP.Sparce2(A).MostrarVector();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Q = SP.Diagonal22(SP);
            label3.Text = Q.Imprimir();
        }
    }
}

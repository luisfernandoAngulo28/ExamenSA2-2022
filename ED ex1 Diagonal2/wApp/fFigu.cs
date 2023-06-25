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
    public partial class fFigu : Form
    {
        public fFigu()
        {
            InitializeComponent();
        }

        int[,] A = { 
                     { 1, 3, 3 }, 
                     { 1, 1, 3 }, 
                     { 1, 1, 1 }, 
                   };

        int[,] B = { 
                     { 2, 2, 2 }, 
                     { 4, 2, 2 }, 
                     { 4, 4, 2 }, 
 
                   };

        clsExa E = new clsExa();

        private void fFigu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text=E.MostraArreglo(A);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text=E.MostraArreglo(B);
        }

        private void button2_Click_1(object sender, EventArgs e)
         {
            // Se define las caracteristicas de la figura inicial
            E.n = 3;       // Fila de la matriz
            E.m = 3;       // Columna la matriz
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = E.MostrarVector();
        }

        

        private void cmdAyBtoV_Click(object sender, EventArgs e)
        {
            E.CargarMatrizToVector(A, B);
        }

        private void cmdProme_Click(object sender, EventArgs e)
        {
            lblPTI.Text = E.PromedioTI().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblPTS.Text = E.PromedioTS().ToString();
        }

       




 


      

      

     


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class clsSpar
    {
        /*ATRIBUTOS*/

        const int Max = 1000;                          // Cantidad de filas del arreglo SP Sparce
        public int[,] SP = new int[Max, 3];            // Arreglo donde se almacena los datos de las Matris  original
        public int Cant = 0;                           // Cantidad de celdas llenas en el  arreglo SP Sparce
        public int m = 0;                             // Cantidad de columnas de la Matriz original
        public int n = 0;                             // Cantidad de filas de la Matriz original


        /*CONSTRUCTORES*/
        public clsSpar()
        {
            Cant = 0; n = 0; m = 0;
            int i = 0;
            while (i < Max)
            {
                SP[i, 0] = 0; SP[i, 1] = 0; SP[i, 2] = 0;
                i++;
            }
        }

        public clsSpar(clsSpar x)
        {
            Cant = x.Cant; n = x.n; m = x.m;
            int i = 0;
            while (i < Max)
            {
                SP[i, 0] = x.SP[i, 0]; SP[i, 1] = x.SP[i, 1]; SP[i, 2] = x.SP[i, 2];
                i++;
            }
        }

        // Limpiar el Arreglo SP
        public void ClearArreglo()
        {
            int i = 0; Cant = 0;
            while (i < Max)
            {
                SP[i, 0] = 0; SP[i, 1] = 0; SP[i, 2] = 0;
                i++;
            }
        }

        // Funcion para mostrar la Matriz A
        public string MostraArreglo(int[,] A)
        {
            int i, j = 0;
            string cad = "";
            for (i = 0; i < n; i++)
            {
                cad += "\n";
                for (j = 0; j < m; j++)
                    cad += "[" + A[i, j] + "]";
            }
            return cad;
        }


        // Funcion para mostrar arreglo Spar V(t,3)
        public string MostrarVector()
        {
            string cad = "";

            for (int i = 0; i < Cant; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cad += " [" + SP[i, j] + "]";
                }
                cad += "\n";
            }
            return cad;
        }

        // Aqui escriba el codigo de la funciones

        /*Sparce(A) --> SP
Copia los elementos de una matriz A con números naturales distintos de 0 a un arreglo Sparce SP.*/
        //Sparce(A) --> SP  //Funcion para pasar los datos de la matriz A a la matros Sparce SP(t,3)

        public clsSpar Sparce(int[,] A)
        {
            clsSpar P = new clsSpar();
            P.n = A.GetLength(0);//numero de fila
            P.m = A.GetLength(1);//numero de columnas
            P.SP[0, 0] = P.n;
            P.SP[0, 1] = P.m;
            P.Cant = 1;
            for (int i = 0; i < P.n; i++)
            {
                for (int j = 0; j < P.m; j++)
                {
                    if (A[i, j] != 0)  
                    {
                        P.SP[P.Cant, 0] = i;
                        P.SP[P.Cant, 1] = j;
                        P.SP[P.Cant, 2] = A[i, j];
                        P.Cant++;
                    }
                }
            }
            P.SP[0, 2] = P.Cant-1;
            return P;
        }
        public clsSpar Sparce2(int[,] A)
        {
            
            n = A.GetLength(0);//numero de fila
            m = A.GetLength(1);//numero de columnas
            SP[0, 0] = n;
            SP[0, 1] = m;
            Cant = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] != 0)
                    {
                        SP[Cant, 0] = i;
                        SP[Cant, 1] = j;
                        SP[Cant, 2] = A[i, j];
                        Cant++;
                    }
                }
            }
            SP[0, 2] = Cant - 1;
            return this;
        }


        //Diagonal2(SP) --> Q       //Funcion para pasar obtener en una cola  Q los datos de la diagonal secundaria de M a partir de SP

        public clsCola Diagonal22(clsSpar S)
        {
            int columna = S.SP[0, 0];
            clsCola Q = new clsCola();
            for (int i = 1; i <= Cant; i++)
            {
                if (S.SP[i,2]>0)
                {
                   
                    if ((S.SP[i,0] + S.SP[i,1]) == (columna-1))
                    {
                        Q.Add(S.SP[i, 2]);

                    }
                }
            }
           // Console.WriteLine(Q.Imprimir());
            return Q;
        }

        public clsCola Diagonal2(clsSpar S)
        {
           // Console.WriteLine(S.MostrarVector());
            clsCola Q = new clsCola();
            for (int i = 1; i <= Cant; i++)
            {
                if (S.SP[i, 2] > 0)
                {
                    if ((S.SP[i, 0] + S.SP[i, 1]) == (S.n - 1))
                        Q.Add(S.SP[i, 2]);
                }
            }
            return Q;
        }








    }

}



﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Stack<char> pila1;
            //pila1 = new Stack<char>();
            //string cadena = textBox1.Text;
            //for (int f = 0; f < cadena.Length; f++)
            //{
            //    if (cadena.ElementAt(f) == '(' || cadena.ElementAt(f) == '[' || cadena.ElementAt(f) == '{')
            //    {
            //        pila1.Push(cadena.ElementAt(f));
            //    }
            //    else
            //    {
            //        if (cadena.ElementAt(f) == ')')
            //        {
            //            if (pila1.Count == 0 || pila1.Pop() != '(')
            //            {
            //                Text = "Incorrecta";
            //                return;
            //            }
            //        }
            //        else
            //        {
            //            if (cadena.ElementAt(f) == ']')
            //            {
            //                if (pila1.Count == 0 || pila1.Pop() != '[')
            //                {
            //                    Text = "Incorrecta";
            //                    return;
            //                }
            //            }
            //            else
            //            {
            //                if (cadena.ElementAt(f) == '}')
            //                {
            //                    if (pila1.Count == 0 || pila1.Pop() != '{')
            //                    {
            //                        Text = "Incorrecta";
            //                        return;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //if (pila1.Count == 0)
            //{
            //    Text = "Correcta";
            //}
            //else
            //{
            //    Text = "Incorrecta";
            //}
            Random ale = new Random();
            int estado = 0;
            int llegada = 2 + ale.Next(0, 2);
            int salida = -1;
            int cantAtendidas = 0;
            Queue<int> cola = new Queue<int>();
            for (int minuto = 0; minuto < 600; minuto++)
            {
                if (llegada == minuto)
                {
                    if (estado == 0)
                    {
                        estado = 1;
                        salida = minuto + 2 + ale.Next(0, 3);
                    }

                    else
                    {
                        cola.Enqueue(minuto);
                    }
                    llegada = minuto + 2 + ale.Next(0, 2);
                }
                if (salida == minuto)
                {
                    estado = 0;
                    cantAtendidas++;
                    if (cola.Count != 0)
                    {
                        cola.Dequeue();
                        estado = 1;
                        salida = minuto + 2 + ale.Next(0, 3);
                    }
                }
            }
            label1.Text = "Atendidos:" + cantAtendidas.ToString();
            label2.Text = "En cola:" + cola.Count.ToString();
            label3.Text = "Minuto llegada:" + cola.Count.ToString();
        }
            
    }
}
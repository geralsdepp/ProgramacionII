﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormEstante
{
    public partial class FormEstante : Form
    {
        public FormEstante()
        {
            InitializeComponent();
            rtxtSalida.ReadOnly = true;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            rtxtSalida.Text = "";
            Estante est1;
            Estante est2;
            this.CargarEstante(out est1, out est2);
            rtxtSalida.Text += String.Format("Valor total Estante1: {0}", est1.ValorEstanteTotal);
            rtxtSalida.Text += String.Format("Valor Estante1 sólo de Galletitas: {0}",
            est1.GetValorEstante(Producto.ETipoProducto.Galletita));
            rtxtSalida.Text += String.Format("Contenido Estante1:\n{0}",
            Estante.MostrarEstante(est1));
            rtxtSalida.Text += "Estante ordenado por Marca....\n";
            est1.GetProductos().Sort(FormEstante.OrdenarProductos);
            rtxtSalida.Text += Estante.MostrarEstante(est1);
            est1 = est1 - Producto.ETipoProducto.Galletita;
            rtxtSalida.Text += String.Format("Estante1 sin Galletitas: {0}",
            Estante.MostrarEstante(est1));
            rtxtSalida.Text += String.Format("Contenido Estante2:\n{0}",
            Estante.MostrarEstante(est2));
            est2 -= Producto.ETipoProducto.Todos;
            rtxtSalida.Text += String.Format("Contenido Estante2:\n{0}",
            Estante.MostrarEstante(est2));
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            rtxtSalida.Text = "";
            Estante est1;
            Estante est2;
            this.CargarEstante(out est1, out est2);
            rtxtSalida.Text += "Estante 1 ordenado por Marca....\n";
            est1.GetProductos().Sort(FormEstante.OrdenarProductos);
            rtxtSalida.Text += Estante.MostrarEstante(est1);
            rtxtSalida.Text += "Estante 2 ordenado por Marca....\n";
            est2.GetProductos().Sort(FormEstante.OrdenarProductos);
            rtxtSalida.Text += Estante.MostrarEstante(est2);
        }

        private static int OrdenarProductos(Producto p1, Producto p2)
        {
            int retorno = p1.Marca.CompareTo(p2.Marca);
            return retorno;
        }

        private void CargarEstante(out Estante est1,out Estante est2)
        {
            est1 = new Estante(4);
            est2 = new Estante(3);

            Harina h1 = new Harina(102, 37.5f, Producto.EMarcaProducto.Favorita,
            Harina.ETipoHarina.CuatroCeros);
            Harina h2 = new Harina(103, 40.25f, Producto.EMarcaProducto.Favorita,
            Harina.ETipoHarina.Integral);
            Galletita g1 = new Galletita(113, 33.65f, Producto.EMarcaProducto.Pitusas, 250f);
            Galletita g2 = new Galletita(111, 56f, Producto.EMarcaProducto.Diversión, 500f);
            Jugo j1 = new Jugo(112, 25f, Producto.EMarcaProducto.Naranjú, Jugo.ESaborJugo.Pasable);
            Jugo j2 = new Jugo(333, 33f, Producto.EMarcaProducto.Swift, Jugo.ESaborJugo.Asqueroso);
            Gaseosa g = new Gaseosa(j2, 2250f);

            if (!(est1 + h1))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g2))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + j1))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + h2))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + j2))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g1))
            {
                MessageBox.Show("No se pudo agregar el producto al estante!!!");
            }
        }

       
    }
}

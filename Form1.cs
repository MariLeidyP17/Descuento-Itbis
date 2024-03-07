using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_aplica.Clear();
            txt_itbis.Clear();
            txt_monto.Clear();
            txt_montoneto.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Monto = int.Parse(txt_monto.Text);
            if (Monto <= 5000)
            {
                double ITBIS = Monto * 0.18;
                txt_itbis.Text = ITBIS.ToString();
                String Noaplica = "No aplica";
                txt_aplica.ForeColor = Color.Red;
                txt_aplica.Text = Noaplica;
                double Monto_neto = Monto + ITBIS;
                txt_montoneto.Text = Monto_neto.ToString();
                txt_precio.Text = Monto.ToString();
            }
            else if (Monto <= 10000)
            {
                double ITBIS = Monto * 0.18;
                txt_itbis.Text = ITBIS.ToString();
                double Descuento = Monto * 0.03;
                String Monto_aplicar = "Descuento a aplicar: " + Descuento;
                txt_aplica.ForeColor = Color.Green;
                txt_aplica.Text = Monto_aplicar;
                double Monto_neto = Monto - Descuento + ITBIS;
                txt_montoneto.Text = Monto_neto.ToString();
                txt_precio.Text = Monto.ToString();
            }
            else if (Monto <= 15000)
            {
                double ITBIS = Monto * 0.18;
                txt_itbis.Text = ITBIS.ToString();
                double Descuento = Monto * 0.05;
                String Monto_aplicar = "Descuento a aplicar: " + Descuento;
                txt_aplica.ForeColor = Color.Green;
                txt_aplica.Text = Monto_aplicar;
                double Monto_neto = Monto - Descuento + ITBIS;
                txt_montoneto.Text = Monto_neto.ToString();
                txt_precio.Text = Monto.ToString();


            }
            else if (Monto <= 20000)

            {
                double ITBIS = Monto * 0.18;
                txt_itbis.Text = ITBIS.ToString();
                double Descuento = Monto * 0.08;
                double Monto_neto = Monto - Descuento + ITBIS;
                txt_montoneto.Text = Monto_neto.ToString();
                String Monto_aplicar = "Descuento a aplicar: " + Descuento;
                txt_aplica.ForeColor = Color.Green;
                txt_aplica.Text = Monto_aplicar;
                txt_precio.Text = Monto.ToString();
            }

            else if (Monto >= 20001)
            {
              
                double ITBIS = Monto * 0.18;
                txt_itbis.Text = ITBIS.ToString();
                double Descuento = Monto * 0.10;
                double Monto_neto = Monto - Descuento + ITBIS;
                txt_montoneto.Text = Monto_neto.ToString();
                String Monto_aplicar = "Descuento a aplicar: " + Descuento;
                txt_aplica.ForeColor = Color.Green;
                txt_aplica.Text = Monto_aplicar;
                txt_precio.Text = Monto.ToString();

            }

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void txt_itbis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
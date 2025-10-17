using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDinamica
{
    public partial class FrmPilaEA : Form
    {
        public FrmPilaEA()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text);
            pila.Push(edad);
        }

        private void Mostrar()
        {
            string msn = "";
            foreach(int edad in pila)
                msn += " " + edad + " | ";
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                Mostrar();
            }
            else
                MessageBox.Show("Pila Vacia");
        }
        // Ordenar de mayor a menor
    }

}

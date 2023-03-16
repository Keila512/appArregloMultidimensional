using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appArregloMultidimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] contacto = new string[10, 3];
        int i = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(i < contacto.GetLength(0))
            {
                contacto[i, 0] = tbNombre.Text;
                contacto[i, 1] = tbCorreo.Text;
                contacto[i, 2] = tbTelefono.Text;
                listView1.Items.Add(contacto[i, 0] + ", " + contacto[i, 1] + ", " + contacto[i, 2]);
                i++;
            }
                       
        }
    }
}

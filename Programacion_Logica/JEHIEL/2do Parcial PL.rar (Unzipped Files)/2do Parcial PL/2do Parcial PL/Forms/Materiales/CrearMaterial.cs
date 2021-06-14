using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_Parcial_PL.Forms
{
    public partial class CrearMaterial : Form
    {
        public CrearMaterial()
        {
            InitializeComponent();
            guardarButton.Click += GuardarButton_Click;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            //Creo la nueva persona usando los valores provistos
            //En la vida real, hay que validarlos antes de hacer esto.

            Models.Material mat = new Models.Material()
            {
                Nombre = nombreTextBox.Text,
                Cantidad = (int)cantidadNumericUpDown.Value
            };

            Models.BaseDeDatos.Materiales.Add(mat);

            Close();
        }
    }
}

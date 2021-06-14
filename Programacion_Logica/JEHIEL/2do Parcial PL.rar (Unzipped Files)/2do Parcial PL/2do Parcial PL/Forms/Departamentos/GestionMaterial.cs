using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_Parcial_PL
{
    public partial class GestionMaterial : Form
    {
        public GestionMaterial()
        {
            InitializeComponent();

            listaDeDeptosControl.SetDeptoItems(Models.BaseDeDatos.Departamentos);

            filtroTextBox.TextChanged += FiltroTextBox_TextChanged;
            crearButton.Click += CrearButton_Click;
        }

        bool FiltroDeDeptos(Models.Departamento dep)
        {
            string filtro = filtroTextBox.Text.ToUpper();

            return filtro.Length < 2 || (dep.Nombre.ToUpper().Contains(filtro) || dep.Direccion.ToUpper().Contains(filtro));
        }

        void AplicarFiltro()
        {
            listaDeDeptosControl.FiltrarDepto(FiltroDeDeptos);
        }

        void RefrescarLista()
        {
            listaDeDeptosControl.SetDeptoItems(Models.BaseDeDatos.Departamentos);

            AplicarFiltro();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            Forms.CrearDepartamento form = new Forms.CrearDepartamento();

            form.ShowDialog();

            RefrescarLista();
        }

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }
    }
}

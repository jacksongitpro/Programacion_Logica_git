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
    public partial class DetalleDepartamento : Form
    {
        Models.Departamento Departamento;

        public DetalleDepartamento()
        {
            InitializeComponent();

            listaDeMatControl.SetMatItems(Models.BaseDeDatos.Materiales);

            filtroTextBox.TextChanged += FiltroTextBox_TextChanged;
            crearButton.Click += CrearButton_Click;
        }

        public DetalleDepartamento(Models.Departamento departamento)
        {
            InitializeComponent();
            SetDepto(departamento);

        }

        void SetDepto(Models.Departamento dep)
        {
            Departamento = dep;

            this.nombreLabel.Text = Departamento.Nombre;
            this.direccionLabel.Text = Departamento.Direccion;
        }

        bool FiltroDeMat(Models.Material mat)
        {
            string filtro = filtroTextBox.Text.ToUpper();

            return filtro.Length < 2 || (mat.Nombre.ToUpper().Contains(filtro));
        }

        void AplicarFiltro()
        {
            listaDeMatControl.FiltrarMat(FiltroDeMat);
        }

        void RefrescarLista()
        {
            listaDeMatControl.SetMatItems(Models.BaseDeDatos.Materiales);
            AplicarFiltro();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            CrearMaterial form = new CrearMaterial();

            form.ShowDialog();

            RefrescarLista();
        }

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

    }
}

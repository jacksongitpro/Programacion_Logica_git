using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_Parcial_PL.Controls.ListaDeDeptos
{
    public partial class ListaDeDeptosItem : UserControl
    {
        public Models.Departamento Departamento;

        public ListaDeDeptosItem()
        {
            InitializeComponent();
        }

        public ListaDeDeptosItem(Models.Departamento dep)
        {
            InitializeComponent();
            infoButton.Click += infoButton_Click;
            SetDepartamento(dep);
        }

        void SetDepartamento(Models.Departamento dep)
        {
            Departamento = dep;

            nombreLabel.Text = $"{Departamento.Nombre}";
            direccionLabel.Text = $"{Departamento.Direccion}";
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            Forms.DetalleDepartamento form = new Forms.DetalleDepartamento(Departamento);
            form.ShowDialog();

        }
    }
}

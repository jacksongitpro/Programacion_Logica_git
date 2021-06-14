using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2do_Parcial_PL.Controls.ListaDeMat
{
    public partial class ListaDeMatItem : UserControl
    {
        public Models.Material Material;
        public ListaDeMatItem()
        {
            InitializeComponent();
        }

        public ListaDeMatItem(Models.Material mat)
        {
            InitializeComponent();
            SetMaterial(mat);
        }

        void SetMaterial(Models.Material mat)
        {
            Material = mat;

            nombreLabel.Text = $"{Material.Nombre}";
            cantidadNumericUpDown.Value = Material.Cantidad;
        }

    }
}

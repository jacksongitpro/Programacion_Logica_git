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
    public partial class ListaDeDeptosControl : UserControl
    {
        List<ListaDeDeptosItem> Items = new List<ListaDeDeptosItem>();

        public ListaDeDeptosControl()
        {
            InitializeComponent();
            flowLayoutPanel1.SizeChanged += FlowLayoutPanel1_SizeChanged;
        }

        public void SetDeptoItems(List<Models.Departamento> departamentos)
        {
            flowLayoutPanel1.Controls.Clear();
            Items.Clear();

            for (int i = 0; i < departamentos.Count; i++)
            {
                ListaDeDeptosItem item = new ListaDeDeptosItem(departamentos[i]);
                item.Width = flowLayoutPanel1.Width - 25;

                Items.Add(item);
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        public void FiltrarDepto(Predicate<Models.Departamento> predicate)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Visible = predicate(Items[i].Departamento);
            }
        }

        void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            ActualizarAnchoDeItems();
        }

        void ActualizarAnchoDeItems()
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                flowLayoutPanel1.Controls[i].Width = flowLayoutPanel1.Width - 25;
            }
        }
    }
}

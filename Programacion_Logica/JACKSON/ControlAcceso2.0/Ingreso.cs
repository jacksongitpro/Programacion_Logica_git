using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//JacksonGarcia
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlAcceso;


namespace ControlAcceso
{
    public partial class Ingreso : Form 
    {
        public static Usuario Usuario;
        List<Usuario> Usuarios;

        public Ingreso()
        {
            InitializeComponent();
            Usuarios = BaseDeDatos.Usuarios;
        }
      

        private void NombretextUsuario_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Usuario user = Usuarios.Find((Usuario admin)=> admin.nombre == NombretextUsuario.Text && admin.password == textContraseña.Text);
            if (user != null)
            {
                MessageBox.Show("Ingreso Exitoso");
                frmPrincipal Form = new frmPrincipal();
                Form.ShowDialog();
            }

            else
            {
                MessageBox.Show("!!ERROR!! usuario o contraseña invalido");
                NombretextUsuario.Clear();
                textContraseña.Clear();
                NombretextUsuario.Focus();
                return;
                

            }
          
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Ingreso_Load(object sender, EventArgs e)
        {

        }       
       
        private void labelUsuario_Click(object sender, EventArgs e)
        {

           
        }
        private void linkLabel1RC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperacionForms Form = new RecuperacionForms();
            Form.ShowDialog();
        }

        private void labelClinica_Click(object sender, EventArgs e)
        {

        }    
                   

    }
}
//Usuario.nombre = NombretextUsuario.Text;
//BaseDeDatos.Usuarios.Find(NombretextUsuario.Text));
//BaseDeDatos.Usuarios.Find(textContraseña.Text);
//Usuario.password = textContraseña.Text;
//Usuario admin = new Usuario()
//{
//    nombre = "admin",
//    password = "admin",
//    codigo = "12345",
//};
//  //public Ingreso(Usuario admin)
//{           
//    InitializeComponent();           
//    Usuarios = BaseDeDatos.Usuarios;
//    SetUser(admin);
//    // NombretextUsuario.TextChanged += NombretextUsuario_TextChanged;
//}
//public void SetUser(Usuario admin)
//{
//    admin = Usuario;
//    admin.nombre = NombretextUsuario.Text;
//    admin.password = textContraseña.Text;
//    admin.codigo = "12345";
//}
//if (NombretextUsuario.Text != admin.nombre || textContraseña.Text != admin.password)
//{
//     NombretextUsuario.Clear();
//textContraseña.Clear();
//frmPrincipal Form = new frmPrincipal(/*admin*/);
//Form.ShowDialog();
//MessageBox.Show("!!Bienvenido!!");

//}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Acceso;
using Datos.Entidades;

namespace TareaEjercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuariotextBox1.Text, ClavetextBox2.Text);

            if(usuario==null)
            {
                MessageBox.Show("Datos mal ingresados");
                return;
            }
            
            else if(!usuario.EstaActivo)
            {
                MessageBox.Show("El usuario esta inactivo");
                return;
            }
             
            MostrarUsuarios mostrarUsuarios = new MostrarUsuarios();
            mostrarUsuarios.Show();

            MessageBox.Show("El codigo y la contraseña son correctos");
        }

        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

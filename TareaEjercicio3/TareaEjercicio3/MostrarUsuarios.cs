using Datos.Acceso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEjercicio3
{
    public partial class MostrarUsuarios : Form
    {
        public MostrarUsuarios()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();

        private void MostrarUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }


        private void ListarUsuarios()
        {
           MostrarUsuariodataGridView1.DataSource = usuarioDA.ListarUsuarios();
        }

        private void Cerrarbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

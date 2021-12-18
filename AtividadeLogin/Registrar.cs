using AtividadeLogin.Entitie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeLogin
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new(txtNomeRe.Text, txtEmailRe.Text, txtSenhaRe.Text, "cripto");
            user.GravarUsuario();
            MessageBox.Show("Usuario registrado com sucesso");
            this.Close();
        }

        private void registrarAssin_Click(object sender, EventArgs e)
        {
            Usuario user = new(txtNomeRe.Text, txtEmailRe.Text, txtSenhaRe.Text);
            user.GravarUsuario();
            MessageBox.Show("Usuario registrado com sucesso");
            this.Close();
        }
    }
}

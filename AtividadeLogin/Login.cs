using AtividadeLogin.Entitie;
using AulaCriptografia;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar reg = new();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginDto model = new(txtEmail.Text, txtSenha.Text);
            Usuario user = new();
            user = user.ConsultaUsuario(txtEmail.Text);

            CriptoAssimetrica assim = new();
            CriptoSimetrica sim = new();

            if (user == null)
                MessageBox.Show("Usuario nao encontrado");

            else
            {
                try
                {
                    user.Senha = sim.DecryptData(user.Senha, "cripto");
                    if (user.Senha == model.Senha)
                        MessageBox.Show("Logado com sucesso!");
                    else
                        MessageBox.Show("Senha inválida");
                }
                catch
                {
                    try
                    {
                        user.Senha = assim.decrypt(user.Senha);
                        if (user.Senha == model.Senha)
                            MessageBox.Show("Logado com sucesso!");
                        else
                            MessageBox.Show("Senha inválida");
                    }
                    catch
                    {
                        MessageBox.Show("Senha inválida");
                    }
                }
            }
        }
    }
}

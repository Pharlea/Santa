using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraticasDeProgramacao_Desafio_Bim01
{
    public partial class FormLer : Form
    {
        public FormLer()
        {
            InitializeComponent();
        }

        private void bt_voltar_Click(object sender, EventArgs e) //Volta ao form1
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void bt_ler_Click(object sender, EventArgs e) //Mostra nas texboxes os dados da pessoa com o id requisitado
        {
            /*
            Variável temporária para a verificação do id
            */
            string temp = tb_id.Text;

            /*
            Verifica o id e guarda ele na classe Pessoa
            */
            BLL.validaId(temp);
            if (Erro.Erro.getErro()) { MessageBox.Show(Erro.Erro.getMsg()); return; }

            /*
            Lê os dados da Pessoa no banco de dados e salva na classe Pessoa
            */
            BLL.lerDados();
            if (Erro.Erro.getErro()) { MessageBox.Show(Erro.Erro.getMsg()); return; }

            /*
            Muda os valores das texboxes para seus respectivos valores na classe Pessoa
            */
            tb_nome.Text = Pessoa.nome;
            tb_telefone.Text = Pessoa.telefone;
            tb_email.Text = Pessoa.eMail;
            tb_cep.Text = Pessoa.cep;
            tb_estado.Text = Pessoa.estado;
            tb_cidade.Text = Pessoa.cidade;
            tb_bairro.Text = Pessoa.bairro;
            tb_rua.Text = Pessoa.rua;
            tb_numero.Text = Pessoa.numero;
            tb_complemento.Text = Pessoa.complemento;

            /*
            Limpa os valores armazenados na classe Pessoa
            */
            BLL.removeValores();
        }
    }
}

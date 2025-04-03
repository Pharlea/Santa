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
    public partial class FormDeletar : Form
    {
        public FormDeletar()
        {
            InitializeComponent();
        }

        private void bt_voltar_Click(object sender, EventArgs e) // Volta ao form1
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void bt_deletar_Click(object sender, EventArgs e) //deleta a pessoa com o id especificado
        {
            /*
            Declara e atribui o valor a variavel id para verificação posterior
            */
            string temp = tb_id.Text;

            /*
            Valida o id e o guarda na classe Pessoa
            */
            BLL.validaId(temp);
            if (Erro.Erro.getErro()) { MessageBox.Show(Erro.Erro.getMsg()); return; }

            DialogResult result = MessageBox.Show("Tem certeza que você deseja deletar a pessoa no endereço " + Pessoa.id + "?", "Sim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) { return; }

            /*
            Deleta a pessoa do banco de dados
            */
            BLL.deletaPessoa();
            if (Erro.Erro.getErro()) { MessageBox.Show(Erro.Erro.getMsg()); return; }

            /*
            Mostra a mensagem de sucesso
            */
            MessageBox.Show("A pessoa no endereço " + Pessoa.id + " foi deletada");

            /*
            remove os valores da classe Pessoa
            */
            BLL.removeValores();
        }
    }
}

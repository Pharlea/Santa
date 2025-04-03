using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraticasDeProgramacao_Desafio_Bim01
{
    public partial class FormEditar : Form
    {
        Thread myThread;

        public FormEditar()
        {
            InitializeComponent();
        }

        private void bt_voltar_Click(object sender, EventArgs e) //Volta para o form1
        {
            Form1 form1 = new Form1();
            myThread.Abort();
            form1.Show();
            BLL.removeValores();
            this.Close();
        }

        private void bt_ler_Click(object sender, EventArgs e) //mostra nas texboxes os valores armazenados 
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
        }

        private void bt_editar_Click(object sender, EventArgs e) //edita os dados no banco de dados da pessoa com o id requisitado
        {
            /*
            Atribui valores das textboxes para a classe pessoas
            */
            string temp = tb_id.Text;
            Pessoa.nome = tb_nome.Text;
            Pessoa.telefone = tb_telefone.Text;
            Pessoa.eMail = tb_email.Text;
            Pessoa.cep = tb_cep.Text;
            Pessoa.estado = tb_estado.Text;
            Pessoa.cidade = tb_cidade.Text;
            Pessoa.bairro = tb_bairro.Text;
            Pessoa.rua = tb_rua.Text;
            Pessoa.numero = tb_numero.Text;
            Pessoa.complemento = tb_complemento.Text;

            /*
            Faz a validação dos valores que foram salvos na classe Pessoa
            */
            BLL.validaId(temp);
            if (Erro.Erro.getErro()) { MessageBox.Show(Erro.Erro.getMsg()); return; }

            /*
            Edita os dados da pessoa no banco de dados
            */
            BLL.editarPessoa();
            if (Erro.Erro.getErro()) { MessageBox.Show(Erro.Erro.getMsg()); return; }

            /*
            Mostra uma mensagem de sucesso em uma messagebox
            */
            MessageBox.Show("Pessoa " + Pessoa.id + " foi alterada");
        }

        private void FormEditar_Load(object sender, EventArgs e) // Inicia a thread ao carregar este form
        {
            myThread = new Thread(new ThreadStart(this.atualizarTb));
            myThread.Start();
        }

        private async void atualizarTb() //Atualiza as texboxes relacionadas ao cep
        {
            while (true)
            {
                try
                {
                    string cep = tb_cep.Text;

                    if (BLL.validaCep(cep))
                    {
                        await BLL.buscarEnderecoAsync(cep);

                        tb_estado.Invoke((Action)delegate () { tb_estado.Text = Pessoa.estado; });
                        tb_cidade.Invoke((Action)delegate () { tb_cidade.Text = Pessoa.cidade; });
                        tb_rua.Invoke((Action)delegate () { tb_rua.Text = Pessoa.rua; });
                        tb_bairro.Invoke((Action)delegate () { tb_bairro.Text = Pessoa.bairro; });
                    }
                    else
                    {
                        tb_estado.Invoke((Action)delegate () { tb_estado.Clear(); });
                        tb_cidade.Invoke((Action)delegate () { tb_cidade.Clear(); ; });
                        tb_rua.Invoke((Action)delegate () { tb_rua.Clear(); });
                        tb_bairro.Invoke((Action)delegate () { tb_bairro.Clear(); });
                    }
                } catch { }
            }
        }
    }
}

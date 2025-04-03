using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Erro;

namespace PraticasDeProgramacao_Desafio_Bim01
{
    public partial class FormCriar : Form
    {
        Thread myThread;

        public FormCriar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Volta para o Form1
        {
            Form1 form1 = new Form1();
            myThread.Abort();
            BLL.removeValores();
            form1.Show();
            this.Close();
        }

        private void bt_criar_Click(object sender, EventArgs e) //Faz o registro de uma  pessoa no banco  de dados
        {
            /*
             Atribuição de valores
             */
            string temp = tb_id.Text;

            temp = tb_id.Text;
            Pessoa.nome = tb_nome.Text;
            Pessoa.telefone = tb_telefone.Text;
            Pessoa.eMail = tb_email.Text;
            Pessoa.cep = tb_cep.Text;
            Pessoa.numero = tb_numero.Text;
            Pessoa.complemento = tb_complemento.Text;

            /*
            Validação 
            */
            BLL.validaDados(temp);
            if (Erro.Erro.getErro()) { MessageBox.Show(Erro.Erro.getMsg()); return; }

            /*
            Registra a pessoa no banco de dados
            */
            BLL.registraPessoa();
            if (Erro.Erro.getErro()) { MessageBox.Show(Erro.Erro.getMsg()); return; }

            /*
            Mensagem de sucesso
            */
            MessageBox.Show("Regitro de " + Pessoa.nome + " criado no endereço " + Pessoa.id);
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
                }
                catch { }
            }
        }

        private void FormCriar_Load(object sender, EventArgs e) //Inicia a thread ao carregar este Form
        {
            myThread = new Thread(new ThreadStart(this.atualizarTb));
            myThread.Start();
        }
    }
}

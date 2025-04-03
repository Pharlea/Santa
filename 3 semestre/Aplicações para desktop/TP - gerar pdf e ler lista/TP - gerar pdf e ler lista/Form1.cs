using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;

namespace TP___gerar_pdf_e_ler_lista
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void bt_Listbox_Click(object sender, EventArgs e)
        {
            LivroBLL.getProximo();
            while (!Erro.getErro())
            {
                lb_mostrar_dados.Items.Add("Titulo = " + Livro.titulo + " escrito por " + Livro.autor);
                LivroBLL.getProximo();
            }
        }

        private void Acesso_Load(object sender, EventArgs e)
        {
            LivroBLL.conecta();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                System.Windows.Forms.Application.Exit();
            }
        }

        private void Acesso_FormClosed(object sender, FormClosedEventArgs e)
        {
            LivroBLL.desconecta();
        }

        private void bt_word_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Document doc = word.Documents.Add();
            Selection texto = word.Selection;

            doc.Activate();

            LivroBLL.getProximo();
            while (!Erro.getErro())
            {
                texto.TypeText("Título = " + Livro.titulo + "\n escrito por " + Livro.autor + "\n\n");
                LivroBLL.getProximo();
            }

            doc.SaveAs(@"c:\matar\BD livro.pdf", WdSaveFormat.wdFormatPDF);
            word.Documents.Close();
            word.Quit();
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();
            Worksheet ws = excel.ActiveSheet;

            for (int i = 0; i < LivroDAL.getDt().Columns.Count; i++)
            {
                ws.Cells[1, (i + 1)] = LivroDAL.getDt().Columns[i].ColumnName;
                for (int j = 0; j < LivroDAL.getDt().Rows.Count; j++)
                {
                    ws.Cells[(j + 2), (i + 1)] = LivroDAL.getDt().Rows[j][i];
                }
            }

            ws.SaveAs(@"c:\matar\BD livro.xlsx");
            excel.Workbooks.Close();
            excel.Quit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaSql;
using System.Threading;
using System.IO;
using System.Data.SqlClient;

namespace ConsultaSac
{
    public partial class Expo : Form
    {
        DataTable dt = new DataTable();
        string arquivoCsv = @"C:\Users\rodrigoamorim\Desktop\ProjetoEtiqueta\Criandotxt\Meu_Comando.txt";
        
        public Expo()
        {
            InitializeComponent();
        }
        private void exportarConsulta()
        {
          /*  StreamWriter sr = new StreamWriter(@"C:\Users\rodrigoamorim\Desktop\ProjetoEtiqueta\Criandotxt\Meu_Comando.csv");
            resultaConsulta = consultaExpo(true);
            sr.WriteLine(resultaConsulta);
            sr.Close();
            Console.Read();
            MessageBox.Show("Exportação com sucesso!");
            MessageBox.Show(""); */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = "";

            if (radioButton1.Checked)
            {
                resultado = radioButton1.Text;
                exportarConsulta();
                if (consultaExpo())
                    MessageBox.Show("Os dados foram salvos com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (radioButton2.Checked)
            {
                resultado = radioButton2.Text;

            }

           

        }

        public bool consultaExpo() // classe do botão CONSULTA - Com a consulta SQL
        {

            var linha = "";

            try
            {
                using (StreamWriter sw = new StreamWriter(arquivoCsv))
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        linha = row["FILIAL"] + ";" + row["CLI_NOME"] + ";" + row["DATA_PEDIDO"];
                        sw.WriteLine(linha);
                    }
                }
                return true;   
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar Salvar: " + ex.Message, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

         } 
    }
}

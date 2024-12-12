using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaSql;

namespace ConsultaSac
{
    
    public partial class Avancada : Form
    {
        Thread t2;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public Avancada()
        {
            InitializeComponent();
        }
        private void Avancada_Load(object sender, EventArgs e)
        {
            loadAv.Text = "### Bem Vindo ###";
        }
        private void ConsultaAv() // Metodo
        {
            dt = ConsultaAvancada1(true);
            dataViu1.DataSource = dt;
        }

        private void ConsultaAv2()
        {
            dt = ConsultaAvancada2(true);
            dataViu1.DataSource = dt;
        }

        private void btt_consulta_Click(object sender, EventArgs e)
        {
            if (txtLojaAv.Text == "" && txtCPF.Text == "")
            {
                MessageBox.Show("### Insira o CPF do cliente ###");
            }

            if (txtLojaAv.Text == "" && txtCPF.Text != "")
            {
                MessageBox.Show("Exibindo todos os pedidos do cliente.");
                statusStrip1.Text = "Conectando, aguarde";
                statusStrip1.Refresh();
                ConsultaAv2();
            }
            else 
            {
                statusStrip1.Text = "Conectando, aguarde";
                statusStrip1.Refresh();
                ConsultaAv();
            }
            
        }

        public DataTable ConsultaAvancada1(bool ativos) // classe do botão CONSULTA - Com a consulta SQL
        {

            string idloja = txtLojaAv.Text;
            string idboleta = txtCPF.Text;
            var dt = new DataTable();

            var sql1 = @"SELECT distinct FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC,  DATA_PEDIDO, STATUS, NF, TRI_ETIQUETA_C_DIGITO FROM pla.ITENSNOTA with(nolock)
                            inner join pla.TRANSPORTADORA_REMESSA_ITEM with(nolock) on ITE_DOC = TRI_NOTA
                            inner join pla.VENDAOMNI_LOCAL with(nolock) on NF = ITE_NOTA
                            inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                            inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON
                            where ITE_FILIAL = '" + idloja+"' and CLI_CGC = '"+idboleta+"'";

            /*var sql2 = @"SELECT NOT_ROMANEIO,NOT_FILIAL,FIL_RAZAO_SOCIAL,EMP_RAZAO_SOCIAL,NOT_NUMERO,NOT_EMISSAO,CLI_NOME, CLI_CGC,TRI_ETIQUETA_C_DIGITO, NOT_FRETE, NOT_DESCONTO, NOT_VALOR_NOTA, NOT_VALOR_MERCADORIA
                        FROM pla.ITENSNOTA WITH(NOLOCK)
                        INNER JOIN pla.NOTA_FISCAL WITH(NOLOCK) ON NOT_DOC = ITE_DOC
                        INNER JOIN pla.TRANSPORTADORA_REMESSA_ITEM WITH(NOLOCK) ON TRI_NOTA = NOT_DOC
                        INNER JOIN CLIENTES WITH(NOLOCK) ON CLI_CODIGON = NOT_CODIGON
                        INNER JOIN FILIAL WITH(NOLOCK) ON NOT_FILIAL = FIL_CODIGO
                        INNER JOIN EMPRESAS WITH(NOLOCK) ON FIL_EMPRESA = EMP_CODIGO
			            WHERE NOT_STATUS<> 'C'
                        AND FIL_FRANQUIA = 1 
                        AND NOT_FILIAL = '"+idloja+"' and NOT_ROMANEIO = '"+idboleta+"'";*/

            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql1, cn))
                    {
                        da.Fill(dt);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
            
           

        }

        public DataTable ConsultaAvancada2(bool ativos) // classe do botão CONSULTA - Com a consulta SQL
        {

            string idloja = txtLojaAv.Text;
            string idboleta = txtCPF.Text;
            var dt = new DataTable();

            var sql1 = @"SELECT distinct FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC,  DATA_PEDIDO, STATUS, NF, TRI_ETIQUETA_C_DIGITO FROM pla.ITENSNOTA with(nolock)
                            inner join pla.TRANSPORTADORA_REMESSA_ITEM with(nolock) on ITE_DOC = TRI_NOTA
                            inner join pla.VENDAOMNI_LOCAL with(nolock) on NF = ITE_NOTA
                            inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                            inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON
                            where CLI_CGC = '" + idboleta + "'";


            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql1, cn))
                    {
                        da.Fill(dt);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;



        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(backForm1);
            t2.SetApartmentState(ApartmentState.STA); //Configura  um estado de uma thread
            t2.Start();
        }

        private void backForm1(object obj) //Criar um metodo usando Thread;
        {
            Application.Run(new Form1()); //o metodo existe para chamar o Application.run(nome do form()) parentese para chamar o construtor;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

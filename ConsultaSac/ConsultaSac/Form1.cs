using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TabelaSql;
using System.Threading;
using System.IO;


//#>#>#>#>#>#>#>#>#>#>#>#>#>#>#>#>#>#>#>#>#>#> CONSULTA SAC V3.0 <#<#<#<#<#<#<#<#<#<#<#<#<#<#<#<#<#<#<#<# 

namespace ConsultaSac
{
    public partial class Form1 : Form
    {
        Thread t1; //dando nome a thread

        DataTable dt = new DataTable();
        
        string arquivoCsv = @"C:\Akira_Corp\Faturado.csv";
        string arquivoCsv2 = @"C:\Akira_Corp\Pendencia.csv";
        string arquivoCsv3 = @"C:\Akira_Corp\Pedidos.csv";


        DateTime horaSistema = DateTime.Now;
        DateTime valiSistema = new DateTime(2023, 01, 03, 00, 00, 00);

        
        
        public Form1()
        {
            InitializeComponent();
            //valiData();
        }

        private void Inicializar() // Metodo
        {
            dt = GetConsultasql(true);
            dataViu.DataSource = dt;
        }

        private void ProntoExpedir() // Metodo
        {
            dt = ProntoParaExpedir(true);  
            dataViu.DataSource = dt;
        }

        private void ProntoExpedir2() // Metodo
        {
            dt = ProntoParaExpedir2(true);
            dataViu.DataSource = dt;
        }

        private void PFaturado()
        {
            dt = FaturadoP(true);
            dataViu.DataSource = dt;
        }// Metodo

        private void PFaturado2()
        {
            dt = FaturadoP2(true);
            dataViu.DataSource = dt;
        }
       
        private void FiltroC()
        {
            dt = FiltroConsulta(true);
            dataViu.DataSource = dt;
        }

        private void FiltroC2()
        {
            dt = FiltroConsulta2(true);
            dataViu.DataSource = dt;
        }

     

        //#################################################################################################################################################################

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "### Bem Vindo ###";
        }


        //#################################################################################################################################################################

        //#################################################################################################################################################################
        private void btt_consulta_Click(object sender, EventArgs e) //Bota PENDENCIAS
        {
           
                toolStripStatusLabel1.Text = "Conectando, aguarde...";
                statusStrip1.Refresh();
                Inicializar();

                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        toolStripStatusLabel1.Text = "Conectado";
                        statusStrip1.Refresh();

                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.Text = "Falha!";
                    statusStrip1.Refresh();
                    MessageBox.Show("Falha ao conectar \n " + ex.Message);
                }

           
        }

        public DataTable GetConsultasql(bool ativos) // Consulta Botão PENDENCIAS
        {

           
            var dt = new DataTable();

            var sql = @"select FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC, DATA_PEDIDO, CAI_DATA, STATUS  from pla.VENDAOMNI_LOCAL WITH(NOLOCK)
                      inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                      inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON  
                      where CAI_DATA >= dateadd(day, -15, getdate()) and [STATUS] = 'Aguadando Separação'
                      order by NOME_LOJA";
            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                        MessageBox.Show("Exibindo lojas com pendencias");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        } 

        private void bttExpedir_Click(object sender, EventArgs e) //PEDIDOS
        {
            if (horaSistema < valiSistema)
            {
                toolStripStatusLabel1.Text = "Conectando, Aguarde...";
                if (txtLoja.Text != "")
                {

                    toolStripStatusLabel1.Text = "Conectado";
                    statusStrip1.Refresh();
                    ProntoExpedir();
                }
                else
                {
                    
                    toolStripStatusLabel1.Text = "Conectado";
                    statusStrip1.Refresh();
                    ProntoExpedir2();
                }
            }
           
        } 

        public DataTable ProntoParaExpedir(bool ativos)
        {
            string idloja; 
            idloja = txtLoja.Text;
            var dt = new DataTable();

            
           
            
            var sql = @"select FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC, DATA_PEDIDO, CAI_DATA, [STATUS]  from pla.VENDAOMNI_LOCAL WITH(NOLOCK)
                      inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                      inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON  
                      where CAI_DATA >= dateadd(day, -30, getdate()) and FILIAL = '"+idloja+"' order by NOME_LOJA";

            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {

                        da.Fill(dt);
                        MessageBox.Show("Exibindo resultados da loja " + idloja);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt; ;
        } //Consulta Botão PEDIDOS para uma Loja

        public DataTable ProntoParaExpedir2(bool ativos)
        {
            string idloja;
            idloja = txtLoja.Text;
            var dt = new DataTable();



            var sql = @"select FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC, DATA_PEDIDO, CAI_DATA, [STATUS]  from pla.VENDAOMNI_LOCAL WITH(NOLOCK)
                      inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                      inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON  
                      where CAI_DATA >= dateadd(day, -30, getdate()) order by NOME_LOJA";

            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {

                        da.Fill(dt);
                        MessageBox.Show("Exibindo resultados de todas as lojas ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt; ;
        }//Consulta Botão PEDIDOS para todas lojas

        private void bttFaturado_Click(object sender, EventArgs e)
        {
            if (horaSistema < valiSistema)
            {
                if (txtLoja.Text != "")
                {
                    toolStripStatusLabel1.Text = "Conectando, aguarde";
                    statusStrip1.Refresh();
                    PFaturado();
                }
                else
                {
                    MessageBox.Show("Exibindo resultado de todas as lojas");
                    statusStrip1.Refresh();
                    PFaturado2();

                }
            }
            else
            {
                MessageBox.Show("Produto Expirado");
            }
        } //Botão FATURADO 

        public DataTable FaturadoP(bool ativos)
        {
            string idloja;
            idloja = txtLoja.Text;
            var dt = new DataTable();

            

            var sql = @"SELECT distinct FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC,  DATA_PEDIDO, [STATUS], DATA_FATURAMENTO,  NF, TRI_ETIQUETA_C_DIGITO FROM pla.ITENSNOTA with(nolock)
                        inner join pla.TRANSPORTADORA_REMESSA_ITEM with(nolock) on ITE_DOC = TRI_NOTA
                        inner join pla.VENDAOMNI_LOCAL with(nolock) on NF = ITE_NOTA
                        inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                        inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON
                        where FILIAL = '"+idloja+"' and DATA_PEDIDO <= dateadd(day, 30, getdate())  order by DATA_PEDIDO desc";

            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {

                        da.Fill(dt);
                        MessageBox.Show("Exibindo resultados da loja " + idloja);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt; ;
        } //Consulta Botão FATURADO para uma loja

        public DataTable FaturadoP2(bool ativos)
        {
            var dt = new DataTable();



            var sql = @"SELECT distinct FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC,  DATA_PEDIDO, [STATUS], DATA_FATURAMENTO,  NF, TRI_ETIQUETA_C_DIGITO FROM pla.ITENSNOTA with(nolock)
                        inner join pla.TRANSPORTADORA_REMESSA_ITEM with(nolock) on ITE_DOC = TRI_NOTA
                        inner join pla.VENDAOMNI_LOCAL with(nolock) on NF = ITE_NOTA
                        inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                        inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON
                        where DATA_PEDIDO <= dateadd(day, 30, getdate())  order by DATA_PEDIDO desc";

            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {

                        da.Fill(dt);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt; ;
        } //Consulta Botão FATURADO todas as lojas

        private void txtLoja_TextChanged(object sender, EventArgs e)
        {

        } //Ignorar 

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }//Ignorar

        private void bttAvancada_Click(object sender, EventArgs e)
        {
            // Avancada J2 = new Avancada(); //Istancia-lo pois o mesmo é uma classe (janela Avancada),  então criamos um objeto a partir dela, se chama J2.
            /* J2.Show();   // Exibir o objeto utilizando um metodo que existe nele. 
             this.Hide();*/
            //Para esconder a janela. utilizando this.
            if (horaSistema < valiSistema)
            {
                this.Close();
                t1 = new Thread(openAvancada);
                t1.SetApartmentState(ApartmentState.STA); //Configura  um estado de uma thread
                t1.Start();
            }
            else
            {
                MessageBox.Show("Produto Expirado!");
            }
        } //Botão consulta avançada

        private void openAvancada(object obj) //Criar um metodo usando Thread;
        {
            Application.Run(new Avancada()); //o metodo existe para chamar o Application.run(nome do form()) parentese para chamar o construtor;  
        }

        private void btt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"###AJUDA###\n " +
                "\n#PENDENCIAS -> Busca todos os pedidos pendentes em todas as lojas.\n" +
                " \n#PRONTO PARA EXPEDIR -> Busca os pedidos pendentes na loja digitada pelo usuário.\n" +
                " \n#Faturado -> Busca todos os pedidos faturados da loja digitada pelo usuário.\n" +
                " \n#ETIQUETA -> Para buscar etiqueta dos correios, Será necessário o CPF do cliente. Também será necessário que digite neste formato xxx-xxx-xxx/xx\n" +
                " \n#EXPORTAR -> Exportação cria um arquivo .csv no endereço C:\\Akira Corp\\." +
                " \n \n$$$ AKIRA CORP $$$ ");
        }

        private void bttExcel_Click(object sender, EventArgs e)
        {
            if (horaSistema < valiSistema)
            {


                if (radioFaturado.Checked)
                {
                    if (consultaExpo())
                        MessageBox.Show("Os dados foram salvos com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (radioPendencia.Checked)
                {
                    if (consultaExpo2())
                        MessageBox.Show("Os dados foram salvos com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (radioGeral.Checked)
                {
                    if (consultaExpo3())
                        MessageBox.Show("Os dados foram salvos com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                   MessageBox.Show("Produto Expirado.");
            }
        }

        public bool consultaExpo() // classe do botão EXCEL - Exportar Faturado
        {

            var linha = "";

            try
            {
                using (StreamWriter sw = new StreamWriter(arquivoCsv))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        linha = row["FILIAL"] + ";" + row["NOME_LOJA"] + ";" + row["BOLETA"] + ";" + row["CLI_NOME"] + ";" + row["CLI_CGC"] + ";" + row["DATA_PEDIDO"]+ ";" + row["STATUS"] + ";" + row["DATA_FATURAMENTO"] + ";" + row["NF"] + ";" + row["TRI_ETIQUETA_C_DIGITO"] + ";" ;
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

        public bool consultaExpo2() // classe do botão EXCEL - Exportar Pendencia
        {

            var linha = "";

            try
            {
                using (StreamWriter sw = new StreamWriter(arquivoCsv2))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        linha = row["FILIAL"] + ";" + row["NOME_LOJA"] + ";" + row["BOLETA"] + ";" + row["CLI_NOME"] + ";" + row["CLI_CGC"] + ";" + row["DATA_PEDIDO"]+ ";" + row["CLI_CGC"] + ";" + row["STATUS"] + ";";
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

        public bool consultaExpo3() // classe do botão EXCEL - Exportar Pedidos
        {

            var linha = "";

            try
            {
                using (StreamWriter sw = new StreamWriter(arquivoCsv3))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        linha = row["FILIAL"] + ";" + row["NOME_LOJA"] + ";" + row["BOLETA"] + ";" + row["CLI_NOME"] + ";" + row["CLI_CGC"] + ";" + row["DATA_PEDIDO"] + ";" + row["CAI_DATA"] + ";" + row["STATUS"] + ";";
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

        private void bttFiltro_Click(object sender, EventArgs e)
        {
            
            if (horaSistema < valiSistema)
            {

                
                if (radioFaturado.Checked)
                {
                    FiltroC(); //FATURADO
                        
                }

                if (radioGeral.Checked)
                {
                    FiltroC2(); //PEDIDOS
                }

            }

            else
            {
                MessageBox.Show("Produto Expirado.");
            }

        } //Botão FILTRO

        public DataTable FiltroConsulta(bool ativos)
        {

            var dt = new DataTable();
            date1.Format = DateTimePickerFormat.Custom;
            date1.CustomFormat = "dd/MM/yyyy";
            date1.ShowUpDown = true;
            string td1 = date1.Value.ToString("dd/MM/yyyy");
            
                        
            date2.Format = DateTimePickerFormat.Custom;
            date2.CustomFormat = "dd/MM/yyyy";
            date2.ShowUpDown = true;
            string td2 = date2.Value.ToString("dd/MM/yyyy");


            var sql = @"SELECT distinct FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC,  DATA_PEDIDO, [STATUS], DATA_FATURAMENTO,  NF, TRI_ETIQUETA_C_DIGITO FROM pla.ITENSNOTA with(nolock)
                        inner join pla.TRANSPORTADORA_REMESSA_ITEM with(nolock) on ITE_DOC = TRI_NOTA
                        inner join pla.VENDAOMNI_LOCAL with(nolock) on NF = ITE_NOTA
                        inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                        inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON
                        where DATA_PEDIDO between '"+td1+"' and '"+td2+"'  order by DATA_PEDIDO desc";

         
            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {

                        da.Fill(dt);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt; ;

        }  //Classe do Filtro FATURADO
        public DataTable FiltroConsulta2(bool ativos)
        {

            var dt = new DataTable();
            date1.Format = DateTimePickerFormat.Custom;
            date1.CustomFormat = "dd/MM/yyyy";
            date1.ShowUpDown = true;
            string td1 = date1.Value.ToString("dd/MM/yyyy");


            date2.Format = DateTimePickerFormat.Custom;
            date2.CustomFormat = "dd/MM/yyyy";
            date2.ShowUpDown = true;
            string td2 = date2.Value.ToString("dd/MM/yyyy");


            var sql = @"select FILIAL, NOME_LOJA, BOLETA,CLI_NOME, CLI_CGC, DATA_PEDIDO, CAI_DATA, [STATUS]  from pla.VENDAOMNI_LOCAL WITH(NOLOCK)
                      inner join pla.CAIXA with(nolock) on BOLETA = CAI_CODIGO and FILIAL = CAI_FILIAL
                      inner join CLIENTES with(nolock) on CAI_CODIGON = CLI_CODIGON  
                      where CAI_DATA between '"+td1+"' and '"+td2+"' order by NOME_LOJA";

            
            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {

                        da.Fill(dt);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt; ;

        } //Classe do Filtro PEDIDOS
        
    }

}

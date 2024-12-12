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

namespace ConsultaSac
{
    public partial class Exportar : Form
    {
       // Thread t2;
        public Exportar()
        {
            InitializeComponent();
        }

        private void Exportar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     /*   private void enviarumzap(string number, string menssagem)
        {
            try
            {

                if (number == "")
                {
                    MessageBox.Show("Adicione um numero de telefone");
                }

                if (number.Length <= 12)
                {
                    MessageBox.Show("O Whatsapp será aberto!");
                    number = "+55" + number;
                }

                number = number.Replace(" ", "");

                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone" + number + "&text=" + menssagem);
            }
            catch (Exception ex)
            {

            }
        } */


        private void backForm1(object obj) //Criar um metodo usando Thread;
        {
            Application.Run(new Form1()); //o metodo existe para chamar o Application.run(nome do form()) parentese para chamar o construtor;  
        }

     /*   private void bttwpp_Click(object sender, EventArgs e)
        {

            string menssagem = "oi";
            enviarumzap(textNum.Text, menssagem);
            
        } */
    } 
}

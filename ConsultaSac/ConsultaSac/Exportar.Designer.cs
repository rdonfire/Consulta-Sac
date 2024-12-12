namespace ConsultaSac
{
    partial class Exportar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttwpp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttwpp
            // 
            this.bttwpp.Location = new System.Drawing.Point(126, 143);
            this.bttwpp.Name = "bttwpp";
            this.bttwpp.Size = new System.Drawing.Size(167, 57);
            this.bttwpp.TabIndex = 0;
            this.bttwpp.Text = "WHATSAPP";
            this.bttwpp.UseVisualStyleBackColor = true;
           // this.bttwpp.Click += new System.EventHandler(this.bttwpp_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "SAIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(126, 81);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(167, 20);
            this.textNum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite seu numero de telefone";
            // 
            // Exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bttwpp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exportar";
            this.Text = "Exportar";
            this.Load += new System.EventHandler(this.Exportar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttwpp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label label1;
    }
}
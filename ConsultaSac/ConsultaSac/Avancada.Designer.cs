namespace ConsultaSac
{
    partial class Avancada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avancada));
            this.btt_consulta = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtLojaAv = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadAv = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataViu1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViu1)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_consulta
            // 
            this.btt_consulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt_consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btt_consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_consulta.ImageKey = "stickers_038.png";
            this.btt_consulta.ImageList = this.imageList1;
            this.btt_consulta.Location = new System.Drawing.Point(43, 199);
            this.btt_consulta.Name = "btt_consulta";
            this.btt_consulta.Size = new System.Drawing.Size(228, 63);
            this.btt_consulta.TabIndex = 8;
            this.btt_consulta.Text = "CONSULTAR";
            this.btt_consulta.UseVisualStyleBackColor = false;
            this.btt_consulta.Click += new System.EventHandler(this.btt_consulta_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo-107x101-s.png");
            this.imageList1.Images.SetKeyName(1, "stickers_012.png");
            this.imageList1.Images.SetKeyName(2, "stickers_026.png");
            this.imageList1.Images.SetKeyName(3, "stickers_038.png");
            // 
            // txtLojaAv
            // 
            this.txtLojaAv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLojaAv.BackColor = System.Drawing.SystemColors.Window;
            this.txtLojaAv.Location = new System.Drawing.Point(43, 56);
            this.txtLojaAv.Name = "txtLojaAv";
            this.txtLojaAv.Size = new System.Drawing.Size(228, 20);
            this.txtLojaAv.TabIndex = 9;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtCPF.Location = new System.Drawing.Point(43, 140);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(228, 20);
            this.txtCPF.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "CODIGO DA LOJA";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(827, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "SAIR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "stickers_026.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(705, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "VOLTAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAv});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(941, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loadAv
            // 
            this.loadAv.Name = "loadAv";
            this.loadAv.Size = new System.Drawing.Size(97, 17);
            this.loadAv.Text = "SONHO DOS PES";
            // 
            // dataViu1
            // 
            this.dataViu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViu1.Location = new System.Drawing.Point(12, 268);
            this.dataViu1.Name = "dataViu1";
            this.dataViu1.Size = new System.Drawing.Size(917, 150);
            this.dataViu1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "000-000-000/00";
            // 
            // Avancada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtLojaAv);
            this.Controls.Add(this.btt_consulta);
            this.Controls.Add(this.dataViu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Avancada";
            this.Text = "Advanced Search V1.0";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btt_consulta;
        private System.Windows.Forms.TextBox txtLojaAv;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel loadAv;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataViu1;
        private System.Windows.Forms.Label label3;
    }
}
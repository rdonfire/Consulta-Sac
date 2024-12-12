namespace ConsultaSac
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttExpedir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtLoja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btt_consulta = new System.Windows.Forms.Button();
            this.bttFaturado = new System.Windows.Forms.Button();
            this.bttAvancada = new System.Windows.Forms.Button();
            this.btt_exit = new System.Windows.Forms.Button();
            this.bttajuda = new System.Windows.Forms.Button();
            this.bttExcel = new System.Windows.Forms.Button();
            this.radioPendencia = new System.Windows.Forms.RadioButton();
            this.radioFaturado = new System.Windows.Forms.RadioButton();
            this.radioGeral = new System.Windows.Forms.RadioButton();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.dataViu = new System.Windows.Forms.DataGridView();
            this.bttFiltro = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViu)).BeginInit();
            this.SuspendLayout();
            // 
            // bttExpedir
            // 
            this.bttExpedir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttExpedir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttExpedir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttExpedir.ImageKey = "stickers_039.png";
            this.bttExpedir.ImageList = this.imageList1;
            this.bttExpedir.Location = new System.Drawing.Point(12, 200);
            this.bttExpedir.Name = "bttExpedir";
            this.bttExpedir.Size = new System.Drawing.Size(228, 63);
            this.bttExpedir.TabIndex = 2;
            this.bttExpedir.Text = "PEDIDOS";
            this.bttExpedir.UseVisualStyleBackColor = false;
            this.bttExpedir.Click += new System.EventHandler(this.bttExpedir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stickers_013.png");
            this.imageList1.Images.SetKeyName(1, "stickers_029.png");
            this.imageList1.Images.SetKeyName(2, "stickers_038.png");
            this.imageList1.Images.SetKeyName(3, "stickers_039.png");
            this.imageList1.Images.SetKeyName(4, "stickers_012.png");
            this.imageList1.Images.SetKeyName(5, "stickers_004.png");
            this.imageList1.Images.SetKeyName(6, "stickers_023.png");
            this.imageList1.Images.SetKeyName(7, "stickers_049.png");
            this.imageList1.Images.SetKeyName(8, "stickers_045.png");
            this.imageList1.Images.SetKeyName(9, "stickers_009.png");
            this.imageList1.Images.SetKeyName(10, "stickers_006.png");
            // 
            // txtLoja
            // 
            this.txtLoja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoja.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoja.Location = new System.Drawing.Point(33, 52);
            this.txtLoja.Name = "txtLoja";
            this.txtLoja.Size = new System.Drawing.Size(183, 20);
            this.txtLoja.TabIndex = 4;
            this.txtLoja.TextChanged += new System.EventHandler(this.txtLoja_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CODIGO DA LOJA";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // btt_consulta
            // 
            this.btt_consulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt_consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btt_consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_consulta.ImageKey = "stickers_049.png";
            this.btt_consulta.ImageList = this.imageList1;
            this.btt_consulta.Location = new System.Drawing.Point(12, 92);
            this.btt_consulta.Name = "btt_consulta";
            this.btt_consulta.Size = new System.Drawing.Size(228, 63);
            this.btt_consulta.TabIndex = 7;
            this.btt_consulta.Text = "PENDENCIAS";
            this.btt_consulta.UseVisualStyleBackColor = false;
            this.btt_consulta.Click += new System.EventHandler(this.btt_consulta_Click);
            // 
            // bttFaturado
            // 
            this.bttFaturado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttFaturado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttFaturado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttFaturado.ImageKey = "stickers_013.png";
            this.bttFaturado.ImageList = this.imageList1;
            this.bttFaturado.Location = new System.Drawing.Point(303, 200);
            this.bttFaturado.Name = "bttFaturado";
            this.bttFaturado.Size = new System.Drawing.Size(228, 63);
            this.bttFaturado.TabIndex = 11;
            this.bttFaturado.Text = "FATURADO";
            this.bttFaturado.UseVisualStyleBackColor = false;
            this.bttFaturado.Click += new System.EventHandler(this.bttFaturado_Click);
            // 
            // bttAvancada
            // 
            this.bttAvancada.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttAvancada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttAvancada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAvancada.ImageKey = "stickers_045.png";
            this.bttAvancada.ImageList = this.imageList1;
            this.bttAvancada.Location = new System.Drawing.Point(303, 92);
            this.bttAvancada.Name = "bttAvancada";
            this.bttAvancada.Size = new System.Drawing.Size(228, 63);
            this.bttAvancada.TabIndex = 13;
            this.bttAvancada.Text = "PESQUISA CPF";
            this.bttAvancada.UseVisualStyleBackColor = false;
            this.bttAvancada.Click += new System.EventHandler(this.bttAvancada_Click);
            // 
            // btt_exit
            // 
            this.btt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_exit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btt_exit.ImageIndex = 4;
            this.btt_exit.ImageList = this.imageList1;
            this.btt_exit.Location = new System.Drawing.Point(838, 8);
            this.btt_exit.Name = "btt_exit";
            this.btt_exit.Size = new System.Drawing.Size(84, 54);
            this.btt_exit.TabIndex = 14;
            this.btt_exit.Text = "SAIR";
            this.btt_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btt_exit.UseVisualStyleBackColor = false;
            this.btt_exit.Click += new System.EventHandler(this.btt_exit_Click);
            // 
            // bttajuda
            // 
            this.bttajuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttajuda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttajuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttajuda.ImageKey = "stickers_023.png";
            this.bttajuda.ImageList = this.imageList1;
            this.bttajuda.Location = new System.Drawing.Point(838, 68);
            this.bttajuda.Name = "bttajuda";
            this.bttajuda.Size = new System.Drawing.Size(84, 54);
            this.bttajuda.TabIndex = 16;
            this.bttajuda.Text = "AJUDA";
            this.bttajuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttajuda.UseVisualStyleBackColor = false;
            this.bttajuda.Click += new System.EventHandler(this.bttajuda_Click);
            // 
            // bttExcel
            // 
            this.bttExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttExcel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttExcel.ImageKey = "stickers_004.png";
            this.bttExcel.ImageList = this.imageList1;
            this.bttExcel.Location = new System.Drawing.Point(729, 8);
            this.bttExcel.Name = "bttExcel";
            this.bttExcel.Size = new System.Drawing.Size(84, 54);
            this.bttExcel.TabIndex = 21;
            this.bttExcel.Text = "EXCEL";
            this.bttExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttExcel.UseVisualStyleBackColor = false;
            this.bttExcel.Click += new System.EventHandler(this.bttExcel_Click);
            // 
            // radioPendencia
            // 
            this.radioPendencia.AutoSize = true;
            this.radioPendencia.BackColor = System.Drawing.Color.Transparent;
            this.radioPendencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPendencia.Location = new System.Drawing.Point(375, 18);
            this.radioPendencia.Name = "radioPendencia";
            this.radioPendencia.Size = new System.Drawing.Size(104, 17);
            this.radioPendencia.TabIndex = 22;
            this.radioPendencia.TabStop = true;
            this.radioPendencia.Text = "PENDENCIAS";
            this.radioPendencia.UseVisualStyleBackColor = false;
            // 
            // radioFaturado
            // 
            this.radioFaturado.AutoSize = true;
            this.radioFaturado.BackColor = System.Drawing.Color.Transparent;
            this.radioFaturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFaturado.Location = new System.Drawing.Point(513, 18);
            this.radioFaturado.Name = "radioFaturado";
            this.radioFaturado.Size = new System.Drawing.Size(92, 17);
            this.radioFaturado.TabIndex = 23;
            this.radioFaturado.TabStop = true;
            this.radioFaturado.Text = "FATURADO";
            this.radioFaturado.UseVisualStyleBackColor = false;
            // 
            // radioGeral
            // 
            this.radioGeral.AutoSize = true;
            this.radioGeral.BackColor = System.Drawing.Color.Transparent;
            this.radioGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGeral.Location = new System.Drawing.Point(624, 18);
            this.radioGeral.Name = "radioGeral";
            this.radioGeral.Size = new System.Drawing.Size(80, 17);
            this.radioGeral.TabIndex = 24;
            this.radioGeral.TabStop = true;
            this.radioGeral.Text = "PEDIDOS";
            this.radioGeral.UseVisualStyleBackColor = false;
            // 
            // date1
            // 
            this.date1.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(624, 165);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(132, 29);
            this.date1.TabIndex = 26;
            // 
            // date2
            // 
            this.date2.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(790, 165);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(132, 29);
            this.date2.TabIndex = 27;
            // 
            // dataViu
            // 
            this.dataViu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataViu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataViu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViu.Location = new System.Drawing.Point(12, 269);
            this.dataViu.Name = "dataViu";
            this.dataViu.Size = new System.Drawing.Size(910, 285);
            this.dataViu.TabIndex = 1;
            // 
            // bttFiltro
            // 
            this.bttFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttFiltro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttFiltro.ImageKey = "stickers_006.png";
            this.bttFiltro.ImageList = this.imageList1;
            this.bttFiltro.Location = new System.Drawing.Point(674, 216);
            this.bttFiltro.Name = "bttFiltro";
            this.bttFiltro.Size = new System.Drawing.Size(231, 47);
            this.bttFiltro.TabIndex = 28;
            this.bttFiltro.Text = "FILTRO";
            this.bttFiltro.UseVisualStyleBackColor = false;
            this.bttFiltro.Click += new System.EventHandler(this.bttFiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 579);
            this.ControlBox = false;
            this.Controls.Add(this.bttFiltro);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.radioGeral);
            this.Controls.Add(this.radioFaturado);
            this.Controls.Add(this.radioPendencia);
            this.Controls.Add(this.bttExcel);
            this.Controls.Add(this.bttajuda);
            this.Controls.Add(this.btt_exit);
            this.Controls.Add(this.bttAvancada);
            this.Controls.Add(this.bttFaturado);
            this.Controls.Add(this.btt_consulta);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoja);
            this.Controls.Add(this.bttExpedir);
            this.Controls.Add(this.dataViu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CONSULTA FRANQUIA V3.0 - SONHO DOS PES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttExpedir;
        private System.Windows.Forms.TextBox txtLoja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btt_consulta;
        private System.Windows.Forms.Button bttFaturado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bttAvancada;
        private System.Windows.Forms.Button btt_exit;
        private System.Windows.Forms.Button bttajuda;
        private System.Windows.Forms.Button bttExcel;
        private System.Windows.Forms.RadioButton radioPendencia;
        private System.Windows.Forms.RadioButton radioFaturado;
        private System.Windows.Forms.RadioButton radioGeral;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DataGridView dataViu;
        private System.Windows.Forms.Button bttFiltro;
    }
}


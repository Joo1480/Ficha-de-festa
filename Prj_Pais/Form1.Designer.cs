namespace Prj_Pais
{
    partial class FrmMaquina
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
            this.lblCrepe = new System.Windows.Forms.Label();
            this.lblChurros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtRefri = new System.Windows.Forms.TextBox();
            this.txtChurro = new System.Windows.Forms.TextBox();
            this.txtCrepe = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPCrepe = new System.Windows.Forms.Label();
            this.lblPChurros = new System.Windows.Forms.Label();
            this.lblPRefri = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.FichaCrepe = new System.Drawing.Printing.PrintDocument();
            this.FichaChurros = new System.Drawing.Printing.PrintDocument();
            this.FichaRefri = new System.Drawing.Printing.PrintDocument();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCrepe
            // 
            this.lblCrepe.AutoSize = true;
            this.lblCrepe.Location = new System.Drawing.Point(52, 119);
            this.lblCrepe.Name = "lblCrepe";
            this.lblCrepe.Size = new System.Drawing.Size(76, 13);
            this.lblCrepe.TabIndex = 1;
            this.lblCrepe.Text = "Crepe R$7,00:";
            // 
            // lblChurros
            // 
            this.lblChurros.AutoSize = true;
            this.lblChurros.Location = new System.Drawing.Point(52, 181);
            this.lblChurros.Name = "lblChurros";
            this.lblChurros.Size = new System.Drawing.Size(84, 13);
            this.lblChurros.TabIndex = 2;
            this.lblChurros.Text = "Churros R$5,00:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Refrigerante R$4,00:";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(70, 340);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(115, 33);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(416, 340);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(114, 33);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(581, 342);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(127, 31);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtRefri
            // 
            this.txtRefri.Location = new System.Drawing.Point(184, 229);
            this.txtRefri.Name = "txtRefri";
            this.txtRefri.Size = new System.Drawing.Size(90, 20);
            this.txtRefri.TabIndex = 6;
            this.txtRefri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verefication);
            this.txtRefri.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRefri_KeyUp);
            // 
            // txtChurro
            // 
            this.txtChurro.Location = new System.Drawing.Point(186, 174);
            this.txtChurro.MaxLength = 2;
            this.txtChurro.Name = "txtChurro";
            this.txtChurro.Size = new System.Drawing.Size(82, 20);
            this.txtChurro.TabIndex = 5;
            this.txtChurro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verefication);
            this.txtChurro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtChurro_KeyUp);
            // 
            // txtCrepe
            // 
            this.txtCrepe.Location = new System.Drawing.Point(184, 118);
            this.txtCrepe.Name = "txtCrepe";
            this.txtCrepe.Size = new System.Drawing.Size(84, 20);
            this.txtCrepe.TabIndex = 4;
            this.txtCrepe.TextChanged += new System.EventHandler(this.txtCrepe_TextChanged);
            this.txtCrepe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verefication);
            this.txtCrepe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCrepe_KeyUp);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(52, 293);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 11;
            // 
            // lblPCrepe
            // 
            this.lblPCrepe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPCrepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCrepe.Location = new System.Drawing.Point(341, 118);
            this.lblPCrepe.Name = "lblPCrepe";
            this.lblPCrepe.Size = new System.Drawing.Size(114, 27);
            this.lblPCrepe.TabIndex = 12;
            // 
            // lblPChurros
            // 
            this.lblPChurros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPChurros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPChurros.Location = new System.Drawing.Point(344, 174);
            this.lblPChurros.Name = "lblPChurros";
            this.lblPChurros.Size = new System.Drawing.Size(110, 29);
            this.lblPChurros.TabIndex = 13;
            // 
            // lblPRefri
            // 
            this.lblPRefri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPRefri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRefri.Location = new System.Drawing.Point(344, 229);
            this.lblPRefri.Name = "lblPRefri";
            this.lblPRefri.Size = new System.Drawing.Size(111, 29);
            this.lblPRefri.TabIndex = 14;
            // 
            // lblHora
            // 
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(222, 33);
            this.lblHora.TabIndex = 16;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(243, 340);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 32);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FichaCrepe
            // 
            this.FichaCrepe.DocumentName = "FichaCrepe";
            this.FichaCrepe.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.FichaCrepe_PrintPage);
            // 
            // FichaChurros
            // 
            this.FichaChurros.DocumentName = "FichaChurros";
            // 
            // FichaRefri
            // 
            this.FichaRefri.DocumentName = "FichaRefri";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 437);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPRefri);
            this.Controls.Add(this.lblPChurros);
            this.Controls.Add(this.lblPCrepe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtRefri);
            this.Controls.Add(this.txtChurro);
            this.Controls.Add(this.txtCrepe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblChurros);
            this.Controls.Add(this.lblCrepe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaquina";
            this.ShowIcon = false;
            this.Text = "Compra de Fichas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCrepe;
        private System.Windows.Forms.Label lblChurros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtRefri;
        private System.Windows.Forms.TextBox txtChurro;
        private System.Windows.Forms.TextBox txtCrepe;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPCrepe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPChurros;
        private System.Windows.Forms.Label lblPRefri;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument FichaCrepe;
        private System.Drawing.Printing.PrintDocument FichaChurros;
        private System.Drawing.Printing.PrintDocument FichaRefri;
        private System.Windows.Forms.Timer timer1;
    }
}



namespace estudoCaso_Papelaria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMovimentacao = new System.Windows.Forms.TabControl();
            this.tabEntrada = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.tabSaida = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.txtQtdeMovimentar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.lblSaldoEntrada = new System.Windows.Forms.Label();
            this.btnMovimentar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabMovimentacao.SuspendLayout();
            this.tabEntrada.SuspendLayout();
            this.tabSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMovimentacao
            // 
            this.tabMovimentacao.Controls.Add(this.tabEntrada);
            this.tabMovimentacao.Controls.Add(this.tabSaida);
            this.tabMovimentacao.Enabled = false;
            this.tabMovimentacao.Location = new System.Drawing.Point(80, 161);
            this.tabMovimentacao.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovimentacao.Name = "tabMovimentacao";
            this.tabMovimentacao.SelectedIndex = 0;
            this.tabMovimentacao.Size = new System.Drawing.Size(796, 166);
            this.tabMovimentacao.TabIndex = 2;
            this.tabMovimentacao.SelectedIndexChanged += new System.EventHandler(this.tabMovimentacao_SelectedIndexChanged);
            // 
            // tabEntrada
            // 
            this.tabEntrada.BackColor = System.Drawing.Color.Transparent;
            this.tabEntrada.Controls.Add(this.label3);
            this.tabEntrada.Controls.Add(this.txtPrecoCusto);
            this.tabEntrada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabEntrada.Location = new System.Drawing.Point(4, 41);
            this.tabEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.tabEntrada.Name = "tabEntrada";
            this.tabEntrada.Padding = new System.Windows.Forms.Padding(4);
            this.tabEntrada.Size = new System.Drawing.Size(788, 121);
            this.tabEntrada.TabIndex = 0;
            this.tabEntrada.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço Custo:";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(199, 56);
            this.txtPrecoCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.ReadOnly = true;
            this.txtPrecoCusto.Size = new System.Drawing.Size(188, 39);
            this.txtPrecoCusto.TabIndex = 5;
            this.txtPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoCusto_KeyPress);
            // 
            // tabSaida
            // 
            this.tabSaida.BackColor = System.Drawing.Color.Transparent;
            this.tabSaida.Controls.Add(this.label5);
            this.tabSaida.Controls.Add(this.txtVenda);
            this.tabSaida.Controls.Add(this.label4);
            this.tabSaida.Controls.Add(this.txtLucro);
            this.tabSaida.Location = new System.Drawing.Point(4, 41);
            this.tabSaida.Margin = new System.Windows.Forms.Padding(4);
            this.tabSaida.Name = "tabSaida";
            this.tabSaida.Padding = new System.Windows.Forms.Padding(4);
            this.tabSaida.Size = new System.Drawing.Size(788, 121);
            this.tabSaida.TabIndex = 1;
            this.tabSaida.Text = "Saída";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Preço Venda:";
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(554, 52);
            this.txtVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.ReadOnly = true;
            this.txtVenda.Size = new System.Drawing.Size(188, 39);
            this.txtVenda.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "% Lucro:";
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(153, 49);
            this.txtLucro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.ReadOnly = true;
            this.txtLucro.Size = new System.Drawing.Size(188, 39);
            this.txtLucro.TabIndex = 7;
            this.txtLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLucro_KeyPress);
            // 
            // txtQtdeMovimentar
            // 
            this.txtQtdeMovimentar.Location = new System.Drawing.Point(737, 86);
            this.txtQtdeMovimentar.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdeMovimentar.Name = "txtQtdeMovimentar";
            this.txtQtdeMovimentar.Size = new System.Drawing.Size(161, 39);
            this.txtQtdeMovimentar.TabIndex = 1;
            this.txtQtdeMovimentar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeMovimentar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qtde. Mov.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto:";
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Items.AddRange(new object[] {
            "Caneta",
            "Caderno",
            "Lápis",
            "Borracha",
            "Apontador"});
            this.cboProduto.Location = new System.Drawing.Point(206, 83);
            this.cboProduto.Margin = new System.Windows.Forms.Padding(4);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(168, 40);
            this.cboProduto.TabIndex = 0;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // lblSaldoEntrada
            // 
            this.lblSaldoEntrada.AutoSize = true;
            this.lblSaldoEntrada.Location = new System.Drawing.Point(372, 86);
            this.lblSaldoEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoEntrada.Name = "lblSaldoEntrada";
            this.lblSaldoEntrada.Size = new System.Drawing.Size(0, 32);
            this.lblSaldoEntrada.TabIndex = 0;
            // 
            // btnMovimentar
            // 
            this.btnMovimentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMovimentar.BackgroundImage = global::estudoCaso_Papelaria.Properties.Resources.check;
            this.btnMovimentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMovimentar.FlatAppearance.BorderSize = 0;
            this.btnMovimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentar.Location = new System.Drawing.Point(273, 376);
            this.btnMovimentar.Name = "btnMovimentar";
            this.btnMovimentar.Size = new System.Drawing.Size(101, 69);
            this.btnMovimentar.TabIndex = 5;
            this.btnMovimentar.UseVisualStyleBackColor = false;
            this.btnMovimentar.Click += new System.EventHandler(this.btnMovimentar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFechar.BackgroundImage = global::estudoCaso_Papelaria.Properties.Resources.cancel;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(489, 376);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 69);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNovo.BackgroundImage = global::estudoCaso_Papelaria.Properties.Resources.novo;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(381, 376);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(101, 69);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 466);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnMovimentar);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.lblSaldoEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdeMovimentar);
            this.Controls.Add(this.tabMovimentacao);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMovimentacao.ResumeLayout(false);
            this.tabEntrada.ResumeLayout(false);
            this.tabEntrada.PerformLayout();
            this.tabSaida.ResumeLayout(false);
            this.tabSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMovimentacao;
        private System.Windows.Forms.TabPage tabEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TabPage tabSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.TextBox txtQtdeMovimentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label lblSaldoEntrada;
        private System.Windows.Forms.Button btnMovimentar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovo;
    }
}


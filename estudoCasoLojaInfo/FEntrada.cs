﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudoCasoLojaInfo
{
    public partial class FEntrada : Form
    {
        public FEntrada()
        {
            InitializeComponent();
        }
        
        private void FEntrada_Shown(object sender, EventArgs e)
        {
            lblCarregar.Text = "Carregando o sistema...";
            this.Refresh(); //atualiza o form

            for (int i = 0; i < 101; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(40); // pausa na execucao em milissegundos
            }

            progressBar1.Value = 99;
            Thread.Sleep(500);

            this.Hide();

            var frmLoja = new FLoja();
            frmLoja.Show();

        }

        
    }
}

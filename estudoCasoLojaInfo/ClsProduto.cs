using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoCasoLojaInfo
{
    class ClsProduto
    {
        private int quantidade;
        private int estoque = 10;
        private string nomeproduto;
        private double precocusto;
        private double precovenda;
        private double precolucro;
        private string tipomovimentacao;
        public List<ClsProduto> ConsultarCompra()
        {
            var listacontas = new List<ClsProduto>();
            string arquivoCaminho = @"C:\Arquivos\conta.txt";

            if (File.Exists(arquivoCaminho))
            {
                using var arquivo = new StreamReader(arquivoCaminho);

                string linhaArquivo;
                int i = 0;

                while ((linhaArquivo = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1) continue;

                    var contaArquivo = linhaArquivo.Split(';');

                    var venda = new ClsProduto();

                    venda.NomeProduto = contaArquivo[0];
                    venda.Precocusto = double.Parse(contaArquivo[1]);
                    venda.Precolucro = double.Parse(contaArquivo[2]);
                    venda.Precovenda = double.Parse(contaArquivo[3]);

                    listacontas.Add(venda);
                }
                arquivo.Close();
            }
            return listacontas;
        }

        public void GravarCompra()
        {
            var ListaContas = ConsultarCompra();
            ListaContas.Add(this);
            string arquivoCaminho = @"C:\Arquivos\conta.txt";
            if (File.Exists(arquivoCaminho))
            {
                StreamWriter escreverArquivo = new StreamWriter(arquivoCaminho);
                escreverArquivo.WriteLine("Operação: ;Produto; Custo;Porcentagem de Lucro Valor;quantidade");

                foreach (var c in ListaContas)
                {
                    var linha = $"{c.TipoMovimentacao}{c.nomeproduto};{c.precocusto};{c.precolucro}{c.precovenda};{c.Quantidade}";
                    escreverArquivo.WriteLine(linha);
                }
                escreverArquivo.Close();
            }

        }

        public int EstoqueVenda()
        {
            return estoque -= quantidade;
        }
        public int EstoqueCompra()
        {
            return estoque += quantidade;
        }
        public double Comprar()
        {
            return Precocusto * precolucro / 100 + Precocusto;

        }
        public double Vender()
        {
            return Precovenda * Quantidade;
        }
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        public String NomeProduto
        {
            get { return nomeproduto; }
            set { nomeproduto = value; }
        }

        public double Precocusto
        {
            get { return precocusto; }
            set { precocusto = value; }
        }
        public double Precovenda
        {
            get { return precovenda; }
            set { precovenda = value; }
        }
        public double Precolucro
        {
            get { return precolucro; }
            set { precolucro = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string TipoMovimentacao
        {
            get { return tipomovimentacao; }
            set { tipomovimentacao = value; }
        }



    }
}

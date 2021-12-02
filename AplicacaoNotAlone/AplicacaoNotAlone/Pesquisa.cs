using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoNotAlone
{
    public partial class Pesquisa : Form
    {
        List<Encomendas> zeEncomendas = new List<Encomendas>();

        private bool encomendaFlag = false;
        private bool opFlag = false;
        private bool dataFlag = false;

        private string numEncomenda;
        private string numOP;
        private string numData;

        Tabela tabela = new Tabela();

        public Pesquisa()
        {
            InitializeComponent();
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            dataFlag = false;

            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Quer usar a data para pesquisa ?", "Data",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                dataFlag = true;
                numData = Convert.ToString(dateTimeEn.Value.Date);
            }

            SearchEncomendas();

            tabela.LoadTabels(6, zeEncomendas);
            tabela.Show();

            zeEncomendas.Clear();
        }
        
        private void DataLabelPesq_Click(object sender, EventArgs e)
        {

        }

        private void NumeroEn_TextChanged(object sender, EventArgs e)
        {
            encomendaFlag = false;

            if (numeroEn.TextLength > 0)
            {
                encomendaFlag = true;
                numEncomenda = numeroEn.Text;
            }
        }

        private void NumeroOP_TextChanged(object sender, EventArgs e)
        {
            opFlag = false;

            if (numeroOP.TextLength > 0)
            {
                opFlag = true;
                numOP = numeroOP.Text;
            }
        }

        private void SearchEncomendas()
        {
            
            foreach (Empresa empresa in MainMenu.empresas)
                foreach(Comercial comercial in empresa.comercials)
                    foreach(Encomendas encomen in comercial.encomendas)
                    {
                           if (FilterEncomendas(encomen))
                               zeEncomendas.Add(encomen);
                    }


        }
        private bool FilterEncomendas(Encomendas encomenda)
        {
             bool aux = true;

            if(encomendaFlag == true)
            {
                if (encomenda.Encomenda != numEncomenda)
                    aux = false;
            }

            if (opFlag == true)
            {
                if (encomenda.OP != numOP)
                    aux = false;
            }

            if (dataFlag == true)
            {
                if (encomenda.Data != numData)
                    aux = false;
            }


            return aux;
        }



    }
}

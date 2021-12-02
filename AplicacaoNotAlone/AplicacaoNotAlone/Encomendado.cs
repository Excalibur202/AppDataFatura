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
    public partial class Encomendado : Form
    {
        //List<Tabela> tabelas = new List<Tabela>();

        public Encomendado()
        {
            InitializeComponent();

            TotalValor.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] d = new object[31];
            object[] m = new object[12];

            for (int i = 0; i < 31; i++)
            {
                d[i] = i + 1;
            }

            for (int i = 0; i < 12; i++)
            {
                m[i] = i + 1;
            }

            this.MonthBox.Items.AddRange(m);
            this.DayBox.Items.AddRange(d);

            foreach(Empresa empresa in MainMenu.empresas)
            {
               EmpresaBox.Items.Add(empresa.empresaNome);   
            }
        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ComercialBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void DayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (!Char.IsDigit(input) && input != 8 && input != 46)
                e.Handled = true;
        }

        private void MonthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (!Char.IsDigit(input) && input != 8 && input != 46)
                e.Handled = true;
        }

        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (!Char.IsDigit(input) && input != 8 && input != 46)
                e.Handled = true;
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void OPbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainMenu menuForm = new MainMenu();
            menuForm.Show();
        }
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Dossier dossierForm = new Dossier();
            dossierForm.Show();
        }
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Encomendado encomendadoForm = new Encomendado();
            encomendadoForm.Show();
        }
        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisaForm = new Pesquisa();
            pesquisaForm.StartPosition = FormStartPosition.Manual;
            pesquisaForm.Location = new Point(0, 0);
            pesquisaForm.Show();
        }

        private void EncomendaValorBox_TextChanged(object sender, EventArgs e)
        {
            RefreshTotal();
        }

        private void TotalValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void OPboxValor_TextChanged(object sender, EventArgs e)
        {
            RefreshTotal();
        }

        private void RefreshTotal()
        {
            if (EncomendaValorBox.TextLength != 0)
            {
                TotalValor.Text = Convert.ToString((float)(Convert.ToDouble(EncomendaValorBox.Text)));

                if(OPboxValor.TextLength != 0 && EncomendaValorBox.TextLength != 0)
                {
                    TotalValor.Text = Convert.ToString((float)(Math.Abs(Convert.ToDouble(EncomendaValorBox.Text) - Convert.ToDouble(OPboxValor.Text))));
                }
            }
            else if (OPboxValor.TextLength != 0)
            {
                TotalValor.Text = Convert.ToString((float)(Convert.ToDouble(OPboxValor.Text)));
            }
            else
                TotalValor.Text = "0";
                
        }

        private void EncomendaValorBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (!Char.IsDigit(input) && input != 8 && input != 46)
                e.Handled = true;
        }

        private void OPboxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (!Char.IsDigit(input) && input != 8 && input != 46)
                e.Handled = true;
        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (TotalCheck() == true)
            {
                string dataEncomenda = DayBox.Text + "/" + MonthBox.Text + "/" + YearBox.Text;
                bool faturado = false;

                if (faturaCheck.Checked)
                    faturado = true;
                else if (nFaturaCheck.Checked)
                    faturado = false;

                MainMenu.empresas[EmpresaBox.SelectedIndex].comercials[ComercialBox.SelectedIndex].encomendas.Add(new Encomendas(dataEncomenda, EncomendaBox.Text, OPbox.Text, Convert.ToDouble(TotalValor.Text), faturado));

                EncomendaBox.Clear();
                OPbox.Clear();
                EncomendaValorBox.Clear();
                OPboxValor.Clear();

                MainMenu.empresas.SaveBinary("Saves", "empresasInfo");
            }
            else
                MessageBox.Show("Falta de informação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
        }

        private bool TotalCheck()
        {
            bool encomendabox = false;
            bool opbox = false;
         
            bool comercialbox = false;
            bool empresabox = false;
            bool daybox = false;
            bool monthbox = false; 
            bool yearbox = false;

            if (EncomendaBox.Text.Trim().Length != 0)
                encomendabox = true;
            if (OPbox.Text.Trim().Length != 0)
                opbox = true;
            if (EmpresaBox.Text.Trim().Length != 0)
                empresabox = true;
            if (ComercialBox.Text.Trim().Length != 0)
                comercialbox = true;
            if (DayBox.Text.Trim().Length != 0)
                daybox = true;
            if (MonthBox.Text.Trim().Length != 0)
                monthbox = true;
            if (YearBox.Text.Trim().Length != 0)
                yearbox = true;

           if (encomendabox == true && empresabox == true && comercialbox == true && daybox == true && monthbox == true && yearbox == true)
                return true; 
           if (opbox == true && empresabox == true && comercialbox == true && daybox == true && monthbox == true && yearbox == true)
                return true;
           if (encomendabox == true && opbox == true && empresabox == true && comercialbox == true && daybox == true && monthbox == true && yearbox == true)
                return true;

            return false;
        }
        private void FaturaCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpresaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComercialBox.Items.Clear();

            foreach (Comercial comercial in MainMenu.empresas[EmpresaBox.SelectedIndex].comercials)
            {
                ComercialBox.Items.Add("T" + comercial.GetComercialID);
            }
           
        }
    }
}

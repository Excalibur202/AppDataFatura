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
    public partial class Tabela : Form
    {
        private List<Encomendas> encomendasIndex;

        public Tabela()
        {
            InitializeComponent();

            textBox1.Text = "0";
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tabela_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadTabels(int selectedWindow ,List<Encomendas> encomendas)
        {
            switch (selectedWindow)
            {
                case 0:
                    TableEncomendas(encomendas);
                    break;
                case 1:
                    TableOP(encomendas);
                    break;
                case 2:
                    TableEncomendasN(encomendas);
                    break;
                case 3:
                    TableOPN(encomendas);
                    break;
                case 4:
                    TableEnOP(encomendas);
                    break;
                case 5:
                    TableEnOPN(encomendas);
                    break;
                case 6:
                    FullTable(encomendas);
                    break;
               
            }
        }
        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void TableEncomendas(List<Encomendas> encomendas)
        {
            Double a = 0;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "Encomenda";
            dataGridView1.Columns[2].Name = "Faturado";

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            
            foreach (Encomendas encomenda in encomendas)
            {
                if (encomenda.Faturado == true && encomenda.OP == "")
                {
                    dataGridView1.Rows.Add(encomenda.Data, encomenda.Encomenda, encomenda.EnTotal.ToString());

                    a += encomenda.EnTotal;
                }
            }

            textBox1.Text = Convert.ToString(a);
        }
        private void TableOP(List<Encomendas> encomendas)
        {
            Double b = 0;
            encomendasIndex = new List<Encomendas>();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "OP";
            dataGridView1.Columns[2].Name = "Faturado";

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (Encomendas encomenda in encomendas)
            {
                if (encomenda.Faturado == true && encomenda.Encomenda == "")
                {
                    dataGridView1.Rows.Add(encomenda.Data, encomenda.OP, encomenda.EnTotal.ToString());

                    b += encomenda.EnTotal;
                }
            }

            textBox1.Text = Convert.ToString(b);

        }
        private void TableEncomendasN(List<Encomendas> encomendas)
        {
            Double c = 0;
            encomendasIndex = new List<Encomendas>();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "Encomendas";
            dataGridView1.Columns[2].Name = "Não Faturado";


            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (Encomendas encomenda in encomendas)
            {
                if (encomenda.Faturado == false && encomenda.OP == "")
                {
                    dataGridView1.Rows.Add(encomenda.Data, encomenda.Encomenda, encomenda.EnTotal.ToString());

                    c += encomenda.EnTotal;
                }
            }

            textBox1.Text = Convert.ToString(c);

        }
        private void TableOPN(List<Encomendas> encomendas)
        {
            Double d = 0;
            encomendasIndex = new List<Encomendas>();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "OP";
            dataGridView1.Columns[2].Name = "Não Faturado";

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (Encomendas encomenda in encomendas)
            {
                if (encomenda.Faturado == false && encomenda.Encomenda == "")
                {
                    dataGridView1.Rows.Add(encomenda.Data, encomenda.OP, encomenda.EnTotal.ToString());

                    d += encomenda.EnTotal;

                    encomendasIndex.Add(new Encomendas(encomenda.Data, encomenda.Encomenda, encomenda.OP, encomenda.EnTotal, false));
                }
            }

            textBox1.Text = Convert.ToString(d);

        }
        private void TableEnOP(List<Encomendas> encomendas)
        {
            Double e = 0;
            encomendasIndex = new List<Encomendas>();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "Encomenda";
            dataGridView1.Columns[2].Name = "OP";
            dataGridView1.Columns[3].Name = "Faturado";


            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (Encomendas encomenda in encomendas)
            {
                if (encomenda.Faturado == true && encomenda.Encomenda != "" && encomenda.OP != "")
                {
                    dataGridView1.Rows.Add(encomenda.Data, encomenda.Encomenda, encomenda.OP, encomenda.EnTotal.ToString());

                    e += encomenda.EnTotal;
                    encomendasIndex.Add(new Encomendas(encomenda.Data, encomenda.Encomenda, encomenda.OP, encomenda.EnTotal, true));

                }
            }

            textBox1.Text = Convert.ToString(e);

        }
        private void TableEnOPN(List<Encomendas> encomendas)
        {
            Double f = 0;
            encomendasIndex = new List<Encomendas>();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "Encomenda";
            dataGridView1.Columns[2].Name = "OP";
            dataGridView1.Columns[3].Name = "Não Faturado";


            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (Encomendas encomenda in encomendas)
            {
                if (encomenda.Faturado == false && encomenda.Encomenda != "" && encomenda.OP != "")
                {
                    dataGridView1.Rows.Add(encomenda.Data, encomenda.Encomenda, encomenda.OP, encomenda.EnTotal.ToString());

                    f += encomenda.EnTotal;

                    encomendasIndex.Add(new Encomendas(encomenda.Data, encomenda.Encomenda, encomenda.OP, encomenda.EnTotal, false));    
                    //meter dentro de lista
                }
                //++ index
            }

            textBox1.Text = Convert.ToString(f);

        }
        private void FullTable(List<Encomendas> encomendas)
        {
            Double f = 0;
            encomendasIndex = new List<Encomendas>();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "Encomenda";
            dataGridView1.Columns[2].Name = "OP";
            dataGridView1.Columns[3].Name = "Total Encomendas";


            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (Encomendas encomenda in encomendas)
            {
               dataGridView1.Rows.Add(encomenda.Data, encomenda.Encomenda, encomenda.OP, encomenda.EnTotal.ToString());
               
               f += encomenda.EnTotal;

               encomendasIndex.Add(new Encomendas(encomenda.Data, encomenda.Encomenda, encomenda.OP, encomenda.EnTotal, false));
               //meter dentro de lista
                
                //++ index
            }

            textBox1.Text = Convert.ToString(f);
        }


        private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            MainMenu menuForm = new MainMenu();
            menuForm.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Dossier dossierForm = new Dossier();
            dossierForm.Show();
        }

        private void ToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            Encomendado encomendadoForm = new Encomendado();
            encomendadoForm.Show();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisaForm = new Pesquisa();
            //pesquisaForm.StartPosition = FormStartPosition.Manual;
            //pesquisaForm.Location = new Point(0, 0);
            pesquisaForm.Show();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Quer remover as encomendas todas ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                foreach (Empresa empresa in MainMenu.empresas)
                    foreach (Comercial comercial in empresa.comercials)
                        comercial.encomendas.Clear();
            }

            dataGridView1.Rows.Clear();
            textBox1.Clear();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //foreach (Empresa empresa in MainMenu.empresas)
            //    foreach (Comercial comercial in empresa.comercials)
            //        comercial.encomendas.RemoveAt(SearchListIndex());

            //foreach (Empresa empresa in MainMenu.empresas)
            //    foreach (Comercial comercial in empresa.comercials)
            //        comercial.encomendas.AddRange(encomendasIndex);

            //MainMenu.empresas.SaveBinary("Saves", "empresasInfo");
        }

        private int SearchListIndex()
        {
            int count = -1;

            foreach(Empresa empresa in MainMenu.empresas)
                foreach(Comercial comercial in empresa.comercials)
                    foreach(Encomendas encomenda in comercial.encomendas)
                    {
                        count = comercial.encomendas.IndexOf(encomenda);
                    }

            return count;

        }
    }
}

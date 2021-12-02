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
    //////////empresas.SaveBinary("Saves", "empresasInfo");
    public partial class Dossier : Form
    {
        public List<Tabela> tabelas = new List<Tabela>();
        private int empresaIndex = -1, comercialIndex = -1;

        private string nomeEmpresa;
        public Dossier()
        {
            InitializeComponent();

        }

        private void Dossier_Load(object sender, EventArgs e)
        {
            RefreshComercial();
        }

        public TreeNode RootTreeNode(TreeNode n)
        {
            while (n.Level > 0)
            {
                n = n.Parent;
            }
            return n;
        }

        private void DossiersView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = (e == null ? ((System.Windows.Forms.TreeView)sender).SelectedNode : e.Node);
            var rootNode = RootTreeNode(node);

            empresaIndex = rootNode.Index;

            if (DossiersView.SelectedNode.Level == 1)
                comercialIndex = DossiersView.SelectedNode.Index;
            else comercialIndex = -1;

            if (comercialIndex == -1)
                test.Text = rootNode.Text;
            else
                test.Text = rootNode.Text + ": " + "T" + comercialIndex.ToString();

        }

        private void AddDossier_Click(object sender, EventArgs e)
        {
            if (NomeEmpresa.Text.Trim().Length != 0)
            {
                MainMenu.empresas.Add(new Empresa(MainMenu.empresas.Count, NomeEmpresa.Text));
                TreeNode parentNodes = new TreeNode(MainMenu.empresas[(MainMenu.empresas.Count - 1)].empresaNome);
                DossiersView.Nodes.Add(parentNodes);
                NomeEmpresa.Clear();
            }
            else
                MessageBox.Show("Por favor preencha o nome da empresa na caixa.", "Falta de Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainMenu.empresas.SaveBinary("Saves","empresasInfo");

        }
        private void RemoveDossier_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level == 0)
            {
                MainMenu.empresas.RemoveAt(empresaIndex);
                DossiersView.SelectedNode.Remove();
            }
            else
                MessageBox.Show("Por favor selecione uma empresa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainMenu.empresas.SaveBinary("Saves", "empresasInfo");
        }

        private void AddComercial_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level == 0)
            {
                //NomeEmpresa.Text = Convert.ToString(DossiersView.SelectedNode.Index);
                MainMenu.empresas[DossiersView.SelectedNode.Index].AddCom();
                RefreshComercial();
            }
            else
                MessageBox.Show("Por favor selecione uma empresa.", "Falta de Informacao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainMenu.empresas.SaveBinary("Saves", "empresasInfo");

        }
        private void RemoveComercial_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level != 0)
            {
                MainMenu.empresas[empresaIndex].comercials.RemoveAt(comercialIndex);
                DossiersView.SelectedNode.Remove();
            }
            else
                MessageBox.Show("Por favor selecione um departamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainMenu.empresas.SaveBinary("Saves", "empresasInfo");
        }

        private void RefreshComercial()
        {
            DossiersView.Nodes.Clear();

            foreach (Empresa emp in MainMenu.empresas)
            {
                TreeNode parentNodes = new TreeNode(emp.empresaNome);
                DossiersView.Nodes.Add(parentNodes);
                DossiersView.SelectedNode = parentNodes;

                foreach (Comercial come in emp.comercials)
                {
                    TreeNode newNode = new TreeNode();
                    newNode.Text = "T " + Convert.ToString(come.GetComercialID);
                    DossiersView.SelectedNode.Nodes.Add(newNode);
                    DossiersView.SelectedNode.Expand();

                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level != 0)
            {
                Tabela tabela = new Tabela();
                tabela.LoadTabels(0, MainMenu.empresas[empresaIndex].comercials[comercialIndex].encomendas);
                tabela.Show();
            }
            else
                MessageBox.Show("Por favor selecione um departamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenTabEnNfat_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level != 0)
            {
                Tabela tabela1 = new Tabela();
                tabela1.LoadTabels(2, MainMenu.empresas[empresaIndex].comercials[comercialIndex].encomendas);
                tabela1.Show();
            }
            else
                MessageBox.Show("Por favor selecione um departamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level != 0)
            {
                Tabela tabela2 = new Tabela();
                tabela2.LoadTabels(1, MainMenu.empresas[empresaIndex].comercials[comercialIndex].encomendas);
                tabela2.Show();
            }
            else
                MessageBox.Show("Por favor selecione um departamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenTabOpNfat_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level != 0)
            {
                Tabela tabela3 = new Tabela();
                tabela3.LoadTabels(3, MainMenu.empresas[empresaIndex].comercials[comercialIndex].encomendas);
                tabela3.Show();
            }
            else
                MessageBox.Show("Por favor selecione um departamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenTabEnOpFat_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level != 0)
            {
                Tabela tabela4 = new Tabela();
                tabela4.LoadTabels(4, MainMenu.empresas[empresaIndex].comercials[comercialIndex].encomendas);
                tabela4.Show();
            }
            else
                MessageBox.Show("Por favor selecione um departamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OpenTabEnOpNfat_Click(object sender, EventArgs e)
        {
            if (DossiersView.SelectedNode != null && DossiersView.SelectedNode.Level != 0)
            {
                Tabela tabela5 = new Tabela();
                tabela5.LoadTabels(5, MainMenu.empresas[empresaIndex].comercials[comercialIndex].encomendas);
                tabela5.Show();
            }
            else
                MessageBox.Show("Por favor selecione um departamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NomeEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void DossiersView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

        }

       

      
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainMenu menuForm = new MainMenu();
            menuForm.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Encomendado encomendadoForm = new Encomendado();
            encomendadoForm.Show();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisaForm = new Pesquisa();
            pesquisaForm.StartPosition = FormStartPosition.Manual;
            pesquisaForm.Location = new Point(0, 0);
            pesquisaForm.Show();
        }

        private void Test_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MainMenu : Form
    {
        private Bitmap MyImage;
        public static List<Empresa> empresas = new List<Empresa>();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dossier dossierForm = new Dossier();
            dossierForm.Show();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Encomendado encomendadoForm = new Encomendado();
            encomendadoForm.Show();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisaForm = new Pesquisa();
            pesquisaForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Image file";
            openFileDialog1.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                ShowMyImage(selectedFile, pictureBox1.Width, pictureBox1.Height);
                button1.Hide();
                //pictureBox1.SaveBinary("Saves", "empresasInfo");
            }
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        public void ShowMyImage(String fileToDisplay, int xSize, int ySize)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox1.ClientSize = new Size(xSize, ySize);
            pictureBox1.Image = (Image)MyImage;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            empresas = empresas.LoadBinary("Saves", "empresasInfo");

            foreach (Empresa empresa in empresas)
            {
                empresaComboBox.Items.Add(empresa.empresaNome);
            }

            if (empresas.Count == 0)
                empresaComboBox.SelectedIndex = -1;
            else
                empresaComboBox.SelectedIndex = 0;
        }

        private void EmpresaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComercialsTable();
        }

        private void DataGridViewComecials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadComercialsTable()
        {
            string encomendadoTotal;

            dataGridViewComecials.RowHeadersVisible = false;
            dataGridViewComecials.ColumnCount = 4;
            dataGridViewComecials.Columns[0].Name = "Comercial";
            dataGridViewComecials.Columns[1].Name = "Encomendaddo";
            dataGridViewComecials.Columns[2].Name = "Faturado";
            dataGridViewComecials.Columns[3].Name = "Comicao";

            for(int i = 0; i < dataGridViewComecials.ColumnCount; i++)
            {
                dataGridViewComecials.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewComecials.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach(Comercial comercial in empresas[empresaComboBox.SelectedIndex].comercials)
            {

            }


            //foreach (Empresa empresa in empresas)
            //    foreach (Comercial comercial in empresa.comercials)
            //    {
            //        encomendadoTotal = comercial.encomendas[comercial.GetComercialID].EnTotal.ToString();

            //        dataGridViewComecials.Rows.Add("T" + comercial.GetComercialID, );
            //        //dataGridViewComecials.Rows.Add("T" + empresa.comercials[empresa.comercials.Count].GetComercialID, empresa.comercials);
            //    }
        }
    }
}

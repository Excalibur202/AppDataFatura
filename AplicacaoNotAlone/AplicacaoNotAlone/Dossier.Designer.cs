namespace AplicacaoNotAlone
{
    partial class Dossier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dossier));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.DossiersView = new System.Windows.Forms.TreeView();
            this.AddDossier = new System.Windows.Forms.Button();
            this.AddComercial = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NomeEmpresa = new System.Windows.Forms.TextBox();
            this.openTabEnFat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openTabEnOpNfat = new System.Windows.Forms.Button();
            this.openTabEnOpFat = new System.Windows.Forms.Button();
            this.openTabOpNfat = new System.Windows.Forms.Button();
            this.openTabOpFat = new System.Windows.Forms.Button();
            this.openTabEnNfat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveDossier = new System.Windows.Forms.Button();
            this.RemoveComercial = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.menuStrip2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 24);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(400, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(96, 20);
            this.toolStripMenuItem2.Text = "Encomendado";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem3.Text = "Pesquisa";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem4.Text = "Armazem";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(111, 20);
            this.toolStripMenuItem5.Text = "Nota Encomenda";
            // 
            // DossiersView
            // 
            this.DossiersView.Location = new System.Drawing.Point(40, 121);
            this.DossiersView.Name = "DossiersView";
            this.DossiersView.Size = new System.Drawing.Size(259, 296);
            this.DossiersView.TabIndex = 2;
            this.DossiersView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.DossiersView_BeforeSelect);
            this.DossiersView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DossiersView_AfterSelect);
            // 
            // AddDossier
            // 
            this.AddDossier.Location = new System.Drawing.Point(244, 69);
            this.AddDossier.Name = "AddDossier";
            this.AddDossier.Size = new System.Drawing.Size(84, 31);
            this.AddDossier.TabIndex = 3;
            this.AddDossier.Text = "Adicionar";
            this.AddDossier.UseVisualStyleBackColor = true;
            this.AddDossier.Click += new System.EventHandler(this.AddDossier_Click);
            // 
            // AddComercial
            // 
            this.AddComercial.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddComercial.ImageIndex = 1;
            this.AddComercial.ImageList = this.imageList1;
            this.AddComercial.Location = new System.Drawing.Point(305, 121);
            this.AddComercial.Name = "AddComercial";
            this.AddComercial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddComercial.Size = new System.Drawing.Size(47, 31);
            this.AddComercial.TabIndex = 4;
            this.AddComercial.Text = "\r\n";
            this.AddComercial.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddComercial.UseVisualStyleBackColor = true;
            this.AddComercial.Click += new System.EventHandler(this.AddComercial_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "plus_icon-icons.com_69476.ico");
            this.imageList1.Images.SetKeyName(1, "add-interface-circular-symbol-with-plus-sign.png");
            this.imageList1.Images.SetKeyName(2, "minus-sign-inside-a-black-circle_icon-icons.com_73488.ico");
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.Location = new System.Drawing.Point(126, 74);
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.Size = new System.Drawing.Size(103, 20);
            this.NomeEmpresa.TabIndex = 5;
            this.NomeEmpresa.TextChanged += new System.EventHandler(this.NomeEmpresa_TextChanged);
            // 
            // openTabEnFat
            // 
            this.openTabEnFat.Location = new System.Drawing.Point(13, 27);
            this.openTabEnFat.Name = "openTabEnFat";
            this.openTabEnFat.Size = new System.Drawing.Size(136, 43);
            this.openTabEnFat.TabIndex = 6;
            this.openTabEnFat.Text = "Encomenda Faturado";
            this.openTabEnFat.UseVisualStyleBackColor = true;
            this.openTabEnFat.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openTabEnOpNfat);
            this.groupBox1.Controls.Add(this.openTabOpNfat);
            this.groupBox1.Controls.Add(this.openTabOpFat);
            this.groupBox1.Controls.Add(this.openTabEnOpFat);
            this.groupBox1.Controls.Add(this.openTabEnNfat);
            this.groupBox1.Controls.Add(this.openTabEnFat);
            this.groupBox1.Location = new System.Drawing.Point(388, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabelas";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // openTabEnOpNfat
            // 
            this.openTabEnOpNfat.Location = new System.Drawing.Point(155, 141);
            this.openTabEnOpNfat.Name = "openTabEnOpNfat";
            this.openTabEnOpNfat.Size = new System.Drawing.Size(137, 47);
            this.openTabEnOpNfat.TabIndex = 11;
            this.openTabEnOpNfat.Text = "Encomenda Op Nao Faturado";
            this.openTabEnOpNfat.UseVisualStyleBackColor = true;
            this.openTabEnOpNfat.Click += new System.EventHandler(this.OpenTabEnOpNfat_Click);
            // 
            // openTabEnOpFat
            // 
            this.openTabEnOpFat.Location = new System.Drawing.Point(13, 141);
            this.openTabEnOpFat.Name = "openTabEnOpFat";
            this.openTabEnOpFat.Size = new System.Drawing.Size(137, 47);
            this.openTabEnOpFat.TabIndex = 10;
            this.openTabEnOpFat.Text = "Encomenda Op Faturado";
            this.openTabEnOpFat.UseVisualStyleBackColor = true;
            this.openTabEnOpFat.Click += new System.EventHandler(this.OpenTabEnOpFat_Click);
            // 
            // openTabOpNfat
            // 
            this.openTabOpNfat.Location = new System.Drawing.Point(155, 79);
            this.openTabOpNfat.Name = "openTabOpNfat";
            this.openTabOpNfat.Size = new System.Drawing.Size(137, 47);
            this.openTabOpNfat.TabIndex = 9;
            this.openTabOpNfat.Text = "OP Nao Faturado";
            this.openTabOpNfat.UseVisualStyleBackColor = true;
            this.openTabOpNfat.Click += new System.EventHandler(this.OpenTabOpNfat_Click);
            // 
            // openTabOpFat
            // 
            this.openTabOpFat.Location = new System.Drawing.Point(13, 78);
            this.openTabOpFat.Name = "openTabOpFat";
            this.openTabOpFat.Size = new System.Drawing.Size(136, 53);
            this.openTabOpFat.TabIndex = 8;
            this.openTabOpFat.Text = "OP Faturado";
            this.openTabOpFat.UseVisualStyleBackColor = true;
            this.openTabOpFat.Click += new System.EventHandler(this.Button2_Click);
            // 
            // openTabEnNfat
            // 
            this.openTabEnNfat.Location = new System.Drawing.Point(155, 27);
            this.openTabEnNfat.Name = "openTabEnNfat";
            this.openTabEnNfat.Size = new System.Drawing.Size(137, 46);
            this.openTabEnNfat.TabIndex = 7;
            this.openTabEnNfat.Text = "Encomenda Nao Faturado";
            this.openTabEnNfat.UseVisualStyleBackColor = true;
            this.openTabEnNfat.Click += new System.EventHandler(this.OpenTabEnNfat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empresa";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // RemoveDossier
            // 
            this.RemoveDossier.Location = new System.Drawing.Point(334, 69);
            this.RemoveDossier.Name = "RemoveDossier";
            this.RemoveDossier.Size = new System.Drawing.Size(98, 31);
            this.RemoveDossier.TabIndex = 9;
            this.RemoveDossier.Text = "Remover";
            this.RemoveDossier.UseVisualStyleBackColor = true;
            this.RemoveDossier.Click += new System.EventHandler(this.RemoveDossier_Click);
            // 
            // RemoveComercial
            // 
            this.RemoveComercial.ImageIndex = 2;
            this.RemoveComercial.ImageList = this.imageList1;
            this.RemoveComercial.Location = new System.Drawing.Point(305, 158);
            this.RemoveComercial.Name = "RemoveComercial";
            this.RemoveComercial.Size = new System.Drawing.Size(47, 31);
            this.RemoveComercial.TabIndex = 10;
            this.RemoveComercial.UseVisualStyleBackColor = true;
            this.RemoveComercial.Click += new System.EventHandler(this.RemoveComercial_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(483, 121);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(127, 20);
            this.test.TabIndex = 11;
            this.test.TextChanged += new System.EventHandler(this.Test_TextChanged);
            // 
            // Dossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.RemoveComercial);
            this.Controls.Add(this.RemoveDossier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NomeEmpresa);
            this.Controls.Add(this.AddComercial);
            this.Controls.Add(this.AddDossier);
            this.Controls.Add(this.DossiersView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Dossier";
            this.ShowIcon = false;
            this.Text = "Dossier";
            this.Load += new System.EventHandler(this.Dossier_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.TreeView DossiersView;
        private System.Windows.Forms.Button AddDossier;
        private System.Windows.Forms.Button AddComercial;
        private System.Windows.Forms.TextBox NomeEmpresa;
        private System.Windows.Forms.Button openTabEnFat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button RemoveDossier;
        private System.Windows.Forms.Button RemoveComercial;
        private System.Windows.Forms.Button openTabEnOpNfat;
        private System.Windows.Forms.Button openTabEnOpFat;
        private System.Windows.Forms.Button openTabOpNfat;
        private System.Windows.Forms.Button openTabOpFat;
        private System.Windows.Forms.Button openTabEnNfat;
        private System.Windows.Forms.TextBox test;
    }
}
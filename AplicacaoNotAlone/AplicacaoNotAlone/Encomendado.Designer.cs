namespace AplicacaoNotAlone
{
    partial class Encomendado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encomendado));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComercialBox = new System.Windows.Forms.ComboBox();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EncomendaBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EncomendaValorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OPbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OPboxValor = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.faturaCheck = new System.Windows.Forms.RadioButton();
            this.nFaturaCheck = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpresaBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.menuStrip2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 24);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.ToolStripMenuItem6});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(462, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip2_ItemClicked);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem2.Text = "Dossiers";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(96, 20);
            this.toolStripMenuItem3.Text = "Encomendado";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem4.Text = "Pesquisa";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem5.Text = "Armazem";
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(111, 20);
            this.ToolStripMenuItem6.Text = "Nota Encomenda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comercial";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // ComercialBox
            // 
            this.ComercialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComercialBox.FormattingEnabled = true;
            this.ComercialBox.Location = new System.Drawing.Point(125, 87);
            this.ComercialBox.Name = "ComercialBox";
            this.ComercialBox.Size = new System.Drawing.Size(121, 21);
            this.ComercialBox.Sorted = true;
            this.ComercialBox.TabIndex = 6;
            this.ComercialBox.SelectedIndexChanged += new System.EventHandler(this.ComercialBox_SelectedIndexChanged);
            // 
            // DayBox
            // 
            this.DayBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DayBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(406, 63);
            this.DayBox.MaxLength = 2;
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(41, 21);
            this.DayBox.TabIndex = 7;
            this.DayBox.SelectedIndexChanged += new System.EventHandler(this.DayBox_SelectedIndexChanged);
            this.DayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DayBox_KeyPress);
            // 
            // MonthBox
            // 
            this.MonthBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MonthBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Location = new System.Drawing.Point(453, 63);
            this.MonthBox.MaxLength = 2;
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(36, 21);
            this.MonthBox.TabIndex = 8;
            this.MonthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MonthBox_KeyPress);
            // 
            // YearBox
            // 
            this.YearBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.YearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Items.AddRange(new object[] {
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.YearBox.Location = new System.Drawing.Point(495, 63);
            this.YearBox.MaxLength = 4;
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(71, 21);
            this.YearBox.TabIndex = 9;
            this.YearBox.SelectedIndexChanged += new System.EventHandler(this.YearBox_SelectedIndexChanged);
            this.YearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Encomenda";
            // 
            // EncomendaBox
            // 
            this.EncomendaBox.Location = new System.Drawing.Point(146, 156);
            this.EncomendaBox.Name = "EncomendaBox";
            this.EncomendaBox.Size = new System.Drawing.Size(100, 20);
            this.EncomendaBox.TabIndex = 11;
            this.EncomendaBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor";
            // 
            // EncomendaValorBox
            // 
            this.EncomendaValorBox.Location = new System.Drawing.Point(389, 156);
            this.EncomendaValorBox.Name = "EncomendaValorBox";
            this.EncomendaValorBox.Size = new System.Drawing.Size(100, 20);
            this.EncomendaValorBox.TabIndex = 13;
            this.EncomendaValorBox.TextChanged += new System.EventHandler(this.EncomendaValorBox_TextChanged);
            this.EncomendaValorBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EncomendaValorBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "OP";
            // 
            // OPbox
            // 
            this.OPbox.Location = new System.Drawing.Point(97, 220);
            this.OPbox.Name = "OPbox";
            this.OPbox.Size = new System.Drawing.Size(100, 20);
            this.OPbox.TabIndex = 15;
            this.OPbox.TextChanged += new System.EventHandler(this.OPbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total";
            // 
            // TotalValor
            // 
            this.TotalValor.Location = new System.Drawing.Point(389, 288);
            this.TotalValor.Name = "TotalValor";
            this.TotalValor.ReadOnly = true;
            this.TotalValor.Size = new System.Drawing.Size(100, 20);
            this.TotalValor.TabIndex = 21;
            this.TotalValor.TextChanged += new System.EventHandler(this.TotalValor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Valor";
            // 
            // OPboxValor
            // 
            this.OPboxValor.Location = new System.Drawing.Point(388, 220);
            this.OPboxValor.Name = "OPboxValor";
            this.OPboxValor.Size = new System.Drawing.Size(100, 20);
            this.OPboxValor.TabIndex = 23;
            this.OPboxValor.TextChanged += new System.EventHandler(this.OPboxValor_TextChanged);
            this.OPboxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OPboxValor_KeyPress);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(426, 355);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(104, 45);
            this.Add.TabIndex = 25;
            this.Add.Text = "Adicionar";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "(dd/mm/yyyy)";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // faturaCheck
            // 
            this.faturaCheck.AutoSize = true;
            this.faturaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faturaCheck.Location = new System.Drawing.Point(34, 350);
            this.faturaCheck.Name = "faturaCheck";
            this.faturaCheck.Size = new System.Drawing.Size(85, 22);
            this.faturaCheck.TabIndex = 27;
            this.faturaCheck.Text = "Faturado";
            this.faturaCheck.UseVisualStyleBackColor = true;
            this.faturaCheck.CheckedChanged += new System.EventHandler(this.FaturaCheck_CheckedChanged);
            // 
            // nFaturaCheck
            // 
            this.nFaturaCheck.AutoSize = true;
            this.nFaturaCheck.Checked = true;
            this.nFaturaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nFaturaCheck.Location = new System.Drawing.Point(34, 378);
            this.nFaturaCheck.Name = "nFaturaCheck";
            this.nFaturaCheck.Size = new System.Drawing.Size(117, 22);
            this.nFaturaCheck.TabIndex = 28;
            this.nFaturaCheck.TabStop = true;
            this.nFaturaCheck.Text = "Não Faturado";
            this.nFaturaCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Empresa";
            // 
            // EmpresaBox
            // 
            this.EmpresaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpresaBox.FormattingEnabled = true;
            this.EmpresaBox.Location = new System.Drawing.Point(125, 49);
            this.EmpresaBox.Name = "EmpresaBox";
            this.EmpresaBox.Size = new System.Drawing.Size(121, 21);
            this.EmpresaBox.TabIndex = 30;
            this.EmpresaBox.SelectedIndexChanged += new System.EventHandler(this.EmpresaBox_SelectedIndexChanged);
            // 
            // Encomendado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(636, 425);
            this.Controls.Add(this.EmpresaBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nFaturaCheck);
            this.Controls.Add(this.faturaCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.OPboxValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OPbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EncomendaValorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EncomendaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.ComercialBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Encomendado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encomendado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComercialBox;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EncomendaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EncomendaValorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OPbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OPboxValor;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton faturaCheck;
        private System.Windows.Forms.RadioButton nFaturaCheck;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox EmpresaBox;
    }
}


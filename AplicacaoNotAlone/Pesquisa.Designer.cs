namespace AplicacaoNotAlone
{
    partial class Pesquisa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeroEn = new System.Windows.Forms.TextBox();
            this.numeroOP = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dateTimeEn = new System.Windows.Forms.DateTimePicker();
            this.DataLabelPesq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encomenda";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "OP";
            // 
            // numeroEn
            // 
            this.numeroEn.Location = new System.Drawing.Point(194, 29);
            this.numeroEn.Name = "numeroEn";
            this.numeroEn.Size = new System.Drawing.Size(100, 20);
            this.numeroEn.TabIndex = 2;
            this.numeroEn.TextChanged += new System.EventHandler(this.NumeroEn_TextChanged);
            // 
            // numeroOP
            // 
            this.numeroOP.Location = new System.Drawing.Point(194, 85);
            this.numeroOP.Name = "numeroOP";
            this.numeroOP.Size = new System.Drawing.Size(100, 20);
            this.numeroOP.TabIndex = 3;
            this.numeroOP.TextChanged += new System.EventHandler(this.NumeroOP_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(175, 196);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 33);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Pesquisa";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimeEn
            // 
            this.dateTimeEn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeEn.Location = new System.Drawing.Point(146, 137);
            this.dateTimeEn.Name = "dateTimeEn";
            this.dateTimeEn.Size = new System.Drawing.Size(95, 20);
            this.dateTimeEn.TabIndex = 5;
            this.dateTimeEn.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // DataLabelPesq
            // 
            this.DataLabelPesq.AutoSize = true;
            this.DataLabelPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabelPesq.Location = new System.Drawing.Point(31, 137);
            this.DataLabelPesq.Name = "DataLabelPesq";
            this.DataLabelPesq.Size = new System.Drawing.Size(44, 20);
            this.DataLabelPesq.TabIndex = 6;
            this.DataLabelPesq.Text = "Data";
            this.DataLabelPesq.Click += new System.EventHandler(this.DataLabelPesq_Click);
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 241);
            this.Controls.Add(this.DataLabelPesq);
            this.Controls.Add(this.dateTimeEn);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.numeroOP);
            this.Controls.Add(this.numeroEn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pesquisa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeroEn;
        private System.Windows.Forms.TextBox numeroOP;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker dateTimeEn;
        private System.Windows.Forms.Label DataLabelPesq;
    }
}
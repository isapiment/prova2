namespace prova2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_unidade = new System.Windows.Forms.ComboBox();
            this.tx_lucro = new System.Windows.Forms.TextBox();
            this.tx_icms = new System.Windows.Forms.TextBox();
            this.tx_pis = new System.Windows.Forms.TextBox();
            this.tx_valor = new System.Windows.Forms.TextBox();
            this.tx_confins = new System.Windows.Forms.TextBox();
            this.tx_descricao = new System.Windows.Forms.TextBox();
            this.tx_codigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_unidade
            // 
            this.tx_unidade.FormattingEnabled = true;
            this.tx_unidade.Items.AddRange(new object[] {
            "UN",
            "LT",
            "KL"});
            this.tx_unidade.Location = new System.Drawing.Point(378, 47);
            this.tx_unidade.Name = "tx_unidade";
            this.tx_unidade.Size = new System.Drawing.Size(121, 21);
            this.tx_unidade.TabIndex = 37;
            // 
            // tx_lucro
            // 
            this.tx_lucro.Location = new System.Drawing.Point(84, 277);
            this.tx_lucro.Name = "tx_lucro";
            this.tx_lucro.Size = new System.Drawing.Size(100, 20);
            this.tx_lucro.TabIndex = 36;
            // 
            // tx_icms
            // 
            this.tx_icms.Location = new System.Drawing.Point(75, 218);
            this.tx_icms.Name = "tx_icms";
            this.tx_icms.Size = new System.Drawing.Size(100, 20);
            this.tx_icms.TabIndex = 35;
            // 
            // tx_pis
            // 
            this.tx_pis.Location = new System.Drawing.Point(345, 157);
            this.tx_pis.Name = "tx_pis";
            this.tx_pis.Size = new System.Drawing.Size(100, 20);
            this.tx_pis.TabIndex = 34;
            // 
            // tx_valor
            // 
            this.tx_valor.Location = new System.Drawing.Point(89, 157);
            this.tx_valor.Name = "tx_valor";
            this.tx_valor.Size = new System.Drawing.Size(100, 20);
            this.tx_valor.TabIndex = 33;
            // 
            // tx_confins
            // 
            this.tx_confins.Location = new System.Drawing.Point(366, 215);
            this.tx_confins.Name = "tx_confins";
            this.tx_confins.Size = new System.Drawing.Size(100, 20);
            this.tx_confins.TabIndex = 32;
            // 
            // tx_descricao
            // 
            this.tx_descricao.Location = new System.Drawing.Point(113, 105);
            this.tx_descricao.Name = "tx_descricao";
            this.tx_descricao.Size = new System.Drawing.Size(100, 20);
            this.tx_descricao.TabIndex = 31;
            // 
            // tx_codigo
            // 
            this.tx_codigo.Location = new System.Drawing.Point(89, 48);
            this.tx_codigo.Name = "tx_codigo";
            this.tx_codigo.Size = new System.Drawing.Size(100, 20);
            this.tx_codigo.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(33, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "valor ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Lucro ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Confins";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "ICMS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "PIS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Valor ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descrição ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastro de Produto ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.tx_unidade);
            this.Controls.Add(this.tx_lucro);
            this.Controls.Add(this.tx_icms);
            this.Controls.Add(this.tx_pis);
            this.Controls.Add(this.tx_valor);
            this.Controls.Add(this.tx_confins);
            this.Controls.Add(this.tx_descricao);
            this.Controls.Add(this.tx_codigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tx_unidade;
        private System.Windows.Forms.TextBox tx_lucro;
        private System.Windows.Forms.TextBox tx_icms;
        private System.Windows.Forms.TextBox tx_pis;
        private System.Windows.Forms.TextBox tx_valor;
        private System.Windows.Forms.TextBox tx_confins;
        private System.Windows.Forms.TextBox tx_descricao;
        private System.Windows.Forms.TextBox tx_codigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


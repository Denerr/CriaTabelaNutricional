namespace Prototipo_CriaTabelaNutri
{
    partial class frmCriaTabelaNutri
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDescricao = new TextBox();
            label1 = new Label();
            ckbCalculoPorcaoAutomatico = new CheckBox();
            ckbImprimeLactoseGalactose = new CheckBox();
            txtPorcaoPorEmbalagem = new TextBox();
            label2 = new Label();
            txtPorcao = new TextBox();
            txtQuantidadeMedidaCaseira = new TextBox();
            cmbPorcaoUnidade = new ComboBox();
            cmbUnidadeMedidaCaseira = new ComboBox();
            cmbMedidaCaseira = new ComboBox();
            panel1 = new Panel();
            txtValorEnergetico = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCarboidratos = new TextBox();
            txtAcucaresTotais = new TextBox();
            txtAcucaresAdicionados = new TextBox();
            txtLactose = new TextBox();
            txtGalactose = new TextBox();
            txtGordurasTrans = new TextBox();
            txtGordurasSaturadas = new TextBox();
            txtGordurasTotais = new TextBox();
            txtProteinas = new TextBox();
            txtSodio = new TextBox();
            txtFibrasAlimentares = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            panel2 = new Panel();
            ckbAltoAcucarAdicionado = new CheckBox();
            ckbAltoGorduraSaturada = new CheckBox();
            ckbAltoSodio = new CheckBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(26, 40);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(325, 23);
            txtDescricao.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Descrição";
            // 
            // ckbCalculoPorcaoAutomatico
            // 
            ckbCalculoPorcaoAutomatico.AutoSize = true;
            ckbCalculoPorcaoAutomatico.Location = new Point(418, 34);
            ckbCalculoPorcaoAutomatico.Name = "ckbCalculoPorcaoAutomatico";
            ckbCalculoPorcaoAutomatico.Size = new Size(230, 34);
            ckbCalculoPorcaoAutomatico.TabIndex = 2;
            ckbCalculoPorcaoAutomatico.Text = "Calcular automaticamente as porções?\r\n(Apenas em vendas por peso)";
            ckbCalculoPorcaoAutomatico.TextAlign = ContentAlignment.MiddleCenter;
            ckbCalculoPorcaoAutomatico.UseVisualStyleBackColor = true;
            // 
            // ckbImprimeLactoseGalactose
            // 
            ckbImprimeLactoseGalactose.AutoSize = true;
            ckbImprimeLactoseGalactose.Location = new Point(712, 42);
            ckbImprimeLactoseGalactose.Name = "ckbImprimeLactoseGalactose";
            ckbImprimeLactoseGalactose.Size = new Size(183, 19);
            ckbImprimeLactoseGalactose.TabIndex = 3;
            ckbImprimeLactoseGalactose.Text = "Imprimir Lactose e Galactose?";
            ckbImprimeLactoseGalactose.UseVisualStyleBackColor = true;
            ckbImprimeLactoseGalactose.CheckedChanged += ckbImprimeLactoseGalactose_CheckedChanged;
            // 
            // txtPorcaoPorEmbalagem
            // 
            txtPorcaoPorEmbalagem.Location = new Point(26, 98);
            txtPorcaoPorEmbalagem.Name = "txtPorcaoPorEmbalagem";
            txtPorcaoPorEmbalagem.Size = new Size(125, 23);
            txtPorcaoPorEmbalagem.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 5;
            label2.Text = "Porções por Embalagem";
            // 
            // txtPorcao
            // 
            txtPorcao.Location = new Point(209, 98);
            txtPorcao.Name = "txtPorcao";
            txtPorcao.Size = new Size(75, 23);
            txtPorcao.TabIndex = 6;
            // 
            // txtQuantidadeMedidaCaseira
            // 
            txtQuantidadeMedidaCaseira.Location = new Point(418, 98);
            txtQuantidadeMedidaCaseira.Name = "txtQuantidadeMedidaCaseira";
            txtQuantidadeMedidaCaseira.Size = new Size(75, 23);
            txtQuantidadeMedidaCaseira.TabIndex = 7;
            // 
            // cmbPorcaoUnidade
            // 
            cmbPorcaoUnidade.FormattingEnabled = true;
            cmbPorcaoUnidade.Items.AddRange(new object[] { "Gramas(g)", "Mililitros(ml)" });
            cmbPorcaoUnidade.Location = new Point(290, 98);
            cmbPorcaoUnidade.Name = "cmbPorcaoUnidade";
            cmbPorcaoUnidade.Size = new Size(75, 23);
            cmbPorcaoUnidade.TabIndex = 8;
            // 
            // cmbUnidadeMedidaCaseira
            // 
            cmbUnidadeMedidaCaseira.FormattingEnabled = true;
            cmbUnidadeMedidaCaseira.Location = new Point(499, 98);
            cmbUnidadeMedidaCaseira.Name = "cmbUnidadeMedidaCaseira";
            cmbUnidadeMedidaCaseira.Size = new Size(175, 23);
            cmbUnidadeMedidaCaseira.TabIndex = 9;
            // 
            // cmbMedidaCaseira
            // 
            cmbMedidaCaseira.FormattingEnabled = true;
            cmbMedidaCaseira.Location = new Point(712, 98);
            cmbMedidaCaseira.Name = "cmbMedidaCaseira";
            cmbMedidaCaseira.Size = new Size(175, 23);
            cmbMedidaCaseira.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(26, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 3);
            panel1.TabIndex = 11;
            // 
            // txtValorEnergetico
            // 
            txtValorEnergetico.Location = new Point(26, 181);
            txtValorEnergetico.Name = "txtValorEnergetico";
            txtValorEnergetico.Size = new Size(150, 23);
            txtValorEnergetico.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 80);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Porções";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 80);
            label4.Name = "label4";
            label4.Size = new Size(174, 15);
            label4.TabIndex = 14;
            label4.Text = "Quantidade por Medida Caseira";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(757, 80);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 15;
            label5.Text = "Medida Caseira";
            // 
            // txtCarboidratos
            // 
            txtCarboidratos.Location = new Point(201, 181);
            txtCarboidratos.Name = "txtCarboidratos";
            txtCarboidratos.Size = new Size(150, 23);
            txtCarboidratos.TabIndex = 16;
            // 
            // txtAcucaresTotais
            // 
            txtAcucaresTotais.Location = new Point(382, 181);
            txtAcucaresTotais.Name = "txtAcucaresTotais";
            txtAcucaresTotais.Size = new Size(150, 23);
            txtAcucaresTotais.TabIndex = 17;
            // 
            // txtAcucaresAdicionados
            // 
            txtAcucaresAdicionados.Location = new Point(566, 181);
            txtAcucaresAdicionados.Name = "txtAcucaresAdicionados";
            txtAcucaresAdicionados.Size = new Size(150, 23);
            txtAcucaresAdicionados.TabIndex = 18;
            // 
            // txtLactose
            // 
            txtLactose.Enabled = false;
            txtLactose.Location = new Point(751, 181);
            txtLactose.Name = "txtLactose";
            txtLactose.Size = new Size(150, 23);
            txtLactose.TabIndex = 19;
            // 
            // txtGalactose
            // 
            txtGalactose.Enabled = false;
            txtGalactose.Location = new Point(751, 244);
            txtGalactose.Name = "txtGalactose";
            txtGalactose.Size = new Size(150, 23);
            txtGalactose.TabIndex = 24;
            // 
            // txtGordurasTrans
            // 
            txtGordurasTrans.Location = new Point(566, 244);
            txtGordurasTrans.Name = "txtGordurasTrans";
            txtGordurasTrans.Size = new Size(150, 23);
            txtGordurasTrans.TabIndex = 23;
            // 
            // txtGordurasSaturadas
            // 
            txtGordurasSaturadas.Location = new Point(382, 244);
            txtGordurasSaturadas.Name = "txtGordurasSaturadas";
            txtGordurasSaturadas.Size = new Size(150, 23);
            txtGordurasSaturadas.TabIndex = 22;
            // 
            // txtGordurasTotais
            // 
            txtGordurasTotais.Location = new Point(201, 244);
            txtGordurasTotais.Name = "txtGordurasTotais";
            txtGordurasTotais.Size = new Size(150, 23);
            txtGordurasTotais.TabIndex = 21;
            // 
            // txtProteinas
            // 
            txtProteinas.Location = new Point(26, 244);
            txtProteinas.Name = "txtProteinas";
            txtProteinas.Size = new Size(150, 23);
            txtProteinas.TabIndex = 20;
            // 
            // txtSodio
            // 
            txtSodio.Location = new Point(201, 308);
            txtSodio.Name = "txtSodio";
            txtSodio.Size = new Size(150, 23);
            txtSodio.TabIndex = 26;
            // 
            // txtFibrasAlimentares
            // 
            txtFibrasAlimentares.Location = new Point(26, 308);
            txtFibrasAlimentares.Name = "txtFibrasAlimentares";
            txtFibrasAlimentares.Size = new Size(150, 23);
            txtFibrasAlimentares.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 163);
            label6.Name = "label6";
            label6.Size = new Size(145, 15);
            label6.TabIndex = 27;
            label6.Text = "Valor Energético(kcal = kJ)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 163);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 28;
            label7.Text = "Carboidratos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 163);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 29;
            label8.Text = "Açúcares Totais";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(566, 163);
            label9.Name = "label9";
            label9.Size = new Size(124, 15);
            label9.TabIndex = 30;
            label9.Text = "Açúcares Adicionados";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(751, 163);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 31;
            label10.Text = "Lactose";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(751, 226);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 36;
            label11.Text = "Galactose";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(566, 226);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 35;
            label12.Text = "Gorduras Trans";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(382, 226);
            label13.Name = "label13";
            label13.Size = new Size(109, 15);
            label13.TabIndex = 34;
            label13.Text = "Gorduras Saturadas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(201, 226);
            label14.Name = "label14";
            label14.Size = new Size(88, 15);
            label14.TabIndex = 33;
            label14.Text = "Gorduras Totais";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(26, 226);
            label15.Name = "label15";
            label15.Size = new Size(56, 15);
            label15.TabIndex = 32;
            label15.Text = "Proteínas";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(201, 290);
            label16.Name = "label16";
            label16.Size = new Size(37, 15);
            label16.TabIndex = 38;
            label16.Text = "Sódio";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(26, 290);
            label17.Name = "label17";
            label17.Size = new Size(104, 15);
            label17.TabIndex = 37;
            label17.Text = "Fibras Alimentares";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(26, 362);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 4);
            panel2.TabIndex = 12;
            // 
            // ckbAltoAcucarAdicionado
            // 
            ckbAltoAcucarAdicionado.AutoSize = true;
            ckbAltoAcucarAdicionado.Enabled = false;
            ckbAltoAcucarAdicionado.Location = new Point(382, 310);
            ckbAltoAcucarAdicionado.Name = "ckbAltoAcucarAdicionado";
            ckbAltoAcucarAdicionado.Size = new Size(172, 19);
            ckbAltoAcucarAdicionado.TabIndex = 39;
            ckbAltoAcucarAdicionado.Text = "Alto em Açúcar Adicionado";
            ckbAltoAcucarAdicionado.UseVisualStyleBackColor = true;
            // 
            // ckbAltoGorduraSaturada
            // 
            ckbAltoGorduraSaturada.AutoSize = true;
            ckbAltoGorduraSaturada.Enabled = false;
            ckbAltoGorduraSaturada.Location = new Point(566, 312);
            ckbAltoGorduraSaturada.Name = "ckbAltoGorduraSaturada";
            ckbAltoGorduraSaturada.Size = new Size(163, 19);
            ckbAltoGorduraSaturada.TabIndex = 40;
            ckbAltoGorduraSaturada.Text = "Alto em Gordura Saturada";
            ckbAltoGorduraSaturada.UseVisualStyleBackColor = true;
            // 
            // ckbAltoSodio
            // 
            ckbAltoSodio.AutoSize = true;
            ckbAltoSodio.Enabled = false;
            ckbAltoSodio.Location = new Point(751, 310);
            ckbAltoSodio.Name = "ckbAltoSodio";
            ckbAltoSodio.Size = new Size(101, 19);
            ckbAltoSodio.TabIndex = 41;
            ckbAltoSodio.Text = "Alto em Sódio";
            ckbAltoSodio.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(776, 554);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 35);
            btnSalvar.TabIndex = 42;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCriaTabelaNutri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 611);
            Controls.Add(btnSalvar);
            Controls.Add(ckbAltoSodio);
            Controls.Add(ckbAltoGorduraSaturada);
            Controls.Add(ckbAltoAcucarAdicionado);
            Controls.Add(panel2);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSodio);
            Controls.Add(txtFibrasAlimentares);
            Controls.Add(txtGalactose);
            Controls.Add(txtGordurasTrans);
            Controls.Add(txtGordurasSaturadas);
            Controls.Add(txtGordurasTotais);
            Controls.Add(txtProteinas);
            Controls.Add(txtLactose);
            Controls.Add(txtAcucaresAdicionados);
            Controls.Add(txtAcucaresTotais);
            Controls.Add(txtCarboidratos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtValorEnergetico);
            Controls.Add(panel1);
            Controls.Add(cmbMedidaCaseira);
            Controls.Add(cmbUnidadeMedidaCaseira);
            Controls.Add(cmbPorcaoUnidade);
            Controls.Add(txtQuantidadeMedidaCaseira);
            Controls.Add(txtPorcao);
            Controls.Add(label2);
            Controls.Add(txtPorcaoPorEmbalagem);
            Controls.Add(ckbImprimeLactoseGalactose);
            Controls.Add(ckbCalculoPorcaoAutomatico);
            Controls.Add(label1);
            Controls.Add(txtDescricao);
            Name = "frmCriaTabelaNutri";
            Text = "Criador de Tabelas Nutricionais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescricao;
        private Label label1;
        private CheckBox ckbCalculoPorcaoAutomatico;
        private CheckBox ckbImprimeLactoseGalactose;
        private TextBox txtPorcaoPorEmbalagem;
        private Label label2;
        private TextBox txtPorcao;
        private TextBox txtQuantidadeMedidaCaseira;
        private ComboBox cmbPorcaoUnidade;
        private ComboBox cmbUnidadeMedidaCaseira;
        private ComboBox cmbMedidaCaseira;
        private Panel panel1;
        private TextBox txtValorEnergetico;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCarboidratos;
        private TextBox txtAcucaresTotais;
        private TextBox txtAcucaresAdicionados;
        private TextBox txtLactose;
        private TextBox txtGalactose;
        private TextBox txtGordurasTrans;
        private TextBox txtGordurasSaturadas;
        private TextBox txtGordurasTotais;
        private TextBox txtProteinas;
        private TextBox txtSodio;
        private TextBox txtFibrasAlimentares;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel panel2;
        private CheckBox ckbAltoAcucarAdicionado;
        private CheckBox ckbAltoGorduraSaturada;
        private CheckBox ckbAltoSodio;
        private Button btnSalvar;
    }
}
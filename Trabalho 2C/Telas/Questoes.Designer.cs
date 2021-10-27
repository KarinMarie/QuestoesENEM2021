namespace Trabalho_2C
{
    partial class Questoes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questoes));
            this.label1 = new System.Windows.Forms.Label();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnProximaPergunta = new System.Windows.Forms.Button();
            this.txtResolucao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLimparDisciplina = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textTema = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelConc = new System.Windows.Forms.Label();
            this.labelDes2 = new System.Windows.Forms.Label();
            this.labelDes1 = new System.Windows.Forms.Label();
            this.labelIntro = new System.Windows.Forms.Label();
            this.textConc = new System.Windows.Forms.TextBox();
            this.textDes2 = new System.Windows.Forms.TextBox();
            this.textDes1 = new System.Windows.Forms.TextBox();
            this.textIntro = new System.Windows.Forms.TextBox();
            this.cbRedacao = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.btnApagarUsuario = new System.Windows.Forms.Button();
            this.lbEstatisticas = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtGraficoAusente = new System.Windows.Forms.Label();
            this.chartUsuario = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_minimizaquest = new System.Windows.Forms.Button();
            this.btn_fechatudoquest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplina:";
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbDisciplina.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(86, 53);
            this.cbDisciplina.Margin = new System.Windows.Forms.Padding(2);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(219, 21);
            this.cbDisciplina.TabIndex = 1;
            this.cbDisciplina.Text = "--- ESCOLHA UMA DISCIPLINA ---";
            this.cbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbDisciplina_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enunciado:";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEnunciado.Location = new System.Drawing.Point(12, 104);
            this.txtEnunciado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.ReadOnly = true;
            this.txtEnunciado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnunciado.Size = new System.Drawing.Size(616, 110);
            this.txtEnunciado.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(10, 229);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(631, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "E.";
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.Location = new System.Drawing.Point(30, 135);
            this.rbE.Margin = new System.Windows.Forms.Padding(2);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(14, 13);
            this.rbE.TabIndex = 8;
            this.rbE.TabStop = true;
            this.rbE.UseVisualStyleBackColor = true;
            this.rbE.MouseHover += new System.EventHandler(this.rbE_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "D.";
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(30, 104);
            this.rbD.Margin = new System.Windows.Forms.Padding(2);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(14, 13);
            this.rbD.TabIndex = 6;
            this.rbD.TabStop = true;
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.MouseHover += new System.EventHandler(this.rbD_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "C.";
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(30, 76);
            this.rbC.Margin = new System.Windows.Forms.Padding(2);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(14, 13);
            this.rbC.TabIndex = 4;
            this.rbC.TabStop = true;
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.MouseHover += new System.EventHandler(this.rbC_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "B.";
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(30, 46);
            this.rbB.Margin = new System.Windows.Forms.Padding(2);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(14, 13);
            this.rbB.TabIndex = 2;
            this.rbB.TabStop = true;
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.MouseHover += new System.EventHandler(this.rbB_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "A.";
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.BackColor = System.Drawing.Color.Transparent;
            this.rbA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbA.Location = new System.Drawing.Point(30, 17);
            this.rbA.Margin = new System.Windows.Forms.Padding(2);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(14, 13);
            this.rbA.TabIndex = 0;
            this.rbA.UseVisualStyleBackColor = false;
            this.rbA.MouseHover += new System.EventHandler(this.rbA_MouseHover);
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(216)))));
            this.btnResponder.Enabled = false;
            this.btnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.Snow;
            this.btnResponder.Location = new System.Drawing.Point(12, 402);
            this.btnResponder.Margin = new System.Windows.Forms.Padding(2);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(175, 34);
            this.btnResponder.TabIndex = 5;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnProximaPergunta
            // 
            this.btnProximaPergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(216)))));
            this.btnProximaPergunta.Enabled = false;
            this.btnProximaPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaPergunta.ForeColor = System.Drawing.Color.Snow;
            this.btnProximaPergunta.Location = new System.Drawing.Point(191, 402);
            this.btnProximaPergunta.Margin = new System.Windows.Forms.Padding(2);
            this.btnProximaPergunta.Name = "btnProximaPergunta";
            this.btnProximaPergunta.Size = new System.Drawing.Size(437, 34);
            this.btnProximaPergunta.TabIndex = 6;
            this.btnProximaPergunta.Text = "Próxima Pergunta";
            this.btnProximaPergunta.UseVisualStyleBackColor = false;
            this.btnProximaPergunta.Click += new System.EventHandler(this.btnProximaPergunta_Click);
            // 
            // txtResolucao
            // 
            this.txtResolucao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtResolucao.Location = new System.Drawing.Point(12, 462);
            this.txtResolucao.Margin = new System.Windows.Forms.Padding(2);
            this.txtResolucao.Multiline = true;
            this.txtResolucao.Name = "txtResolucao";
            this.txtResolucao.ReadOnly = true;
            this.txtResolucao.Size = new System.Drawing.Size(616, 100);
            this.txtResolucao.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(11, 445);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Resolução com comentários:";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAcertos.Location = new System.Drawing.Point(11, 575);
            this.lblAcertos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(98, 15);
            this.lblAcertos.TabIndex = 12;
            this.lblAcertos.Text = "0% de acertos";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(124, 575);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(504, 15);
            this.progressBar.TabIndex = 11;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(216)))));
            this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenu.ForeColor = System.Drawing.Color.Snow;
            this.btnVoltarMenu.Location = new System.Drawing.Point(509, 36);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(119, 36);
            this.btnVoltarMenu.TabIndex = 13;
            this.btnVoltarMenu.Text = "Voltar ao Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 673);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(238)))));
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnLimparDisciplina);
            this.tabPage1.Controls.Add(this.cbDisciplina);
            this.tabPage1.Controls.Add(this.lblAcertos);
            this.tabPage1.Controls.Add(this.btnVoltarMenu);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnProximaPergunta);
            this.tabPage1.Controls.Add(this.btnResponder);
            this.tabPage1.Controls.Add(this.txtResolucao);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtEnunciado);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Disciplinas ";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNome.Location = new System.Drawing.Point(133, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(495, 20);
            this.txtNome.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(11, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Insira seu Nome:";
            // 
            // btnLimparDisciplina
            // 
            this.btnLimparDisciplina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(216)))));
            this.btnLimparDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparDisciplina.ForeColor = System.Drawing.Color.Snow;
            this.btnLimparDisciplina.Location = new System.Drawing.Point(55, 603);
            this.btnLimparDisciplina.Name = "btnLimparDisciplina";
            this.btnLimparDisciplina.Size = new System.Drawing.Size(529, 35);
            this.btnLimparDisciplina.TabIndex = 14;
            this.btnLimparDisciplina.Text = "Limpar Acertos e Erros da Disciplina";
            this.btnLimparDisciplina.UseVisualStyleBackColor = false;
            this.btnLimparDisciplina.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(238)))));
            this.tabPage2.Controls.Add(this.textTema);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.labelConc);
            this.tabPage2.Controls.Add(this.labelDes2);
            this.tabPage2.Controls.Add(this.labelDes1);
            this.tabPage2.Controls.Add(this.labelIntro);
            this.tabPage2.Controls.Add(this.textConc);
            this.tabPage2.Controls.Add(this.textDes2);
            this.tabPage2.Controls.Add(this.textDes1);
            this.tabPage2.Controls.Add(this.textIntro);
            this.tabPage2.Controls.Add(this.cbRedacao);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Redação";
            // 
            // textTema
            // 
            this.textTema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textTema.Location = new System.Drawing.Point(65, 38);
            this.textTema.Name = "textTema";
            this.textTema.ReadOnly = true;
            this.textTema.Size = new System.Drawing.Size(567, 20);
            this.textTema.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(9, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tema:";
            // 
            // labelConc
            // 
            this.labelConc.AutoSize = true;
            this.labelConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(33)))), ((int)(((byte)(178)))));
            this.labelConc.Location = new System.Drawing.Point(9, 510);
            this.labelConc.Name = "labelConc";
            this.labelConc.Size = new System.Drawing.Size(85, 16);
            this.labelConc.TabIndex = 11;
            this.labelConc.Text = "Conclusão:";
            // 
            // labelDes2
            // 
            this.labelDes2.AutoSize = true;
            this.labelDes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(123)))), ((int)(((byte)(170)))));
            this.labelDes2.Location = new System.Drawing.Point(9, 373);
            this.labelDes2.Name = "labelDes2";
            this.labelDes2.Size = new System.Drawing.Size(231, 16);
            this.labelDes2.TabIndex = 10;
            this.labelDes2.Text = "Desenvolvimento (argumento 2):";
            // 
            // labelDes1
            // 
            this.labelDes1.AutoSize = true;
            this.labelDes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(87)))), ((int)(((byte)(214)))));
            this.labelDes1.Location = new System.Drawing.Point(9, 223);
            this.labelDes1.Name = "labelDes1";
            this.labelDes1.Size = new System.Drawing.Size(231, 16);
            this.labelDes1.TabIndex = 9;
            this.labelDes1.Text = "Desenvolvimento (argumento 1):";
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(74)))), ((int)(((byte)(129)))));
            this.labelIntro.Location = new System.Drawing.Point(9, 70);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(85, 16);
            this.labelIntro.TabIndex = 5;
            this.labelIntro.Text = "Introdução:";
            // 
            // textConc
            // 
            this.textConc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textConc.Location = new System.Drawing.Point(12, 89);
            this.textConc.Multiline = true;
            this.textConc.Name = "textConc";
            this.textConc.ReadOnly = true;
            this.textConc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textConc.Size = new System.Drawing.Size(620, 109);
            this.textConc.TabIndex = 4;
            // 
            // textDes2
            // 
            this.textDes2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textDes2.Location = new System.Drawing.Point(12, 529);
            this.textDes2.Multiline = true;
            this.textDes2.Name = "textDes2";
            this.textDes2.ReadOnly = true;
            this.textDes2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDes2.Size = new System.Drawing.Size(620, 109);
            this.textDes2.TabIndex = 3;
            // 
            // textDes1
            // 
            this.textDes1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textDes1.Location = new System.Drawing.Point(12, 392);
            this.textDes1.Multiline = true;
            this.textDes1.Name = "textDes1";
            this.textDes1.ReadOnly = true;
            this.textDes1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDes1.Size = new System.Drawing.Size(620, 109);
            this.textDes1.TabIndex = 2;
            // 
            // textIntro
            // 
            this.textIntro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textIntro.Location = new System.Drawing.Point(12, 242);
            this.textIntro.Multiline = true;
            this.textIntro.Name = "textIntro";
            this.textIntro.ReadOnly = true;
            this.textIntro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textIntro.Size = new System.Drawing.Size(620, 109);
            this.textIntro.TabIndex = 1;
            // 
            // cbRedacao
            // 
            this.cbRedacao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbRedacao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbRedacao.FormattingEnabled = true;
            this.cbRedacao.Location = new System.Drawing.Point(12, 11);
            this.cbRedacao.Name = "cbRedacao";
            this.cbRedacao.Size = new System.Drawing.Size(206, 21);
            this.cbRedacao.TabIndex = 0;
            this.cbRedacao.Text = "--- ESCOLHA UMA REDAÇÃO ---";
            this.cbRedacao.SelectedIndexChanged += new System.EventHandler(this.cbRedacao_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.tabPage3.Controls.Add(this.btnApagarTudo);
            this.tabPage3.Controls.Add(this.btnApagarUsuario);
            this.tabPage3.Controls.Add(this.lbEstatisticas);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(648, 647);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estatísticas";
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(216)))));
            this.btnApagarTudo.ForeColor = System.Drawing.Color.Snow;
            this.btnApagarTudo.Location = new System.Drawing.Point(62, 601);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(526, 35);
            this.btnApagarTudo.TabIndex = 2;
            this.btnApagarTudo.Text = "Apagar Tudo";
            this.btnApagarTudo.UseVisualStyleBackColor = false;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // btnApagarUsuario
            // 
            this.btnApagarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(216)))));
            this.btnApagarUsuario.ForeColor = System.Drawing.Color.Snow;
            this.btnApagarUsuario.Location = new System.Drawing.Point(62, 561);
            this.btnApagarUsuario.Name = "btnApagarUsuario";
            this.btnApagarUsuario.Size = new System.Drawing.Size(526, 34);
            this.btnApagarUsuario.TabIndex = 1;
            this.btnApagarUsuario.Text = "Apagar Usuário";
            this.btnApagarUsuario.UseVisualStyleBackColor = false;
            this.btnApagarUsuario.Click += new System.EventHandler(this.btnApagarUsuario_Click);
            // 
            // lbEstatisticas
            // 
            this.lbEstatisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(238)))));
            this.lbEstatisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstatisticas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbEstatisticas.FormattingEnabled = true;
            this.lbEstatisticas.HorizontalScrollbar = true;
            this.lbEstatisticas.ItemHeight = 29;
            this.lbEstatisticas.Location = new System.Drawing.Point(12, 14);
            this.lbEstatisticas.Name = "lbEstatisticas";
            this.lbEstatisticas.Size = new System.Drawing.Size(622, 526);
            this.lbEstatisticas.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(238)))));
            this.tabPage4.Controls.Add(this.txtGraficoAusente);
            this.tabPage4.Controls.Add(this.chartUsuario);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(648, 647);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gráfico";
            // 
            // txtGraficoAusente
            // 
            this.txtGraficoAusente.AutoSize = true;
            this.txtGraficoAusente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGraficoAusente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGraficoAusente.Location = new System.Drawing.Point(123, 230);
            this.txtGraficoAusente.Name = "txtGraficoAusente";
            this.txtGraficoAusente.Size = new System.Drawing.Size(408, 165);
            this.txtGraficoAusente.TabIndex = 4;
            this.txtGraficoAusente.Text = "COMPLETE UMA\r\nDISCIPLINA\r\nPRIMEIRO!";
            this.txtGraficoAusente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartUsuario
            // 
            this.chartUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(238)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(238)))));
            chartArea1.Name = "ChartArea1";
            this.chartUsuario.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(238)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartUsuario.Legends.Add(legend1);
            this.chartUsuario.Location = new System.Drawing.Point(20, 27);
            this.chartUsuario.Name = "chartUsuario";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Usuario";
            this.chartUsuario.Series.Add(series1);
            this.chartUsuario.Size = new System.Drawing.Size(618, 611);
            this.chartUsuario.TabIndex = 3;
            this.chartUsuario.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Materia";
            this.chartUsuario.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(177)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_minimizaquest);
            this.panel1.Controls.Add(this.btn_fechatudoquest);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 44);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_2C.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(39, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(86, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "ÁREA DE QUESTÕES";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label11_MouseDown);
            // 
            // btn_minimizaquest
            // 
            this.btn_minimizaquest.BackColor = System.Drawing.Color.Linen;
            this.btn_minimizaquest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_minimizaquest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizaquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimizaquest.ForeColor = System.Drawing.Color.Orchid;
            this.btn_minimizaquest.Location = new System.Drawing.Point(463, 6);
            this.btn_minimizaquest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minimizaquest.Name = "btn_minimizaquest";
            this.btn_minimizaquest.Size = new System.Drawing.Size(76, 32);
            this.btn_minimizaquest.TabIndex = 3;
            this.btn_minimizaquest.Text = "-";
            this.btn_minimizaquest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_minimizaquest.UseVisualStyleBackColor = false;
            this.btn_minimizaquest.Click += new System.EventHandler(this.btn_minimizaquest_Click);
            // 
            // btn_fechatudoquest
            // 
            this.btn_fechatudoquest.BackColor = System.Drawing.Color.Linen;
            this.btn_fechatudoquest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_fechatudoquest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechatudoquest.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechatudoquest.ForeColor = System.Drawing.Color.Orchid;
            this.btn_fechatudoquest.Location = new System.Drawing.Point(561, 6);
            this.btn_fechatudoquest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fechatudoquest.Name = "btn_fechatudoquest";
            this.btn_fechatudoquest.Size = new System.Drawing.Size(76, 32);
            this.btn_fechatudoquest.TabIndex = 2;
            this.btn_fechatudoquest.Text = "x";
            this.btn_fechatudoquest.UseVisualStyleBackColor = false;
            this.btn_fechatudoquest.Click += new System.EventHandler(this.btn_fechatudoquest_Click);
            // 
            // Questoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(656, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Questoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo de Resolução de Questões CPII";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Questoes_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnProximaPergunta;
        private System.Windows.Forms.TextBox txtResolucao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textIntro;
        private System.Windows.Forms.ComboBox cbRedacao;
        private System.Windows.Forms.TextBox textConc;
        private System.Windows.Forms.TextBox textDes2;
        private System.Windows.Forms.TextBox textDes1;
        private System.Windows.Forms.Label labelConc;
        private System.Windows.Forms.Label labelDes2;
        private System.Windows.Forms.Label labelDes1;
        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.TextBox textTema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimparDisciplina;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbEstatisticas;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Button btnApagarUsuario;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsuario;
        private System.Windows.Forms.Label txtGraficoAusente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimizaquest;
        private System.Windows.Forms.Button btn_fechatudoquest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


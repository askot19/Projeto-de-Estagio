namespace GestaoFinanceira
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.labelUsuarioConectado = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelData = new MetroFramework.Controls.MetroLabel();
            this.labelHora = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnImpressao = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCalculaJuros = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnConfiguracao = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSair = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBlocoNota = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnExcel = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnWord = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCaculadora = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRelatorio = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCadastro = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // labelUsuarioConectado
            // 
            this.labelUsuarioConectado.AutoSize = true;
            this.labelUsuarioConectado.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelUsuarioConectado.Location = new System.Drawing.Point(188, 35);
            this.labelUsuarioConectado.Name = "labelUsuarioConectado";
            this.labelUsuarioConectado.Size = new System.Drawing.Size(103, 25);
            this.labelUsuarioConectado.TabIndex = 3;
            this.labelUsuarioConectado.Text = "metroLabel1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(26, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(166, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Usuário Conectado: ";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelData.Location = new System.Drawing.Point(26, 481);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(106, 25);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "metroLabel2";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelHora.Location = new System.Drawing.Point(26, 508);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(106, 25);
            this.labelHora.TabIndex = 4;
            this.labelHora.Text = "metroLabel2";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(26, 443);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(848, 35);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTileButton1.color = System.Drawing.Color.Silver;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.DarkGray;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 15;
            this.bunifuTileButton1.ImageZoom = 70;
            this.bunifuTileButton1.LabelPosition = 0;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(26, 372);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(66, 69);
            this.bunifuTileButton1.TabIndex = 2;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Silver;
            this.bunifuTileButton2.color = System.Drawing.Color.Silver;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.DarkGray;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 15;
            this.bunifuTileButton2.ImageZoom = 70;
            this.bunifuTileButton2.LabelPosition = 0;
            this.bunifuTileButton2.LabelText = "";
            this.bunifuTileButton2.Location = new System.Drawing.Point(94, 372);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(66, 69);
            this.bunifuTileButton2.TabIndex = 2;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.Silver;
            this.bunifuTileButton3.color = System.Drawing.Color.Silver;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.DarkGray;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = null;
            this.bunifuTileButton3.ImagePosition = 15;
            this.bunifuTileButton3.ImageZoom = 70;
            this.bunifuTileButton3.LabelPosition = 0;
            this.bunifuTileButton3.LabelText = "";
            this.bunifuTileButton3.Location = new System.Drawing.Point(163, 372);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(65, 69);
            this.bunifuTileButton3.TabIndex = 2;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.Silver;
            this.bunifuTileButton4.color = System.Drawing.Color.Silver;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.DarkGray;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = null;
            this.bunifuTileButton4.ImagePosition = 15;
            this.bunifuTileButton4.ImageZoom = 70;
            this.bunifuTileButton4.LabelPosition = 0;
            this.bunifuTileButton4.LabelText = "";
            this.bunifuTileButton4.Location = new System.Drawing.Point(231, 372);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(65, 69);
            this.bunifuTileButton4.TabIndex = 2;
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.Silver;
            this.bunifuTileButton5.color = System.Drawing.Color.Silver;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.DarkGray;
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = null;
            this.bunifuTileButton5.ImagePosition = 15;
            this.bunifuTileButton5.ImageZoom = 70;
            this.bunifuTileButton5.LabelPosition = 0;
            this.bunifuTileButton5.LabelText = "";
            this.bunifuTileButton5.Location = new System.Drawing.Point(746, 372);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(63, 69);
            this.bunifuTileButton5.TabIndex = 2;
            this.bunifuTileButton5.Visible = false;
            // 
            // btnImpressao
            // 
            this.btnImpressao.BackColor = System.Drawing.Color.Silver;
            this.btnImpressao.color = System.Drawing.Color.Silver;
            this.btnImpressao.colorActive = System.Drawing.Color.DarkGray;
            this.btnImpressao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpressao.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnImpressao.ForeColor = System.Drawing.Color.White;
            this.btnImpressao.Image = global::GestaoFinanceira.Properties.Resources.icons8_impressão_321;
            this.btnImpressao.ImagePosition = 20;
            this.btnImpressao.ImageZoom = 50;
            this.btnImpressao.LabelPosition = 30;
            this.btnImpressao.LabelText = "IMPRESSÃO";
            this.btnImpressao.Location = new System.Drawing.Point(299, 66);
            this.btnImpressao.Margin = new System.Windows.Forms.Padding(6);
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.Size = new System.Drawing.Size(131, 116);
            this.btnImpressao.TabIndex = 6;
            this.btnImpressao.Click += new System.EventHandler(this.btnImpressao_Click);
            // 
            // btnCalculaJuros
            // 
            this.btnCalculaJuros.BackColor = System.Drawing.Color.Silver;
            this.btnCalculaJuros.color = System.Drawing.Color.Silver;
            this.btnCalculaJuros.colorActive = System.Drawing.Color.DarkGray;
            this.btnCalculaJuros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculaJuros.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCalculaJuros.ForeColor = System.Drawing.Color.White;
            this.btnCalculaJuros.Image = global::GestaoFinanceira.Properties.Resources.icons8_pilha_de_dinheiro_751;
            this.btnCalculaJuros.ImagePosition = 5;
            this.btnCalculaJuros.ImageZoom = 35;
            this.btnCalculaJuros.LabelPosition = 30;
            this.btnCalculaJuros.LabelText = "CALCULA JUROS SIMPLES";
            this.btnCalculaJuros.Location = new System.Drawing.Point(26, 184);
            this.btnCalculaJuros.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculaJuros.Name = "btnCalculaJuros";
            this.btnCalculaJuros.Size = new System.Drawing.Size(270, 117);
            this.btnCalculaJuros.TabIndex = 2;
            this.btnCalculaJuros.Click += new System.EventHandler(this.btnCalculaJuros_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.BackColor = System.Drawing.Color.Silver;
            this.btnConfiguracao.color = System.Drawing.Color.Silver;
            this.btnConfiguracao.colorActive = System.Drawing.Color.DarkGray;
            this.btnConfiguracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracao.Image = global::GestaoFinanceira.Properties.Resources.icons8_configurações_75;
            this.btnConfiguracao.ImagePosition = 15;
            this.btnConfiguracao.ImageZoom = 70;
            this.btnConfiguracao.LabelPosition = 0;
            this.btnConfiguracao.LabelText = "";
            this.btnConfiguracao.Location = new System.Drawing.Point(811, 372);
            this.btnConfiguracao.Margin = new System.Windows.Forms.Padding(6);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(63, 69);
            this.btnConfiguracao.TabIndex = 2;
            this.btnConfiguracao.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Silver;
            this.btnSair.color = System.Drawing.Color.Silver;
            this.btnSair.colorActive = System.Drawing.Color.DarkGray;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::GestaoFinanceira.Properties.Resources.icons8_desligar_100;
            this.btnSair.ImagePosition = 15;
            this.btnSair.ImageZoom = 80;
            this.btnSair.LabelPosition = 0;
            this.btnSair.LabelText = "";
            this.btnSair.Location = new System.Drawing.Point(746, 66);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(128, 129);
            this.btnSair.TabIndex = 2;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnBlocoNota
            // 
            this.btnBlocoNota.BackColor = System.Drawing.Color.Silver;
            this.btnBlocoNota.color = System.Drawing.Color.Silver;
            this.btnBlocoNota.colorActive = System.Drawing.Color.DarkGray;
            this.btnBlocoNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlocoNota.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBlocoNota.ForeColor = System.Drawing.Color.White;
            this.btnBlocoNota.Image = global::GestaoFinanceira.Properties.Resources.icons8_arquivo_regular_751;
            this.btnBlocoNota.ImagePosition = 15;
            this.btnBlocoNota.ImageZoom = 70;
            this.btnBlocoNota.LabelPosition = 0;
            this.btnBlocoNota.LabelText = "";
            this.btnBlocoNota.Location = new System.Drawing.Point(231, 303);
            this.btnBlocoNota.Margin = new System.Windows.Forms.Padding(6);
            this.btnBlocoNota.Name = "btnBlocoNota";
            this.btnBlocoNota.Size = new System.Drawing.Size(65, 67);
            this.btnBlocoNota.TabIndex = 2;
            this.btnBlocoNota.Click += new System.EventHandler(this.btnBlocoNota_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Silver;
            this.btnExcel.color = System.Drawing.Color.Silver;
            this.btnExcel.colorActive = System.Drawing.Color.DarkGray;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::GestaoFinanceira.Properties.Resources.icons8_ms_excel_751;
            this.btnExcel.ImagePosition = 15;
            this.btnExcel.ImageZoom = 70;
            this.btnExcel.LabelPosition = 0;
            this.btnExcel.LabelText = "";
            this.btnExcel.Location = new System.Drawing.Point(163, 303);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(65, 67);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackColor = System.Drawing.Color.Silver;
            this.btnWord.color = System.Drawing.Color.Silver;
            this.btnWord.colorActive = System.Drawing.Color.DarkGray;
            this.btnWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWord.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnWord.ForeColor = System.Drawing.Color.White;
            this.btnWord.Image = global::GestaoFinanceira.Properties.Resources.icons8_ms_word_751;
            this.btnWord.ImagePosition = 15;
            this.btnWord.ImageZoom = 70;
            this.btnWord.LabelPosition = 0;
            this.btnWord.LabelText = "";
            this.btnWord.Location = new System.Drawing.Point(94, 303);
            this.btnWord.Margin = new System.Windows.Forms.Padding(6);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(66, 67);
            this.btnWord.TabIndex = 2;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnCaculadora
            // 
            this.btnCaculadora.BackColor = System.Drawing.Color.Silver;
            this.btnCaculadora.color = System.Drawing.Color.Silver;
            this.btnCaculadora.colorActive = System.Drawing.Color.DarkGray;
            this.btnCaculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaculadora.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCaculadora.ForeColor = System.Drawing.Color.White;
            this.btnCaculadora.Image = global::GestaoFinanceira.Properties.Resources.icons8_calculadora_75;
            this.btnCaculadora.ImagePosition = 20;
            this.btnCaculadora.ImageZoom = 50;
            this.btnCaculadora.LabelPosition = 0;
            this.btnCaculadora.LabelText = "";
            this.btnCaculadora.Location = new System.Drawing.Point(26, 303);
            this.btnCaculadora.Margin = new System.Windows.Forms.Padding(6);
            this.btnCaculadora.Name = "btnCaculadora";
            this.btnCaculadora.Size = new System.Drawing.Size(66, 67);
            this.btnCaculadora.TabIndex = 2;
            this.btnCaculadora.Click += new System.EventHandler(this.btnCaculadora_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Silver;
            this.btnRelatorio.color = System.Drawing.Color.Silver;
            this.btnRelatorio.colorActive = System.Drawing.Color.DarkGray;
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Image = global::GestaoFinanceira.Properties.Resources.icons8_copiar_75__1_;
            this.btnRelatorio.ImagePosition = 20;
            this.btnRelatorio.ImageZoom = 50;
            this.btnRelatorio.LabelPosition = 30;
            this.btnRelatorio.LabelText = "RELATÓRIO";
            this.btnRelatorio.Location = new System.Drawing.Point(165, 66);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(6);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(131, 116);
            this.btnRelatorio.TabIndex = 2;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Silver;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastro.color = System.Drawing.Color.Silver;
            this.btnCadastro.colorActive = System.Drawing.Color.DarkGray;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = global::GestaoFinanceira.Properties.Resources.icons8_pessoa_do_sexo_masculino_75;
            this.btnCadastro.ImagePosition = 20;
            this.btnCadastro.ImageZoom = 50;
            this.btnCadastro.LabelPosition = 30;
            this.btnCadastro.LabelText = "CADASTRO";
            this.btnCadastro.Location = new System.Drawing.Point(26, 66);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(136, 116);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnImpressao);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.labelUsuarioConectado);
            this.Controls.Add(this.btnCalculaJuros);
            this.Controls.Add(this.bunifuTileButton4);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuTileButton5);
            this.Controls.Add(this.btnConfiguracao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnBlocoNota);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnCaculadora);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnCadastro);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Software de Gestão Financeira";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnCadastro;
        private Bunifu.Framework.UI.BunifuTileButton btnRelatorio;
        private Bunifu.Framework.UI.BunifuTileButton btnCalculaJuros;
        private Bunifu.Framework.UI.BunifuTileButton btnSair;
        private Bunifu.Framework.UI.BunifuTileButton btnCaculadora;
        private Bunifu.Framework.UI.BunifuTileButton btnWord;
        private Bunifu.Framework.UI.BunifuTileButton btnExcel;
        private Bunifu.Framework.UI.BunifuTileButton btnBlocoNota;
        private MetroFramework.Controls.MetroLabel labelUsuarioConectado;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuTileButton btnConfiguracao;
        private MetroFramework.Controls.MetroLabel labelData;
        private MetroFramework.Controls.MetroLabel labelHora;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.Framework.UI.BunifuTileButton btnImpressao;
    }
}


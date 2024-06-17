namespace GestaoFinanceira.Visual
{
    partial class frmCadastroUsuario
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPesquisar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNovo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Código";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(149, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Usuário";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(560, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Password";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Icon = global::GestaoFinanceira.Properties.Resources.icons8_chave_16;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(561, 80);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(204, 27);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.DisplayIcon = true;
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsuario.Icon = global::GestaoFinanceira.Properties.Resources.icons8_pessoa_do_sexo_masculino_16;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(149, 80);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(406, 27);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.DisplayIcon = true;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCodigo.Icon = global::GestaoFinanceira.Properties.Resources.icons8_cardápio_16;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(29, 80);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(114, 27);
            this.txtCodigo.Style = MetroFramework.MetroColorStyle.Red;
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Active = false;
            this.btnVoltar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_duplo_para_a_esquerda_32;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.BorderRadius = 4;
            this.btnVoltar.ButtonText = "               Voltar";
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVoltar.Iconimage = null;
            this.btnVoltar.Iconimage_right = null;
            this.btnVoltar.Iconimage_right_Selected = null;
            this.btnVoltar.Iconimage_Selected = null;
            this.btnVoltar.IconMarginLeft = 0;
            this.btnVoltar.IconMarginRight = 0;
            this.btnVoltar.IconRightVisible = true;
            this.btnVoltar.IconRightZoom = 0D;
            this.btnVoltar.IconVisible = true;
            this.btnVoltar.IconZoom = 90D;
            this.btnVoltar.IsTab = false;
            this.btnVoltar.Location = new System.Drawing.Point(660, 407);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVoltar.selected = false;
            this.btnVoltar.Size = new System.Drawing.Size(100, 36);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "               Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Textcolor = System.Drawing.Color.Black;
            this.btnVoltar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Active = false;
            this.btnGravar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnGravar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGravar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_salvar_321;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGravar.BorderRadius = 4;
            this.btnGravar.ButtonText = "               Gravar";
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnGravar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGravar.Iconimage = null;
            this.btnGravar.Iconimage_right = null;
            this.btnGravar.Iconimage_right_Selected = null;
            this.btnGravar.Iconimage_Selected = null;
            this.btnGravar.IconMarginLeft = 0;
            this.btnGravar.IconMarginRight = 0;
            this.btnGravar.IconRightVisible = true;
            this.btnGravar.IconRightZoom = 0D;
            this.btnGravar.IconVisible = true;
            this.btnGravar.IconZoom = 90D;
            this.btnGravar.IsTab = false;
            this.btnGravar.Location = new System.Drawing.Point(556, 407);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnGravar.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnGravar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGravar.selected = false;
            this.btnGravar.Size = new System.Drawing.Size(100, 36);
            this.btnGravar.TabIndex = 22;
            this.btnGravar.Text = "               Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Textcolor = System.Drawing.Color.Black;
            this.btnGravar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Active = false;
            this.btnExcluir.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_excluir_32;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.BorderRadius = 4;
            this.btnExcluir.ButtonText = "               Excluir";
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcluir.Iconimage = null;
            this.btnExcluir.Iconimage_right = null;
            this.btnExcluir.Iconimage_right_Selected = null;
            this.btnExcluir.Iconimage_Selected = null;
            this.btnExcluir.IconMarginLeft = 0;
            this.btnExcluir.IconMarginRight = 0;
            this.btnExcluir.IconRightVisible = true;
            this.btnExcluir.IconRightZoom = 0D;
            this.btnExcluir.IconVisible = true;
            this.btnExcluir.IconZoom = 90D;
            this.btnExcluir.IsTab = false;
            this.btnExcluir.Location = new System.Drawing.Point(452, 407);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnExcluir.selected = false;
            this.btnExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "               Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Textcolor = System.Drawing.Color.Black;
            this.btnExcluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Active = false;
            this.btnEditar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_editar_321;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.BorderRadius = 4;
            this.btnEditar.ButtonText = "               Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = null;
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(348, 407);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnEditar.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(100, 36);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "               Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.Black;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Active = false;
            this.btnCancelar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_cancelar_32;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.BorderRadius = 4;
            this.btnCancelar.ButtonText = "            Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = null;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 90D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(244, 407);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "            Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.Black;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Active = false;
            this.btnPesquisar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_32;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.BorderRadius = 4;
            this.btnPesquisar.ButtonText = "           Pesquisar";
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Iconimage = null;
            this.btnPesquisar.Iconimage_right = null;
            this.btnPesquisar.Iconimage_right_Selected = null;
            this.btnPesquisar.Iconimage_Selected = null;
            this.btnPesquisar.IconMarginLeft = 0;
            this.btnPesquisar.IconMarginRight = 0;
            this.btnPesquisar.IconRightVisible = true;
            this.btnPesquisar.IconRightZoom = 0D;
            this.btnPesquisar.IconVisible = true;
            this.btnPesquisar.IconZoom = 90D;
            this.btnPesquisar.IsTab = false;
            this.btnPesquisar.Location = new System.Drawing.Point(140, 407);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPesquisar.selected = false;
            this.btnPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "           Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Textcolor = System.Drawing.Color.Black;
            this.btnPesquisar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Active = false;
            this.btnNovo.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnNovo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNovo.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_mais_32;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.BorderRadius = 4;
            this.btnNovo.ButtonText = "             Novo";
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnNovo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNovo.Iconimage = null;
            this.btnNovo.Iconimage_right = null;
            this.btnNovo.Iconimage_right_Selected = null;
            this.btnNovo.Iconimage_Selected = null;
            this.btnNovo.IconMarginLeft = 0;
            this.btnNovo.IconMarginRight = 0;
            this.btnNovo.IconRightVisible = true;
            this.btnNovo.IconRightZoom = 0D;
            this.btnNovo.IconVisible = true;
            this.btnNovo.IconZoom = 90D;
            this.btnNovo.IsTab = false;
            this.btnNovo.Location = new System.Drawing.Point(36, 407);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnNovo.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnNovo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnNovo.selected = false;
            this.btnNovo.Size = new System.Drawing.Size(100, 36);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "             Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Textcolor = System.Drawing.Color.Black;
            this.btnNovo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.metroLabel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroUsuario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnVoltar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGravar;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluir;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNovo;
    }
}
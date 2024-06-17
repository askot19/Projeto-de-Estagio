namespace GestaoFinanceira
{
    partial class frmLogin
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
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVersao = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.DisplayIcon = true;
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsuario.Icon = global::GestaoFinanceira.Properties.Resources.icons8_usuário_homem_com_círculo_16__2_;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(341, 156);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(223, 30);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(195, 2);
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
            this.txtPassword.Location = new System.Drawing.Point(341, 211);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(223, 30);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(341, 189);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(341, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Usuário";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(421, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Sistema";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(421, 48);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Gestão Financeira";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_impressão_digital_aceita_322;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEntrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEntrar.Location = new System.Drawing.Point(341, 295);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(223, 35);
            this.btnEntrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEntrar.UseCustomForeColor = true;
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_remover_impressão_digital_322;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSair.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSair.Location = new System.Drawing.Point(341, 336);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(223, 35);
            this.btnSair.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSair.UseSelectable = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GestaoFinanceira.Properties.Resources.Logo_Financeiro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 274);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelVersao
            // 
            this.labelVersao.AutoSize = true;
            this.labelVersao.Location = new System.Drawing.Point(531, 83);
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(0, 0);
            this.labelVersao.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 441);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.labelVersao);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Login de Acesso";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MetroFramework.Controls.MetroTextBox txtUsuario;
        protected MetroFramework.Controls.MetroTextBox txtPassword;
        protected MetroFramework.Controls.MetroLabel metroLabel1;
        protected MetroFramework.Controls.MetroLabel metroLabel2;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected MetroFramework.Controls.MetroButton btnSair;
        protected MetroFramework.Controls.MetroButton btnEntrar;
        protected MetroFramework.Controls.MetroLabel metroLabel3;
        protected MetroFramework.Controls.MetroLabel metroLabel4;
        protected MetroFramework.Controls.MetroLabel labelVersao;
    }
}
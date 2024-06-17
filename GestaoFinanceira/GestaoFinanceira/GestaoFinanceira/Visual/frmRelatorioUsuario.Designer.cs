namespace GestaoFinanceira.Visual
{
    partial class frmRelatorioUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPesquisaUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvUsuario = new MetroFramework.Controls.MetroGrid();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGerar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbGerarArquivo = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnPesquisar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaUsuario
            // 
            // 
            // 
            // 
            this.txtPesquisaUsuario.CustomButton.Image = null;
            this.txtPesquisaUsuario.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtPesquisaUsuario.CustomButton.Name = "";
            this.txtPesquisaUsuario.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPesquisaUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisaUsuario.CustomButton.TabIndex = 1;
            this.txtPesquisaUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaUsuario.CustomButton.UseSelectable = true;
            this.txtPesquisaUsuario.CustomButton.Visible = false;
            this.txtPesquisaUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisaUsuario.Lines = new string[0];
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(112, 57);
            this.txtPesquisaUsuario.MaxLength = 32767;
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.PasswordChar = '\0';
            this.txtPesquisaUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisaUsuario.SelectedText = "";
            this.txtPesquisaUsuario.SelectionLength = 0;
            this.txtPesquisaUsuario.SelectionStart = 0;
            this.txtPesquisaUsuario.ShortcutsEnabled = true;
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(546, 31);
            this.txtPesquisaUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPesquisaUsuario.TabIndex = 3;
            this.txtPesquisaUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaUsuario.UseSelectable = true;
            this.txtPesquisaUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisaUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Pesquisar";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuario.EnableHeadersVisualStyles = false;
            this.dgvUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuario.Location = new System.Drawing.Point(23, 94);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(757, 301);
            this.dgvUsuario.Style = MetroFramework.MetroColorStyle.Silver;
            this.dgvUsuario.TabIndex = 15;
            this.dgvUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellDoubleClick);
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
            this.btnVoltar.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnVoltar.Location = new System.Drawing.Point(663, 406);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVoltar.selected = false;
            this.btnVoltar.Size = new System.Drawing.Size(117, 36);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "               Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Textcolor = System.Drawing.Color.Black;
            this.btnVoltar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Active = false;
            this.btnGerar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnGerar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGerar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_instalando_atualizações_32;
            this.btnGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerar.BorderRadius = 4;
            this.btnGerar.ButtonText = "           Gerar Arquivo";
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.DisabledColor = System.Drawing.Color.Black;
            this.btnGerar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGerar.Iconimage = null;
            this.btnGerar.Iconimage_right = null;
            this.btnGerar.Iconimage_right_Selected = null;
            this.btnGerar.Iconimage_Selected = null;
            this.btnGerar.IconMarginLeft = 0;
            this.btnGerar.IconMarginRight = 0;
            this.btnGerar.IconRightVisible = true;
            this.btnGerar.IconRightZoom = 0D;
            this.btnGerar.IconVisible = true;
            this.btnGerar.IconZoom = 90D;
            this.btnGerar.IsTab = false;
            this.btnGerar.Location = new System.Drawing.Point(187, 406);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnGerar.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnGerar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGerar.selected = false;
            this.btnGerar.Size = new System.Drawing.Size(125, 36);
            this.btnGerar.TabIndex = 20;
            this.btnGerar.Text = "           Gerar Arquivo";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.Textcolor = System.Drawing.Color.Black;
            this.btnGerar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // cmbGerarArquivo
            // 
            this.cmbGerarArquivo.BackColor = System.Drawing.Color.Transparent;
            this.cmbGerarArquivo.BorderRadius = 5;
            this.cmbGerarArquivo.DisabledColor = System.Drawing.Color.Gray;
            this.cmbGerarArquivo.ForeColor = System.Drawing.Color.Black;
            this.cmbGerarArquivo.Location = new System.Drawing.Point(23, 407);
            this.cmbGerarArquivo.Name = "cmbGerarArquivo";
            this.cmbGerarArquivo.NomalColor = System.Drawing.Color.Gainsboro;
            this.cmbGerarArquivo.onHoverColor = System.Drawing.Color.Gainsboro;
            this.cmbGerarArquivo.selectedIndex = -1;
            this.cmbGerarArquivo.Size = new System.Drawing.Size(159, 35);
            this.cmbGerarArquivo.TabIndex = 21;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Active = false;
            this.btnPesquisar.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_32;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.BorderRadius = 4;
            this.btnPesquisar.ButtonText = "             Pesquisar";
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.DisabledColor = System.Drawing.Color.Black;
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
            this.btnPesquisar.Location = new System.Drawing.Point(663, 56);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnPesquisar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPesquisar.selected = false;
            this.btnPesquisar.Size = new System.Drawing.Size(117, 32);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "             Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Textcolor = System.Drawing.Color.Black;
            this.btnPesquisar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGerarArquivo);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.txtPesquisaUsuario);
            this.Controls.Add(this.metroLabel2);
            this.Name = "frmRelatorioUsuario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Formulário de Usuário";
            this.Load += new System.EventHandler(this.frmRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPesquisaUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dgvUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnVoltar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGerar;
        private Bunifu.Framework.UI.BunifuDropdown cmbGerarArquivo;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisar;
    }
}
namespace GestaoFinanceira.Visual
{
    partial class frmRelatorioCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbGerarArquivo = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnGerarArquivo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPesquisar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvCliente = new MetroFramework.Controls.MetroGrid();
            this.txtPesquisaCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
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
            this.cmbGerarArquivo.TabIndex = 28;
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Active = false;
            this.btnGerarArquivo.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnGerarArquivo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGerarArquivo.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_instalando_atualizações_32;
            this.btnGerarArquivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGerarArquivo.BorderRadius = 4;
            this.btnGerarArquivo.ButtonText = "           Gerar Arquivo";
            this.btnGerarArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarArquivo.DisabledColor = System.Drawing.Color.Black;
            this.btnGerarArquivo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGerarArquivo.Iconimage = null;
            this.btnGerarArquivo.Iconimage_right = null;
            this.btnGerarArquivo.Iconimage_right_Selected = null;
            this.btnGerarArquivo.Iconimage_Selected = null;
            this.btnGerarArquivo.IconMarginLeft = 0;
            this.btnGerarArquivo.IconMarginRight = 0;
            this.btnGerarArquivo.IconRightVisible = true;
            this.btnGerarArquivo.IconRightZoom = 0D;
            this.btnGerarArquivo.IconVisible = true;
            this.btnGerarArquivo.IconZoom = 90D;
            this.btnGerarArquivo.IsTab = false;
            this.btnGerarArquivo.Location = new System.Drawing.Point(187, 406);
            this.btnGerarArquivo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnGerarArquivo.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnGerarArquivo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGerarArquivo.selected = false;
            this.btnGerarArquivo.Size = new System.Drawing.Size(125, 36);
            this.btnGerarArquivo.TabIndex = 25;
            this.btnGerarArquivo.Text = "           Gerar Arquivo";
            this.btnGerarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerarArquivo.Textcolor = System.Drawing.Color.Black;
            this.btnGerarArquivo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
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
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "             Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Textcolor = System.Drawing.Color.Black;
            this.btnPesquisar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "               Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Textcolor = System.Drawing.Color.Black;
            this.btnVoltar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCliente.Location = new System.Drawing.Point(23, 94);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(757, 301);
            this.dgvCliente.Style = MetroFramework.MetroColorStyle.Silver;
            this.dgvCliente.TabIndex = 24;
            this.dgvCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // txtPesquisaCliente
            // 
            // 
            // 
            // 
            this.txtPesquisaCliente.CustomButton.Image = null;
            this.txtPesquisaCliente.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtPesquisaCliente.CustomButton.Name = "";
            this.txtPesquisaCliente.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPesquisaCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisaCliente.CustomButton.TabIndex = 1;
            this.txtPesquisaCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaCliente.CustomButton.UseSelectable = true;
            this.txtPesquisaCliente.CustomButton.Visible = false;
            this.txtPesquisaCliente.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisaCliente.Lines = new string[0];
            this.txtPesquisaCliente.Location = new System.Drawing.Point(112, 57);
            this.txtPesquisaCliente.MaxLength = 32767;
            this.txtPesquisaCliente.Name = "txtPesquisaCliente";
            this.txtPesquisaCliente.PasswordChar = '\0';
            this.txtPesquisaCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisaCliente.SelectedText = "";
            this.txtPesquisaCliente.SelectionLength = 0;
            this.txtPesquisaCliente.SelectionStart = 0;
            this.txtPesquisaCliente.ShortcutsEnabled = true;
            this.txtPesquisaCliente.Size = new System.Drawing.Size(546, 31);
            this.txtPesquisaCliente.Style = MetroFramework.MetroColorStyle.Red;
            this.txtPesquisaCliente.TabIndex = 22;
            this.txtPesquisaCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisaCliente.UseSelectable = true;
            this.txtPesquisaCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisaCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 25);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Pesquisar";
            // 
            // frmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGerarArquivo);
            this.Controls.Add(this.btnGerarArquivo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtPesquisaCliente);
            this.Controls.Add(this.metroLabel2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioCliente";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Relatório de Cliente";
            this.Load += new System.EventHandler(this.frmRelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown cmbGerarArquivo;
        private Bunifu.Framework.UI.BunifuFlatButton btnGerarArquivo;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisar;
        private Bunifu.Framework.UI.BunifuFlatButton btnVoltar;
        private MetroFramework.Controls.MetroGrid dgvCliente;
        private MetroFramework.Controls.MetroTextBox txtPesquisaCliente;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
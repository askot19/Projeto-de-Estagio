namespace GestaoFinanceira.Visual
{
    partial class frmRelatorio
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
            this.btnRelatorioCliente = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFormaPagto = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRelatorioUsuario = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btnRelatorioCliente
            // 
            this.btnRelatorioCliente.BackColor = System.Drawing.Color.Silver;
            this.btnRelatorioCliente.color = System.Drawing.Color.Silver;
            this.btnRelatorioCliente.colorActive = System.Drawing.Color.DarkGray;
            this.btnRelatorioCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnRelatorioCliente.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioCliente.Image = global::GestaoFinanceira.Properties.Resources.icons8_arquivo_75;
            this.btnRelatorioCliente.ImagePosition = 12;
            this.btnRelatorioCliente.ImageZoom = 50;
            this.btnRelatorioCliente.LabelPosition = 40;
            this.btnRelatorioCliente.LabelText = "CLIENTE";
            this.btnRelatorioCliente.Location = new System.Drawing.Point(285, 66);
            this.btnRelatorioCliente.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnRelatorioCliente.Name = "btnRelatorioCliente";
            this.btnRelatorioCliente.Size = new System.Drawing.Size(128, 129);
            this.btnRelatorioCliente.TabIndex = 4;
            this.btnRelatorioCliente.Click += new System.EventHandler(this.btnRelatorioCliente_Click);
            // 
            // btnFormaPagto
            // 
            this.btnFormaPagto.BackColor = System.Drawing.Color.Silver;
            this.btnFormaPagto.color = System.Drawing.Color.Silver;
            this.btnFormaPagto.colorActive = System.Drawing.Color.DarkGray;
            this.btnFormaPagto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormaPagto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnFormaPagto.ForeColor = System.Drawing.Color.White;
            this.btnFormaPagto.Image = global::GestaoFinanceira.Properties.Resources.icons8_arquivo_regular_75;
            this.btnFormaPagto.ImagePosition = 12;
            this.btnFormaPagto.ImageZoom = 50;
            this.btnFormaPagto.LabelPosition = 51;
            this.btnFormaPagto.LabelText = "Forma Pagto";
            this.btnFormaPagto.Location = new System.Drawing.Point(156, 66);
            this.btnFormaPagto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnFormaPagto.Name = "btnFormaPagto";
            this.btnFormaPagto.Size = new System.Drawing.Size(128, 129);
            this.btnFormaPagto.TabIndex = 4;
            this.btnFormaPagto.Click += new System.EventHandler(this.btnFormaPagto_Click);
            // 
            // btnRelatorioUsuario
            // 
            this.btnRelatorioUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnRelatorioUsuario.color = System.Drawing.Color.Silver;
            this.btnRelatorioUsuario.colorActive = System.Drawing.Color.DarkGray;
            this.btnRelatorioUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnRelatorioUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioUsuario.Image = global::GestaoFinanceira.Properties.Resources.icons8_documento_compartilhado_75__1_;
            this.btnRelatorioUsuario.ImagePosition = 20;
            this.btnRelatorioUsuario.ImageZoom = 50;
            this.btnRelatorioUsuario.LabelPosition = 41;
            this.btnRelatorioUsuario.LabelText = "USUÁRIO";
            this.btnRelatorioUsuario.Location = new System.Drawing.Point(26, 66);
            this.btnRelatorioUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnRelatorioUsuario.Name = "btnRelatorioUsuario";
            this.btnRelatorioUsuario.Size = new System.Drawing.Size(128, 129);
            this.btnRelatorioUsuario.TabIndex = 4;
            this.btnRelatorioUsuario.Click += new System.EventHandler(this.btnRelatorioUsuario_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.btnRelatorioCliente);
            this.Controls.Add(this.btnFormaPagto);
            this.Controls.Add(this.btnRelatorioUsuario);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorio";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Relatório";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnRelatorioUsuario;
        private Bunifu.Framework.UI.BunifuTileButton btnFormaPagto;
        private Bunifu.Framework.UI.BunifuTileButton btnRelatorioCliente;
    }
}
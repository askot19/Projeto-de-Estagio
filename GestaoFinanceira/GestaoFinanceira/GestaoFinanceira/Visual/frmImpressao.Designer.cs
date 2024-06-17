namespace GestaoFinanceira.Visual
{
    partial class frmImpressao
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
            this.btnFormaPagto = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnImpressaoCliente = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnImpressaoUsuario = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // btnFormaPagto
            // 
            this.btnFormaPagto.BackColor = System.Drawing.Color.Silver;
            this.btnFormaPagto.color = System.Drawing.Color.Silver;
            this.btnFormaPagto.colorActive = System.Drawing.Color.DarkGray;
            this.btnFormaPagto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormaPagto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.btnFormaPagto.ForeColor = System.Drawing.Color.White;
            this.btnFormaPagto.Image = global::GestaoFinanceira.Properties.Resources.icons8_adicionar_usuário_masculino_64;
            this.btnFormaPagto.ImagePosition = 10;
            this.btnFormaPagto.ImageZoom = 50;
            this.btnFormaPagto.LabelPosition = 50;
            this.btnFormaPagto.LabelText = "FORMA PAGTO";
            this.btnFormaPagto.Location = new System.Drawing.Point(155, 66);
            this.btnFormaPagto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnFormaPagto.Name = "btnFormaPagto";
            this.btnFormaPagto.Size = new System.Drawing.Size(128, 129);
            this.btnFormaPagto.TabIndex = 3;
            // 
            // btnImpressaoCliente
            // 
            this.btnImpressaoCliente.BackColor = System.Drawing.Color.Silver;
            this.btnImpressaoCliente.color = System.Drawing.Color.Silver;
            this.btnImpressaoCliente.colorActive = System.Drawing.Color.DarkGray;
            this.btnImpressaoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpressaoCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnImpressaoCliente.ForeColor = System.Drawing.Color.White;
            this.btnImpressaoCliente.Image = global::GestaoFinanceira.Properties.Resources.icons8_verifique_macho_75;
            this.btnImpressaoCliente.ImagePosition = 20;
            this.btnImpressaoCliente.ImageZoom = 50;
            this.btnImpressaoCliente.LabelPosition = 41;
            this.btnImpressaoCliente.LabelText = "CLIENTE";
            this.btnImpressaoCliente.Location = new System.Drawing.Point(284, 66);
            this.btnImpressaoCliente.Margin = new System.Windows.Forms.Padding(6);
            this.btnImpressaoCliente.Name = "btnImpressaoCliente";
            this.btnImpressaoCliente.Size = new System.Drawing.Size(128, 129);
            this.btnImpressaoCliente.TabIndex = 4;
            this.btnImpressaoCliente.Click += new System.EventHandler(this.btnImpressaoCliente_Click);
            // 
            // btnImpressaoUsuario
            // 
            this.btnImpressaoUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnImpressaoUsuario.color = System.Drawing.Color.Silver;
            this.btnImpressaoUsuario.colorActive = System.Drawing.Color.DarkGray;
            this.btnImpressaoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpressaoUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnImpressaoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnImpressaoUsuario.Image = global::GestaoFinanceira.Properties.Resources.icons8_adicionar_usuário_masculino_64;
            this.btnImpressaoUsuario.ImagePosition = 20;
            this.btnImpressaoUsuario.ImageZoom = 50;
            this.btnImpressaoUsuario.LabelPosition = 41;
            this.btnImpressaoUsuario.LabelText = "USUÁRIO";
            this.btnImpressaoUsuario.Location = new System.Drawing.Point(26, 66);
            this.btnImpressaoUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.btnImpressaoUsuario.Name = "btnImpressaoUsuario";
            this.btnImpressaoUsuario.Size = new System.Drawing.Size(128, 129);
            this.btnImpressaoUsuario.TabIndex = 5;
            this.btnImpressaoUsuario.Click += new System.EventHandler(this.btnImpressaoUsuario_Click);
            // 
            // frmImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.btnFormaPagto);
            this.Controls.Add(this.btnImpressaoCliente);
            this.Controls.Add(this.btnImpressaoUsuario);
            this.Name = "frmImpressao";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Relatório de Impressão";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnFormaPagto;
        private Bunifu.Framework.UI.BunifuTileButton btnImpressaoCliente;
        private Bunifu.Framework.UI.BunifuTileButton btnImpressaoUsuario;
    }
}
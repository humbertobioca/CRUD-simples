namespace WindowsFormsApp2
{
    partial class SistemaSenhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaSenhas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_cadastrar_senhas = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_consutar_senhas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_alterar_senhas = new System.Windows.Forms.ToolStripMenuItem();
            this.senhasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dg_senha = new System.Windows.Forms.DataGridView();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_senha)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.Menu_alterar_senhas,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_cadastrar_senhas});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastrar";
            // 
            // Menu_cadastrar_senhas
            // 
            this.Menu_cadastrar_senhas.Name = "Menu_cadastrar_senhas";
            this.Menu_cadastrar_senhas.Size = new System.Drawing.Size(180, 22);
            this.Menu_cadastrar_senhas.Text = "Senhas";
            this.Menu_cadastrar_senhas.Click += new System.EventHandler(this.Menu_cadastrar_senhas_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_consutar_senhas});
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.atualizarToolStripMenuItem.Text = "Consultar";
            // 
            // Menu_consutar_senhas
            // 
            this.Menu_consutar_senhas.Name = "Menu_consutar_senhas";
            this.Menu_consutar_senhas.Size = new System.Drawing.Size(180, 22);
            this.Menu_consutar_senhas.Text = "Senhas";
            this.Menu_consutar_senhas.Click += new System.EventHandler(this.Menu_consutar_senhas_Click);
            // 
            // Menu_alterar_senhas
            // 
            this.Menu_alterar_senhas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.senhasToolStripMenuItem2});
            this.Menu_alterar_senhas.Name = "Menu_alterar_senhas";
            this.Menu_alterar_senhas.Size = new System.Drawing.Size(54, 20);
            this.Menu_alterar_senhas.Text = "Alterar";
            // 
            // senhasToolStripMenuItem2
            // 
            this.senhasToolStripMenuItem2.Name = "senhasToolStripMenuItem2";
            this.senhasToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.senhasToolStripMenuItem2.Text = "Senhas";
            this.senhasToolStripMenuItem2.Click += new System.EventHandler(this.senhasToolStripMenuItem2_Click_1);
            // 
            // dg_senha
            // 
            this.dg_senha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_senha.Location = new System.Drawing.Point(0, 54);
            this.dg_senha.Name = "dg_senha";
            this.dg_senha.Size = new System.Drawing.Size(467, 174);
            this.dg_senha.TabIndex = 1;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(381, 27);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 2;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // SistemaSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(468, 240);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.dg_senha);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SistemaSenhas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Senhas";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_senha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_cadastrar_senhas;
        private System.Windows.Forms.ToolStripMenuItem Menu_consutar_senhas;
        private System.Windows.Forms.ToolStripMenuItem Menu_alterar_senhas;
        private System.Windows.Forms.ToolStripMenuItem senhasToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dg_senha;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}


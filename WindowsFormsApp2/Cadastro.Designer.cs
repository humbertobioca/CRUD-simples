namespace WindowsFormsApp2
{
    partial class frm_Cadastro
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
            this.lbl_jogo = new System.Windows.Forms.Label();
            this.txt_jogos = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_jogo
            // 
            this.lbl_jogo.AutoSize = true;
            this.lbl_jogo.Location = new System.Drawing.Point(44, 31);
            this.lbl_jogo.Name = "lbl_jogo";
            this.lbl_jogo.Size = new System.Drawing.Size(47, 13);
            this.lbl_jogo.TabIndex = 0;
            this.lbl_jogo.Text = "Sistema:";
            // 
            // txt_jogos
            // 
            this.txt_jogos.Location = new System.Drawing.Point(105, 28);
            this.txt_jogos.Name = "txt_jogos";
            this.txt_jogos.Size = new System.Drawing.Size(121, 20);
            this.txt_jogos.TabIndex = 1;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(105, 68);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(121, 20);
            this.txt_senha.TabIndex = 3;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(15, 71);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(84, 13);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha Utilizada:";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(29, 107);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(55, 13);
            this.lbl_categoria.TabIndex = 4;
            this.lbl_categoria.Text = "Categoria:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "JOGOS",
            "REDE SOCIAL",
            "PROGRAMAS PROGRAMAÇÃO",
            "PROGRAMAS DE COMUNICAÇÃO",
            "PROGRAMAS ÁREA DE TRABALHO"});
            this.cb_categoria.Location = new System.Drawing.Point(105, 107);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_categoria.TabIndex = 5;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(32, 161);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(151, 161);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Sair";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 209);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.txt_jogos);
            this.Controls.Add(this.lbl_jogo);
            this.Name = "frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_jogo;
        private System.Windows.Forms.TextBox txt_jogos;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}
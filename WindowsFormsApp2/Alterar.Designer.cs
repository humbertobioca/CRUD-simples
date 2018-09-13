namespace WindowsFormsApp2
{
    partial class frm_Alterar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtxAltId = new System.Windows.Forms.TextBox();
            this.txtAltNome = new System.Windows.Forms.TextBox();
            this.txtAltSenha = new System.Windows.Forms.TextBox();
            this.cbAltCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtxAltId
            // 
            this.txtxAltId.Location = new System.Drawing.Point(65, 32);
            this.txtxAltId.Name = "txtxAltId";
            this.txtxAltId.Size = new System.Drawing.Size(38, 20);
            this.txtxAltId.TabIndex = 1;
            // 
            // txtAltNome
            // 
            this.txtAltNome.Location = new System.Drawing.Point(65, 62);
            this.txtAltNome.Name = "txtAltNome";
            this.txtAltNome.Size = new System.Drawing.Size(121, 20);
            this.txtAltNome.TabIndex = 2;
            // 
            // txtAltSenha
            // 
            this.txtAltSenha.Location = new System.Drawing.Point(65, 95);
            this.txtAltSenha.Name = "txtAltSenha";
            this.txtAltSenha.Size = new System.Drawing.Size(121, 20);
            this.txtAltSenha.TabIndex = 3;
            // 
            // cbAltCategoria
            // 
            this.cbAltCategoria.FormattingEnabled = true;
            this.cbAltCategoria.Items.AddRange(new object[] {
            "JOGOS",
            "REDE SOCIAL",
            "PROGRAMAS PROGRAMAÇÃO",
            "PROGRAMAS DE COMUNICAÇÃO",
            "PROGRAMAS ÁREA DE TRABALHO"});
            this.cbAltCategoria.Location = new System.Drawing.Point(65, 129);
            this.cbAltCategoria.Name = "cbAltCategoria";
            this.cbAltCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbAltCategoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sistema:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(12, 186);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(131, 186);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // frm_Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 228);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAltCategoria);
            this.Controls.Add(this.txtAltSenha);
            this.Controls.Add(this.txtAltNome);
            this.Controls.Add(this.txtxAltId);
            this.Controls.Add(this.label1);
            this.Name = "frm_Alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtxAltId;
        private System.Windows.Forms.TextBox txtAltNome;
        private System.Windows.Forms.TextBox txtAltSenha;
        private System.Windows.Forms.ComboBox cbAltCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDeletar;
    }
}
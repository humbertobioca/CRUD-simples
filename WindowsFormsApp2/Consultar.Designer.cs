namespace WindowsFormsApp2
{
    partial class frm_Consultar
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
            this.btnSairCons = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsSenha = new System.Windows.Forms.TextBox();
            this.txtConsNome = new System.Windows.Forms.TextBox();
            this.txtconsId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSairCons
            // 
            this.btnSairCons.Location = new System.Drawing.Point(148, 177);
            this.btnSairCons.Name = "btnSairCons";
            this.btnSairCons.Size = new System.Drawing.Size(75, 23);
            this.btnSairCons.TabIndex = 19;
            this.btnSairCons.Text = "Sair";
            this.btnSairCons.UseVisualStyleBackColor = true;
            this.btnSairCons.Click += new System.EventHandler(this.btnSairCons_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(29, 177);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sistema:";
            // 
            // txtConsSenha
            // 
            this.txtConsSenha.Enabled = false;
            this.txtConsSenha.Location = new System.Drawing.Point(82, 86);
            this.txtConsSenha.Name = "txtConsSenha";
            this.txtConsSenha.Size = new System.Drawing.Size(121, 20);
            this.txtConsSenha.TabIndex = 13;
            // 
            // txtConsNome
            // 
            this.txtConsNome.Enabled = false;
            this.txtConsNome.Location = new System.Drawing.Point(82, 53);
            this.txtConsNome.Name = "txtConsNome";
            this.txtConsNome.Size = new System.Drawing.Size(121, 20);
            this.txtConsNome.TabIndex = 12;
            // 
            // txtconsId
            // 
            this.txtconsId.Location = new System.Drawing.Point(82, 23);
            this.txtconsId.Name = "txtconsId";
            this.txtconsId.Size = new System.Drawing.Size(38, 20);
            this.txtconsId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // txtConsCategoria
            // 
            this.txtConsCategoria.Enabled = false;
            this.txtConsCategoria.Location = new System.Drawing.Point(82, 120);
            this.txtConsCategoria.Name = "txtConsCategoria";
            this.txtConsCategoria.Size = new System.Drawing.Size(121, 20);
            this.txtConsCategoria.TabIndex = 20;
            // 
            // frm_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 226);
            this.Controls.Add(this.txtConsCategoria);
            this.Controls.Add(this.btnSairCons);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsSenha);
            this.Controls.Add(this.txtConsNome);
            this.Controls.Add(this.txtconsId);
            this.Controls.Add(this.label1);
            this.Name = "frm_Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairCons;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsSenha;
        private System.Windows.Forms.TextBox txtConsNome;
        private System.Windows.Forms.TextBox txtconsId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsCategoria;
    }
}
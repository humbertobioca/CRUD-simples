namespace WindowsFormsApp2
{
    partial class frm_Categoria
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
            this.btn_categoria = new System.Windows.Forms.Button();
            this.dg_categoria = new System.Windows.Forms.DataGridView();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_categoria
            // 
            this.btn_categoria.Location = new System.Drawing.Point(92, 62);
            this.btn_categoria.Name = "btn_categoria";
            this.btn_categoria.Size = new System.Drawing.Size(75, 23);
            this.btn_categoria.TabIndex = 0;
            this.btn_categoria.Text = "Adicionar";
            this.btn_categoria.UseVisualStyleBackColor = true;
            this.btn_categoria.Click += new System.EventHandler(this.btn_categoria_Click);
            // 
            // dg_categoria
            // 
            this.dg_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_categoria.Location = new System.Drawing.Point(12, 91);
            this.dg_categoria.Name = "dg_categoria";
            this.dg_categoria.Size = new System.Drawing.Size(240, 150);
            this.dg_categoria.TabIndex = 1;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(41, 36);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(177, 20);
            this.txt_categoria.TabIndex = 2;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_categoria.Location = new System.Drawing.Point(77, 20);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(101, 13);
            this.lbl_categoria.TabIndex = 3;
            this.lbl_categoria.Text = "Nome da Categoria:";
            // 
            // frm_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 252);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.dg_categoria);
            this.Controls.Add(this.btn_categoria);
            this.Name = "frm_Categoria";
            this.Text = "Cadastro de Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dg_categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_categoria;
        private System.Windows.Forms.DataGridView dg_categoria;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label lbl_categoria;
    }
}
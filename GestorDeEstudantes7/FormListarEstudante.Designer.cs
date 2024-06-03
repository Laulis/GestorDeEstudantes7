namespace GestorDeEstudantes7
{
    partial class FormListarEstudante
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
            this.GridViewListaDeAlunos = new System.Windows.Forms.DataGridView();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListaDeAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewListaDeAlunos
            // 
            this.GridViewListaDeAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewListaDeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewListaDeAlunos.Location = new System.Drawing.Point(18, 12);
            this.GridViewListaDeAlunos.Name = "GridViewListaDeAlunos";
            this.GridViewListaDeAlunos.Size = new System.Drawing.Size(770, 352);
            this.GridViewListaDeAlunos.TabIndex = 0;
            this.GridViewListaDeAlunos.DoubleClick += new System.EventHandler(this.GridViewListaDeAlunos_DoubleClick);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(46, 370);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(726, 68);
            this.buttonAtualizar.TabIndex = 1;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // FormListarEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.GridViewListaDeAlunos);
            this.Name = "FormListarEstudante";
            this.Text = "Listar Estudantes";
            this.Load += new System.EventHandler(this.FormListarEstudante_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListaDeAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewListaDeAlunos;
        private System.Windows.Forms.Button buttonAtualizar;
    }
}
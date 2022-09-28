namespace pryDoloresBibloteca
{
    partial class frmBibloteca
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblDistribuidor = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtCodigoEd = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtCodigoDist = new System.Windows.Forms.TextBox();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(12, 76);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(90, 13);
            this.lblNombreLibro.TabIndex = 1;
            this.lblNombreLibro.Text = "Nombre del Libro:";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Location = new System.Drawing.Point(12, 114);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(98, 13);
            this.lblCodigoEditorial.TabIndex = 2;
            this.lblCodigoEditorial.Text = "Codigo de Editorial:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 152);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(88, 13);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Codigo del Autor:";
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.Location = new System.Drawing.Point(12, 190);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(112, 13);
            this.lblDistribuidor.TabIndex = 4;
            this.lblDistribuidor.Text = "Codigo del Distribuidor";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(129, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Enabled = false;
            this.txtNombreLibro.Location = new System.Drawing.Point(129, 73);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLibro.TabIndex = 6;
            // 
            // txtCodigoEd
            // 
            this.txtCodigoEd.Enabled = false;
            this.txtCodigoEd.Location = new System.Drawing.Point(129, 111);
            this.txtCodigoEd.Name = "txtCodigoEd";
            this.txtCodigoEd.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEd.TabIndex = 7;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Enabled = false;
            this.txtCodigoAutor.Location = new System.Drawing.Point(129, 149);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAutor.TabIndex = 8;
            // 
            // txtCodigoDist
            // 
            this.txtCodigoDist.Enabled = false;
            this.txtCodigoDist.Location = new System.Drawing.Point(129, 187);
            this.txtCodigoDist.Name = "txtCodigoDist";
            this.txtCodigoDist.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDist.TabIndex = 9;
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(155, 233);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(75, 23);
            this.btnAdelante.TabIndex = 10;
            this.btnAdelante.Text = ">>>>";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 233);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "<<<<";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // frmBibloteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 271);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.txtCodigoDist);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtCodigoEd);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDistribuidor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmBibloteca";
            this.Text = "Consulta libros";
            this.Load += new System.EventHandler(this.frmBibloteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtCodigoEd;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.TextBox txtCodigoDist;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAtras;
    }
}
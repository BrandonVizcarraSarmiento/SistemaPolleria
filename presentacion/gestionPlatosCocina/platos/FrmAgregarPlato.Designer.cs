namespace SistemaPolleria.presentacion.gestionPlatosCocina.platos
{
    partial class FrmAgregarPlato
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePlato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionPlato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioPlato = new System.Windows.Forms.TextBox();
            this.btnCancelarPlato = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarPlato = new FontAwesome.Sharp.IconButton();
            this.btnGuardarPlato = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(112, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Agregar Plato";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombrePlato
            // 
            this.txtNombrePlato.Location = new System.Drawing.Point(52, 108);
            this.txtNombrePlato.Name = "txtNombrePlato";
            this.txtNombrePlato.Size = new System.Drawing.Size(292, 20);
            this.txtNombrePlato.TabIndex = 52;
            this.txtNombrePlato.TextChanged += new System.EventHandler(this.txtNombrePlato_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Descripción ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDescripcionPlato
            // 
            this.txtDescripcionPlato.Location = new System.Drawing.Point(52, 164);
            this.txtDescripcionPlato.Name = "txtDescripcionPlato";
            this.txtDescripcionPlato.Size = new System.Drawing.Size(292, 20);
            this.txtDescripcionPlato.TabIndex = 54;
            this.txtDescripcionPlato.TextChanged += new System.EventHandler(this.txtDescripcionPlato_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Precio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrecioPlato
            // 
            this.txtPrecioPlato.Location = new System.Drawing.Point(55, 225);
            this.txtPrecioPlato.Name = "txtPrecioPlato";
            this.txtPrecioPlato.Size = new System.Drawing.Size(82, 20);
            this.txtPrecioPlato.TabIndex = 56;
            this.txtPrecioPlato.TextChanged += new System.EventHandler(this.txtPrecioPlato_TextChanged);
            // 
            // btnCancelarPlato
            // 
            this.btnCancelarPlato.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPlato.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPlato.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPlato.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelarPlato.IconColor = System.Drawing.Color.White;
            this.btnCancelarPlato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarPlato.IconSize = 21;
            this.btnCancelarPlato.Location = new System.Drawing.Point(243, 261);
            this.btnCancelarPlato.Name = "btnCancelarPlato";
            this.btnCancelarPlato.Size = new System.Drawing.Size(81, 33);
            this.btnCancelarPlato.TabIndex = 60;
            this.btnCancelarPlato.Text = "Cancelar";
            this.btnCancelarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPlato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarPlato.UseVisualStyleBackColor = false;
            this.btnCancelarPlato.Click += new System.EventHandler(this.btnCancelarPlato_Click);
            // 
            // btnLimpiarPlato
            // 
            this.btnLimpiarPlato.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarPlato.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarPlato.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarPlato.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarPlato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarPlato.IconSize = 21;
            this.btnLimpiarPlato.Location = new System.Drawing.Point(156, 261);
            this.btnLimpiarPlato.Name = "btnLimpiarPlato";
            this.btnLimpiarPlato.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarPlato.TabIndex = 59;
            this.btnLimpiarPlato.Text = "Limpiar";
            this.btnLimpiarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarPlato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarPlato.UseVisualStyleBackColor = false;
            this.btnLimpiarPlato.Click += new System.EventHandler(this.btnLimpiarPlato_Click);
            // 
            // btnGuardarPlato
            // 
            this.btnGuardarPlato.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPlato.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarPlato.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarPlato.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarPlato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPlato.IconSize = 21;
            this.btnGuardarPlato.Location = new System.Drawing.Point(69, 261);
            this.btnGuardarPlato.Name = "btnGuardarPlato";
            this.btnGuardarPlato.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarPlato.TabIndex = 58;
            this.btnGuardarPlato.Text = "Guardar";
            this.btnGuardarPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPlato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPlato.UseVisualStyleBackColor = false;
            this.btnGuardarPlato.Click += new System.EventHandler(this.btnGuardarPlato_Click);
            // 
            // FrmAgregarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 339);
            this.Controls.Add(this.btnCancelarPlato);
            this.Controls.Add(this.btnLimpiarPlato);
            this.Controls.Add(this.btnGuardarPlato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioPlato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcionPlato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombrePlato);
            this.Controls.Add(this.label2);
            this.Name = "FrmAgregarPlato";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionPlato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioPlato;
        private FontAwesome.Sharp.IconButton btnCancelarPlato;
        private FontAwesome.Sharp.IconButton btnLimpiarPlato;
        private FontAwesome.Sharp.IconButton btnGuardarPlato;
    }
}
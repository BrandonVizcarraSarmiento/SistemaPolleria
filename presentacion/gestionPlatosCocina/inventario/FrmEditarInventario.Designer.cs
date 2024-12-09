namespace SistemaPolleria.presentacion.gestionPlatosCocina.inventario
{
    partial class FrmEditarInventario
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
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtNombreIngrediente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboIngredienteID = new System.Windows.Forms.ComboBox();
            this.btnCancelarInventario = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarInventario = new FontAwesome.Sharp.IconButton();
            this.btnGuardarInventario = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(254, 102);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 85;
            // 
            // txtNombreIngrediente
            // 
            this.txtNombreIngrediente.Location = new System.Drawing.Point(112, 149);
            this.txtNombreIngrediente.Name = "txtNombreIngrediente";
            this.txtNombreIngrediente.Size = new System.Drawing.Size(262, 20);
            this.txtNombreIngrediente.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Unidad Medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Cantidad Actual";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(112, 199);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadMedida.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Nombre del Ingrediente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Ingrediente ID";
            // 
            // cboIngredienteID
            // 
            this.cboIngredienteID.FormattingEnabled = true;
            this.cboIngredienteID.Location = new System.Drawing.Point(109, 102);
            this.cboIngredienteID.Name = "cboIngredienteID";
            this.cboIngredienteID.Size = new System.Drawing.Size(121, 21);
            this.cboIngredienteID.TabIndex = 78;
            this.cboIngredienteID.SelectedIndexChanged += new System.EventHandler(this.cboIngredienteID_SelectedIndexChanged);
            // 
            // btnCancelarInventario
            // 
            this.btnCancelarInventario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarInventario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarInventario.ForeColor = System.Drawing.Color.White;
            this.btnCancelarInventario.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelarInventario.IconColor = System.Drawing.Color.White;
            this.btnCancelarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarInventario.IconSize = 21;
            this.btnCancelarInventario.Location = new System.Drawing.Point(273, 250);
            this.btnCancelarInventario.Name = "btnCancelarInventario";
            this.btnCancelarInventario.Size = new System.Drawing.Size(81, 33);
            this.btnCancelarInventario.TabIndex = 77;
            this.btnCancelarInventario.Text = "Cancelar";
            this.btnCancelarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarInventario.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarInventario
            // 
            this.btnLimpiarInventario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarInventario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarInventario.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarInventario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarInventario.IconSize = 21;
            this.btnLimpiarInventario.Location = new System.Drawing.Point(186, 250);
            this.btnLimpiarInventario.Name = "btnLimpiarInventario";
            this.btnLimpiarInventario.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarInventario.TabIndex = 76;
            this.btnLimpiarInventario.Text = "Limpiar";
            this.btnLimpiarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarInventario.UseVisualStyleBackColor = false;
            // 
            // btnGuardarInventario
            // 
            this.btnGuardarInventario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarInventario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarInventario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarInventario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarInventario.IconSize = 21;
            this.btnGuardarInventario.Location = new System.Drawing.Point(99, 250);
            this.btnGuardarInventario.Name = "btnGuardarInventario";
            this.btnGuardarInventario.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarInventario.TabIndex = 75;
            this.btnGuardarInventario.Text = "Editar";
            this.btnGuardarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarInventario.UseVisualStyleBackColor = false;
            this.btnGuardarInventario.Click += new System.EventHandler(this.btnGuardarInventario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(136, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "Editar Inventario";
            // 
            // FrmEditarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 356);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtNombreIngrediente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIngredienteID);
            this.Controls.Add(this.btnCancelarInventario);
            this.Controls.Add(this.btnLimpiarInventario);
            this.Controls.Add(this.btnGuardarInventario);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditarInventario";
            this.Text = "FrmEditarInventario";
            this.Load += new System.EventHandler(this.FrmEditarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtNombreIngrediente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboIngredienteID;
        private FontAwesome.Sharp.IconButton btnCancelarInventario;
        private FontAwesome.Sharp.IconButton btnLimpiarInventario;
        private FontAwesome.Sharp.IconButton btnGuardarInventario;
        private System.Windows.Forms.Label label2;
    }
}
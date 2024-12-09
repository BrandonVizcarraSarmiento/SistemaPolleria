namespace SistemaPolleria.presentacion.gestionPlatosCocina.ingredientesporplato
{
    partial class FrmEditarIngredientePorPlato
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
            this.btnCancelarIngredienteporPlato = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarIngredienteporPlato = new FontAwesome.Sharp.IconButton();
            this.btnGuardarIngredienteporPlato = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboIngredienteID = new System.Windows.Forms.ComboBox();
            this.cboPlatoID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(206, 224);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 71;
            // 
            // btnCancelarIngredienteporPlato
            // 
            this.btnCancelarIngredienteporPlato.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelarIngredienteporPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarIngredienteporPlato.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarIngredienteporPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarIngredienteporPlato.ForeColor = System.Drawing.Color.White;
            this.btnCancelarIngredienteporPlato.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelarIngredienteporPlato.IconColor = System.Drawing.Color.White;
            this.btnCancelarIngredienteporPlato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarIngredienteporPlato.IconSize = 21;
            this.btnCancelarIngredienteporPlato.Location = new System.Drawing.Point(308, 266);
            this.btnCancelarIngredienteporPlato.Name = "btnCancelarIngredienteporPlato";
            this.btnCancelarIngredienteporPlato.Size = new System.Drawing.Size(81, 33);
            this.btnCancelarIngredienteporPlato.TabIndex = 70;
            this.btnCancelarIngredienteporPlato.Text = "Cancelar";
            this.btnCancelarIngredienteporPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarIngredienteporPlato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarIngredienteporPlato.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarIngredienteporPlato
            // 
            this.btnLimpiarIngredienteporPlato.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarIngredienteporPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarIngredienteporPlato.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarIngredienteporPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarIngredienteporPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarIngredienteporPlato.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarIngredienteporPlato.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarIngredienteporPlato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarIngredienteporPlato.IconSize = 21;
            this.btnLimpiarIngredienteporPlato.Location = new System.Drawing.Point(221, 266);
            this.btnLimpiarIngredienteporPlato.Name = "btnLimpiarIngredienteporPlato";
            this.btnLimpiarIngredienteporPlato.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiarIngredienteporPlato.TabIndex = 69;
            this.btnLimpiarIngredienteporPlato.Text = "Limpiar";
            this.btnLimpiarIngredienteporPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarIngredienteporPlato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarIngredienteporPlato.UseVisualStyleBackColor = false;
            // 
            // btnGuardarIngredienteporPlato
            // 
            this.btnGuardarIngredienteporPlato.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnGuardarIngredienteporPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarIngredienteporPlato.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarIngredienteporPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIngredienteporPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarIngredienteporPlato.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnGuardarIngredienteporPlato.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarIngredienteporPlato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarIngredienteporPlato.IconSize = 21;
            this.btnGuardarIngredienteporPlato.Location = new System.Drawing.Point(134, 266);
            this.btnGuardarIngredienteporPlato.Name = "btnGuardarIngredienteporPlato";
            this.btnGuardarIngredienteporPlato.Size = new System.Drawing.Size(81, 33);
            this.btnGuardarIngredienteporPlato.TabIndex = 68;
            this.btnGuardarIngredienteporPlato.Text = "Editar";
            this.btnGuardarIngredienteporPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarIngredienteporPlato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarIngredienteporPlato.UseVisualStyleBackColor = false;
            this.btnGuardarIngredienteporPlato.Click += new System.EventHandler(this.btnGuardarIngredienteporPlato_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Cantidad Necesaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ingrediente ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Plaato ID";
            // 
            // cboIngredienteID
            // 
            this.cboIngredienteID.FormattingEnabled = true;
            this.cboIngredienteID.Location = new System.Drawing.Point(305, 130);
            this.cboIngredienteID.Name = "cboIngredienteID";
            this.cboIngredienteID.Size = new System.Drawing.Size(121, 21);
            this.cboIngredienteID.TabIndex = 64;
            // 
            // cboPlatoID
            // 
            this.cboPlatoID.FormattingEnabled = true;
            this.cboPlatoID.Location = new System.Drawing.Point(101, 130);
            this.cboPlatoID.Name = "cboPlatoID";
            this.cboPlatoID.Size = new System.Drawing.Size(121, 21);
            this.cboPlatoID.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(140, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "Editar Ingrediente por Plato";
            // 
            // FrmEditarIngredientePorPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 351);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnCancelarIngredienteporPlato);
            this.Controls.Add(this.btnLimpiarIngredienteporPlato);
            this.Controls.Add(this.btnGuardarIngredienteporPlato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboIngredienteID);
            this.Controls.Add(this.cboPlatoID);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditarIngredientePorPlato";
            this.Text = "FrmEditarIngredientePorPlato";
            this.Load += new System.EventHandler(this.FrmEditarIngredientePorPlato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCantidad;
        private FontAwesome.Sharp.IconButton btnCancelarIngredienteporPlato;
        private FontAwesome.Sharp.IconButton btnLimpiarIngredienteporPlato;
        private FontAwesome.Sharp.IconButton btnGuardarIngredienteporPlato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboIngredienteID;
        private System.Windows.Forms.ComboBox cboPlatoID;
        private System.Windows.Forms.Label label2;
    }
}
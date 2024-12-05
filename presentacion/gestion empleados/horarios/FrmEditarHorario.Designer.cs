namespace SistemaPolleria.presentacion.gestion_empleados.horarios
{
    partial class FrmEditarHorario
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
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHoraFinHorario = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicioHorario = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnEditarHorario = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cboDiaSemana.Location = new System.Drawing.Point(52, 133);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(254, 21);
            this.cboDiaSemana.TabIndex = 88;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(52, 94);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(254, 21);
            this.cboEmpleado.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(178, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(49, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Inicio";
            // 
            // dtpHoraFinHorario
            // 
            this.dtpHoraFinHorario.CustomFormat = "";
            this.dtpHoraFinHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinHorario.Location = new System.Drawing.Point(181, 172);
            this.dtpHoraFinHorario.MinDate = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            this.dtpHoraFinHorario.Name = "dtpHoraFinHorario";
            this.dtpHoraFinHorario.ShowUpDown = true;
            this.dtpHoraFinHorario.Size = new System.Drawing.Size(126, 20);
            this.dtpHoraFinHorario.TabIndex = 84;
            // 
            // dtpHoraInicioHorario
            // 
            this.dtpHoraInicioHorario.CustomFormat = "";
            this.dtpHoraInicioHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicioHorario.Location = new System.Drawing.Point(52, 172);
            this.dtpHoraInicioHorario.Name = "dtpHoraInicioHorario";
            this.dtpHoraInicioHorario.ShowUpDown = true;
            this.dtpHoraInicioHorario.Size = new System.Drawing.Size(123, 20);
            this.dtpHoraInicioHorario.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(90, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 82;
            this.label2.Text = "Editar Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(49, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Nombre del empleado";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDia.Location = new System.Drawing.Point(49, 117);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(89, 13);
            this.lblDia.TabIndex = 80;
            this.lblDia.Text = "Dia de la semana";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 21;
            this.btnCancelar.Location = new System.Drawing.Point(226, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 33);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 21;
            this.btnLimpiar.Location = new System.Drawing.Point(139, 225);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 33);
            this.btnLimpiar.TabIndex = 78;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEditarHorario
            // 
            this.btnEditarHorario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarHorario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarHorario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarHorario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarHorario.IconSize = 21;
            this.btnEditarHorario.Location = new System.Drawing.Point(52, 225);
            this.btnEditarHorario.Name = "btnEditarHorario";
            this.btnEditarHorario.Size = new System.Drawing.Size(81, 33);
            this.btnEditarHorario.TabIndex = 77;
            this.btnEditarHorario.Text = "Editar";
            this.btnEditarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarHorario.UseVisualStyleBackColor = false;
            this.btnEditarHorario.Click += new System.EventHandler(this.btnEditarHorario_Click);
            // 
            // FrmEditarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 291);
            this.Controls.Add(this.cboDiaSemana);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHoraFinHorario);
            this.Controls.Add(this.dtpHoraInicioHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditarHorario);
            this.Name = "FrmEditarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarHorario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDiaSemana;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHoraFinHorario;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDia;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEditarHorario;
    }
}
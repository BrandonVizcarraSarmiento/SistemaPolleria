namespace SistemaPolleria.presentacion.gestion_empleados.turnos
{
    partial class FrmEditarTurno
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
            this.cboNombreTurno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHoraFinTurno = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicioTurno = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnEditarTurno = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // cboNombreTurno
            // 
            this.cboNombreTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreTurno.FormattingEnabled = true;
            this.cboNombreTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche",
            "Mediodia",
            "Temprano"});
            this.cboNombreTurno.Location = new System.Drawing.Point(57, 101);
            this.cboNombreTurno.Name = "cboNombreTurno";
            this.cboNombreTurno.Size = new System.Drawing.Size(254, 21);
            this.cboNombreTurno.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(183, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(54, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Inicio";
            // 
            // dtpHoraFinTurno
            // 
            this.dtpHoraFinTurno.CustomFormat = "";
            this.dtpHoraFinTurno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinTurno.Location = new System.Drawing.Point(185, 140);
            this.dtpHoraFinTurno.MinDate = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            this.dtpHoraFinTurno.Name = "dtpHoraFinTurno";
            this.dtpHoraFinTurno.ShowUpDown = true;
            this.dtpHoraFinTurno.Size = new System.Drawing.Size(126, 20);
            this.dtpHoraFinTurno.TabIndex = 95;
            // 
            // dtpHoraInicioTurno
            // 
            this.dtpHoraInicioTurno.CustomFormat = "";
            this.dtpHoraInicioTurno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicioTurno.Location = new System.Drawing.Point(57, 140);
            this.dtpHoraInicioTurno.Name = "dtpHoraInicioTurno";
            this.dtpHoraInicioTurno.ShowUpDown = true;
            this.dtpHoraInicioTurno.Size = new System.Drawing.Size(123, 20);
            this.dtpHoraInicioTurno.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(99, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 93;
            this.label7.Text = "Editar Turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(54, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Nombre de turno";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 21;
            this.iconButton1.Location = new System.Drawing.Point(231, 193);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(81, 33);
            this.iconButton1.TabIndex = 91;
            this.iconButton1.Text = "Cancelar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 21;
            this.iconButton2.Location = new System.Drawing.Point(144, 193);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(81, 33);
            this.iconButton2.TabIndex = 90;
            this.iconButton2.Text = "Limpiar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnEditarTurno
            // 
            this.btnEditarTurno.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarTurno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarTurno.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarTurno.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarTurno.IconSize = 21;
            this.btnEditarTurno.Location = new System.Drawing.Point(57, 193);
            this.btnEditarTurno.Name = "btnEditarTurno";
            this.btnEditarTurno.Size = new System.Drawing.Size(81, 33);
            this.btnEditarTurno.TabIndex = 89;
            this.btnEditarTurno.Text = "Editar";
            this.btnEditarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarTurno.UseVisualStyleBackColor = false;
            this.btnEditarTurno.Click += new System.EventHandler(this.btnEditarTurno_Click);
            // 
            // FrmEditarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 271);
            this.Controls.Add(this.cboNombreTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHoraFinTurno);
            this.Controls.Add(this.dtpHoraInicioTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnEditarTurno);
            this.Name = "FrmEditarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarTurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNombreTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHoraFinTurno;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioTurno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnEditarTurno;
    }
}
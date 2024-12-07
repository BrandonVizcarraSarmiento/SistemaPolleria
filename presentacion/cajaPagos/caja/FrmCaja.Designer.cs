namespace SistemaPolleria.presentacion.cajaPagos.caja
{
    partial class FrmCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCaja = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoCaja = new FontAwesome.Sharp.IconButton();
            this.btnEditarCaja = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCaja = new FontAwesome.Sharp.IconButton();
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.panelBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscar.Controls.Add(this.btnLimpiar);
            this.panelBuscar.Controls.Add(this.dtpFechaFin);
            this.panelBuscar.Controls.Add(this.dtpFechaInicio);
            this.panelBuscar.Controls.Add(this.btnBuscarCaja);
            this.panelBuscar.Location = new System.Drawing.Point(165, 12);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(438, 47);
            this.panelBuscar.TabIndex = 43;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(181, 13);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(160, 20);
            this.dtpFechaFin.TabIndex = 92;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(17, 13);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(160, 20);
            this.dtpFechaInicio.TabIndex = 91;
            // 
            // btnBuscarCaja
            // 
            this.btnBuscarCaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarCaja.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCaja.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCaja.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCaja.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCaja.IconSize = 21;
            this.btnBuscarCaja.Location = new System.Drawing.Point(347, 13);
            this.btnBuscarCaja.Name = "btnBuscarCaja";
            this.btnBuscarCaja.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarCaja.TabIndex = 11;
            this.btnBuscarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCaja.UseVisualStyleBackColor = false;
            this.btnBuscarCaja.Click += new System.EventHandler(this.btnBuscarCaja_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoCaja);
            this.panel3.Controls.Add(this.btnEditarCaja);
            this.panel3.Controls.Add(this.btnEliminarCaja);
            this.panel3.Location = new System.Drawing.Point(237, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 42;
            // 
            // btnNuevoCaja
            // 
            this.btnNuevoCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoCaja.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCaja.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCaja.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoCaja.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoCaja.IconSize = 21;
            this.btnNuevoCaja.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoCaja.Name = "btnNuevoCaja";
            this.btnNuevoCaja.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoCaja.TabIndex = 8;
            this.btnNuevoCaja.Text = "Nuevo";
            this.btnNuevoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCaja.UseVisualStyleBackColor = false;
            this.btnNuevoCaja.Click += new System.EventHandler(this.btnNuevoCaja_Click);
            // 
            // btnEditarCaja
            // 
            this.btnEditarCaja.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarCaja.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCaja.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCaja.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarCaja.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCaja.IconSize = 21;
            this.btnEditarCaja.Location = new System.Drawing.Point(108, 17);
            this.btnEditarCaja.Name = "btnEditarCaja";
            this.btnEditarCaja.Size = new System.Drawing.Size(81, 33);
            this.btnEditarCaja.TabIndex = 10;
            this.btnEditarCaja.Text = "Editar";
            this.btnEditarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCaja.UseVisualStyleBackColor = false;
            this.btnEditarCaja.Click += new System.EventHandler(this.btnEditarCaja_Click);
            // 
            // btnEliminarCaja
            // 
            this.btnEliminarCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCaja.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCaja.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCaja.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarCaja.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCaja.IconSize = 21;
            this.btnEliminarCaja.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarCaja.Name = "btnEliminarCaja";
            this.btnEliminarCaja.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarCaja.TabIndex = 9;
            this.btnEliminarCaja.Text = "Eliminar";
            this.btnEliminarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCaja.UseVisualStyleBackColor = false;
            this.btnEliminarCaja.Click += new System.EventHandler(this.btnEliminarCaja_Click);
            // 
            // dgvCaja
            // 
            this.dgvCaja.AllowUserToAddRows = false;
            this.dgvCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCaja.ColumnHeadersHeight = 30;
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaja.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCaja.EnableHeadersVisualStyles = false;
            this.dgvCaja.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCaja.Location = new System.Drawing.Point(72, 64);
            this.dgvCaja.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.ReadOnly = true;
            this.dgvCaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCaja.RowHeadersWidth = 51;
            this.dgvCaja.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvCaja.RowTemplate.Height = 24;
            this.dgvCaja.Size = new System.Drawing.Size(657, 316);
            this.dgvCaja.TabIndex = 41;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 21;
            this.btnLimpiar.Location = new System.Drawing.Point(388, 13);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(35, 20);
            this.btnLimpiar.TabIndex = 93;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaja";
            this.Text = "FrmCaja";
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            this.panelBuscar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscar;
        private FontAwesome.Sharp.IconButton btnBuscarCaja;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoCaja;
        private FontAwesome.Sharp.IconButton btnEditarCaja;
        private FontAwesome.Sharp.IconButton btnEliminarCaja;
        private System.Windows.Forms.DataGridView dgvCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}
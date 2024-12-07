namespace SistemaPolleria.presentacion.gestion_empleados.turnos
{
    partial class FrmTurno
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
            this.panelBuscarCargos = new System.Windows.Forms.Panel();
            this.txtBuscarTurno = new System.Windows.Forms.TextBox();
            this.btnBuscarTurno = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoTurno = new FontAwesome.Sharp.IconButton();
            this.btnEditarTurno = new FontAwesome.Sharp.IconButton();
            this.btnEliminarTurno = new FontAwesome.Sharp.IconButton();
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.panelBuscarCargos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscarCargos
            // 
            this.panelBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarCargos.Controls.Add(this.txtBuscarTurno);
            this.panelBuscarCargos.Controls.Add(this.btnBuscarTurno);
            this.panelBuscarCargos.Location = new System.Drawing.Point(260, 12);
            this.panelBuscarCargos.Name = "panelBuscarCargos";
            this.panelBuscarCargos.Size = new System.Drawing.Size(247, 47);
            this.panelBuscarCargos.TabIndex = 37;
            // 
            // txtBuscarTurno
            // 
            this.txtBuscarTurno.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarTurno.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarTurno.Name = "txtBuscarTurno";
            this.txtBuscarTurno.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarTurno.TabIndex = 12;
            // 
            // btnBuscarTurno
            // 
            this.btnBuscarTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarTurno.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarTurno.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarTurno.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarTurno.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarTurno.IconSize = 21;
            this.btnBuscarTurno.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarTurno.Name = "btnBuscarTurno";
            this.btnBuscarTurno.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarTurno.TabIndex = 11;
            this.btnBuscarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTurno.UseVisualStyleBackColor = false;
            this.btnBuscarTurno.Click += new System.EventHandler(this.btnBuscarTurno_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoTurno);
            this.panel3.Controls.Add(this.btnEditarTurno);
            this.panel3.Controls.Add(this.btnEliminarTurno);
            this.panel3.Location = new System.Drawing.Point(231, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 36;
            // 
            // btnNuevoTurno
            // 
            this.btnNuevoTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoTurno.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoTurno.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoTurno.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoTurno.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoTurno.IconSize = 21;
            this.btnNuevoTurno.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoTurno.Name = "btnNuevoTurno";
            this.btnNuevoTurno.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoTurno.TabIndex = 8;
            this.btnNuevoTurno.Text = "Nuevo";
            this.btnNuevoTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoTurno.UseVisualStyleBackColor = false;
            this.btnNuevoTurno.Click += new System.EventHandler(this.btnNuevoTurno_Click);
            // 
            // btnEditarTurno
            // 
            this.btnEditarTurno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarTurno.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarTurno.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarTurno.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarTurno.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarTurno.IconSize = 21;
            this.btnEditarTurno.Location = new System.Drawing.Point(108, 17);
            this.btnEditarTurno.Name = "btnEditarTurno";
            this.btnEditarTurno.Size = new System.Drawing.Size(81, 33);
            this.btnEditarTurno.TabIndex = 10;
            this.btnEditarTurno.Text = "Editar";
            this.btnEditarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarTurno.UseVisualStyleBackColor = false;
            this.btnEditarTurno.Click += new System.EventHandler(this.btnEditarTurno_Click);
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarTurno.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTurno.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTurno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTurno.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarTurno.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarTurno.IconSize = 21;
            this.btnEliminarTurno.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarTurno.TabIndex = 9;
            this.btnEliminarTurno.Text = "Eliminar";
            this.btnEliminarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarTurno.UseVisualStyleBackColor = false;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // dgvTurno
            // 
            this.dgvTurno.AllowUserToAddRows = false;
            this.dgvTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTurno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTurno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTurno.ColumnHeadersHeight = 30;
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurno.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTurno.EnableHeadersVisualStyles = false;
            this.dgvTurno.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTurno.Location = new System.Drawing.Point(72, 64);
            this.dgvTurno.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.ReadOnly = true;
            this.dgvTurno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurno.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTurno.RowHeadersWidth = 51;
            this.dgvTurno.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvTurno.RowTemplate.Height = 24;
            this.dgvTurno.Size = new System.Drawing.Size(657, 326);
            this.dgvTurno.TabIndex = 35;
            // 
            // FrmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.panelBuscarCargos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvTurno);
            this.Name = "FrmTurno";
            this.Text = "FrmTurno";
            this.Load += new System.EventHandler(this.FrmTurno_Load);
            this.panelBuscarCargos.ResumeLayout(false);
            this.panelBuscarCargos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscarCargos;
        private System.Windows.Forms.TextBox txtBuscarTurno;
        private FontAwesome.Sharp.IconButton btnBuscarTurno;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoTurno;
        private FontAwesome.Sharp.IconButton btnEditarTurno;
        private FontAwesome.Sharp.IconButton btnEliminarTurno;
        private System.Windows.Forms.DataGridView dgvTurno;
    }
}
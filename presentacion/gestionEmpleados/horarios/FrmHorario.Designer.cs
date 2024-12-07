namespace SistemaPolleria.presentacion.gestion_empleados.horarios
{
    partial class FrmHorario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBuscarCargos = new System.Windows.Forms.Panel();
            this.txtBuscarHorario = new System.Windows.Forms.TextBox();
            this.btnBuscarHorario = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoHorario = new FontAwesome.Sharp.IconButton();
            this.btnEditarHorario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarHorario = new FontAwesome.Sharp.IconButton();
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.panelBuscarCargos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscarCargos
            // 
            this.panelBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarCargos.Controls.Add(this.txtBuscarHorario);
            this.panelBuscarCargos.Controls.Add(this.btnBuscarHorario);
            this.panelBuscarCargos.Location = new System.Drawing.Point(277, 6);
            this.panelBuscarCargos.Name = "panelBuscarCargos";
            this.panelBuscarCargos.Size = new System.Drawing.Size(247, 47);
            this.panelBuscarCargos.TabIndex = 34;
            // 
            // txtBuscarHorario
            // 
            this.txtBuscarHorario.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarHorario.Name = "txtBuscarHorario";
            this.txtBuscarHorario.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarHorario.TabIndex = 12;
            // 
            // btnBuscarHorario
            // 
            this.btnBuscarHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarHorario.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarHorario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarHorario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarHorario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarHorario.IconSize = 21;
            this.btnBuscarHorario.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarHorario.Name = "btnBuscarHorario";
            this.btnBuscarHorario.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarHorario.TabIndex = 11;
            this.btnBuscarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarHorario.UseVisualStyleBackColor = false;
            this.btnBuscarHorario.Click += new System.EventHandler(this.btnBuscarHorario_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoHorario);
            this.panel3.Controls.Add(this.btnEditarHorario);
            this.panel3.Controls.Add(this.btnEliminarHorario);
            this.panel3.Location = new System.Drawing.Point(248, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 33;
            // 
            // btnNuevoHorario
            // 
            this.btnNuevoHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoHorario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoHorario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoHorario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoHorario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoHorario.IconSize = 21;
            this.btnNuevoHorario.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoHorario.Name = "btnNuevoHorario";
            this.btnNuevoHorario.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoHorario.TabIndex = 8;
            this.btnNuevoHorario.Text = "Nuevo";
            this.btnNuevoHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoHorario.UseVisualStyleBackColor = false;
            this.btnNuevoHorario.Click += new System.EventHandler(this.btnNuevoHorario_Click);
            // 
            // btnEditarHorario
            // 
            this.btnEditarHorario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarHorario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarHorario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarHorario.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarHorario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarHorario.IconSize = 21;
            this.btnEditarHorario.Location = new System.Drawing.Point(108, 17);
            this.btnEditarHorario.Name = "btnEditarHorario";
            this.btnEditarHorario.Size = new System.Drawing.Size(81, 33);
            this.btnEditarHorario.TabIndex = 10;
            this.btnEditarHorario.Text = "Editar";
            this.btnEditarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarHorario.UseVisualStyleBackColor = false;
            this.btnEditarHorario.Click += new System.EventHandler(this.btnEditarHorario_Click);
            // 
            // btnEliminarHorario
            // 
            this.btnEliminarHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarHorario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarHorario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarHorario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarHorario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarHorario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarHorario.IconSize = 21;
            this.btnEliminarHorario.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarHorario.Name = "btnEliminarHorario";
            this.btnEliminarHorario.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarHorario.TabIndex = 9;
            this.btnEliminarHorario.Text = "Eliminar";
            this.btnEliminarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarHorario.UseVisualStyleBackColor = false;
            this.btnEliminarHorario.Click += new System.EventHandler(this.btnEliminarHorario_Click);
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvHorario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHorario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvHorario.ColumnHeadersHeight = 30;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorario.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvHorario.EnableHeadersVisualStyles = false;
            this.dgvHorario.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvHorario.Location = new System.Drawing.Point(89, 58);
            this.dgvHorario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.ReadOnly = true;
            this.dgvHorario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHorario.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvHorario.RowHeadersWidth = 51;
            this.dgvHorario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvHorario.RowTemplate.Height = 24;
            this.dgvHorario.Size = new System.Drawing.Size(657, 334);
            this.dgvHorario.TabIndex = 32;
            // 
            // FrmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 469);
            this.Controls.Add(this.panelBuscarCargos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHorario";
            this.Load += new System.EventHandler(this.FrmHorario_Load);
            this.panelBuscarCargos.ResumeLayout(false);
            this.panelBuscarCargos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscarCargos;
        private System.Windows.Forms.TextBox txtBuscarHorario;
        private FontAwesome.Sharp.IconButton btnBuscarHorario;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoHorario;
        private FontAwesome.Sharp.IconButton btnEditarHorario;
        private FontAwesome.Sharp.IconButton btnEliminarHorario;
        private System.Windows.Forms.DataGridView dgvHorario;
    }
}
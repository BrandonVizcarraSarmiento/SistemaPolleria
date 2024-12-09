namespace SistemaPolleria.presentacion.gestionEquipos.equipos
{
    partial class FrmEquipo
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
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.txtBuscarEquipo = new System.Windows.Forms.TextBox();
            this.btnBuscarEquipo = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoEquipo = new FontAwesome.Sharp.IconButton();
            this.btnEditarEquipo = new FontAwesome.Sharp.IconButton();
            this.btnEliminarEquipo = new FontAwesome.Sharp.IconButton();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.panelBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscar.Controls.Add(this.txtBuscarEquipo);
            this.panelBuscar.Controls.Add(this.btnBuscarEquipo);
            this.panelBuscar.Location = new System.Drawing.Point(270, 14);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(247, 47);
            this.panelBuscar.TabIndex = 31;
            // 
            // txtBuscarEquipo
            // 
            this.txtBuscarEquipo.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarEquipo.Name = "txtBuscarEquipo";
            this.txtBuscarEquipo.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarEquipo.TabIndex = 12;
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarEquipo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEquipo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEquipo.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarEquipo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEquipo.IconSize = 21;
            this.btnBuscarEquipo.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarEquipo.TabIndex = 11;
            this.btnBuscarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEquipo.UseVisualStyleBackColor = false;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoEquipo);
            this.panel3.Controls.Add(this.btnEditarEquipo);
            this.panel3.Controls.Add(this.btnEliminarEquipo);
            this.panel3.Location = new System.Drawing.Point(249, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 30;
            // 
            // btnNuevoEquipo
            // 
            this.btnNuevoEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoEquipo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEquipo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEquipo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoEquipo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoEquipo.IconSize = 21;
            this.btnNuevoEquipo.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoEquipo.Name = "btnNuevoEquipo";
            this.btnNuevoEquipo.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoEquipo.TabIndex = 8;
            this.btnNuevoEquipo.Text = "Nuevo";
            this.btnNuevoEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoEquipo.UseVisualStyleBackColor = false;
            this.btnNuevoEquipo.Click += new System.EventHandler(this.btnNuevoEquipo_Click);
            // 
            // btnEditarEquipo
            // 
            this.btnEditarEquipo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarEquipo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEquipo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEquipo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarEquipo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarEquipo.IconSize = 21;
            this.btnEditarEquipo.Location = new System.Drawing.Point(108, 17);
            this.btnEditarEquipo.Name = "btnEditarEquipo";
            this.btnEditarEquipo.Size = new System.Drawing.Size(81, 33);
            this.btnEditarEquipo.TabIndex = 10;
            this.btnEditarEquipo.Text = "Editar";
            this.btnEditarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEquipo.UseVisualStyleBackColor = false;
            this.btnEditarEquipo.Click += new System.EventHandler(this.btnEditarEquipo_Click);
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEquipo.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEquipo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEquipo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarEquipo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarEquipo.IconSize = 21;
            this.btnEliminarEquipo.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarEquipo.TabIndex = 9;
            this.btnEliminarEquipo.Text = "Eliminar";
            this.btnEliminarEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEquipo.UseVisualStyleBackColor = false;
            this.btnEliminarEquipo.Click += new System.EventHandler(this.btnEliminarEquipo_Click);
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEquipo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvEquipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvEquipo.ColumnHeadersHeight = 30;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipo.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvEquipo.EnableHeadersVisualStyles = false;
            this.dgvEquipo.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEquipo.Location = new System.Drawing.Point(98, 81);
            this.dgvEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            this.dgvEquipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvEquipo.RowHeadersWidth = 51;
            this.dgvEquipo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvEquipo.RowTemplate.Height = 24;
            this.dgvEquipo.Size = new System.Drawing.Size(604, 272);
            this.dgvEquipo.TabIndex = 29;
            // 
            // FrmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvEquipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEquipo";
            this.Text = "FrmEquipo";
            this.Load += new System.EventHandler(this.FrmEquipo_Load);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtBuscarEquipo;
        private FontAwesome.Sharp.IconButton btnBuscarEquipo;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoEquipo;
        private FontAwesome.Sharp.IconButton btnEditarEquipo;
        private FontAwesome.Sharp.IconButton btnEliminarEquipo;
        private System.Windows.Forms.DataGridView dgvEquipo;
    }
}
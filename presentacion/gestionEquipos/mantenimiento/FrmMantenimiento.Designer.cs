namespace SistemaPolleria.presentacion.gestionEquipos.mantenimiento
{
    partial class FrmMantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.txtBuscarMantenimiento = new System.Windows.Forms.TextBox();
            this.btnBuscarMantenimiento = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoMantenimiento = new FontAwesome.Sharp.IconButton();
            this.btnEditarMantenimiento = new FontAwesome.Sharp.IconButton();
            this.btnEliminarMantenimiento = new FontAwesome.Sharp.IconButton();
            this.dgvMantenimiento = new System.Windows.Forms.DataGridView();
            this.panelBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscar.Controls.Add(this.txtBuscarMantenimiento);
            this.panelBuscar.Controls.Add(this.btnBuscarMantenimiento);
            this.panelBuscar.Location = new System.Drawing.Point(270, 14);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(247, 47);
            this.panelBuscar.TabIndex = 31;
            // 
            // txtBuscarMantenimiento
            // 
            this.txtBuscarMantenimiento.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarMantenimiento.Name = "txtBuscarMantenimiento";
            this.txtBuscarMantenimiento.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarMantenimiento.TabIndex = 12;
            // 
            // btnBuscarMantenimiento
            // 
            this.btnBuscarMantenimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarMantenimiento.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMantenimiento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMantenimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarMantenimiento.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarMantenimiento.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarMantenimiento.IconSize = 21;
            this.btnBuscarMantenimiento.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarMantenimiento.Name = "btnBuscarMantenimiento";
            this.btnBuscarMantenimiento.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarMantenimiento.TabIndex = 11;
            this.btnBuscarMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarMantenimiento.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoMantenimiento);
            this.panel3.Controls.Add(this.btnEditarMantenimiento);
            this.panel3.Controls.Add(this.btnEliminarMantenimiento);
            this.panel3.Location = new System.Drawing.Point(249, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 30;
            // 
            // btnNuevoMantenimiento
            // 
            this.btnNuevoMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoMantenimiento.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoMantenimiento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMantenimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoMantenimiento.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoMantenimiento.IconSize = 21;
            this.btnNuevoMantenimiento.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoMantenimiento.Name = "btnNuevoMantenimiento";
            this.btnNuevoMantenimiento.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoMantenimiento.TabIndex = 8;
            this.btnNuevoMantenimiento.Text = "Nuevo";
            this.btnNuevoMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnEditarMantenimiento
            // 
            this.btnEditarMantenimiento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarMantenimiento.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarMantenimiento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMantenimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarMantenimiento.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarMantenimiento.IconSize = 21;
            this.btnEditarMantenimiento.Location = new System.Drawing.Point(108, 17);
            this.btnEditarMantenimiento.Name = "btnEditarMantenimiento";
            this.btnEditarMantenimiento.Size = new System.Drawing.Size(81, 33);
            this.btnEditarMantenimiento.TabIndex = 10;
            this.btnEditarMantenimiento.Text = "Editar";
            this.btnEditarMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnEliminarMantenimiento
            // 
            this.btnEliminarMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarMantenimiento.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarMantenimiento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMantenimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarMantenimiento.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarMantenimiento.IconSize = 21;
            this.btnEliminarMantenimiento.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarMantenimiento.Name = "btnEliminarMantenimiento";
            this.btnEliminarMantenimiento.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarMantenimiento.TabIndex = 9;
            this.btnEliminarMantenimiento.Text = "Eliminar";
            this.btnEliminarMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarMantenimiento.UseVisualStyleBackColor = false;
            // 
            // dgvMantenimiento
            // 
            this.dgvMantenimiento.AllowUserToAddRows = false;
            this.dgvMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMantenimiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMantenimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMantenimiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMantenimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMantenimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMantenimiento.ColumnHeadersHeight = 30;
            this.dgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMantenimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMantenimiento.EnableHeadersVisualStyles = false;
            this.dgvMantenimiento.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMantenimiento.Location = new System.Drawing.Point(98, 81);
            this.dgvMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMantenimiento.Name = "dgvMantenimiento";
            this.dgvMantenimiento.ReadOnly = true;
            this.dgvMantenimiento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMantenimiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMantenimiento.RowHeadersWidth = 51;
            this.dgvMantenimiento.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvMantenimiento.RowTemplate.Height = 24;
            this.dgvMantenimiento.Size = new System.Drawing.Size(604, 272);
            this.dgvMantenimiento.TabIndex = 29;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvMantenimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantenimiento";
            this.Text = "FrmMantenimiento";
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtBuscarMantenimiento;
        private FontAwesome.Sharp.IconButton btnBuscarMantenimiento;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoMantenimiento;
        private FontAwesome.Sharp.IconButton btnEditarMantenimiento;
        private FontAwesome.Sharp.IconButton btnEliminarMantenimiento;
        private System.Windows.Forms.DataGridView dgvMantenimiento;
    }
}
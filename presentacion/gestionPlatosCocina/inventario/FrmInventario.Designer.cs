namespace SistemaPolleria.presentacion.gestionPlatosCocina.inventario
{
    partial class FrmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBuscarCargos = new System.Windows.Forms.Panel();
            this.txtBuscarInventario = new System.Windows.Forms.TextBox();
            this.btnBuscarInventario = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoInventario = new FontAwesome.Sharp.IconButton();
            this.btnEditarInventario = new FontAwesome.Sharp.IconButton();
            this.btnEliminarInventario = new FontAwesome.Sharp.IconButton();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.panelBuscarCargos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscarCargos
            // 
            this.panelBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarCargos.Controls.Add(this.txtBuscarInventario);
            this.panelBuscarCargos.Controls.Add(this.btnBuscarInventario);
            this.panelBuscarCargos.Location = new System.Drawing.Point(277, 17);
            this.panelBuscarCargos.Name = "panelBuscarCargos";
            this.panelBuscarCargos.Size = new System.Drawing.Size(247, 47);
            this.panelBuscarCargos.TabIndex = 40;
            // 
            // txtBuscarInventario
            // 
            this.txtBuscarInventario.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarInventario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarInventario.Name = "txtBuscarInventario";
            this.txtBuscarInventario.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarInventario.TabIndex = 12;
            // 
            // btnBuscarInventario
            // 
            this.btnBuscarInventario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarInventario.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarInventario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarInventario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarInventario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarInventario.IconSize = 21;
            this.btnBuscarInventario.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarInventario.Name = "btnBuscarInventario";
            this.btnBuscarInventario.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarInventario.TabIndex = 11;
            this.btnBuscarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarInventario.UseVisualStyleBackColor = false;
            this.btnBuscarInventario.Click += new System.EventHandler(this.btnBuscarInventario_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoInventario);
            this.panel3.Controls.Add(this.btnEditarInventario);
            this.panel3.Controls.Add(this.btnEliminarInventario);
            this.panel3.Location = new System.Drawing.Point(256, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 39;
            // 
            // btnNuevoInventario
            // 
            this.btnNuevoInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoInventario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoInventario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoInventario.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoInventario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoInventario.IconSize = 21;
            this.btnNuevoInventario.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoInventario.Name = "btnNuevoInventario";
            this.btnNuevoInventario.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoInventario.TabIndex = 8;
            this.btnNuevoInventario.Text = "Nuevo";
            this.btnNuevoInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoInventario.UseVisualStyleBackColor = false;
            this.btnNuevoInventario.Click += new System.EventHandler(this.btnNuevoInventario_Click);
            // 
            // btnEditarInventario
            // 
            this.btnEditarInventario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarInventario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarInventario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarInventario.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarInventario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarInventario.IconSize = 21;
            this.btnEditarInventario.Location = new System.Drawing.Point(108, 17);
            this.btnEditarInventario.Name = "btnEditarInventario";
            this.btnEditarInventario.Size = new System.Drawing.Size(81, 33);
            this.btnEditarInventario.TabIndex = 10;
            this.btnEditarInventario.Text = "Editar";
            this.btnEditarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarInventario.UseVisualStyleBackColor = false;
            this.btnEditarInventario.Click += new System.EventHandler(this.btnEditarInventario_Click);
            // 
            // btnEliminarInventario
            // 
            this.btnEliminarInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarInventario.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarInventario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarInventario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarInventario.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarInventario.IconSize = 21;
            this.btnEliminarInventario.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarInventario.Name = "btnEliminarInventario";
            this.btnEliminarInventario.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarInventario.TabIndex = 9;
            this.btnEliminarInventario.Text = "Eliminar";
            this.btnEliminarInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarInventario.UseVisualStyleBackColor = false;
            this.btnEliminarInventario.Click += new System.EventHandler(this.btnEliminarInventario_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvInventario.ColumnHeadersHeight = 30;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvInventario.Location = new System.Drawing.Point(112, 69);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(605, 337);
            this.dgvInventario.TabIndex = 38;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 522);
            this.Controls.Add(this.panelBuscarCargos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvInventario);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.panelBuscarCargos.ResumeLayout(false);
            this.panelBuscarCargos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscarCargos;
        private System.Windows.Forms.TextBox txtBuscarInventario;
        private FontAwesome.Sharp.IconButton btnBuscarInventario;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoInventario;
        private FontAwesome.Sharp.IconButton btnEditarInventario;
        private FontAwesome.Sharp.IconButton btnEliminarInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
    }
}
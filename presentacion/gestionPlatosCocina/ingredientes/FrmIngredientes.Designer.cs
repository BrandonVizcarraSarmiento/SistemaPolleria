namespace SistemaPolleria.presentacion.gestionPlatosCocina.ingredientes
{
    partial class FrmIngredientes
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
            this.txtBuscarIngredientes = new System.Windows.Forms.TextBox();
            this.btnBuscarIngredientes = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoIngredientes = new FontAwesome.Sharp.IconButton();
            this.btnEditarIngredientes = new FontAwesome.Sharp.IconButton();
            this.btnEliminarIngredientes = new FontAwesome.Sharp.IconButton();
            this.dgvIngredientes = new System.Windows.Forms.DataGridView();
            this.panelBuscarCargos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscarCargos
            // 
            this.panelBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarCargos.Controls.Add(this.txtBuscarIngredientes);
            this.panelBuscarCargos.Controls.Add(this.btnBuscarIngredientes);
            this.panelBuscarCargos.Location = new System.Drawing.Point(309, 32);
            this.panelBuscarCargos.Name = "panelBuscarCargos";
            this.panelBuscarCargos.Size = new System.Drawing.Size(247, 47);
            this.panelBuscarCargos.TabIndex = 34;
            // 
            // txtBuscarIngredientes
            // 
            this.txtBuscarIngredientes.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarIngredientes.Name = "txtBuscarIngredientes";
            this.txtBuscarIngredientes.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarIngredientes.TabIndex = 12;
            // 
            // btnBuscarIngredientes
            // 
            this.btnBuscarIngredientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarIngredientes.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarIngredientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarIngredientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarIngredientes.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarIngredientes.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarIngredientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarIngredientes.IconSize = 21;
            this.btnBuscarIngredientes.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarIngredientes.Name = "btnBuscarIngredientes";
            this.btnBuscarIngredientes.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarIngredientes.TabIndex = 11;
            this.btnBuscarIngredientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarIngredientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarIngredientes.UseVisualStyleBackColor = false;
            this.btnBuscarIngredientes.Click += new System.EventHandler(this.btnBuscarIngredientes_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoIngredientes);
            this.panel3.Controls.Add(this.btnEditarIngredientes);
            this.panel3.Controls.Add(this.btnEliminarIngredientes);
            this.panel3.Location = new System.Drawing.Point(288, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 33;
            // 
            // btnNuevoIngredientes
            // 
            this.btnNuevoIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoIngredientes.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoIngredientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoIngredientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoIngredientes.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoIngredientes.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoIngredientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoIngredientes.IconSize = 21;
            this.btnNuevoIngredientes.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoIngredientes.Name = "btnNuevoIngredientes";
            this.btnNuevoIngredientes.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoIngredientes.TabIndex = 8;
            this.btnNuevoIngredientes.Text = "Nuevo";
            this.btnNuevoIngredientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoIngredientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoIngredientes.UseVisualStyleBackColor = false;
            this.btnNuevoIngredientes.Click += new System.EventHandler(this.btnNuevoIngredientes_Click);
            // 
            // btnEditarIngredientes
            // 
            this.btnEditarIngredientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarIngredientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarIngredientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarIngredientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarIngredientes.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarIngredientes.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarIngredientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarIngredientes.IconSize = 21;
            this.btnEditarIngredientes.Location = new System.Drawing.Point(108, 17);
            this.btnEditarIngredientes.Name = "btnEditarIngredientes";
            this.btnEditarIngredientes.Size = new System.Drawing.Size(81, 33);
            this.btnEditarIngredientes.TabIndex = 10;
            this.btnEditarIngredientes.Text = "Editar";
            this.btnEditarIngredientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarIngredientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarIngredientes.UseVisualStyleBackColor = false;
            this.btnEditarIngredientes.Click += new System.EventHandler(this.btnEditarIngredientes_Click);
            // 
            // btnEliminarIngredientes
            // 
            this.btnEliminarIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarIngredientes.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarIngredientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarIngredientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarIngredientes.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarIngredientes.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarIngredientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarIngredientes.IconSize = 21;
            this.btnEliminarIngredientes.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarIngredientes.Name = "btnEliminarIngredientes";
            this.btnEliminarIngredientes.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarIngredientes.TabIndex = 9;
            this.btnEliminarIngredientes.Text = "Eliminar";
            this.btnEliminarIngredientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarIngredientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarIngredientes.UseVisualStyleBackColor = false;
            this.btnEliminarIngredientes.Click += new System.EventHandler(this.btnEliminarIngredientes_Click);
            // 
            // dgvIngredientes
            // 
            this.dgvIngredientes.AllowUserToAddRows = false;
            this.dgvIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngredientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIngredientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvIngredientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIngredientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvIngredientes.ColumnHeadersHeight = 30;
            this.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngredientes.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvIngredientes.EnableHeadersVisualStyles = false;
            this.dgvIngredientes.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvIngredientes.Location = new System.Drawing.Point(144, 84);
            this.dgvIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvIngredientes.Name = "dgvIngredientes";
            this.dgvIngredientes.ReadOnly = true;
            this.dgvIngredientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvIngredientes.RowHeadersWidth = 51;
            this.dgvIngredientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvIngredientes.RowTemplate.Height = 24;
            this.dgvIngredientes.Size = new System.Drawing.Size(605, 366);
            this.dgvIngredientes.TabIndex = 32;
            // 
            // FrmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 586);
            this.Controls.Add(this.panelBuscarCargos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvIngredientes);
            this.Name = "FrmIngredientes";
            this.Text = "FrmIngredientes";
            this.Load += new System.EventHandler(this.FrmIngredientes_Load);
            this.panelBuscarCargos.ResumeLayout(false);
            this.panelBuscarCargos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscarCargos;
        private System.Windows.Forms.TextBox txtBuscarIngredientes;
        private FontAwesome.Sharp.IconButton btnBuscarIngredientes;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoIngredientes;
        private FontAwesome.Sharp.IconButton btnEditarIngredientes;
        private FontAwesome.Sharp.IconButton btnEliminarIngredientes;
        private System.Windows.Forms.DataGridView dgvIngredientes;
    }
}
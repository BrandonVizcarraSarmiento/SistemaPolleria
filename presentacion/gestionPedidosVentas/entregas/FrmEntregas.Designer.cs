namespace SistemaPolleria.presentacion.gestionPedidosVentas.entregas
{
    partial class FrmEntregas
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
            this.txtBuscarEntrega = new System.Windows.Forms.TextBox();
            this.btnBuscarEntrega = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoEntrega = new FontAwesome.Sharp.IconButton();
            this.btnEditarEntrega = new FontAwesome.Sharp.IconButton();
            this.btnEliminarEntrega = new FontAwesome.Sharp.IconButton();
            this.dgvEntrega = new System.Windows.Forms.DataGridView();
            this.panelBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscar.Controls.Add(this.txtBuscarEntrega);
            this.panelBuscar.Controls.Add(this.btnBuscarEntrega);
            this.panelBuscar.Location = new System.Drawing.Point(270, 14);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(247, 47);
            this.panelBuscar.TabIndex = 31;
            // 
            // txtBuscarEntrega
            // 
            this.txtBuscarEntrega.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarEntrega.Name = "txtBuscarEntrega";
            this.txtBuscarEntrega.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarEntrega.TabIndex = 12;
            // 
            // btnBuscarEntrega
            // 
            this.btnBuscarEntrega.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarEntrega.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarEntrega.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEntrega.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEntrega.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarEntrega.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarEntrega.IconSize = 21;
            this.btnBuscarEntrega.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarEntrega.Name = "btnBuscarEntrega";
            this.btnBuscarEntrega.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarEntrega.TabIndex = 11;
            this.btnBuscarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEntrega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEntrega.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoEntrega);
            this.panel3.Controls.Add(this.btnEditarEntrega);
            this.panel3.Controls.Add(this.btnEliminarEntrega);
            this.panel3.Location = new System.Drawing.Point(249, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 30;
            // 
            // btnNuevoEntrega
            // 
            this.btnNuevoEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoEntrega.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEntrega.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEntrega.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEntrega.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoEntrega.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoEntrega.IconSize = 21;
            this.btnNuevoEntrega.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoEntrega.Name = "btnNuevoEntrega";
            this.btnNuevoEntrega.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoEntrega.TabIndex = 8;
            this.btnNuevoEntrega.Text = "Nuevo";
            this.btnNuevoEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEntrega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoEntrega.UseVisualStyleBackColor = false;
            // 
            // btnEditarEntrega
            // 
            this.btnEditarEntrega.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarEntrega.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEntrega.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEntrega.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEntrega.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarEntrega.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarEntrega.IconSize = 21;
            this.btnEditarEntrega.Location = new System.Drawing.Point(108, 17);
            this.btnEditarEntrega.Name = "btnEditarEntrega";
            this.btnEditarEntrega.Size = new System.Drawing.Size(81, 33);
            this.btnEditarEntrega.TabIndex = 10;
            this.btnEditarEntrega.Text = "Editar";
            this.btnEditarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarEntrega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEntrega.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEntrega
            // 
            this.btnEliminarEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEntrega.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEntrega.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEntrega.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEntrega.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarEntrega.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarEntrega.IconSize = 21;
            this.btnEliminarEntrega.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarEntrega.Name = "btnEliminarEntrega";
            this.btnEliminarEntrega.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarEntrega.TabIndex = 9;
            this.btnEliminarEntrega.Text = "Eliminar";
            this.btnEliminarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEntrega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEntrega.UseVisualStyleBackColor = false;
            // 
            // dgvEntrega
            // 
            this.dgvEntrega.AllowUserToAddRows = false;
            this.dgvEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntrega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEntrega.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvEntrega.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEntrega.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntrega.ColumnHeadersHeight = 30;
            this.dgvEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntrega.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntrega.EnableHeadersVisualStyles = false;
            this.dgvEntrega.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEntrega.Location = new System.Drawing.Point(98, 81);
            this.dgvEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEntrega.Name = "dgvEntrega";
            this.dgvEntrega.ReadOnly = true;
            this.dgvEntrega.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntrega.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntrega.RowHeadersWidth = 51;
            this.dgvEntrega.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvEntrega.RowTemplate.Height = 24;
            this.dgvEntrega.Size = new System.Drawing.Size(604, 272);
            this.dgvEntrega.TabIndex = 29;
            // 
            // FrmEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntregas";
            this.Text = "FrmEntregas";
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtBuscarEntrega;
        private FontAwesome.Sharp.IconButton btnBuscarEntrega;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoEntrega;
        private FontAwesome.Sharp.IconButton btnEditarEntrega;
        private FontAwesome.Sharp.IconButton btnEliminarEntrega;
        private System.Windows.Forms.DataGridView dgvEntrega;
    }
}
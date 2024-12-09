namespace SistemaPolleria.presentacion.gestionPedidosVentas.pedidos
{
    partial class FrmPedidos
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
            this.txtBuscarPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarPedido = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoPedido = new FontAwesome.Sharp.IconButton();
            this.btnEditarPedido = new FontAwesome.Sharp.IconButton();
            this.btnEliminarPedido = new FontAwesome.Sharp.IconButton();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.panelBuscar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscar.Controls.Add(this.txtBuscarPedido);
            this.panelBuscar.Controls.Add(this.btnBuscarPedido);
            this.panelBuscar.Location = new System.Drawing.Point(270, 14);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(247, 47);
            this.panelBuscar.TabIndex = 31;
            // 
            // txtBuscarPedido
            // 
            this.txtBuscarPedido.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPedido.Name = "txtBuscarPedido";
            this.txtBuscarPedido.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarPedido.TabIndex = 12;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarPedido.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPedido.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarPedido.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPedido.IconSize = 21;
            this.btnBuscarPedido.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarPedido.TabIndex = 11;
            this.btnBuscarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarPedido.UseVisualStyleBackColor = false;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoPedido);
            this.panel3.Controls.Add(this.btnEditarPedido);
            this.panel3.Controls.Add(this.btnEliminarPedido);
            this.panel3.Location = new System.Drawing.Point(249, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 30;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPedido.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPedido.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoPedido.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoPedido.IconSize = 21;
            this.btnNuevoPedido.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoPedido.TabIndex = 8;
            this.btnNuevoPedido.Text = "Nuevo";
            this.btnNuevoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnEditarPedido
            // 
            this.btnEditarPedido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarPedido.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPedido.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarPedido.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPedido.IconSize = 21;
            this.btnEditarPedido.Location = new System.Drawing.Point(108, 17);
            this.btnEditarPedido.Name = "btnEditarPedido";
            this.btnEditarPedido.Size = new System.Drawing.Size(81, 33);
            this.btnEditarPedido.TabIndex = 10;
            this.btnEditarPedido.Text = "Editar";
            this.btnEditarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPedido.UseVisualStyleBackColor = false;
            this.btnEditarPedido.Click += new System.EventHandler(this.btnEditarPedido_Click);
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPedido.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPedido.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarPedido.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarPedido.IconSize = 21;
            this.btnEliminarPedido.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarPedido.TabIndex = 9;
            this.btnEliminarPedido.Text = "Eliminar";
            this.btnEliminarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarPedido.UseVisualStyleBackColor = false;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedido.ColumnHeadersHeight = 30;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPedido.Location = new System.Drawing.Point(98, 81);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.Size = new System.Drawing.Size(604, 272);
            this.dgvPedido.TabIndex = 29;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtBuscarPedido;
        private FontAwesome.Sharp.IconButton btnBuscarPedido;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoPedido;
        private FontAwesome.Sharp.IconButton btnEditarPedido;
        private FontAwesome.Sharp.IconButton btnEliminarPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
    }
}
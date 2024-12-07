namespace SistemaPolleria.presentacion.cajaPagos.pagos
{
    partial class FrmPago
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
            this.txtBuscarPago = new System.Windows.Forms.TextBox();
            this.btnBuscarPago = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoPago = new FontAwesome.Sharp.IconButton();
            this.btnEditarPago = new FontAwesome.Sharp.IconButton();
            this.btnEliminarPago = new FontAwesome.Sharp.IconButton();
            this.dgvPago = new System.Windows.Forms.DataGridView();
            this.panelBuscarCargos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscarCargos
            // 
            this.panelBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarCargos.Controls.Add(this.txtBuscarPago);
            this.panelBuscarCargos.Controls.Add(this.btnBuscarPago);
            this.panelBuscarCargos.Location = new System.Drawing.Point(270, 14);
            this.panelBuscarCargos.Name = "panelBuscarCargos";
            this.panelBuscarCargos.Size = new System.Drawing.Size(247, 47);
            this.panelBuscarCargos.TabIndex = 31;
            // 
            // txtBuscarPago
            // 
            this.txtBuscarPago.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPago.Name = "txtBuscarPago";
            this.txtBuscarPago.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarPago.TabIndex = 12;
            // 
            // btnBuscarPago
            // 
            this.btnBuscarPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarPago.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPago.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPago.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarPago.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPago.IconSize = 21;
            this.btnBuscarPago.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarPago.Name = "btnBuscarPago";
            this.btnBuscarPago.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarPago.TabIndex = 11;
            this.btnBuscarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarPago.UseVisualStyleBackColor = false;
            this.btnBuscarPago.Click += new System.EventHandler(this.btnBuscarPago_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoPago);
            this.panel3.Controls.Add(this.btnEditarPago);
            this.panel3.Controls.Add(this.btnEliminarPago);
            this.panel3.Location = new System.Drawing.Point(249, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 30;
            // 
            // btnNuevoPago
            // 
            this.btnNuevoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPago.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPago.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPago.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoPago.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoPago.IconSize = 21;
            this.btnNuevoPago.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoPago.Name = "btnNuevoPago";
            this.btnNuevoPago.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoPago.TabIndex = 8;
            this.btnNuevoPago.Text = "Nuevo";
            this.btnNuevoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoPago.UseVisualStyleBackColor = false;
            this.btnNuevoPago.Click += new System.EventHandler(this.btnNuevoPago_Click);
            // 
            // btnEditarPago
            // 
            this.btnEditarPago.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarPago.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPago.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPago.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarPago.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPago.IconSize = 21;
            this.btnEditarPago.Location = new System.Drawing.Point(108, 17);
            this.btnEditarPago.Name = "btnEditarPago";
            this.btnEditarPago.Size = new System.Drawing.Size(81, 33);
            this.btnEditarPago.TabIndex = 10;
            this.btnEditarPago.Text = "Editar";
            this.btnEditarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPago.UseVisualStyleBackColor = false;
            this.btnEditarPago.Click += new System.EventHandler(this.btnEditarPago_Click);
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPago.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPago.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPago.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarPago.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarPago.IconSize = 21;
            this.btnEliminarPago.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarPago.TabIndex = 9;
            this.btnEliminarPago.Text = "Eliminar";
            this.btnEliminarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarPago.UseVisualStyleBackColor = false;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // dgvPago
            // 
            this.dgvPago.AllowUserToAddRows = false;
            this.dgvPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPago.ColumnHeadersHeight = 30;
            this.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPago.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPago.EnableHeadersVisualStyles = false;
            this.dgvPago.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPago.Location = new System.Drawing.Point(98, 81);
            this.dgvPago.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPago.Name = "dgvPago";
            this.dgvPago.ReadOnly = true;
            this.dgvPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPago.RowHeadersWidth = 51;
            this.dgvPago.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvPago.RowTemplate.Height = 24;
            this.dgvPago.Size = new System.Drawing.Size(604, 272);
            this.dgvPago.TabIndex = 29;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBuscarCargos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            this.panelBuscarCargos.ResumeLayout(false);
            this.panelBuscarCargos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscarCargos;
        private System.Windows.Forms.TextBox txtBuscarPago;
        private FontAwesome.Sharp.IconButton btnBuscarPago;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoPago;
        private FontAwesome.Sharp.IconButton btnEditarPago;
        private FontAwesome.Sharp.IconButton btnEliminarPago;
        private System.Windows.Forms.DataGridView dgvPago;
    }
}
namespace SistemaPolleria.presentacion.gestionPlatosCocina.platos
{
    partial class FrmPlatos
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
            this.txtBuscarPlatos = new System.Windows.Forms.TextBox();
            this.btnBuscarPlatos = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoPlato = new FontAwesome.Sharp.IconButton();
            this.btnEditarPlatos = new FontAwesome.Sharp.IconButton();
            this.btnEliminarPlatos = new FontAwesome.Sharp.IconButton();
            this.dgvPlatos = new System.Windows.Forms.DataGridView();
            this.panelBuscarCargos.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuscarCargos
            // 
            this.panelBuscarCargos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarCargos.Controls.Add(this.txtBuscarPlatos);
            this.panelBuscarCargos.Controls.Add(this.btnBuscarPlatos);
            this.panelBuscarCargos.Location = new System.Drawing.Point(263, 12);
            this.panelBuscarCargos.Name = "panelBuscarCargos";
            this.panelBuscarCargos.Size = new System.Drawing.Size(247, 47);
            this.panelBuscarCargos.TabIndex = 31;
            // 
            // txtBuscarPlatos
            // 
            this.txtBuscarPlatos.Location = new System.Drawing.Point(19, 13);
            this.txtBuscarPlatos.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPlatos.Name = "txtBuscarPlatos";
            this.txtBuscarPlatos.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarPlatos.TabIndex = 12;
            // 
            // btnBuscarPlatos
            // 
            this.btnBuscarPlatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarPlatos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscarPlatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPlatos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPlatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPlatos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarPlatos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPlatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarPlatos.IconSize = 21;
            this.btnBuscarPlatos.Location = new System.Drawing.Point(200, 13);
            this.btnBuscarPlatos.Name = "btnBuscarPlatos";
            this.btnBuscarPlatos.Size = new System.Drawing.Size(35, 20);
            this.btnBuscarPlatos.TabIndex = 11;
            this.btnBuscarPlatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarPlatos.UseVisualStyleBackColor = false;
            this.btnBuscarPlatos.Click += new System.EventHandler(this.btnBuscarPlatos_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoPlato);
            this.panel3.Controls.Add(this.btnEditarPlatos);
            this.panel3.Controls.Add(this.btnEliminarPlatos);
            this.panel3.Location = new System.Drawing.Point(242, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 30;
            // 
            // btnNuevoPlato
            // 
            this.btnNuevoPlato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoPlato.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPlato.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPlato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPlato.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoPlato.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPlato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoPlato.IconSize = 21;
            this.btnNuevoPlato.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoPlato.Name = "btnNuevoPlato";
            this.btnNuevoPlato.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoPlato.TabIndex = 8;
            this.btnNuevoPlato.Text = "Nuevo";
            this.btnNuevoPlato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPlato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoPlato.UseVisualStyleBackColor = false;
            this.btnNuevoPlato.Click += new System.EventHandler(this.btnNuevoPlato_Click_1);
            // 
            // btnEditarPlatos
            // 
            this.btnEditarPlatos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarPlatos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarPlatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPlatos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPlatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPlatos.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarPlatos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPlatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPlatos.IconSize = 21;
            this.btnEditarPlatos.Location = new System.Drawing.Point(108, 17);
            this.btnEditarPlatos.Name = "btnEditarPlatos";
            this.btnEditarPlatos.Size = new System.Drawing.Size(81, 33);
            this.btnEditarPlatos.TabIndex = 10;
            this.btnEditarPlatos.Text = "Editar";
            this.btnEditarPlatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPlatos.UseVisualStyleBackColor = false;
            this.btnEditarPlatos.Click += new System.EventHandler(this.btnEditarPlatos_Click);
            // 
            // btnEliminarPlatos
            // 
            this.btnEliminarPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPlatos.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarPlatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPlatos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPlatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPlatos.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarPlatos.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarPlatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarPlatos.IconSize = 21;
            this.btnEliminarPlatos.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarPlatos.Name = "btnEliminarPlatos";
            this.btnEliminarPlatos.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarPlatos.TabIndex = 9;
            this.btnEliminarPlatos.Text = "Eliminar";
            this.btnEliminarPlatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarPlatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarPlatos.UseVisualStyleBackColor = false;
            this.btnEliminarPlatos.Click += new System.EventHandler(this.btnEliminarPlatos_Click);
            // 
            // dgvPlatos
            // 
            this.dgvPlatos.AllowUserToAddRows = false;
            this.dgvPlatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPlatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPlatos.ColumnHeadersHeight = 30;
            this.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlatos.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPlatos.EnableHeadersVisualStyles = false;
            this.dgvPlatos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPlatos.Location = new System.Drawing.Point(98, 64);
            this.dgvPlatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlatos.Name = "dgvPlatos";
            this.dgvPlatos.ReadOnly = true;
            this.dgvPlatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPlatos.RowHeadersWidth = 51;
            this.dgvPlatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvPlatos.RowTemplate.Height = 24;
            this.dgvPlatos.Size = new System.Drawing.Size(605, 366);
            this.dgvPlatos.TabIndex = 29;
            // 
            // FrmPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 510);
            this.Controls.Add(this.panelBuscarCargos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvPlatos);
            this.Name = "FrmPlatos";
            this.Text = "FrmPlatos";
            this.Load += new System.EventHandler(this.FrmPlatos_Load_1);
            this.panelBuscarCargos.ResumeLayout(false);
            this.panelBuscarCargos.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuscarCargos;
        private System.Windows.Forms.TextBox txtBuscarPlatos;
        private FontAwesome.Sharp.IconButton btnBuscarPlatos;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoPlato;
        private FontAwesome.Sharp.IconButton btnEditarPlatos;
        private FontAwesome.Sharp.IconButton btnEliminarPlatos;
        private System.Windows.Forms.DataGridView dgvPlatos;
    }
}
namespace SistemaPolleria.presentacion.gestion_empleados.carpetas
{
    partial class FrmAsistencia
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
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnEditarAsistencia = new FontAwesome.Sharp.IconButton();
            this.btnEliminarAsistencia = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsistencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsistencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvAsistencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsistencia.ColumnHeadersHeight = 30;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsistencia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsistencia.EnableHeadersVisualStyles = false;
            this.dgvAsistencia.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvAsistencia.Location = new System.Drawing.Point(184, 119);
            this.dgvAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.ReadOnly = true;
            this.dgvAsistencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAsistencia.RowHeadersWidth = 51;
            this.dgvAsistencia.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvAsistencia.RowTemplate.Height = 24;
            this.dgvAsistencia.Size = new System.Drawing.Size(600, 306);
            this.dgvAsistencia.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNuevoAsistencia);
            this.panel3.Controls.Add(this.btnEditarAsistencia);
            this.panel3.Controls.Add(this.btnEliminarAsistencia);
            this.panel3.Location = new System.Drawing.Point(184, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 65);
            this.panel3.TabIndex = 27;
            // 
            // btnNuevoAsistencia
            // 
            this.btnNuevoAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoAsistencia.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNuevoAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoAsistencia.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoAsistencia.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNuevoAsistencia.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoAsistencia.IconSize = 21;
            this.btnNuevoAsistencia.Location = new System.Drawing.Point(21, 17);
            this.btnNuevoAsistencia.Name = "btnNuevoAsistencia";
            this.btnNuevoAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnNuevoAsistencia.TabIndex = 8;
            this.btnNuevoAsistencia.Text = "Nuevo";
            this.btnNuevoAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnEditarAsistencia
            // 
            this.btnEditarAsistencia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarAsistencia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAsistencia.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAsistencia.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarAsistencia.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarAsistencia.IconSize = 21;
            this.btnEditarAsistencia.Location = new System.Drawing.Point(108, 17);
            this.btnEditarAsistencia.Name = "btnEditarAsistencia";
            this.btnEditarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnEditarAsistencia.TabIndex = 10;
            this.btnEditarAsistencia.Text = "Editar";
            this.btnEditarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnEliminarAsistencia
            // 
            this.btnEliminarAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarAsistencia.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAsistencia.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAsistencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarAsistencia.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarAsistencia.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarAsistencia.IconSize = 21;
            this.btnEliminarAsistencia.Location = new System.Drawing.Point(195, 17);
            this.btnEliminarAsistencia.Name = "btnEliminarAsistencia";
            this.btnEliminarAsistencia.Size = new System.Drawing.Size(81, 33);
            this.btnEliminarAsistencia.TabIndex = 9;
            this.btnEliminarAsistencia.Text = "Eliminar";
            this.btnEliminarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarAsistencia.UseVisualStyleBackColor = false;
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvAsistencia);
            this.Name = "FrmAsistencia";
            this.Text = "FrmAsistencia";
            this.Load += new System.EventHandler(this.FrmAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnNuevoAsistencia;
        private FontAwesome.Sharp.IconButton btnEditarAsistencia;
        private FontAwesome.Sharp.IconButton btnEliminarAsistencia;
    }
}
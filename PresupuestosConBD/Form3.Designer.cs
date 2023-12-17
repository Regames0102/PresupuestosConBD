
namespace PresupuestosConBD
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXCodigo = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Guardar = new System.Windows.Forms.Button();
            this.dglineas = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.añadirLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dglineas)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label2.Location = new System.Drawing.Point(75, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // TXCodigo
            // 
            this.TXCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXCodigo.Location = new System.Drawing.Point(158, 28);
            this.TXCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TXCodigo.Name = "TXCodigo";
            this.TXCodigo.Size = new System.Drawing.Size(212, 30);
            this.TXCodigo.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.Location = new System.Drawing.Point(158, 76);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(212, 30);
            this.Fecha.TabIndex = 3;
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.Guardar.Location = new System.Drawing.Point(422, 45);
            this.Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(135, 61);
            this.Guardar.TabIndex = 5;
            this.Guardar.Text = "Crear";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // dglineas
            // 
            this.dglineas.AllowUserToAddRows = false;
            this.dglineas.AllowUserToDeleteRows = false;
            this.dglineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CodigoPresupuesto,
            this.CodigoArticulo,
            this.Descripcion,
            this.Cantidad,
            this.Prec,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dglineas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dglineas.Location = new System.Drawing.Point(11, 32);
            this.dglineas.Margin = new System.Windows.Forms.Padding(2);
            this.dglineas.Name = "dglineas";
            this.dglineas.RowHeadersWidth = 51;
            this.dglineas.RowTemplate.Height = 24;
            this.dglineas.Size = new System.Drawing.Size(1115, 494);
            this.dglineas.TabIndex = 6;
            this.dglineas.Visible = false;
            this.dglineas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglineas_CellContentDoubleClick);
            this.dglineas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglineas_CellDoubleClick);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirLineaToolStripMenuItem,
            this.presupuestoToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1137, 33);
            this.menu.TabIndex = 11;
            this.menu.Text = "menuStrip1";
            this.menu.Visible = false;
            // 
            // añadirLineaToolStripMenuItem
            // 
            this.añadirLineaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.añadirLineaToolStripMenuItem.Name = "añadirLineaToolStripMenuItem";
            this.añadirLineaToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.añadirLineaToolStripMenuItem.Text = "Lineas";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.añadirToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // presupuestoToolStripMenuItem
            // 
            this.presupuestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.borrarToolStripMenuItem1});
            this.presupuestoToolStripMenuItem.Name = "presupuestoToolStripMenuItem";
            this.presupuestoToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.presupuestoToolStripMenuItem.Text = "Presupuesto";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 30);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // CodigoPresupuesto
            // 
            this.CodigoPresupuesto.HeaderText = "CodigoPresupuesto";
            this.CodigoPresupuesto.MinimumWidth = 6;
            this.CodigoPresupuesto.Name = "CodigoPresupuesto";
            this.CodigoPresupuesto.Width = 125;
            // 
            // CodigoArticulo
            // 
            this.CodigoArticulo.HeaderText = "CodigoArticulo";
            this.CodigoArticulo.MinimumWidth = 6;
            this.CodigoArticulo.Name = "CodigoArticulo";
            this.CodigoArticulo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Prec
            // 
            this.Prec.HeaderText = "Precio";
            this.Prec.Name = "Prec";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(24, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total:";
            // 
            // TXTotal
            // 
            this.TXTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TXTotal.Location = new System.Drawing.Point(80, 541);
            this.TXTotal.Name = "TXTotal";
            this.TXTotal.Size = new System.Drawing.Size(100, 29);
            this.TXTotal.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 577);
            this.Controls.Add(this.TXTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dglineas);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.TXCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglineas)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXCodigo;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Button Guardar;
        public System.Windows.Forms.DataGridView dglineas;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem añadirLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTotal;
    }
}
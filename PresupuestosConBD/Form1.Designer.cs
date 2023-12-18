
namespace PresupuestosConBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXContra = new System.Windows.Forms.TextBox();
            this.TXUser = new System.Windows.Forms.TextBox();
            this.TXHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TXBD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label1.Location = new System.Drawing.Point(214, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label2.Location = new System.Drawing.Point(188, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label3.Location = new System.Drawing.Point(156, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // TXContra
            // 
            this.TXContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXContra.Location = new System.Drawing.Point(298, 158);
            this.TXContra.Margin = new System.Windows.Forms.Padding(2);
            this.TXContra.Name = "TXContra";
            this.TXContra.Size = new System.Drawing.Size(127, 30);
            this.TXContra.TabIndex = 3;
            this.TXContra.Text = "dani";
            this.TXContra.UseSystemPasswordChar = true;
            // 
            // TXUser
            // 
            this.TXUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXUser.Location = new System.Drawing.Point(296, 120);
            this.TXUser.Margin = new System.Windows.Forms.Padding(2);
            this.TXUser.Name = "TXUser";
            this.TXUser.Size = new System.Drawing.Size(127, 30);
            this.TXUser.TabIndex = 4;
            this.TXUser.Text = "root";
            // 
            // TXHost
            // 
            this.TXHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXHost.Location = new System.Drawing.Point(296, 83);
            this.TXHost.Margin = new System.Windows.Forms.Padding(2);
            this.TXHost.Name = "TXHost";
            this.TXHost.Size = new System.Drawing.Size(127, 30);
            this.TXHost.TabIndex = 5;
            this.TXHost.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.8F);
            this.label4.Location = new System.Drawing.Point(154, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "INICIO DE SESION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.button1.Location = new System.Drawing.Point(167, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button2.Location = new System.Drawing.Point(308, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXBD
            // 
            this.TXBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXBD.Location = new System.Drawing.Point(300, 201);
            this.TXBD.Margin = new System.Windows.Forms.Padding(2);
            this.TXBD.Name = "TXBD";
            this.TXBD.Size = new System.Drawing.Size(125, 30);
            this.TXBD.TabIndex = 9;
            this.TXBD.Text = "presupuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label5.Location = new System.Drawing.Point(136, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Base de Datos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXBD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXHost);
            this.Controls.Add(this.TXUser);
            this.Controls.Add(this.TXContra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXContra;
        private System.Windows.Forms.TextBox TXUser;
        private System.Windows.Forms.TextBox TXHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}



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
            this.label1.Location = new System.Drawing.Point(286, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label2.Location = new System.Drawing.Point(251, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label3.Location = new System.Drawing.Point(208, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // TXContra
            // 
            this.TXContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXContra.Location = new System.Drawing.Point(397, 195);
            this.TXContra.Name = "TXContra";
            this.TXContra.Size = new System.Drawing.Size(168, 35);
            this.TXContra.TabIndex = 3;
            this.TXContra.Text = "dani";
            this.TXContra.UseSystemPasswordChar = true;
            // 
            // TXUser
            // 
            this.TXUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXUser.Location = new System.Drawing.Point(394, 148);
            this.TXUser.Name = "TXUser";
            this.TXUser.Size = new System.Drawing.Size(168, 35);
            this.TXUser.TabIndex = 4;
            this.TXUser.Text = "root";
            // 
            // TXHost
            // 
            this.TXHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXHost.Location = new System.Drawing.Point(394, 102);
            this.TXHost.Name = "TXHost";
            this.TXHost.Size = new System.Drawing.Size(168, 35);
            this.TXHost.TabIndex = 5;
            this.TXHost.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.8F);
            this.label4.Location = new System.Drawing.Point(205, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "INICIO DE SESION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.button1.Location = new System.Drawing.Point(223, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 79);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.button2.Location = new System.Drawing.Point(411, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 79);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TXBD
            // 
            this.TXBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.TXBD.Location = new System.Drawing.Point(400, 247);
            this.TXBD.Name = "TXBD";
            this.TXBD.Size = new System.Drawing.Size(165, 35);
            this.TXBD.TabIndex = 9;
            this.TXBD.Text = "presupuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label5.Location = new System.Drawing.Point(181, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 29);
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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


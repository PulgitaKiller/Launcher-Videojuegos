namespace Launcher
{
    partial class Launcher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSnake = new System.Windows.Forms.Button();
            this.btnSimon = new System.Windows.Forms.Button();
            this.btnBird = new System.Windows.Forms.Button();
            this.btnTopo = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.btnTopo);
            this.panel1.Controls.Add(this.btnBird);
            this.panel1.Controls.Add(this.btnSimon);
            this.panel1.Controls.Add(this.btnSnake);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(225, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(38, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "🏠";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            this.txbUsuario.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.ForeColor = System.Drawing.Color.White;
            this.txbUsuario.Location = new System.Drawing.Point(60, 16);
            this.txbUsuario.MaxLength = 12;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(146, 20);
            this.txbUsuario.TabIndex = 2;
            this.txbUsuario.Text = "Username123";
            this.txbUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.txbUsuario);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnSnake
            // 
            this.btnSnake.FlatAppearance.BorderSize = 0;
            this.btnSnake.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.btnSnake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnake.ForeColor = System.Drawing.Color.White;
            this.btnSnake.Location = new System.Drawing.Point(329, 5);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(38, 40);
            this.btnSnake.TabIndex = 2;
            this.btnSnake.Text = "🐍";
            this.btnSnake.UseVisualStyleBackColor = true;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // btnSimon
            // 
            this.btnSimon.FlatAppearance.BorderSize = 0;
            this.btnSimon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.btnSimon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimon.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimon.ForeColor = System.Drawing.Color.White;
            this.btnSimon.Location = new System.Drawing.Point(443, 5);
            this.btnSimon.Name = "btnSimon";
            this.btnSimon.Size = new System.Drawing.Size(38, 40);
            this.btnSimon.TabIndex = 3;
            this.btnSimon.Text = "🤔";
            this.btnSimon.UseVisualStyleBackColor = true;
            this.btnSimon.Click += new System.EventHandler(this.btnSimon_Click);
            // 
            // btnBird
            // 
            this.btnBird.FlatAppearance.BorderSize = 0;
            this.btnBird.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.btnBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBird.ForeColor = System.Drawing.Color.White;
            this.btnBird.Location = new System.Drawing.Point(548, 5);
            this.btnBird.Name = "btnBird";
            this.btnBird.Size = new System.Drawing.Size(38, 40);
            this.btnBird.TabIndex = 4;
            this.btnBird.Text = "🐤";
            this.btnBird.UseVisualStyleBackColor = true;
            this.btnBird.Click += new System.EventHandler(this.btnBird_Click);
            // 
            // btnTopo
            // 
            this.btnTopo.FlatAppearance.BorderSize = 0;
            this.btnTopo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.btnTopo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopo.ForeColor = System.Drawing.Color.White;
            this.btnTopo.Location = new System.Drawing.Point(654, 5);
            this.btnTopo.Name = "btnTopo";
            this.btnTopo.Size = new System.Drawing.Size(38, 40);
            this.btnTopo.TabIndex = 5;
            this.btnTopo.Text = "🔨";
            this.btnTopo.UseVisualStyleBackColor = true;
            this.btnTopo.Click += new System.EventHandler(this.btnTopo_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 51);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(704, 270);
            this.panelContenedor.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, -2);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(51, 51);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "🧒";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🎮 ¦ Pixel Fruit";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTopo;
        private System.Windows.Forms.Button btnBird;
        private System.Windows.Forms.Button btnSimon;
        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblUsuario;
    }
}


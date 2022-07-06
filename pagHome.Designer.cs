namespace Launcher
{
    partial class pagHome
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSnake = new System.Windows.Forms.Label();
            this.lblSimon = new System.Windows.Forms.Label();
            this.lblBird = new System.Windows.Forms.Label();
            this.lblTopo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = global::Launcher.Properties.Resources.Titulo;
            this.pictureBox1.Location = new System.Drawing.Point(99, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblSnake
            // 
            this.lblSnake.AutoSize = true;
            this.lblSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnake.ForeColor = System.Drawing.Color.White;
            this.lblSnake.Location = new System.Drawing.Point(101, 14);
            this.lblSnake.Name = "lblSnake";
            this.lblSnake.Size = new System.Drawing.Size(53, 39);
            this.lblSnake.TabIndex = 1;
            this.lblSnake.Text = "🐍";
            this.lblSnake.Visible = false;
            // 
            // lblSimon
            // 
            this.lblSimon.AutoSize = true;
            this.lblSimon.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimon.ForeColor = System.Drawing.Color.White;
            this.lblSimon.Location = new System.Drawing.Point(550, 14);
            this.lblSimon.Name = "lblSimon";
            this.lblSimon.Size = new System.Drawing.Size(55, 39);
            this.lblSimon.TabIndex = 2;
            this.lblSimon.Text = "🤔";
            this.lblSimon.Visible = false;
            // 
            // lblBird
            // 
            this.lblBird.AutoSize = true;
            this.lblBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBird.ForeColor = System.Drawing.Color.White;
            this.lblBird.Location = new System.Drawing.Point(101, 167);
            this.lblBird.Name = "lblBird";
            this.lblBird.Size = new System.Drawing.Size(55, 39);
            this.lblBird.TabIndex = 3;
            this.lblBird.Text = "🐤";
            this.lblBird.Visible = false;
            this.lblBird.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTopo
            // 
            this.lblTopo.AutoSize = true;
            this.lblTopo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopo.ForeColor = System.Drawing.Color.White;
            this.lblTopo.Location = new System.Drawing.Point(550, 167);
            this.lblTopo.Name = "lblTopo";
            this.lblTopo.Size = new System.Drawing.Size(55, 39);
            this.lblTopo.TabIndex = 4;
            this.lblTopo.Text = "🔨";
            this.lblTopo.Visible = false;
            // 
            // pagHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(688, 231);
            this.Controls.Add(this.lblTopo);
            this.Controls.Add(this.lblBird);
            this.Controls.Add(this.lblSimon);
            this.Controls.Add(this.lblSnake);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pagHome";
            this.Text = "pagHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSnake;
        private System.Windows.Forms.Label lblSimon;
        private System.Windows.Forms.Label lblBird;
        private System.Windows.Forms.Label lblTopo;
    }
}
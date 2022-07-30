namespace TareaReproductor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnReproducir = new System.Windows.Forms.Button();
            this.BtnParar = new System.Windows.Forms.Button();
            this.BtnPausa = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblRuta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnCargar.Location = new System.Drawing.Point(33, 391);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(90, 44);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Buscar ";
            this.BtnCargar.UseVisualStyleBackColor = false;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnReproducir
            // 
            this.BtnReproducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnReproducir.Location = new System.Drawing.Point(179, 391);
            this.BtnReproducir.Name = "BtnReproducir";
            this.BtnReproducir.Size = new System.Drawing.Size(87, 44);
            this.BtnReproducir.TabIndex = 1;
            this.BtnReproducir.Text = "Reproducir";
            this.BtnReproducir.UseVisualStyleBackColor = false;
            this.BtnReproducir.Click += new System.EventHandler(this.BtnReproducir_Click);
            // 
            // BtnParar
            // 
            this.BtnParar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnParar.Location = new System.Drawing.Point(315, 391);
            this.BtnParar.Name = "BtnParar";
            this.BtnParar.Size = new System.Drawing.Size(90, 44);
            this.BtnParar.TabIndex = 2;
            this.BtnParar.Text = "Parar";
            this.BtnParar.UseVisualStyleBackColor = false;
            this.BtnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // BtnPausa
            // 
            this.BtnPausa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnPausa.ForeColor = System.Drawing.Color.Black;
            this.BtnPausa.Location = new System.Drawing.Point(458, 391);
            this.BtnPausa.Name = "BtnPausa";
            this.BtnPausa.Size = new System.Drawing.Size(91, 44);
            this.BtnPausa.TabIndex = 3;
            this.BtnPausa.Text = "Pausa";
            this.BtnPausa.UseVisualStyleBackColor = false;
            this.BtnPausa.Click += new System.EventHandler(this.BtnPausa_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(33, 36);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(516, 336);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.ForeColor = System.Drawing.Color.Red;
            this.lblRuta.Location = new System.Drawing.Point(30, 20);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(33, 13);
            this.lblRuta.TabIndex = 5;
            this.lblRuta.Text = "Ruta:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(584, 447);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.BtnPausa);
            this.Controls.Add(this.BtnParar);
            this.Controls.Add(this.BtnReproducir);
            this.Controls.Add(this.BtnCargar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "REPRODUCTOR";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnReproducir;
        private System.Windows.Forms.Button BtnParar;
        private System.Windows.Forms.Button BtnPausa;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


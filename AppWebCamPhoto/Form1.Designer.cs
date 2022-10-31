
namespace AppWebCamPhoto
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
            this.pctCapturaImagem = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.cbbDispositivo = new System.Windows.Forms.ComboBox();
            this.sfdSalvarImagem = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturaImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCapturaImagem
            // 
            this.pctCapturaImagem.Location = new System.Drawing.Point(56, 39);
            this.pctCapturaImagem.Name = "pctCapturaImagem";
            this.pctCapturaImagem.Size = new System.Drawing.Size(265, 250);
            this.pctCapturaImagem.TabIndex = 0;
            this.pctCapturaImagem.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.Location = new System.Drawing.Point(397, 39);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(167, 46);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(397, 114);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(167, 46);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivo.Location = new System.Drawing.Point(56, 335);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(75, 16);
            this.lblDispositivo.TabIndex = 3;
            this.lblDispositivo.Text = "Dispositivo";
            // 
            // cbbDispositivo
            // 
            this.cbbDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDispositivo.FormattingEnabled = true;
            this.cbbDispositivo.Location = new System.Drawing.Point(59, 365);
            this.cbbDispositivo.Name = "cbbDispositivo";
            this.cbbDispositivo.Size = new System.Drawing.Size(262, 24);
            this.cbbDispositivo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 449);
            this.Controls.Add(this.cbbDispositivo);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.pctCapturaImagem);
            this.Name = "Form1";
            this.Text = "WebCam";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCapturaImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCapturaImagem;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.ComboBox cbbDispositivo;
        private System.Windows.Forms.SaveFileDialog sfdSalvarImagem;
    }
}


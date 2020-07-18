namespace PortasLogicas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.cbOpLogica = new System.Windows.Forms.ComboBox();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(500, 39);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(102, 44);
            this.btnAnalisar.TabIndex = 0;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // cbOpLogica
            // 
            this.cbOpLogica.FormattingEnabled = true;
            this.cbOpLogica.Location = new System.Drawing.Point(25, 39);
            this.cbOpLogica.Name = "cbOpLogica";
            this.cbOpLogica.Size = new System.Drawing.Size(159, 28);
            this.cbOpLogica.TabIndex = 1;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(268, 39);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 50);
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 147);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.cbOpLogica);
            this.Controls.Add(this.btnAnalisar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Portas Lógicas v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.ComboBox cbOpLogica;
        private System.Windows.Forms.PictureBox pb;
    }
}


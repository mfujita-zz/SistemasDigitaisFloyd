namespace Binary_Gray
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBinarioIn = new System.Windows.Forms.Label();
            this.txtBinary2GrayIn = new System.Windows.Forms.TextBox();
            this.btnBinary2Gray = new System.Windows.Forms.Button();
            this.txtBinary2GrayOut = new System.Windows.Forms.TextBox();
            this.lblGrayIn = new System.Windows.Forms.Label();
            this.lblGrayOut = new System.Windows.Forms.Label();
            this.txtGray2BinaryIn = new System.Windows.Forms.TextBox();
            this.btnGray2Binary = new System.Windows.Forms.Button();
            this.lblBinaryOut = new System.Windows.Forms.Label();
            this.txtGray2BinaryOut = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 214);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.lblGrayOut);
            this.tabPage1.Controls.Add(this.txtBinary2GrayOut);
            this.tabPage1.Controls.Add(this.btnBinary2Gray);
            this.tabPage1.Controls.Add(this.txtBinary2GrayIn);
            this.tabPage1.Controls.Add(this.lblBinarioIn);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Binário → Gray";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.txtGray2BinaryOut);
            this.tabPage2.Controls.Add(this.lblBinaryOut);
            this.tabPage2.Controls.Add(this.btnGray2Binary);
            this.tabPage2.Controls.Add(this.txtGray2BinaryIn);
            this.tabPage2.Controls.Add(this.lblGrayIn);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gray → Binário";
            // 
            // lblBinarioIn
            // 
            this.lblBinarioIn.AutoSize = true;
            this.lblBinarioIn.Location = new System.Drawing.Point(7, 14);
            this.lblBinarioIn.Name = "lblBinarioIn";
            this.lblBinarioIn.Size = new System.Drawing.Size(119, 19);
            this.lblBinarioIn.TabIndex = 0;
            this.lblBinarioIn.Text = "Código binário";
            // 
            // txtBinary2GrayIn
            // 
            this.txtBinary2GrayIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinary2GrayIn.Location = new System.Drawing.Point(11, 47);
            this.txtBinary2GrayIn.Name = "txtBinary2GrayIn";
            this.txtBinary2GrayIn.Size = new System.Drawing.Size(750, 26);
            this.txtBinary2GrayIn.TabIndex = 1;
            // 
            // btnBinary2Gray
            // 
            this.btnBinary2Gray.Location = new System.Drawing.Point(290, 90);
            this.btnBinary2Gray.Name = "btnBinary2Gray";
            this.btnBinary2Gray.Size = new System.Drawing.Size(180, 30);
            this.btnBinary2Gray.TabIndex = 2;
            this.btnBinary2Gray.Text = "Binário → Gray";
            this.btnBinary2Gray.UseVisualStyleBackColor = true;
            this.btnBinary2Gray.Click += new System.EventHandler(this.btnBinary2Gray_Click);
            // 
            // txtBinary2GrayOut
            // 
            this.txtBinary2GrayOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinary2GrayOut.Location = new System.Drawing.Point(11, 141);
            this.txtBinary2GrayOut.Name = "txtBinary2GrayOut";
            this.txtBinary2GrayOut.Size = new System.Drawing.Size(750, 26);
            this.txtBinary2GrayOut.TabIndex = 3;
            // 
            // lblGrayIn
            // 
            this.lblGrayIn.AutoSize = true;
            this.lblGrayIn.Location = new System.Drawing.Point(7, 14);
            this.lblGrayIn.Name = "lblGrayIn";
            this.lblGrayIn.Size = new System.Drawing.Size(105, 19);
            this.lblGrayIn.TabIndex = 0;
            this.lblGrayIn.Text = "Código Gray";
            // 
            // lblGrayOut
            // 
            this.lblGrayOut.AutoSize = true;
            this.lblGrayOut.Location = new System.Drawing.Point(7, 119);
            this.lblGrayOut.Name = "lblGrayOut";
            this.lblGrayOut.Size = new System.Drawing.Size(105, 19);
            this.lblGrayOut.TabIndex = 4;
            this.lblGrayOut.Text = "Código Gray";
            // 
            // txtGray2BinaryIn
            // 
            this.txtGray2BinaryIn.Location = new System.Drawing.Point(11, 46);
            this.txtGray2BinaryIn.Name = "txtGray2BinaryIn";
            this.txtGray2BinaryIn.Size = new System.Drawing.Size(750, 26);
            this.txtGray2BinaryIn.TabIndex = 1;
            // 
            // btnGray2Binary
            // 
            this.btnGray2Binary.Location = new System.Drawing.Point(290, 90);
            this.btnGray2Binary.Name = "btnGray2Binary";
            this.btnGray2Binary.Size = new System.Drawing.Size(180, 30);
            this.btnGray2Binary.TabIndex = 2;
            this.btnGray2Binary.Text = "Gray → Bináro";
            this.btnGray2Binary.UseVisualStyleBackColor = true;
            this.btnGray2Binary.Click += new System.EventHandler(this.btnGray2Binary_Click);
            // 
            // lblBinaryOut
            // 
            this.lblBinaryOut.AutoSize = true;
            this.lblBinaryOut.Location = new System.Drawing.Point(7, 119);
            this.lblBinaryOut.Name = "lblBinaryOut";
            this.lblBinaryOut.Size = new System.Drawing.Size(118, 19);
            this.lblBinaryOut.TabIndex = 3;
            this.lblBinaryOut.Text = "Código Binário";
            // 
            // txtGray2BinaryOut
            // 
            this.txtGray2BinaryOut.Location = new System.Drawing.Point(11, 141);
            this.txtGray2BinaryOut.Name = "txtGray2BinaryOut";
            this.txtGray2BinaryOut.Size = new System.Drawing.Size(750, 26);
            this.txtGray2BinaryOut.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 215);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Conversor Binario-Gray e Gray_Binário";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblGrayOut;
        private System.Windows.Forms.TextBox txtBinary2GrayOut;
        private System.Windows.Forms.Button btnBinary2Gray;
        private System.Windows.Forms.TextBox txtBinary2GrayIn;
        private System.Windows.Forms.Label lblBinarioIn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtGray2BinaryOut;
        private System.Windows.Forms.Label lblBinaryOut;
        private System.Windows.Forms.Button btnGray2Binary;
        private System.Windows.Forms.TextBox txtGray2BinaryIn;
        private System.Windows.Forms.Label lblGrayIn;
    }
}


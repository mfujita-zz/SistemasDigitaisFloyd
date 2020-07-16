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
            this.tabBinaryToGray = new System.Windows.Forms.TabPage();
            this.tabGray2Binary = new System.Windows.Forms.TabPage();
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
            this.tabLote = new System.Windows.Forms.TabPage();
            this.lblEntradaLote = new System.Windows.Forms.Label();
            this.txtLoteIn = new System.Windows.Forms.TextBox();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.txtLoteOut = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBinaryToGray.SuspendLayout();
            this.tabGray2Binary.SuspendLayout();
            this.tabLote.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBinaryToGray);
            this.tabControl1.Controls.Add(this.tabGray2Binary);
            this.tabControl1.Controls.Add(this.tabLote);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 214);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBinaryToGray
            // 
            this.tabBinaryToGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabBinaryToGray.Controls.Add(this.lblGrayOut);
            this.tabBinaryToGray.Controls.Add(this.txtBinary2GrayOut);
            this.tabBinaryToGray.Controls.Add(this.btnBinary2Gray);
            this.tabBinaryToGray.Controls.Add(this.txtBinary2GrayIn);
            this.tabBinaryToGray.Controls.Add(this.lblBinarioIn);
            this.tabBinaryToGray.Location = new System.Drawing.Point(4, 28);
            this.tabBinaryToGray.Name = "tabBinaryToGray";
            this.tabBinaryToGray.Padding = new System.Windows.Forms.Padding(3);
            this.tabBinaryToGray.Size = new System.Drawing.Size(780, 182);
            this.tabBinaryToGray.TabIndex = 0;
            this.tabBinaryToGray.Text = "Binário → Gray";
            // 
            // tabGray2Binary
            // 
            this.tabGray2Binary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabGray2Binary.Controls.Add(this.txtGray2BinaryOut);
            this.tabGray2Binary.Controls.Add(this.lblBinaryOut);
            this.tabGray2Binary.Controls.Add(this.btnGray2Binary);
            this.tabGray2Binary.Controls.Add(this.txtGray2BinaryIn);
            this.tabGray2Binary.Controls.Add(this.lblGrayIn);
            this.tabGray2Binary.Location = new System.Drawing.Point(4, 28);
            this.tabGray2Binary.Name = "tabGray2Binary";
            this.tabGray2Binary.Padding = new System.Windows.Forms.Padding(3);
            this.tabGray2Binary.Size = new System.Drawing.Size(780, 182);
            this.tabGray2Binary.TabIndex = 1;
            this.tabGray2Binary.Text = "Gray → Binário";
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
            // tabLote
            // 
            this.tabLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabLote.Controls.Add(this.btnConvert);
            this.tabLote.Controls.Add(this.txtLoteOut);
            this.tabLote.Controls.Add(this.cbChoose);
            this.tabLote.Controls.Add(this.txtLoteIn);
            this.tabLote.Controls.Add(this.lblEntradaLote);
            this.tabLote.Location = new System.Drawing.Point(4, 28);
            this.tabLote.Name = "tabLote";
            this.tabLote.Size = new System.Drawing.Size(973, 182);
            this.tabLote.TabIndex = 2;
            this.tabLote.Text = "Conversão em lote";
            // 
            // lblEntradaLote
            // 
            this.lblEntradaLote.AutoSize = true;
            this.lblEntradaLote.Location = new System.Drawing.Point(7, 69);
            this.lblEntradaLote.Name = "lblEntradaLote";
            this.lblEntradaLote.Size = new System.Drawing.Size(75, 19);
            this.lblEntradaLote.TabIndex = 0;
            this.lblEntradaLote.Text = "Entradas";
            // 
            // txtLoteIn
            // 
            this.txtLoteIn.Location = new System.Drawing.Point(88, 12);
            this.txtLoteIn.Multiline = true;
            this.txtLoteIn.Name = "txtLoteIn";
            this.txtLoteIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoteIn.Size = new System.Drawing.Size(292, 154);
            this.txtLoteIn.TabIndex = 1;
            // 
            // cbChoose
            // 
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Location = new System.Drawing.Point(389, 66);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(259, 27);
            this.cbChoose.TabIndex = 2;
            // 
            // txtLoteOut
            // 
            this.txtLoteOut.Location = new System.Drawing.Point(660, 12);
            this.txtLoteOut.Multiline = true;
            this.txtLoteOut.Name = "txtLoteOut";
            this.txtLoteOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoteOut.Size = new System.Drawing.Size(292, 154);
            this.txtLoteOut.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(453, 143);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(111, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 215);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Conversor Binario-Gray e Gray_Binário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBinaryToGray.ResumeLayout(false);
            this.tabBinaryToGray.PerformLayout();
            this.tabGray2Binary.ResumeLayout(false);
            this.tabGray2Binary.PerformLayout();
            this.tabLote.ResumeLayout(false);
            this.tabLote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBinaryToGray;
        private System.Windows.Forms.Label lblGrayOut;
        private System.Windows.Forms.TextBox txtBinary2GrayOut;
        private System.Windows.Forms.Button btnBinary2Gray;
        private System.Windows.Forms.TextBox txtBinary2GrayIn;
        private System.Windows.Forms.Label lblBinarioIn;
        private System.Windows.Forms.TabPage tabGray2Binary;
        private System.Windows.Forms.TextBox txtGray2BinaryOut;
        private System.Windows.Forms.Label lblBinaryOut;
        private System.Windows.Forms.Button btnGray2Binary;
        private System.Windows.Forms.TextBox txtGray2BinaryIn;
        private System.Windows.Forms.Label lblGrayIn;
        private System.Windows.Forms.TabPage tabLote;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtLoteOut;
        private System.Windows.Forms.ComboBox cbChoose;
        private System.Windows.Forms.TextBox txtLoteIn;
        private System.Windows.Forms.Label lblEntradaLote;
    }
}


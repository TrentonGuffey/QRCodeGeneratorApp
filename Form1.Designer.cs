namespace QRCodeGeneratorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerateQRCode = new Button();
            pictureBoxQRCode = new PictureBox();
            txtQRCodeText = new TextBox();
            btnCopyToClipboard = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // btnGenerateQRCode
            // 
            btnGenerateQRCode.BackColor = Color.Blue;
            btnGenerateQRCode.ForeColor = SystemColors.ButtonFace;
            btnGenerateQRCode.Location = new Point(118, 105);
            btnGenerateQRCode.Name = "btnGenerateQRCode";
            btnGenerateQRCode.Size = new Size(75, 23);
            btnGenerateQRCode.TabIndex = 0;
            btnGenerateQRCode.Text = "Generate";
            btnGenerateQRCode.UseVisualStyleBackColor = false;
            btnGenerateQRCode.Click += BtnGenerateQRCode_Click;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(362, 58);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(350, 350);
            pictureBoxQRCode.TabIndex = 1;
            pictureBoxQRCode.TabStop = false;
            // 
            // txtQRCodeText
            // 
            txtQRCodeText.Location = new Point(57, 58);
            txtQRCodeText.Name = "txtQRCodeText";
            txtQRCodeText.Size = new Size(249, 23);
            txtQRCodeText.TabIndex = 2;
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.BackColor = Color.FromArgb(0, 192, 0);
            btnCopyToClipboard.CausesValidation = false;
            btnCopyToClipboard.ForeColor = SystemColors.ButtonFace;
            btnCopyToClipboard.Location = new Point(259, 385);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new Size(75, 23);
            btnCopyToClipboard.TabIndex = 3;
            btnCopyToClipboard.Text = "Copy";
            btnCopyToClipboard.UseVisualStyleBackColor = false;
            btnCopyToClipboard.Click += BtnCopyToClipboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 40);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "Insert Text Below";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCopyToClipboard);
            Controls.Add(txtQRCodeText);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(btnGenerateQRCode);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerateQRCode;
        private PictureBox pictureBoxQRCode;
        private TextBox txtQRCodeText;
        private Button btnCopyToClipboard;
        private Label label1;
    }
}

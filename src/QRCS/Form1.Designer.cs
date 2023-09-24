using System.ComponentModel;

namespace QRCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            btnDecodeQR = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnDecodeQR
            // 
            btnDecodeQR.Location = new Point(12, 12);
            btnDecodeQR.Name = "btnDecodeQR";
            btnDecodeQR.Size = new Size(75, 23);
            btnDecodeQR.TabIndex = 0;
            btnDecodeQR.Text = "Decode QR Code";
            btnDecodeQR.UseVisualStyleBackColor = true;
            btnDecodeQR.Click += BtnDecodeQR_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDecodeQR);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDecodeQR;
        private OpenFileDialog openFileDialog1;
    }
}
﻿namespace compare_image
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
            this.btnFile2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnFile1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.dlgSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.txtFile2 = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picImage1 = new System.Windows.Forms.PictureBox();
            this.picImage2 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFile2
            // 
            this.btnFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile2.Image = ((System.Drawing.Image)(resources.GetObject("btnFile2.Image")));
            this.btnFile2.Location = new System.Drawing.Point(284, 42);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(24, 20);
            this.btnFile2.TabIndex = 3;
            this.btnFile2.UseVisualStyleBackColor = false;
            this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "File 2";
            // 
            // btnFile1
            // 
            this.btnFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile1.Image = ((System.Drawing.Image)(resources.GetObject("btnFile1.Image")));
            this.btnFile1.Location = new System.Drawing.Point(284, 16);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(24, 20);
            this.btnFile1.TabIndex = 1;
            this.btnFile1.UseVisualStyleBackColor = false;
            this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "File 1";
            // 
            // txtFile1
            // 
            this.txtFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile1.Location = new System.Drawing.Point(50, 16);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(228, 20);
            this.txtFile1.TabIndex = 0;
            // 
            // picResult
            // 
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Location = new System.Drawing.Point(127, 3);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(56, 50);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picResult.TabIndex = 0;
            this.picResult.TabStop = false;
            // 
            // dlgSelectFile
            // 
            this.dlgSelectFile.Filter = "Graphics Files|*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png;*.tif;*.tiff|All Files|*.*";
            this.dlgSelectFile.Title = "Select File";
            // 
            // txtFile2
            // 
            this.txtFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile2.Location = new System.Drawing.Point(50, 42);
            this.txtFile2.Name = "txtFile2";
            this.txtFile2.Size = new System.Drawing.Size(228, 20);
            this.txtFile2.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(136, 68);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(48, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.picImage1);
            this.flowLayoutPanel1.Controls.Add(this.picImage2);
            this.flowLayoutPanel1.Controls.Add(this.picResult);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 172);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // picImage1
            // 
            this.picImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage1.Location = new System.Drawing.Point(3, 3);
            this.picImage1.Name = "picImage1";
            this.picImage1.Size = new System.Drawing.Size(56, 50);
            this.picImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage1.TabIndex = 1;
            this.picImage1.TabStop = false;
            // 
            // picImage2
            // 
            this.picImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage2.Location = new System.Drawing.Point(65, 3);
            this.picImage2.Name = "picImage2";
            this.picImage2.Size = new System.Drawing.Size(56, 50);
            this.picImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage2.TabIndex = 2;
            this.picImage2.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnFile2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnFile1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtFile1);
            this.Controls.Add(this.txtFile2);
            this.Controls.Add(this.btnGo);
            this.Name = "Form1";
            this.Text = "compare_image";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnFile2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnFile1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtFile1;
        internal System.Windows.Forms.PictureBox picResult;
        internal System.Windows.Forms.OpenFileDialog dlgSelectFile;
        internal System.Windows.Forms.TextBox txtFile2;
        internal System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.PictureBox picImage1;
        internal System.Windows.Forms.PictureBox picImage2;
        internal System.Windows.Forms.Label lblResult;
    }
}


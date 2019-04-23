namespace Find
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picFind = new System.Windows.Forms.PictureBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFind)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐẠI HỌC SƯ PHẠM KỸ THUẬT THÀNH PHỐ HCM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Find.Properties.Resources.sodo;
            this.pictureBox1.Location = new System.Drawing.Point(281, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picFind
            // 
            this.picFind.Image = global::Find.Properties.Resources.find;
            this.picFind.Location = new System.Drawing.Point(234, 52);
            this.picFind.Margin = new System.Windows.Forms.Padding(6);
            this.picFind.Name = "picFind";
            this.picFind.Size = new System.Drawing.Size(38, 33);
            this.picFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFind.TabIndex = 0;
            this.picFind.TabStop = false;
            this.picFind.Click += new System.EventHandler(this.picFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(12, 52);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(213, 32);
            this.txtFind.TabIndex = 0;
            this.txtFind.TabStop = false;
            this.txtFind.Text = "tên phòng học cần tìm";
            this.txtFind.Click += new System.EventHandler(this.txtFind_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 159);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(260, 101);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 459);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picFind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Tìm đường";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label txtResult;
    }
}


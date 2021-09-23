
namespace FinalProjectDhruvP
{
    partial class FormAwesomeness
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
            this.buttonRightNo = new System.Windows.Forms.Button();
            this.buttonLeftNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRightNo
            // 
            this.buttonRightNo.Location = new System.Drawing.Point(229, 207);
            this.buttonRightNo.Name = "buttonRightNo";
            this.buttonRightNo.Size = new System.Drawing.Size(94, 29);
            this.buttonRightNo.TabIndex = 7;
            this.buttonRightNo.Text = "&No";
            this.buttonRightNo.UseVisualStyleBackColor = true;
            this.buttonRightNo.Visible = false;
            this.buttonRightNo.Click += new System.EventHandler(this.buttonRightNo_Click);
            // 
            // buttonLeftNo
            // 
            this.buttonLeftNo.Location = new System.Drawing.Point(113, 207);
            this.buttonLeftNo.Name = "buttonLeftNo";
            this.buttonLeftNo.Size = new System.Drawing.Size(94, 29);
            this.buttonLeftNo.TabIndex = 6;
            this.buttonLeftNo.Text = "&No";
            this.buttonLeftNo.UseVisualStyleBackColor = true;
            this.buttonLeftNo.Click += new System.EventHandler(this.buttonLeftNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(13, 207);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(94, 29);
            this.buttonYes.TabIndex = 5;
            this.buttonYes.Text = "&Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 160);
            this.label1.TabIndex = 4;
            this.label1.Text = "In May of 2021, \r\nthe computer has detected \r\nthat Dhruv is awesome.  \r\nIs it pos" +
    "sible that \r\nthey are awesome?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAwesomeness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 247);
            this.Controls.Add(this.buttonRightNo);
            this.Controls.Add(this.buttonLeftNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAwesomeness";
            this.Text = "Awesomeness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRightNo;
        private System.Windows.Forms.Button buttonLeftNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label label1;
    }
}
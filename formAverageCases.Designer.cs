
namespace FinalProjectDhruvP
{
    partial class FormAverageCases
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
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.textBoxCaseList = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxCaseEntry = new System.Windows.Forms.TextBox();
            this.labelCasePrompt = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(333, 399);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(113, 29);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "&Close";
            this.toolTip.SetToolTip(this.buttonClose, "Click to Exit the form.");
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(177, 399);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(113, 29);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset this form to normal one");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(20, 399);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(113, 29);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to get the current number of cases");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.EnterClick);
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(19, 354);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(427, 25);
            this.labelAverageOutput.TabIndex = 12;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCaseList
            // 
            this.textBoxCaseList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCaseList.Location = new System.Drawing.Point(19, 95);
            this.textBoxCaseList.Multiline = true;
            this.textBoxCaseList.Name = "textBoxCaseList";
            this.textBoxCaseList.ReadOnly = true;
            this.textBoxCaseList.Size = new System.Drawing.Size(427, 220);
            this.textBoxCaseList.TabIndex = 11;
            this.textBoxCaseList.TabStop = false;
            this.toolTip.SetToolTip(this.textBoxCaseList, "This week\'s historic case");
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(327, 25);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(119, 20);
            this.labelDay.TabIndex = 10;
            this.labelDay.Text = "Day 1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDay.UseCompatibleTextRendering = true;
            // 
            // textBoxCaseEntry
            // 
            this.textBoxCaseEntry.Location = new System.Drawing.Point(125, 23);
            this.textBoxCaseEntry.Name = "textBoxCaseEntry";
            this.textBoxCaseEntry.Size = new System.Drawing.Size(165, 27);
            this.textBoxCaseEntry.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxCaseEntry, "Enter this Day");
            // 
            // labelCasePrompt
            // 
            this.labelCasePrompt.Location = new System.Drawing.Point(19, 25);
            this.labelCasePrompt.Name = "labelCasePrompt";
            this.labelCasePrompt.Size = new System.Drawing.Size(119, 25);
            this.labelCasePrompt.TabIndex = 8;
            this.labelCasePrompt.Text = "Daily &Cases:";
            this.labelCasePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAverageCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.textBoxCaseList);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxCaseEntry);
            this.Controls.Add(this.labelCasePrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAverageCases";
            this.Text = "Average Cases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.TextBox textBoxCaseList;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxCaseEntry;
        private System.Windows.Forms.Label labelCasePrompt;
    }
}

namespace FinalProjectDhruvP
{
    partial class FormContactTracer
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
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelContacted = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.dataGridViewEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContacted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTracer = new System.Windows.Forms.DataGridView();
            this.checkBoxContacted = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(543, 605);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 29);
            this.buttonClose.TabIndex = 29;
            this.buttonClose.Text = "&Close";
            this.toolTip1.SetToolTip(this.buttonClose, "Exits the application.");
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(443, 605);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 28;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Makes the form default.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(343, 605);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 27;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "By clicking this will display the entered value in DataGridView.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(10, 475);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(627, 110);
            this.textBoxOutput.TabIndex = 26;
            this.toolTip1.SetToolTip(this.textBoxOutput, "Displays Error Message if an of the Value is not entered.");
            // 
            // labelContacted
            // 
            this.labelContacted.AutoSize = true;
            this.labelContacted.Location = new System.Drawing.Point(227, 183);
            this.labelContacted.Name = "labelContacted";
            this.labelContacted.Size = new System.Drawing.Size(80, 20);
            this.labelContacted.TabIndex = 23;
            this.labelContacted.Text = "&Contacted:";
            this.labelContacted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(201, 99);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(106, 20);
            this.labelEmailAddress.TabIndex = 19;
            this.labelEmailAddress.Text = "&Email Address:";
            this.labelEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(225, 52);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(82, 20);
            this.labelLastName.TabIndex = 17;
            this.labelLastName.Text = "&Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(224, 15);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(83, 20);
            this.labelFirstName.TabIndex = 15;
            this.labelFirstName.Text = "&First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewEmail
            // 
            this.dataGridViewEmail.HeaderText = "Email";
            this.dataGridViewEmail.MinimumWidth = 6;
            this.dataGridViewEmail.Name = "dataGridViewEmail";
            this.dataGridViewEmail.ReadOnly = true;
            this.dataGridViewEmail.Width = 125;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 125;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.MinimumWidth = 6;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Width = 125;
            // 
            // colContacted
            // 
            this.colContacted.DataPropertyName = "Contacted";
            this.colContacted.HeaderText = "Contacted";
            this.colContacted.MinimumWidth = 6;
            this.colContacted.Name = "colContacted";
            this.colContacted.ReadOnly = true;
            this.colContacted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colContacted.Width = 125;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // dataGridViewTracer
            // 
            this.dataGridViewTracer.AllowUserToAddRows = false;
            this.dataGridViewTracer.AllowUserToDeleteRows = false;
            this.dataGridViewTracer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.colContacted,
            this.colFirstName,
            this.colLastName,
            this.colDate,
            this.dataGridViewEmail});
            this.dataGridViewTracer.Location = new System.Drawing.Point(11, 226);
            this.dataGridViewTracer.MultiSelect = false;
            this.dataGridViewTracer.Name = "dataGridViewTracer";
            this.dataGridViewTracer.ReadOnly = true;
            this.dataGridViewTracer.RowHeadersVisible = false;
            this.dataGridViewTracer.RowHeadersWidth = 51;
            this.dataGridViewTracer.RowTemplate.Height = 29;
            this.dataGridViewTracer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTracer.Size = new System.Drawing.Size(627, 224);
            this.dataGridViewTracer.TabIndex = 25;
            this.toolTip1.SetToolTip(this.dataGridViewTracer, "Displays data which is entered in the textboxes.");
            // 
            // checkBoxContacted
            // 
            this.checkBoxContacted.AutoSize = true;
            this.checkBoxContacted.Location = new System.Drawing.Point(313, 186);
            this.checkBoxContacted.Name = "checkBoxContacted";
            this.checkBoxContacted.Size = new System.Drawing.Size(18, 17);
            this.checkBoxContacted.TabIndex = 24;
            this.toolTip1.SetToolTip(this.checkBoxContacted, "Check the Box if it is contacted.");
            this.checkBoxContacted.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(313, 140);
            this.maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxPhoneNumber.TabIndex = 22;
            this.toolTip1.SetToolTip(this.maskedTextBoxPhoneNumber, "Enter Phone Number.");
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(196, 143);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(111, 20);
            this.labelPhoneNumber.TabIndex = 21;
            this.labelPhoneNumber.Text = "&Phone Number:";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(313, 96);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxEmail.TabIndex = 20;
            this.toolTip1.SetToolTip(this.maskedTextBoxEmail, "Enter Your Email Address Here.");
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(313, 52);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(125, 27);
            this.textBoxLastName.TabIndex = 18;
            this.toolTip1.SetToolTip(this.textBoxLastName, "Enter Your Last Name Here.");
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(313, 8);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(125, 27);
            this.textBoxFirstName.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxFirstName, "Enter Your First Name Here.");
            // 
            // FormContactTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 648);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelContacted);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.dataGridViewTracer);
            this.Controls.Add(this.checkBoxContacted);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.maskedTextBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContactTracer";
            this.Text = "Contact Tracer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelContacted;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colContacted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridView dataGridViewTracer;
        private System.Windows.Forms.CheckBox checkBoxContacted;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
    }
}
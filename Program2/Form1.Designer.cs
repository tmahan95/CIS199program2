namespace Program2
{
    partial class Prog2
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.creditsTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regisButton = new System.Windows.Forms.Button();
            this.regLbl = new System.Windows.Forms.Label();
            this.regTAndDLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(41, 77);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 0;
            // 
            // creditsTxtBox
            // 
            this.creditsTxtBox.Location = new System.Drawing.Point(197, 77);
            this.creditsTxtBox.Name = "creditsTxtBox";
            this.creditsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.creditsTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Total Credits Earned:";
            // 
            // regisButton
            // 
            this.regisButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.regisButton.Location = new System.Drawing.Point(131, 212);
            this.regisButton.Name = "regisButton";
            this.regisButton.Size = new System.Drawing.Size(75, 37);
            this.regisButton.TabIndex = 4;
            this.regisButton.Text = "Show Registration";
            this.regisButton.UseVisualStyleBackColor = true;
            this.regisButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // regLbl
            // 
            this.regLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regLbl.Location = new System.Drawing.Point(107, 163);
            this.regLbl.Name = "regLbl";
            this.regLbl.Size = new System.Drawing.Size(123, 26);
            this.regLbl.TabIndex = 5;
            this.regLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // regTAndDLbl
            // 
            this.regTAndDLbl.AutoSize = true;
            this.regTAndDLbl.Location = new System.Drawing.Point(104, 137);
            this.regTAndDLbl.Name = "regTAndDLbl";
            this.regTAndDLbl.Size = new System.Drawing.Size(136, 13);
            this.regTAndDLbl.TabIndex = 6;
            this.regTAndDLbl.Text = "Registration Time and Date";
            // 
            // Prog2
            // 
            this.AcceptButton = this.regisButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.regTAndDLbl);
            this.Controls.Add(this.regLbl);
            this.Controls.Add(this.regisButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditsTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "Prog2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox creditsTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regisButton;
        private System.Windows.Forms.Label regLbl;
        private System.Windows.Forms.Label regTAndDLbl;
    }
}


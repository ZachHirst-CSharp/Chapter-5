namespace TestingForms_Greeting
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
            this.userentry_txtBox = new System.Windows.Forms.TextBox();
            this.btngreet = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many greetings would you like?";
            // 
            // userentry_txtBox
            // 
            this.userentry_txtBox.Location = new System.Drawing.Point(315, 70);
            this.userentry_txtBox.Name = "userentry_txtBox";
            this.userentry_txtBox.Size = new System.Drawing.Size(100, 20);
            this.userentry_txtBox.TabIndex = 1;
            // 
            // btngreet
            // 
            this.btngreet.Location = new System.Drawing.Point(224, 161);
            this.btngreet.Name = "btngreet";
            this.btngreet.Size = new System.Drawing.Size(75, 23);
            this.btngreet.TabIndex = 2;
            this.btngreet.Text = "greet";
            this.btngreet.UseVisualStyleBackColor = true;
            this.btngreet.Click += new System.EventHandler(this.btngreet_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(384, 161);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btngreet);
            this.Controls.Add(this.userentry_txtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userentry_txtBox;
        private System.Windows.Forms.Button btngreet;
        private System.Windows.Forms.Button btnclear;
    }
}


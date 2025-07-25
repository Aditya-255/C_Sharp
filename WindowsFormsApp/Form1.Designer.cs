namespace WindowsFormsApp
{
    partial class Label
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
            this.label4 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the num1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter the num2:";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(209, 102);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 22);
            this.A.TabIndex = 2;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(209, 132);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 22);
            this.B.TabIndex = 3;
            this.B.TextChanged += new System.EventHandler(this.B_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(162, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(243, 177);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(164, 23);
            this.ans.TabIndex = 5;
            this.ans.Text = "Answer";
            this.ans.UseVisualStyleBackColor = true;
            this.ans.Visible = false;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // Label
            // 
            this.ClientSize = new System.Drawing.Size(627, 518);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Label";
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox num01;
        private System.Windows.Forms.TextBox num02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ans;
    }
}


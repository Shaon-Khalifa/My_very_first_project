
namespace calculator
{
    partial class calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.FIRST = new System.Windows.Forms.TextBox();
            this.SECOND = new System.Windows.Forms.TextBox();
            this.SUM = new System.Windows.Forms.Button();
            this.MINUS = new System.Windows.Forms.Button();
            this.DIVIDE = new System.Windows.Forms.Button();
            this.MULIPLE = new System.Windows.Forms.Button();
            this.RESULT = new System.Windows.Forms.Label();
            this.RESULTS = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST NUMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "SECOND NUMBER";
            // 
            // FIRST
            // 
            this.FIRST.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRST.Location = new System.Drawing.Point(447, 44);
            this.FIRST.Name = "FIRST";
            this.FIRST.Size = new System.Drawing.Size(251, 42);
            this.FIRST.TabIndex = 0;
            // 
            // SECOND
            // 
            this.SECOND.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SECOND.Location = new System.Drawing.Point(447, 107);
            this.SECOND.Name = "SECOND";
            this.SECOND.Size = new System.Drawing.Size(251, 42);
            this.SECOND.TabIndex = 1;
            // 
            // SUM
            // 
            this.SUM.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUM.Location = new System.Drawing.Point(447, 174);
            this.SUM.Name = "SUM";
            this.SUM.Size = new System.Drawing.Size(75, 40);
            this.SUM.TabIndex = 2;
            this.SUM.Text = "+";
            this.SUM.UseVisualStyleBackColor = true;
            this.SUM.Click += new System.EventHandler(this.SUM_Click);
            // 
            // MINUS
            // 
            this.MINUS.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MINUS.Location = new System.Drawing.Point(528, 174);
            this.MINUS.Name = "MINUS";
            this.MINUS.Size = new System.Drawing.Size(75, 40);
            this.MINUS.TabIndex = 3;
            this.MINUS.Text = "-";
            this.MINUS.UseVisualStyleBackColor = true;
            this.MINUS.Click += new System.EventHandler(this.MINUS_Click);
            // 
            // DIVIDE
            // 
            this.DIVIDE.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIVIDE.Location = new System.Drawing.Point(528, 220);
            this.DIVIDE.Name = "DIVIDE";
            this.DIVIDE.Size = new System.Drawing.Size(75, 40);
            this.DIVIDE.TabIndex = 5;
            this.DIVIDE.Text = "/";
            this.DIVIDE.UseVisualStyleBackColor = true;
            this.DIVIDE.Click += new System.EventHandler(this.DIVIDE_Click);
            // 
            // MULIPLE
            // 
            this.MULIPLE.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MULIPLE.Location = new System.Drawing.Point(447, 220);
            this.MULIPLE.Name = "MULIPLE";
            this.MULIPLE.Size = new System.Drawing.Size(75, 40);
            this.MULIPLE.TabIndex = 4;
            this.MULIPLE.Text = "*";
            this.MULIPLE.UseVisualStyleBackColor = true;
            this.MULIPLE.Click += new System.EventHandler(this.MULIPLE_Click);
            // 
            // RESULT
            // 
            this.RESULT.AutoSize = true;
            this.RESULT.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULT.Location = new System.Drawing.Point(144, 280);
            this.RESULT.Name = "RESULT";
            this.RESULT.Size = new System.Drawing.Size(103, 34);
            this.RESULT.TabIndex = 4;
            this.RESULT.Text = "RESULT";
            // 
            // RESULTS
            // 
            this.RESULTS.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTS.Location = new System.Drawing.Point(447, 284);
            this.RESULTS.Name = "RESULTS";
            this.RESULTS.Size = new System.Drawing.Size(251, 42);
            this.RESULTS.TabIndex = 6;
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(633, 174);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(90, 86);
            this.C.TabIndex = 7;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.C);
            this.Controls.Add(this.RESULTS);
            this.Controls.Add(this.RESULT);
            this.Controls.Add(this.MULIPLE);
            this.Controls.Add(this.DIVIDE);
            this.Controls.Add(this.MINUS);
            this.Controls.Add(this.SUM);
            this.Controls.Add(this.SECOND);
            this.Controls.Add(this.FIRST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIRST;
        private System.Windows.Forms.TextBox SECOND;
        private System.Windows.Forms.Button SUM;
        private System.Windows.Forms.Button MINUS;
        private System.Windows.Forms.Button DIVIDE;
        private System.Windows.Forms.Button MULIPLE;
        private System.Windows.Forms.Label RESULT;
        private System.Windows.Forms.TextBox RESULTS;
        private System.Windows.Forms.Button C;
    }
}


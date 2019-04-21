namespace Kinderbijslag
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddChild = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Label();
            this.Bereken = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // AddChild
            // 
            this.AddChild.Location = new System.Drawing.Point(252, 12);
            this.AddChild.Name = "AddChild";
            this.AddChild.Size = new System.Drawing.Size(29, 20);
            this.AddChild.TabIndex = 1;
            this.AddChild.Text = "+";
            this.AddChild.UseVisualStyleBackColor = true;
            this.AddChild.Click += new System.EventHandler(this.AddChild_Click);
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Location = new System.Drawing.Point(5, 16);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(34, 13);
            this.NO.TabIndex = 2;
            this.NO.Text = "Kind1";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(46, 51);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(200, 23);
            this.Bereken.TabIndex = 3;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(43, 89);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(203, 23);
            this.Output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 121);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.AddChild);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Kinderbijslag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddChild;
        private System.Windows.Forms.Label NO;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label Output;
    }
}


namespace numsquare
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
            this.NumBox = new System.Windows.Forms.TextBox();
            this.numsList = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(85, 146);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(100, 22);
            this.NumBox.TabIndex = 1;
            this.NumBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.NumBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumBox_KeyDown);
            // 
            // numsList
            // 
            this.numsList.Location = new System.Drawing.Point(12, 12);
            this.numsList.Name = "numsList";
            this.numsList.Size = new System.Drawing.Size(261, 113);
            this.numsList.TabIndex = 2;
            this.numsList.UseCompatibleStateImageBehavior = false;
            this.numsList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numsList);
            this.Controls.Add(this.NumBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.ListView numsList;
        private System.Windows.Forms.Button button1;
    }
}


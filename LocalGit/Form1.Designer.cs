namespace LocalGit
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
            this.btmHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmHello
            // 
            this.btmHello.Location = new System.Drawing.Point(168, 71);
            this.btmHello.Name = "btmHello";
            this.btmHello.Size = new System.Drawing.Size(75, 23);
            this.btmHello.TabIndex = 0;
            this.btmHello.Text = "Hello";
            this.btmHello.UseVisualStyleBackColor = true;
            this.btmHello.Click += new System.EventHandler(this.btmHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btmHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmHello;
    }
}


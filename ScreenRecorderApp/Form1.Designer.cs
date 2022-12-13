namespace ScreenRecordApp
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
            this.recordStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recordStart
            // 
            this.recordStart.Location = new System.Drawing.Point(183, 78);
            this.recordStart.Name = "recordStart";
            this.recordStart.Size = new System.Drawing.Size(104, 42);
            this.recordStart.TabIndex = 0;
            this.recordStart.Text = "Start Recording";
            this.recordStart.UseVisualStyleBackColor = true;
            this.recordStart.Click += new System.EventHandler(this.recordStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recording...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordStart);
            this.Name = "Form1";
            this.Text = "Screen Record Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recordStart;
        private System.Windows.Forms.Label label1;
    }
}


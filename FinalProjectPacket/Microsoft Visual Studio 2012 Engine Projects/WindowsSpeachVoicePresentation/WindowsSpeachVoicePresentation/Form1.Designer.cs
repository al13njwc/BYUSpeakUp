namespace WindowsSpeachVoicePresentation
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
            this.mainForm = new System.Windows.Forms.RichTextBox();
            this.enableBtn = new System.Windows.Forms.Button();
            this.disableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainForm
            // 
            this.mainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainForm.Location = new System.Drawing.Point(12, 12);
            this.mainForm.Name = "mainForm";
            this.mainForm.Size = new System.Drawing.Size(686, 444);
            this.mainForm.TabIndex = 0;
            this.mainForm.Text = "";
            this.mainForm.TextChanged += new System.EventHandler(this.mainForm_TextChanged);
            // 
            // enableBtn
            // 
            this.enableBtn.Location = new System.Drawing.Point(12, 462);
            this.enableBtn.Name = "enableBtn";
            this.enableBtn.Size = new System.Drawing.Size(134, 23);
            this.enableBtn.TabIndex = 1;
            this.enableBtn.Text = "Enable Voice Control";
            this.enableBtn.UseVisualStyleBackColor = true;
            this.enableBtn.Click += new System.EventHandler(this.enableBtn_Click);
            // 
            // disableBtn
            // 
            this.disableBtn.Enabled = false;
            this.disableBtn.Location = new System.Drawing.Point(564, 462);
            this.disableBtn.Name = "disableBtn";
            this.disableBtn.Size = new System.Drawing.Size(134, 23);
            this.disableBtn.TabIndex = 2;
            this.disableBtn.Text = "Disable Voice Control";
            this.disableBtn.UseVisualStyleBackColor = true;
            this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 497);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.enableBtn);
            this.Controls.Add(this.mainForm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speak Up Voice Recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainForm;
        private System.Windows.Forms.Button enableBtn;
        private System.Windows.Forms.Button disableBtn;
    }
}


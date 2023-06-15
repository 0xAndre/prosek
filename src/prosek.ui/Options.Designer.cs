namespace prosek.ui
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            buttonOptionsSave = new Button();
            textBoxAbuseHeader = new TextBox();
            labelAbusHeader = new Label();
            SuspendLayout();
            // 
            // buttonOptionsSave
            // 
            buttonOptionsSave.Location = new Point(462, 71);
            buttonOptionsSave.Name = "buttonOptionsSave";
            buttonOptionsSave.Size = new Size(75, 23);
            buttonOptionsSave.TabIndex = 0;
            buttonOptionsSave.Text = "Save";
            buttonOptionsSave.UseVisualStyleBackColor = true;
            buttonOptionsSave.Click += buttonOptionsSave_Click;
            // 
            // textBoxAbuseHeader
            // 
            textBoxAbuseHeader.Location = new Point(158, 21);
            textBoxAbuseHeader.Name = "textBoxAbuseHeader";
            textBoxAbuseHeader.Size = new Size(379, 23);
            textBoxAbuseHeader.TabIndex = 1;
            // 
            // labelAbusHeader
            // 
            labelAbusHeader.AutoSize = true;
            labelAbusHeader.Location = new Point(12, 24);
            labelAbusHeader.Name = "labelAbusHeader";
            labelAbusHeader.Size = new Size(140, 15);
            labelAbusHeader.TabIndex = 2;
            labelAbusHeader.Text = "X-VT-Anti-Abuse-Header";
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 109);
            Controls.Add(labelAbusHeader);
            Controls.Add(textBoxAbuseHeader);
            Controls.Add(buttonOptionsSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Options";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            Load += Options_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOptionsSave;
        private TextBox textBoxAbuseHeader;
        private Label labelAbusHeader;
    }
}
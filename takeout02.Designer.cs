namespace Pizza_LoadingScreen
{
    partial class takeout02
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
            this.takeout1 = new Pizza_LoadingScreen.Takeout();
            this.SuspendLayout();
            // 
            // takeout1
            // 
            this.takeout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.takeout1.Location = new System.Drawing.Point(0, -251);
            this.takeout1.Name = "takeout1";
            this.takeout1.Size = new System.Drawing.Size(432, 502);
            this.takeout1.TabIndex = 0;
            // 
            // takeout02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 251);
            this.Controls.Add(this.takeout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "takeout02";
            this.Text = "takeout02";
            this.ResumeLayout(false);

        }

        #endregion

        private Takeout takeout1;
    }
}
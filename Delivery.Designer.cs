
namespace Pizza_LoadingScreen
{
    partial class Delivery
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
            this.delivery_03_2 = new Pizza_LoadingScreen.Delivery_03_();
            this.SuspendLayout();
            // 
            // delivery_03_2
            // 
            this.delivery_03_2.BackColor = System.Drawing.Color.White;
            this.delivery_03_2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.delivery_03_2.Location = new System.Drawing.Point(0, -251);
            this.delivery_03_2.Name = "delivery_03_2";
            this.delivery_03_2.Size = new System.Drawing.Size(432, 502);
            this.delivery_03_2.TabIndex = 0;
            this.delivery_03_2.Load += new System.EventHandler(this.delivery_03_2_Load);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 251);
            this.Controls.Add(this.delivery_03_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.ResumeLayout(false);

        }

        #endregion

        private Delivery_03_ delivery_03_1;
        private Delivery_03_ delivery_03_2;
    }
}
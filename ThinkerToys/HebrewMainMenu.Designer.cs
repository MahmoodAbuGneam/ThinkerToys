namespace ThinkerToys
{
    partial class HebrewMainMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponents()
        {
            SuspendLayout();
            // 
            // HebrewMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Name = "HebrewMainMenu";
            Text = "Main Menu";
            Load += HebrewMainMenu_Load;
            ResumeLayout(false);
        }
    }
}

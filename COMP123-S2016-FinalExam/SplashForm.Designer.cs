namespace COMP123_S2016_FinalExam
{
    partial class SplashForm
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
            this.InsertingImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InsertingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertingImage
            // 
            this.InsertingImage.Image = global::COMP123_S2016_FinalExam.Properties.Resources.splashSceen1;
            this.InsertingImage.Location = new System.Drawing.Point(123, 39);
            this.InsertingImage.Name = "InsertingImage";
            this.InsertingImage.Size = new System.Drawing.Size(100, 50);
            this.InsertingImage.TabIndex = 0;
            this.InsertingImage.TabStop = false;
            // 
            // SplashForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 304);
            this.ControlBox = false;
            this.Controls.Add(this.InsertingImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InsertingImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox InsertingImage;
    }
}
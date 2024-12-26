namespace Tyuiu.OsadetsAA.Sprint7.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_OAA = new PictureBox();
            labelInfo_OAA = new Label();
            buttonOK_OAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_OAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_OAA
            // 
            pictureBoxAvatar_OAA.Image = (Image)resources.GetObject("pictureBoxAvatar_OAA.Image");
            pictureBoxAvatar_OAA.Location = new Point(12, 12);
            pictureBoxAvatar_OAA.Name = "pictureBoxAvatar_OAA";
            pictureBoxAvatar_OAA.Size = new Size(179, 228);
            pictureBoxAvatar_OAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_OAA.TabIndex = 2;
            pictureBoxAvatar_OAA.TabStop = false;
            // 
            // labelInfo_OAA
            // 
            labelInfo_OAA.AutoSize = true;
            labelInfo_OAA.Location = new Point(197, 12);
            labelInfo_OAA.Name = "labelInfo_OAA";
            labelInfo_OAA.Size = new Size(387, 200);
            labelInfo_OAA.TabIndex = 3;
            labelInfo_OAA.Text = resources.GetString("labelInfo_OAA.Text");
            // 
            // buttonOK_OAA
            // 
            buttonOK_OAA.BackColor = SystemColors.Control;
            buttonOK_OAA.Location = new Point(464, 219);
            buttonOK_OAA.Name = "buttonOK_OAA";
            buttonOK_OAA.Size = new Size(120, 29);
            buttonOK_OAA.TabIndex = 4;
            buttonOK_OAA.Text = "Ок";
            buttonOK_OAA.UseVisualStyleBackColor = false;
            buttonOK_OAA.Click += buttonOK_OAA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 260);
            Controls.Add(buttonOK_OAA);
            Controls.Add(labelInfo_OAA);
            Controls.Add(pictureBoxAvatar_OAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_OAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_OAA;
        private Label labelInfo_OAA;
        private Button buttonOK_OAA;
    }
}
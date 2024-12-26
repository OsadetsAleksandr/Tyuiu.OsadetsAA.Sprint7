namespace Tyuiu.OsadetsAA.Sprint7.V7
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            labelHelpButtons_OAA = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelHelpButtons_OAA
            // 
            labelHelpButtons_OAA.AutoSize = true;
            labelHelpButtons_OAA.Location = new Point(12, 9);
            labelHelpButtons_OAA.Name = "labelHelpButtons_OAA";
            labelHelpButtons_OAA.Size = new Size(882, 200);
            labelHelpButtons_OAA.TabIndex = 0;
            labelHelpButtons_OAA.Text = resources.GetString("labelHelpButtons_OAA.Text");
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(804, 349);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 1;
            button1.Text = "Ок";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 390);
            Controls.Add(button1);
            Controls.Add(labelHelpButtons_OAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHelp";
            Text = "Краткое руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHelpButtons_OAA;
        private Button button1;
    }
}
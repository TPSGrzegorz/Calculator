namespace CalculatorWFA
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
            this.newButton1 = new CalculatorWFA.NewButton();
            this.SuspendLayout();
            // 
            // newButton1
            // 
            this.newButton1.Location = new System.Drawing.Point(12, 243);
            this.newButton1.Name = "newButton1";
            this.newButton1.Size = new System.Drawing.Size(50, 49);
            this.newButton1.TabIndex = 0;
            this.newButton1.Text = "newButton1";
            this.newButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 304);
            this.Controls.Add(this.newButton1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private NewButton newButton1;
    }
}


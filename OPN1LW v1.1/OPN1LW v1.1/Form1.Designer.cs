namespace OPN1LW_v1._1
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
            this.SimulationFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SimulationFormButton
            // 
            this.SimulationFormButton.Location = new System.Drawing.Point(95, 26);
            this.SimulationFormButton.Name = "SimulationFormButton";
            this.SimulationFormButton.Size = new System.Drawing.Size(125, 23);
            this.SimulationFormButton.TabIndex = 0;
            this.SimulationFormButton.Text = "Започни симулација";
            this.SimulationFormButton.UseVisualStyleBackColor = true;
            this.SimulationFormButton.Click += new System.EventHandler(this.SimulationFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.SimulationFormButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SimulationFormButton;
    }
}


namespace COMP1004_Assignment3_200180985
{
    partial class StreamForm
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.CreditCardChargeLabel = new System.Windows.Forms.Label();
            this.MovieWillBeginLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.Location = new System.Drawing.Point(12, 9);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(286, 20);
            this.HeadingLabel.TabIndex = 1;
            this.HeadingLabel.Text = "Thank you for choosing Movie Bonanza";
            // 
            // CreditCardChargeLabel
            // 
            this.CreditCardChargeLabel.AutoSize = true;
            this.CreditCardChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardChargeLabel.Location = new System.Drawing.Point(25, 41);
            this.CreditCardChargeLabel.Name = "CreditCardChargeLabel";
            this.CreditCardChargeLabel.Size = new System.Drawing.Size(0, 16);
            this.CreditCardChargeLabel.TabIndex = 2;
            // 
            // MovieWillBeginLabel
            // 
            this.MovieWillBeginLabel.AutoSize = true;
            this.MovieWillBeginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieWillBeginLabel.Location = new System.Drawing.Point(24, 72);
            this.MovieWillBeginLabel.Name = "MovieWillBeginLabel";
            this.MovieWillBeginLabel.Size = new System.Drawing.Size(0, 16);
            this.MovieWillBeginLabel.TabIndex = 3;
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(113, 108);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 31);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 154);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MovieWillBeginLabel);
            this.Controls.Add(this.CreditCardChargeLabel);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Movie is About to Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label CreditCardChargeLabel;
        private System.Windows.Forms.Label MovieWillBeginLabel;
        private System.Windows.Forms.Button OkButton;
    }
}
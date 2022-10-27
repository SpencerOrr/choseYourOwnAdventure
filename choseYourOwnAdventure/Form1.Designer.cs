namespace choseYourOwnAdventure
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choice1Button = new System.Windows.Forms.Button();
            this.choice2Button = new System.Windows.Forms.Button();
            this.choice3Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(423, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Chose Your Adventure";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 175);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(1, 207);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(423, 72);
            this.descriptionLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 11);
            this.label1.TabIndex = 3;
            // 
            // choice1Button
            // 
            this.choice1Button.Location = new System.Drawing.Point(1, 293);
            this.choice1Button.Name = "choice1Button";
            this.choice1Button.Size = new System.Drawing.Size(423, 41);
            this.choice1Button.TabIndex = 4;
            this.choice1Button.Text = "choice 1";
            this.choice1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice1Button.UseVisualStyleBackColor = true;
            this.choice1Button.Click += new System.EventHandler(this.choice1Button_Click);
            // 
            // choice2Button
            // 
            this.choice2Button.Location = new System.Drawing.Point(0, 340);
            this.choice2Button.Name = "choice2Button";
            this.choice2Button.Size = new System.Drawing.Size(423, 41);
            this.choice2Button.TabIndex = 5;
            this.choice2Button.Text = "choice 2";
            this.choice2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice2Button.UseVisualStyleBackColor = true;
            this.choice2Button.Click += new System.EventHandler(this.choice2Button_Click);
            // 
            // choice3Button
            // 
            this.choice3Button.Location = new System.Drawing.Point(0, 387);
            this.choice3Button.Name = "choice3Button";
            this.choice3Button.Size = new System.Drawing.Size(423, 41);
            this.choice3Button.TabIndex = 6;
            this.choice3Button.Text = "choice 3";
            this.choice3Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choice3Button.UseVisualStyleBackColor = true;
            this.choice3Button.Click += new System.EventHandler(this.choice3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 427);
            this.Controls.Add(this.choice3Button);
            this.Controls.Add(this.choice2Button);
            this.Controls.Add(this.choice1Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choice1Button;
        private System.Windows.Forms.Button choice2Button;
        private System.Windows.Forms.Button choice3Button;
    }
}


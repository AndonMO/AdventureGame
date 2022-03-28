namespace AdventureGame
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
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.itemBox2 = new System.Windows.Forms.PictureBox();
            this.itemBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(82, 357);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(75, 23);
            this.option1Button.TabIndex = 1;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(82, 386);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(75, 23);
            this.option2Button.TabIndex = 2;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(82, 415);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(75, 23);
            this.option3Button.TabIndex = 3;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 272);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(776, 68);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "You wake up in a strange room you have never seen before. It looks drab and run d" +
    "own, the walls are made of brick and there is a single door. Do you go through t" +
    "he door?";
            // 
            // option1Label
            // 
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(193, 357);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(595, 23);
            this.option1Label.TabIndex = 5;
            // 
            // option2Label
            // 
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(193, 386);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(595, 23);
            this.option2Label.TabIndex = 6;
            // 
            // option3Label
            // 
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(193, 420);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(595, 23);
            this.option3Label.TabIndex = 7;
            // 
            // itemBox2
            // 
            this.itemBox2.Location = new System.Drawing.Point(58, 69);
            this.itemBox2.Name = "itemBox2";
            this.itemBox2.Size = new System.Drawing.Size(50, 50);
            this.itemBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemBox2.TabIndex = 9;
            this.itemBox2.TabStop = false;

            // 
            // itemBox1
            // 
            this.itemBox1.Location = new System.Drawing.Point(58, 13);
            this.itemBox1.Name = "itemBox1";
            this.itemBox1.Size = new System.Drawing.Size(50, 50);
            this.itemBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemBox1.TabIndex = 8;
            this.itemBox1.TabStop = false;

            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::AdventureGame.Properties.Resources.StartRoom;
            this.pictureBox.Location = new System.Drawing.Point(58, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(687, 257);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.itemBox2);
            this.Controls.Add(this.itemBox1);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.pictureBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Choose your own Adventure Game";
            ((System.ComponentModel.ISupportInitialize)(this.itemBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.PictureBox itemBox1;
        private System.Windows.Forms.PictureBox itemBox2;
    }
}


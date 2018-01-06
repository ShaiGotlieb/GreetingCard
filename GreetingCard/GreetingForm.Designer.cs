namespace GreetingCard
{
    partial class GreetingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreetingForm));
            this.Tshirtimg = new System.Windows.Forms.PictureBox();
            this.myButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tshirtimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Tshirtimg
            // 
            this.Tshirtimg.Image = ((System.Drawing.Image)(resources.GetObject("Tshirtimg.Image")));
            this.Tshirtimg.Location = new System.Drawing.Point(31, 157);
            this.Tshirtimg.Name = "Tshirtimg";
            this.Tshirtimg.Size = new System.Drawing.Size(302, 179);
            this.Tshirtimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tshirtimg.TabIndex = 0;
            this.Tshirtimg.TabStop = false;
            this.Tshirtimg.Visible = false;
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(472, 32);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(117, 43);
            this.myButton.TabIndex = 1;
            this.myButton.Text = "Send";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(90, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(320, 44);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.colorComboBox.Location = new System.Drawing.Point(337, 97);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 28);
            this.colorComboBox.TabIndex = 5;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(232, 100);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(99, 20);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "choose color";
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Mistral", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.Location = new System.Drawing.Point(37, 92);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(169, 53);
            this.greetingLabel.TabIndex = 4;
            this.greetingLabel.Text = "GreenLabel";
            this.greetingLabel.Visible = false;
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(635, 348);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.Tshirtimg);
            this.Name = "GreetingForm";
            this.Text = "GreetingCard";
            this.Load += new System.EventHandler(this.GreetingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tshirtimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Tshirtimg;
        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label greetingLabel;
    }
}


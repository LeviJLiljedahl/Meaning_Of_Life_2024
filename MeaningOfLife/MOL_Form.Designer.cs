namespace MeaningOfLife
{
    partial class MOL_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textLabel = new Label();
            revealButton = new Button();
            newTextLabel = new Label();
            secondNewTextLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 430);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 22);
            label1.TabIndex = 0;
            label1.Text = "** Created April 1st, 2024";
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLabel.Location = new Point(11, 43);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(350, 100);
            textLabel.TabIndex = 1;
            textLabel.Text = "Click the button to reveal \r\nThe Meaning of Life and \r\nto reveal the answer to all of \r\nlife's mysteries.";
            textLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // revealButton
            // 
            revealButton.BackColor = Color.ForestGreen;
            revealButton.Location = new Point(104, 225);
            revealButton.Name = "revealButton";
            revealButton.Size = new Size(158, 78);
            revealButton.TabIndex = 2;
            revealButton.Text = "Reveal";
            revealButton.UseVisualStyleBackColor = false;
            revealButton.Click += revealButton_Click;
            // 
            // newTextLabel
            // 
            newTextLabel.AutoSize = true;
            newTextLabel.Font = new Font("Snap ITC", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newTextLabel.Location = new Point(12, 143);
            newTextLabel.Name = "newTextLabel";
            newTextLabel.Size = new Size(358, 63);
            newTextLabel.TabIndex = 3;
            newTextLabel.Text = "April Fools!";
            newTextLabel.Visible = false;
            // 
            // secondNewTextLabel
            // 
            secondNewTextLabel.AutoSize = true;
            secondNewTextLabel.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondNewTextLabel.Location = new Point(11, 242);
            secondNewTextLabel.Name = "secondNewTextLabel";
            secondNewTextLabel.Size = new Size(357, 70);
            secondNewTextLabel.TabIndex = 4;
            secondNewTextLabel.Text = "Happy April Fools Day\r\n2024!";
            secondNewTextLabel.TextAlign = ContentAlignment.TopCenter;
            secondNewTextLabel.Visible = false;
            // 
            // MOL_Form
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(373, 473);
            Controls.Add(secondNewTextLabel);
            Controls.Add(newTextLabel);
            Controls.Add(revealButton);
            Controls.Add(textLabel);
            Controls.Add(label1);
            Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MOL_Form";
            Text = "The Meaning of Life";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label textLabel;
        private Button revealButton;
        private Label newTextLabel;
        private Label secondNewTextLabel;
    }
}

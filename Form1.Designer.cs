namespace Ch8_Pg382_MoveCardsBetweenDecks
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
            this.reset1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.shuffle2 = new System.Windows.Forms.Button();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.deck1Label = new System.Windows.Forms.Label();
            this.deck2Label = new System.Windows.Forms.Label();
            this.deck1ListBox = new System.Windows.Forms.ListBox();
            this.deck2ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(69, 306);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(118, 23);
            this.reset1.TabIndex = 0;
            this.reset1.Text = "Reset Deck#1";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(287, 306);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(118, 23);
            this.reset2.TabIndex = 1;
            this.reset2.Text = "Reset Deck #2";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // shuffle1
            // 
            this.shuffle1.Location = new System.Drawing.Point(69, 375);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(118, 23);
            this.shuffle1.TabIndex = 2;
            this.shuffle1.Text = "Shuffle Deck #1";
            this.shuffle1.UseVisualStyleBackColor = true;
            this.shuffle1.Click += new System.EventHandler(this.shuffle1_Click);
            // 
            // shuffle2
            // 
            this.shuffle2.Location = new System.Drawing.Point(287, 375);
            this.shuffle2.Name = "shuffle2";
            this.shuffle2.Size = new System.Drawing.Size(118, 23);
            this.shuffle2.TabIndex = 3;
            this.shuffle2.Text = "Shuffle Deck #2";
            this.shuffle2.UseVisualStyleBackColor = true;
            this.shuffle2.Click += new System.EventHandler(this.shuffle2_Click);
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(197, 78);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(75, 23);
            this.moveToDeck2.TabIndex = 4;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(197, 135);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(75, 23);
            this.moveToDeck1.TabIndex = 5;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // deck1Label
            // 
            this.deck1Label.AutoSize = true;
            this.deck1Label.Location = new System.Drawing.Point(12, 25);
            this.deck1Label.Name = "deck1Label";
            this.deck1Label.Size = new System.Drawing.Size(46, 17);
            this.deck1Label.TabIndex = 6;
            this.deck1Label.Text = "label1";
            // 
            // deck2Label
            // 
            this.deck2Label.AutoSize = true;
            this.deck2Label.Location = new System.Drawing.Point(305, 25);
            this.deck2Label.Name = "deck2Label";
            this.deck2Label.Size = new System.Drawing.Size(46, 17);
            this.deck2Label.TabIndex = 7;
            this.deck2Label.Text = "label2";
            // 
            // deck1ListBox
            // 
            this.deck1ListBox.FormattingEnabled = true;
            this.deck1ListBox.ItemHeight = 16;
            this.deck1ListBox.Location = new System.Drawing.Point(12, 67);
            this.deck1ListBox.Name = "deck1ListBox";
            this.deck1ListBox.Size = new System.Drawing.Size(151, 196);
            this.deck1ListBox.TabIndex = 8;
            // 
            // deck2ListBox
            // 
            this.deck2ListBox.FormattingEnabled = true;
            this.deck2ListBox.ItemHeight = 16;
            this.deck2ListBox.Location = new System.Drawing.Point(308, 67);
            this.deck2ListBox.Name = "deck2ListBox";
            this.deck2ListBox.Size = new System.Drawing.Size(143, 196);
            this.deck2ListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 441);
            this.Controls.Add(this.deck2ListBox);
            this.Controls.Add(this.deck1ListBox);
            this.Controls.Add(this.deck2Label);
            this.Controls.Add(this.deck1Label);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.shuffle2);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.reset1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button shuffle2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Label deck1Label;
        private System.Windows.Forms.Label deck2Label;
        private System.Windows.Forms.ListBox deck1ListBox;
        private System.Windows.Forms.ListBox deck2ListBox;
    }
}


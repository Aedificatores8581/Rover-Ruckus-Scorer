namespace Rover_Ruckus_Scorer
{
    partial class ScorerForm
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
            this.landedCheckBox = new System.Windows.Forms.CheckBox();
            this.claimedCheckBox = new System.Windows.Forms.CheckBox();
            this.silverKnockedCheckBox = new System.Windows.Forms.CheckBox();
            this.autoLabel = new System.Windows.Forms.Label();
            this.goldKnockedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depotScoredTextBox = new System.Windows.Forms.TextBox();
            this.cargoScoredTextBox = new System.Windows.Forms.TextBox();
            this.endGameLabel = new System.Windows.Forms.Label();
            this.latchedCheckBox = new System.Windows.Forms.CheckBox();
            this.autoParkedCheckBox = new System.Windows.Forms.CheckBox();
            this.partialParkCheckBox = new System.Windows.Forms.CheckBox();
            this.totalParkCheckBox = new System.Windows.Forms.CheckBox();
            this.autoScoreTextBox = new System.Windows.Forms.TextBox();
            this.teleopScoreTextBox = new System.Windows.Forms.TextBox();
            this.endGameScoreTextBox = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.totalScoreTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // landedCheckBox
            // 
            this.landedCheckBox.AutoSize = true;
            this.landedCheckBox.Location = new System.Drawing.Point(13, 29);
            this.landedCheckBox.Name = "landedCheckBox";
            this.landedCheckBox.Size = new System.Drawing.Size(68, 17);
            this.landedCheckBox.TabIndex = 0;
            this.landedCheckBox.Text = "Landed?";
            this.landedCheckBox.UseVisualStyleBackColor = true;
            // 
            // claimedCheckBox
            // 
            this.claimedCheckBox.AutoSize = true;
            this.claimedCheckBox.Location = new System.Drawing.Point(13, 52);
            this.claimedCheckBox.Name = "claimedCheckBox";
            this.claimedCheckBox.Size = new System.Drawing.Size(101, 17);
            this.claimedCheckBox.TabIndex = 1;
            this.claimedCheckBox.Text = "Depot Claimed?";
            this.claimedCheckBox.UseVisualStyleBackColor = true;
            // 
            // silverKnockedCheckBox
            // 
            this.silverKnockedCheckBox.AutoSize = true;
            this.silverKnockedCheckBox.Location = new System.Drawing.Point(13, 75);
            this.silverKnockedCheckBox.Name = "silverKnockedCheckBox";
            this.silverKnockedCheckBox.Size = new System.Drawing.Size(156, 17);
            this.silverKnockedCheckBox.TabIndex = 2;
            this.silverKnockedCheckBox.Text = "Silver Sphere Knocked off?";
            this.silverKnockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.Location = new System.Drawing.Point(10, 13);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(66, 13);
            this.autoLabel.TabIndex = 3;
            this.autoLabel.Text = "Autonomous";
            // 
            // goldKnockedCheckBox
            // 
            this.goldKnockedCheckBox.AutoSize = true;
            this.goldKnockedCheckBox.Location = new System.Drawing.Point(13, 98);
            this.goldKnockedCheckBox.Name = "goldKnockedCheckBox";
            this.goldKnockedCheckBox.Size = new System.Drawing.Size(145, 17);
            this.goldKnockedCheckBox.TabIndex = 4;
            this.goldKnockedCheckBox.Text = "Gold Block Knocked off?";
            this.goldKnockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TeleOp";
            // 
            // depotScoredTextBox
            // 
            this.depotScoredTextBox.Location = new System.Drawing.Point(13, 162);
            this.depotScoredTextBox.Name = "depotScoredTextBox";
            this.depotScoredTextBox.Size = new System.Drawing.Size(145, 20);
            this.depotScoredTextBox.TabIndex = 6;
            this.depotScoredTextBox.Text = "Minerals Scored in Depot?";
            // 
            // cargoScoredTextBox
            // 
            this.cargoScoredTextBox.Location = new System.Drawing.Point(13, 188);
            this.cargoScoredTextBox.Name = "cargoScoredTextBox";
            this.cargoScoredTextBox.Size = new System.Drawing.Size(145, 20);
            this.cargoScoredTextBox.TabIndex = 7;
            this.cargoScoredTextBox.Text = "Minerals Scored in Cargo?";
            // 
            // endGameLabel
            // 
            this.endGameLabel.AutoSize = true;
            this.endGameLabel.Location = new System.Drawing.Point(10, 221);
            this.endGameLabel.Name = "endGameLabel";
            this.endGameLabel.Size = new System.Drawing.Size(57, 13);
            this.endGameLabel.TabIndex = 8;
            this.endGameLabel.Text = "End Game";
            // 
            // latchedCheckBox
            // 
            this.latchedCheckBox.AutoSize = true;
            this.latchedCheckBox.Location = new System.Drawing.Point(13, 237);
            this.latchedCheckBox.Name = "latchedCheckBox";
            this.latchedCheckBox.Size = new System.Drawing.Size(71, 17);
            this.latchedCheckBox.TabIndex = 9;
            this.latchedCheckBox.Text = "Latched?";
            this.latchedCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoParkedCheckBox
            // 
            this.autoParkedCheckBox.AutoSize = true;
            this.autoParkedCheckBox.Location = new System.Drawing.Point(13, 121);
            this.autoParkedCheckBox.Name = "autoParkedCheckBox";
            this.autoParkedCheckBox.Size = new System.Drawing.Size(66, 17);
            this.autoParkedCheckBox.TabIndex = 10;
            this.autoParkedCheckBox.Text = "Parked?";
            this.autoParkedCheckBox.UseVisualStyleBackColor = true;
            // 
            // partialParkCheckBox
            // 
            this.partialParkCheckBox.AutoSize = true;
            this.partialParkCheckBox.Location = new System.Drawing.Point(13, 260);
            this.partialParkCheckBox.Name = "partialParkCheckBox";
            this.partialParkCheckBox.Size = new System.Drawing.Size(105, 17);
            this.partialParkCheckBox.TabIndex = 11;
            this.partialParkCheckBox.Text = "Partially Parked?";
            this.partialParkCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalParkCheckBox
            // 
            this.totalParkCheckBox.AutoSize = true;
            this.totalParkCheckBox.Location = new System.Drawing.Point(13, 283);
            this.totalParkCheckBox.Name = "totalParkCheckBox";
            this.totalParkCheckBox.Size = new System.Drawing.Size(100, 17);
            this.totalParkCheckBox.TabIndex = 12;
            this.totalParkCheckBox.Text = "Totally Parked?";
            this.totalParkCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoScoreTextBox
            // 
            this.autoScoreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.autoScoreTextBox.Enabled = false;
            this.autoScoreTextBox.Location = new System.Drawing.Point(242, 13);
            this.autoScoreTextBox.Name = "autoScoreTextBox";
            this.autoScoreTextBox.Size = new System.Drawing.Size(61, 20);
            this.autoScoreTextBox.TabIndex = 13;
            // 
            // teleopScoreTextBox
            // 
            this.teleopScoreTextBox.Enabled = false;
            this.teleopScoreTextBox.Location = new System.Drawing.Point(242, 139);
            this.teleopScoreTextBox.Name = "teleopScoreTextBox";
            this.teleopScoreTextBox.Size = new System.Drawing.Size(61, 20);
            this.teleopScoreTextBox.TabIndex = 14;
            // 
            // endGameScoreTextBox
            // 
            this.endGameScoreTextBox.Enabled = false;
            this.endGameScoreTextBox.Location = new System.Drawing.Point(242, 214);
            this.endGameScoreTextBox.Name = "endGameScoreTextBox";
            this.endGameScoreTextBox.Size = new System.Drawing.Size(61, 20);
            this.endGameScoreTextBox.TabIndex = 15;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(10, 313);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 16;
            this.Total.Text = "Total";
            // 
            // totalScoreTextBox
            // 
            this.totalScoreTextBox.Enabled = false;
            this.totalScoreTextBox.Location = new System.Drawing.Point(242, 306);
            this.totalScoreTextBox.Name = "totalScoreTextBox";
            this.totalScoreTextBox.Size = new System.Drawing.Size(61, 20);
            this.totalScoreTextBox.TabIndex = 17;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 332);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(289, 46);
            this.calcButton.TabIndex = 18;
            this.calcButton.Text = "CALCULATE BUTTON (TM)";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // ScorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 390);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalScoreTextBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.endGameScoreTextBox);
            this.Controls.Add(this.teleopScoreTextBox);
            this.Controls.Add(this.autoScoreTextBox);
            this.Controls.Add(this.totalParkCheckBox);
            this.Controls.Add(this.partialParkCheckBox);
            this.Controls.Add(this.autoParkedCheckBox);
            this.Controls.Add(this.latchedCheckBox);
            this.Controls.Add(this.endGameLabel);
            this.Controls.Add(this.cargoScoredTextBox);
            this.Controls.Add(this.depotScoredTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goldKnockedCheckBox);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.silverKnockedCheckBox);
            this.Controls.Add(this.claimedCheckBox);
            this.Controls.Add(this.landedCheckBox);
            this.Name = "ScorerForm";
            this.Text = "Rover Ruckus Scorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox landedCheckBox;
        private System.Windows.Forms.CheckBox claimedCheckBox;
        private System.Windows.Forms.CheckBox silverKnockedCheckBox;
        private System.Windows.Forms.Label autoLabel;
        private System.Windows.Forms.CheckBox goldKnockedCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depotScoredTextBox;
        private System.Windows.Forms.TextBox cargoScoredTextBox;
        private System.Windows.Forms.Label endGameLabel;
        private System.Windows.Forms.CheckBox latchedCheckBox;
        private System.Windows.Forms.CheckBox autoParkedCheckBox;
        private System.Windows.Forms.CheckBox partialParkCheckBox;
        private System.Windows.Forms.CheckBox totalParkCheckBox;
        private System.Windows.Forms.TextBox autoScoreTextBox;
        private System.Windows.Forms.TextBox teleopScoreTextBox;
        private System.Windows.Forms.TextBox endGameScoreTextBox;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox totalScoreTextBox;
        private System.Windows.Forms.Button calcButton;
    }
}


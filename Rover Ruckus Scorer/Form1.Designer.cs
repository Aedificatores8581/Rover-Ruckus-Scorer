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
            this.silverKnockedCheckBox = new System.Windows.Forms.CheckBox();
            this.autoLabel = new System.Windows.Forms.Label();
            this.goldKnockedCheckBox = new System.Windows.Forms.CheckBox();
            this.teleopLabel = new System.Windows.Forms.Label();
            this.depotScoredTextBox = new System.Windows.Forms.TextBox();
            this.cargoScoredTextBox = new System.Windows.Forms.TextBox();
            this.endGameLabel = new System.Windows.Forms.Label();
            this.autoScoreTextBox = new System.Windows.Forms.TextBox();
            this.teleopScoreTextBox = new System.Windows.Forms.TextBox();
            this.endGameScoreTextBox = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.totalScoreTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.landedBox = new System.Windows.Forms.GroupBox();
            this.noneLandedButton = new System.Windows.Forms.RadioButton();
            this.oneLandedButton = new System.Windows.Forms.RadioButton();
            this.twoLandedButton = new System.Windows.Forms.RadioButton();
            this.depotBox = new System.Windows.Forms.GroupBox();
            this.twoMarkersPlacedButton = new System.Windows.Forms.RadioButton();
            this.oneMarkerPlacedButton = new System.Windows.Forms.RadioButton();
            this.noMarkersPlacedButton = new System.Windows.Forms.RadioButton();
            this.parkedBox = new System.Windows.Forms.GroupBox();
            this.twoAutoParkedButton = new System.Windows.Forms.RadioButton();
            this.oneAutoParkedButton = new System.Windows.Forms.RadioButton();
            this.noneAutoParkedButton = new System.Windows.Forms.RadioButton();
            this.latchedBox = new System.Windows.Forms.GroupBox();
            this.twoLatchedButton = new System.Windows.Forms.RadioButton();
            this.oneLatchedButton = new System.Windows.Forms.RadioButton();
            this.noneLatchedButton = new System.Windows.Forms.RadioButton();
            this.partiallyParkedBox = new System.Windows.Forms.GroupBox();
            this.twoPartiallyParkedButton = new System.Windows.Forms.RadioButton();
            this.onePartiallyParkedButton = new System.Windows.Forms.RadioButton();
            this.nonePartiallyParkedButton = new System.Windows.Forms.RadioButton();
            this.totallyParkedBox = new System.Windows.Forms.GroupBox();
            this.twoTotallyParkedButton = new System.Windows.Forms.RadioButton();
            this.oneTotallyParkedButton = new System.Windows.Forms.RadioButton();
            this.noneTotallyParkedButton = new System.Windows.Forms.RadioButton();
            this.landedBox.SuspendLayout();
            this.depotBox.SuspendLayout();
            this.parkedBox.SuspendLayout();
            this.latchedBox.SuspendLayout();
            this.partiallyParkedBox.SuspendLayout();
            this.totallyParkedBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // silverKnockedCheckBox
            // 
            this.silverKnockedCheckBox.AutoSize = true;
            this.silverKnockedCheckBox.Location = new System.Drawing.Point(13, 172);
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
            this.goldKnockedCheckBox.Location = new System.Drawing.Point(13, 149);
            this.goldKnockedCheckBox.Name = "goldKnockedCheckBox";
            this.goldKnockedCheckBox.Size = new System.Drawing.Size(145, 17);
            this.goldKnockedCheckBox.TabIndex = 4;
            this.goldKnockedCheckBox.Text = "Gold Block Knocked off?";
            this.goldKnockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // teleopLabel
            // 
            this.teleopLabel.AutoSize = true;
            this.teleopLabel.Location = new System.Drawing.Point(10, 203);
            this.teleopLabel.Name = "teleopLabel";
            this.teleopLabel.Size = new System.Drawing.Size(42, 13);
            this.teleopLabel.TabIndex = 5;
            this.teleopLabel.Text = "TeleOp";
            // 
            // depotScoredTextBox
            // 
            this.depotScoredTextBox.Location = new System.Drawing.Point(13, 223);
            this.depotScoredTextBox.Name = "depotScoredTextBox";
            this.depotScoredTextBox.Size = new System.Drawing.Size(145, 20);
            this.depotScoredTextBox.TabIndex = 6;
            this.depotScoredTextBox.Text = "Minerals Scored in Depot?";
            // 
            // cargoScoredTextBox
            // 
            this.cargoScoredTextBox.Location = new System.Drawing.Point(13, 249);
            this.cargoScoredTextBox.Name = "cargoScoredTextBox";
            this.cargoScoredTextBox.Size = new System.Drawing.Size(145, 20);
            this.cargoScoredTextBox.TabIndex = 7;
            this.cargoScoredTextBox.Text = "Minerals Scored in Cargo?";
            // 
            // endGameLabel
            // 
            this.endGameLabel.AutoSize = true;
            this.endGameLabel.Location = new System.Drawing.Point(10, 283);
            this.endGameLabel.Name = "endGameLabel";
            this.endGameLabel.Size = new System.Drawing.Size(57, 13);
            this.endGameLabel.TabIndex = 8;
            this.endGameLabel.Text = "End Game";
            // 
            // autoScoreTextBox
            // 
            this.autoScoreTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.autoScoreTextBox.Enabled = false;
            this.autoScoreTextBox.Location = new System.Drawing.Point(175, 13);
            this.autoScoreTextBox.Name = "autoScoreTextBox";
            this.autoScoreTextBox.Size = new System.Drawing.Size(61, 20);
            this.autoScoreTextBox.TabIndex = 13;
            // 
            // teleopScoreTextBox
            // 
            this.teleopScoreTextBox.Enabled = false;
            this.teleopScoreTextBox.Location = new System.Drawing.Point(175, 200);
            this.teleopScoreTextBox.Name = "teleopScoreTextBox";
            this.teleopScoreTextBox.Size = new System.Drawing.Size(61, 20);
            this.teleopScoreTextBox.TabIndex = 14;
            // 
            // endGameScoreTextBox
            // 
            this.endGameScoreTextBox.Enabled = false;
            this.endGameScoreTextBox.Location = new System.Drawing.Point(175, 283);
            this.endGameScoreTextBox.Name = "endGameScoreTextBox";
            this.endGameScoreTextBox.Size = new System.Drawing.Size(61, 20);
            this.endGameScoreTextBox.TabIndex = 15;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(9, 437);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 16;
            this.Total.Text = "Total";
            // 
            // totalScoreTextBox
            // 
            this.totalScoreTextBox.Enabled = false;
            this.totalScoreTextBox.Location = new System.Drawing.Point(175, 437);
            this.totalScoreTextBox.Name = "totalScoreTextBox";
            this.totalScoreTextBox.Size = new System.Drawing.Size(61, 20);
            this.totalScoreTextBox.TabIndex = 17;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 463);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(224, 46);
            this.calcButton.TabIndex = 18;
            this.calcButton.Text = "CALCULATE BUTTON (TM)";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // landedBox
            // 
            this.landedBox.Controls.Add(this.twoLandedButton);
            this.landedBox.Controls.Add(this.oneLandedButton);
            this.landedBox.Controls.Add(this.noneLandedButton);
            this.landedBox.Location = new System.Drawing.Point(13, 29);
            this.landedBox.Name = "landedBox";
            this.landedBox.Size = new System.Drawing.Size(116, 40);
            this.landedBox.TabIndex = 19;
            this.landedBox.TabStop = false;
            this.landedBox.Text = "# Robots Landed";
            // 
            // noneLandedButton
            // 
            this.noneLandedButton.AutoSize = true;
            this.noneLandedButton.Location = new System.Drawing.Point(6, 17);
            this.noneLandedButton.Name = "noneLandedButton";
            this.noneLandedButton.Size = new System.Drawing.Size(31, 17);
            this.noneLandedButton.TabIndex = 0;
            this.noneLandedButton.TabStop = true;
            this.noneLandedButton.Text = "0";
            this.noneLandedButton.UseVisualStyleBackColor = true;
            // 
            // oneLandedButton
            // 
            this.oneLandedButton.AutoSize = true;
            this.oneLandedButton.Location = new System.Drawing.Point(43, 17);
            this.oneLandedButton.Name = "oneLandedButton";
            this.oneLandedButton.Size = new System.Drawing.Size(31, 17);
            this.oneLandedButton.TabIndex = 1;
            this.oneLandedButton.TabStop = true;
            this.oneLandedButton.Text = "1";
            this.oneLandedButton.UseVisualStyleBackColor = true;
            // 
            // twoLandedButton
            // 
            this.twoLandedButton.AutoSize = true;
            this.twoLandedButton.Location = new System.Drawing.Point(80, 17);
            this.twoLandedButton.Name = "twoLandedButton";
            this.twoLandedButton.Size = new System.Drawing.Size(31, 17);
            this.twoLandedButton.TabIndex = 2;
            this.twoLandedButton.TabStop = true;
            this.twoLandedButton.Text = "2";
            this.twoLandedButton.UseVisualStyleBackColor = true;
            // 
            // depotBox
            // 
            this.depotBox.Controls.Add(this.twoMarkersPlacedButton);
            this.depotBox.Controls.Add(this.oneMarkerPlacedButton);
            this.depotBox.Controls.Add(this.noMarkersPlacedButton);
            this.depotBox.Location = new System.Drawing.Point(13, 69);
            this.depotBox.Name = "depotBox";
            this.depotBox.Size = new System.Drawing.Size(116, 40);
            this.depotBox.TabIndex = 20;
            this.depotBox.TabStop = false;
            this.depotBox.Text = "# Team Markers";
            // 
            // twoMarkersPlacedButton
            // 
            this.twoMarkersPlacedButton.AutoSize = true;
            this.twoMarkersPlacedButton.Location = new System.Drawing.Point(80, 17);
            this.twoMarkersPlacedButton.Name = "twoMarkersPlacedButton";
            this.twoMarkersPlacedButton.Size = new System.Drawing.Size(31, 17);
            this.twoMarkersPlacedButton.TabIndex = 2;
            this.twoMarkersPlacedButton.TabStop = true;
            this.twoMarkersPlacedButton.Text = "2";
            this.twoMarkersPlacedButton.UseVisualStyleBackColor = true;
            // 
            // oneMarkerPlacedButton
            // 
            this.oneMarkerPlacedButton.AutoSize = true;
            this.oneMarkerPlacedButton.Location = new System.Drawing.Point(43, 17);
            this.oneMarkerPlacedButton.Name = "oneMarkerPlacedButton";
            this.oneMarkerPlacedButton.Size = new System.Drawing.Size(31, 17);
            this.oneMarkerPlacedButton.TabIndex = 1;
            this.oneMarkerPlacedButton.TabStop = true;
            this.oneMarkerPlacedButton.Text = "1";
            this.oneMarkerPlacedButton.UseVisualStyleBackColor = true;
            // 
            // noMarkersPlacedButton
            // 
            this.noMarkersPlacedButton.AutoSize = true;
            this.noMarkersPlacedButton.Location = new System.Drawing.Point(6, 17);
            this.noMarkersPlacedButton.Name = "noMarkersPlacedButton";
            this.noMarkersPlacedButton.Size = new System.Drawing.Size(31, 17);
            this.noMarkersPlacedButton.TabIndex = 0;
            this.noMarkersPlacedButton.TabStop = true;
            this.noMarkersPlacedButton.Text = "0";
            this.noMarkersPlacedButton.UseVisualStyleBackColor = true;
            // 
            // parkedBox
            // 
            this.parkedBox.Controls.Add(this.twoAutoParkedButton);
            this.parkedBox.Controls.Add(this.oneAutoParkedButton);
            this.parkedBox.Controls.Add(this.noneAutoParkedButton);
            this.parkedBox.Location = new System.Drawing.Point(13, 109);
            this.parkedBox.Name = "parkedBox";
            this.parkedBox.Size = new System.Drawing.Size(116, 40);
            this.parkedBox.TabIndex = 21;
            this.parkedBox.TabStop = false;
            this.parkedBox.Text = "# Parked";
            // 
            // twoAutoParkedButton
            // 
            this.twoAutoParkedButton.AutoSize = true;
            this.twoAutoParkedButton.Location = new System.Drawing.Point(80, 17);
            this.twoAutoParkedButton.Name = "twoAutoParkedButton";
            this.twoAutoParkedButton.Size = new System.Drawing.Size(31, 17);
            this.twoAutoParkedButton.TabIndex = 2;
            this.twoAutoParkedButton.TabStop = true;
            this.twoAutoParkedButton.Text = "2";
            this.twoAutoParkedButton.UseVisualStyleBackColor = true;
            // 
            // oneAutoParkedButton
            // 
            this.oneAutoParkedButton.AutoSize = true;
            this.oneAutoParkedButton.Location = new System.Drawing.Point(43, 17);
            this.oneAutoParkedButton.Name = "oneAutoParkedButton";
            this.oneAutoParkedButton.Size = new System.Drawing.Size(31, 17);
            this.oneAutoParkedButton.TabIndex = 1;
            this.oneAutoParkedButton.TabStop = true;
            this.oneAutoParkedButton.Text = "1";
            this.oneAutoParkedButton.UseVisualStyleBackColor = true;
            // 
            // noneAutoParkedButton
            // 
            this.noneAutoParkedButton.AutoSize = true;
            this.noneAutoParkedButton.Location = new System.Drawing.Point(6, 17);
            this.noneAutoParkedButton.Name = "noneAutoParkedButton";
            this.noneAutoParkedButton.Size = new System.Drawing.Size(31, 17);
            this.noneAutoParkedButton.TabIndex = 0;
            this.noneAutoParkedButton.TabStop = true;
            this.noneAutoParkedButton.Text = "0";
            this.noneAutoParkedButton.UseVisualStyleBackColor = true;
            // 
            // latchedBox
            // 
            this.latchedBox.Controls.Add(this.twoLatchedButton);
            this.latchedBox.Controls.Add(this.oneLatchedButton);
            this.latchedBox.Controls.Add(this.noneLatchedButton);
            this.latchedBox.Location = new System.Drawing.Point(13, 299);
            this.latchedBox.Name = "latchedBox";
            this.latchedBox.Size = new System.Drawing.Size(116, 40);
            this.latchedBox.TabIndex = 22;
            this.latchedBox.TabStop = false;
            this.latchedBox.Text = "# Latched";
            // 
            // twoLatchedButton
            // 
            this.twoLatchedButton.AutoSize = true;
            this.twoLatchedButton.Location = new System.Drawing.Point(80, 17);
            this.twoLatchedButton.Name = "twoLatchedButton";
            this.twoLatchedButton.Size = new System.Drawing.Size(31, 17);
            this.twoLatchedButton.TabIndex = 2;
            this.twoLatchedButton.TabStop = true;
            this.twoLatchedButton.Text = "2";
            this.twoLatchedButton.UseVisualStyleBackColor = true;
            // 
            // oneLatchedButton
            // 
            this.oneLatchedButton.AutoSize = true;
            this.oneLatchedButton.Location = new System.Drawing.Point(43, 17);
            this.oneLatchedButton.Name = "oneLatchedButton";
            this.oneLatchedButton.Size = new System.Drawing.Size(31, 17);
            this.oneLatchedButton.TabIndex = 1;
            this.oneLatchedButton.TabStop = true;
            this.oneLatchedButton.Text = "1";
            this.oneLatchedButton.UseVisualStyleBackColor = true;
            // 
            // noneLatchedButton
            // 
            this.noneLatchedButton.AutoSize = true;
            this.noneLatchedButton.Location = new System.Drawing.Point(6, 17);
            this.noneLatchedButton.Name = "noneLatchedButton";
            this.noneLatchedButton.Size = new System.Drawing.Size(31, 17);
            this.noneLatchedButton.TabIndex = 0;
            this.noneLatchedButton.TabStop = true;
            this.noneLatchedButton.Text = "0";
            this.noneLatchedButton.UseVisualStyleBackColor = true;
            // 
            // partiallyParkedBox
            // 
            this.partiallyParkedBox.Controls.Add(this.twoPartiallyParkedButton);
            this.partiallyParkedBox.Controls.Add(this.onePartiallyParkedButton);
            this.partiallyParkedBox.Controls.Add(this.nonePartiallyParkedButton);
            this.partiallyParkedBox.Location = new System.Drawing.Point(13, 340);
            this.partiallyParkedBox.Name = "partiallyParkedBox";
            this.partiallyParkedBox.Size = new System.Drawing.Size(116, 40);
            this.partiallyParkedBox.TabIndex = 23;
            this.partiallyParkedBox.TabStop = false;
            this.partiallyParkedBox.Text = "# Partially Parked";
            // 
            // twoPartiallyParkedButton
            // 
            this.twoPartiallyParkedButton.AutoSize = true;
            this.twoPartiallyParkedButton.Location = new System.Drawing.Point(80, 17);
            this.twoPartiallyParkedButton.Name = "twoPartiallyParkedButton";
            this.twoPartiallyParkedButton.Size = new System.Drawing.Size(31, 17);
            this.twoPartiallyParkedButton.TabIndex = 2;
            this.twoPartiallyParkedButton.TabStop = true;
            this.twoPartiallyParkedButton.Text = "2";
            this.twoPartiallyParkedButton.UseVisualStyleBackColor = true;
            // 
            // onePartiallyParkedButton
            // 
            this.onePartiallyParkedButton.AutoSize = true;
            this.onePartiallyParkedButton.Location = new System.Drawing.Point(43, 17);
            this.onePartiallyParkedButton.Name = "onePartiallyParkedButton";
            this.onePartiallyParkedButton.Size = new System.Drawing.Size(31, 17);
            this.onePartiallyParkedButton.TabIndex = 1;
            this.onePartiallyParkedButton.TabStop = true;
            this.onePartiallyParkedButton.Text = "1";
            this.onePartiallyParkedButton.UseVisualStyleBackColor = true;
            // 
            // nonePartiallyParkedButton
            // 
            this.nonePartiallyParkedButton.AutoSize = true;
            this.nonePartiallyParkedButton.Location = new System.Drawing.Point(6, 17);
            this.nonePartiallyParkedButton.Name = "nonePartiallyParkedButton";
            this.nonePartiallyParkedButton.Size = new System.Drawing.Size(31, 17);
            this.nonePartiallyParkedButton.TabIndex = 0;
            this.nonePartiallyParkedButton.TabStop = true;
            this.nonePartiallyParkedButton.Text = "0";
            this.nonePartiallyParkedButton.UseVisualStyleBackColor = true;
            // 
            // totallyParkedBox
            // 
            this.totallyParkedBox.Controls.Add(this.twoTotallyParkedButton);
            this.totallyParkedBox.Controls.Add(this.oneTotallyParkedButton);
            this.totallyParkedBox.Controls.Add(this.noneTotallyParkedButton);
            this.totallyParkedBox.Location = new System.Drawing.Point(13, 380);
            this.totallyParkedBox.Name = "totallyParkedBox";
            this.totallyParkedBox.Size = new System.Drawing.Size(116, 40);
            this.totallyParkedBox.TabIndex = 24;
            this.totallyParkedBox.TabStop = false;
            this.totallyParkedBox.Text = "# Totally Parked";
            // 
            // twoTotallyParkedButton
            // 
            this.twoTotallyParkedButton.AutoSize = true;
            this.twoTotallyParkedButton.Location = new System.Drawing.Point(80, 17);
            this.twoTotallyParkedButton.Name = "twoTotallyParkedButton";
            this.twoTotallyParkedButton.Size = new System.Drawing.Size(31, 17);
            this.twoTotallyParkedButton.TabIndex = 2;
            this.twoTotallyParkedButton.TabStop = true;
            this.twoTotallyParkedButton.Text = "2";
            this.twoTotallyParkedButton.UseVisualStyleBackColor = true;
            // 
            // oneTotallyParkedButton
            // 
            this.oneTotallyParkedButton.AutoSize = true;
            this.oneTotallyParkedButton.Location = new System.Drawing.Point(43, 17);
            this.oneTotallyParkedButton.Name = "oneTotallyParkedButton";
            this.oneTotallyParkedButton.Size = new System.Drawing.Size(31, 17);
            this.oneTotallyParkedButton.TabIndex = 1;
            this.oneTotallyParkedButton.TabStop = true;
            this.oneTotallyParkedButton.Text = "1";
            this.oneTotallyParkedButton.UseVisualStyleBackColor = true;
            // 
            // noneTotallyParkedButton
            // 
            this.noneTotallyParkedButton.AutoSize = true;
            this.noneTotallyParkedButton.Location = new System.Drawing.Point(6, 17);
            this.noneTotallyParkedButton.Name = "noneTotallyParkedButton";
            this.noneTotallyParkedButton.Size = new System.Drawing.Size(31, 17);
            this.noneTotallyParkedButton.TabIndex = 0;
            this.noneTotallyParkedButton.TabStop = true;
            this.noneTotallyParkedButton.Text = "0";
            this.noneTotallyParkedButton.UseVisualStyleBackColor = true;
            // 
            // ScorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 516);
            this.Controls.Add(this.totallyParkedBox);
            this.Controls.Add(this.partiallyParkedBox);
            this.Controls.Add(this.latchedBox);
            this.Controls.Add(this.parkedBox);
            this.Controls.Add(this.depotBox);
            this.Controls.Add(this.landedBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalScoreTextBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.endGameScoreTextBox);
            this.Controls.Add(this.teleopScoreTextBox);
            this.Controls.Add(this.autoScoreTextBox);
            this.Controls.Add(this.endGameLabel);
            this.Controls.Add(this.cargoScoredTextBox);
            this.Controls.Add(this.depotScoredTextBox);
            this.Controls.Add(this.teleopLabel);
            this.Controls.Add(this.goldKnockedCheckBox);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.silverKnockedCheckBox);
            this.Name = "ScorerForm";
            this.Text = "Rover Ruckus Scorer";
            this.landedBox.ResumeLayout(false);
            this.landedBox.PerformLayout();
            this.depotBox.ResumeLayout(false);
            this.depotBox.PerformLayout();
            this.parkedBox.ResumeLayout(false);
            this.parkedBox.PerformLayout();
            this.latchedBox.ResumeLayout(false);
            this.latchedBox.PerformLayout();
            this.partiallyParkedBox.ResumeLayout(false);
            this.partiallyParkedBox.PerformLayout();
            this.totallyParkedBox.ResumeLayout(false);
            this.totallyParkedBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox silverKnockedCheckBox;
        private System.Windows.Forms.Label autoLabel;
        private System.Windows.Forms.CheckBox goldKnockedCheckBox;
        private System.Windows.Forms.Label teleopLabel;
        private System.Windows.Forms.TextBox depotScoredTextBox;
        private System.Windows.Forms.TextBox cargoScoredTextBox;
        private System.Windows.Forms.Label endGameLabel;
        private System.Windows.Forms.TextBox autoScoreTextBox;
        private System.Windows.Forms.TextBox teleopScoreTextBox;
        private System.Windows.Forms.TextBox endGameScoreTextBox;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox totalScoreTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.GroupBox landedBox;
        private System.Windows.Forms.RadioButton twoLandedButton;
        private System.Windows.Forms.RadioButton oneLandedButton;
        private System.Windows.Forms.RadioButton noneLandedButton;
        private System.Windows.Forms.GroupBox depotBox;
        private System.Windows.Forms.RadioButton twoMarkersPlacedButton;
        private System.Windows.Forms.RadioButton oneMarkerPlacedButton;
        private System.Windows.Forms.RadioButton noMarkersPlacedButton;
        private System.Windows.Forms.GroupBox parkedBox;
        private System.Windows.Forms.RadioButton twoAutoParkedButton;
        private System.Windows.Forms.RadioButton oneAutoParkedButton;
        private System.Windows.Forms.RadioButton noneAutoParkedButton;
        private System.Windows.Forms.GroupBox latchedBox;
        private System.Windows.Forms.RadioButton twoLatchedButton;
        private System.Windows.Forms.RadioButton oneLatchedButton;
        private System.Windows.Forms.RadioButton noneLatchedButton;
        private System.Windows.Forms.GroupBox partiallyParkedBox;
        private System.Windows.Forms.RadioButton twoPartiallyParkedButton;
        private System.Windows.Forms.RadioButton onePartiallyParkedButton;
        private System.Windows.Forms.RadioButton nonePartiallyParkedButton;
        private System.Windows.Forms.GroupBox totallyParkedBox;
        private System.Windows.Forms.RadioButton twoTotallyParkedButton;
        private System.Windows.Forms.RadioButton oneTotallyParkedButton;
        private System.Windows.Forms.RadioButton noneTotallyParkedButton;
    }
}


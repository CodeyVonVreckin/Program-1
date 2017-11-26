namespace Program_1
{
    partial class program1
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
            this.answerButton = new System.Windows.Forms.Button();
            this.pricePerGallonTxtBox = new System.Windows.Forms.TextBox();
            this.numberOfCoatsTxtBox = new System.Windows.Forms.TextBox();
            this.sqFtTxtBox = new System.Windows.Forms.TextBox();
            this.sqFootLabel = new System.Windows.Forms.Label();
            this.coatsLabel = new System.Windows.Forms.Label();
            this.pricePerGallonLabel = new System.Windows.Forms.Label();
            this.totalSqFtLabel = new System.Windows.Forms.Label();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.laborHoursLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalSqFtAnswerLabel = new System.Windows.Forms.Label();
            this.gallonsAnswerLabel = new System.Windows.Forms.Label();
            this.timeRequiredAnswerLabel = new System.Windows.Forms.Label();
            this.costOfPaintAnswerLabel = new System.Windows.Forms.Label();
            this.totalLaborCostAnswerLabel = new System.Windows.Forms.Label();
            this.totalCostAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(155, 259);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(145, 34);
            this.answerButton.TabIndex = 0;
            this.answerButton.Text = "Calculate Total Cost";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // pricePerGallonTxtBox
            // 
            this.pricePerGallonTxtBox.Location = new System.Drawing.Point(101, 71);
            this.pricePerGallonTxtBox.Name = "pricePerGallonTxtBox";
            this.pricePerGallonTxtBox.Size = new System.Drawing.Size(100, 20);
            this.pricePerGallonTxtBox.TabIndex = 1;
            // 
            // numberOfCoatsTxtBox
            // 
            this.numberOfCoatsTxtBox.Location = new System.Drawing.Point(101, 45);
            this.numberOfCoatsTxtBox.Name = "numberOfCoatsTxtBox";
            this.numberOfCoatsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfCoatsTxtBox.TabIndex = 2;
            // 
            // sqFtTxtBox
            // 
            this.sqFtTxtBox.Location = new System.Drawing.Point(101, 19);
            this.sqFtTxtBox.Name = "sqFtTxtBox";
            this.sqFtTxtBox.Size = new System.Drawing.Size(100, 20);
            this.sqFtTxtBox.TabIndex = 3;
            // 
            // sqFootLabel
            // 
            this.sqFootLabel.AutoSize = true;
            this.sqFootLabel.Location = new System.Drawing.Point(12, 19);
            this.sqFootLabel.Name = "sqFootLabel";
            this.sqFootLabel.Size = new System.Drawing.Size(87, 13);
            this.sqFootLabel.TabIndex = 4;
            this.sqFootLabel.Text = "# of Square Feet";
            // 
            // coatsLabel
            // 
            this.coatsLabel.AutoSize = true;
            this.coatsLabel.Location = new System.Drawing.Point(12, 45);
            this.coatsLabel.Name = "coatsLabel";
            this.coatsLabel.Size = new System.Drawing.Size(56, 13);
            this.coatsLabel.TabIndex = 5;
            this.coatsLabel.Text = "# of Coats";
            // 
            // pricePerGallonLabel
            // 
            this.pricePerGallonLabel.AutoSize = true;
            this.pricePerGallonLabel.Location = new System.Drawing.Point(12, 71);
            this.pricePerGallonLabel.Name = "pricePerGallonLabel";
            this.pricePerGallonLabel.Size = new System.Drawing.Size(83, 13);
            this.pricePerGallonLabel.TabIndex = 6;
            this.pricePerGallonLabel.Text = "Price Per Gallon";
            // 
            // totalSqFtLabel
            // 
            this.totalSqFtLabel.AutoSize = true;
            this.totalSqFtLabel.Location = new System.Drawing.Point(244, 19);
            this.totalSqFtLabel.Name = "totalSqFtLabel";
            this.totalSqFtLabel.Size = new System.Drawing.Size(62, 13);
            this.totalSqFtLabel.TabIndex = 7;
            this.totalSqFtLabel.Text = "Total Sq. Ft";
            // 
            // gallonsLabel
            // 
            this.gallonsLabel.AutoSize = true;
            this.gallonsLabel.Location = new System.Drawing.Point(220, 48);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(110, 13);
            this.gallonsLabel.TabIndex = 8;
            this.gallonsLabel.Text = "Required # of Gallons";
            // 
            // laborHoursLabel
            // 
            this.laborHoursLabel.AutoSize = true;
            this.laborHoursLabel.Location = new System.Drawing.Point(232, 78);
            this.laborHoursLabel.Name = "laborHoursLabel";
            this.laborHoursLabel.Size = new System.Drawing.Size(79, 13);
            this.laborHoursLabel.TabIndex = 9;
            this.laborHoursLabel.Text = "Time Required ";
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.AutoSize = true;
            this.paintCostLabel.Location = new System.Drawing.Point(244, 109);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(67, 13);
            this.paintCostLabel.TabIndex = 10;
            this.paintCostLabel.Text = "Cost of Paint";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(245, 135);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(58, 13);
            this.laborCostLabel.TabIndex = 11;
            this.laborCostLabel.Text = "Labor Cost";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(248, 164);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(55, 13);
            this.totalCostLabel.TabIndex = 12;
            this.totalCostLabel.Text = "Total Cost";
            // 
            // totalSqFtAnswerLabel
            // 
            this.totalSqFtAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqFtAnswerLabel.Location = new System.Drawing.Point(385, 15);
            this.totalSqFtAnswerLabel.Name = "totalSqFtAnswerLabel";
            this.totalSqFtAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.totalSqFtAnswerLabel.TabIndex = 13;
            // 
            // gallonsAnswerLabel
            // 
            this.gallonsAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsAnswerLabel.Location = new System.Drawing.Point(385, 44);
            this.gallonsAnswerLabel.Name = "gallonsAnswerLabel";
            this.gallonsAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.gallonsAnswerLabel.TabIndex = 14;
            // 
            // timeRequiredAnswerLabel
            // 
            this.timeRequiredAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeRequiredAnswerLabel.Location = new System.Drawing.Point(385, 73);
            this.timeRequiredAnswerLabel.Name = "timeRequiredAnswerLabel";
            this.timeRequiredAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.timeRequiredAnswerLabel.TabIndex = 15;
            // 
            // costOfPaintAnswerLabel
            // 
            this.costOfPaintAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfPaintAnswerLabel.Location = new System.Drawing.Point(385, 102);
            this.costOfPaintAnswerLabel.Name = "costOfPaintAnswerLabel";
            this.costOfPaintAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.costOfPaintAnswerLabel.TabIndex = 16;
            // 
            // totalLaborCostAnswerLabel
            // 
            this.totalLaborCostAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLaborCostAnswerLabel.Location = new System.Drawing.Point(385, 131);
            this.totalLaborCostAnswerLabel.Name = "totalLaborCostAnswerLabel";
            this.totalLaborCostAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLaborCostAnswerLabel.TabIndex = 17;
            // 
            // totalCostAnswerLabel
            // 
            this.totalCostAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostAnswerLabel.Location = new System.Drawing.Point(385, 160);
            this.totalCostAnswerLabel.Name = "totalCostAnswerLabel";
            this.totalCostAnswerLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostAnswerLabel.TabIndex = 18;
            // 
            // program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 371);
            this.Controls.Add(this.totalCostAnswerLabel);
            this.Controls.Add(this.totalLaborCostAnswerLabel);
            this.Controls.Add(this.costOfPaintAnswerLabel);
            this.Controls.Add(this.timeRequiredAnswerLabel);
            this.Controls.Add(this.gallonsAnswerLabel);
            this.Controls.Add(this.totalSqFtAnswerLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.laborHoursLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.totalSqFtLabel);
            this.Controls.Add(this.pricePerGallonLabel);
            this.Controls.Add(this.coatsLabel);
            this.Controls.Add(this.sqFootLabel);
            this.Controls.Add(this.sqFtTxtBox);
            this.Controls.Add(this.numberOfCoatsTxtBox);
            this.Controls.Add(this.pricePerGallonTxtBox);
            this.Controls.Add(this.answerButton);
            this.Name = "program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.TextBox pricePerGallonTxtBox;
        private System.Windows.Forms.TextBox numberOfCoatsTxtBox;
        private System.Windows.Forms.TextBox sqFtTxtBox;
        private System.Windows.Forms.Label sqFootLabel;
        private System.Windows.Forms.Label coatsLabel;
        private System.Windows.Forms.Label pricePerGallonLabel;
        private System.Windows.Forms.Label totalSqFtLabel;
        private System.Windows.Forms.Label gallonsLabel;
        private System.Windows.Forms.Label laborHoursLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalSqFtAnswerLabel;
        private System.Windows.Forms.Label gallonsAnswerLabel;
        private System.Windows.Forms.Label timeRequiredAnswerLabel;
        private System.Windows.Forms.Label costOfPaintAnswerLabel;
        private System.Windows.Forms.Label totalLaborCostAnswerLabel;
        private System.Windows.Forms.Label totalCostAnswerLabel;
    }
}


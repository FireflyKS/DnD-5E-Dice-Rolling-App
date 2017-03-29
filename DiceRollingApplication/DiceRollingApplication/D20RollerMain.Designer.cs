namespace DiceRollingApplication
{
    partial class D20RollerMain
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
            this.greetingText = new System.Windows.Forms.Label();
            this.applicationDecsription = new System.Windows.Forms.Label();
            this.advantageDisadvantageLabel = new System.Windows.Forms.Label();
            this.advantageRadioButton = new System.Windows.Forms.RadioButton();
            this.disadvantageRadioButton = new System.Windows.Forms.RadioButton();
            this.modifierUpDownSelect = new System.Windows.Forms.NumericUpDown();
            this.modifierInputLabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.selectNumberOfDiceLable = new System.Windows.Forms.Label();
            this.selectNumberDiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.individualRollResultsLabel = new System.Windows.Forms.Label();
            this.totalRollResultLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.selectAdvantagePanel = new System.Windows.Forms.Panel();
            this.d2RadioButton = new System.Windows.Forms.RadioButton();
            this.d4RadioButton = new System.Windows.Forms.RadioButton();
            this.d6RadioButton = new System.Windows.Forms.RadioButton();
            this.d8RadioButton = new System.Windows.Forms.RadioButton();
            this.d10RadioButton = new System.Windows.Forms.RadioButton();
            this.d12RadioButton = new System.Windows.Forms.RadioButton();
            this.d20RadioButton = new System.Windows.Forms.RadioButton();
            this.d100RadioButton = new System.Windows.Forms.RadioButton();
            this.selectDiceIntro = new System.Windows.Forms.Label();
            this.selectDiceTypePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.modifierUpDownSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectNumberDiceUpDown)).BeginInit();
            this.selectAdvantagePanel.SuspendLayout();
            this.selectDiceTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // greetingText
            // 
            this.greetingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greetingText.AutoSize = true;
            this.greetingText.Font = new System.Drawing.Font("Book Antiqua", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(175)))));
            this.greetingText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greetingText.Location = new System.Drawing.Point(131, 9);
            this.greetingText.Name = "greetingText";
            this.greetingText.Size = new System.Drawing.Size(604, 39);
            this.greetingText.TabIndex = 0;
            this.greetingText.Text = "Welcome to the Dice Roller Application";
            this.greetingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applicationDecsription
            // 
            this.applicationDecsription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applicationDecsription.AutoSize = true;
            this.applicationDecsription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationDecsription.ForeColor = System.Drawing.Color.White;
            this.applicationDecsription.Location = new System.Drawing.Point(26, 58);
            this.applicationDecsription.Margin = new System.Windows.Forms.Padding(17, 10, 17, 0);
            this.applicationDecsription.MaximumSize = new System.Drawing.Size(800, 0);
            this.applicationDecsription.Name = "applicationDecsription";
            this.applicationDecsription.Size = new System.Drawing.Size(786, 30);
            this.applicationDecsription.TabIndex = 1;
            this.applicationDecsription.Text = "This program lets you select which type of dice you want to roll, how many of tha" +
    "t type of dice to roll, if there are any modifiers to the roll, and then display" +
    "s the results of the roll.";
            this.applicationDecsription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // advantageDisadvantageLabel
            // 
            this.advantageDisadvantageLabel.AutoSize = true;
            this.advantageDisadvantageLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advantageDisadvantageLabel.ForeColor = System.Drawing.Color.White;
            this.advantageDisadvantageLabel.Location = new System.Drawing.Point(22, 16);
            this.advantageDisadvantageLabel.Name = "advantageDisadvantageLabel";
            this.advantageDisadvantageLabel.Size = new System.Drawing.Size(317, 19);
            this.advantageDisadvantageLabel.TabIndex = 11;
            this.advantageDisadvantageLabel.Text = "Does the roll have Advantage/Disadvantage?";
            // 
            // advantageRadioButton
            // 
            this.advantageRadioButton.AutoSize = true;
            this.advantageRadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advantageRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.advantageRadioButton.Location = new System.Drawing.Point(26, 45);
            this.advantageRadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.advantageRadioButton.Name = "advantageRadioButton";
            this.advantageRadioButton.Size = new System.Drawing.Size(101, 23);
            this.advantageRadioButton.TabIndex = 12;
            this.advantageRadioButton.TabStop = true;
            this.advantageRadioButton.Text = "Advantage";
            this.advantageRadioButton.UseVisualStyleBackColor = true;
            // 
            // disadvantageRadioButton
            // 
            this.disadvantageRadioButton.AutoSize = true;
            this.disadvantageRadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disadvantageRadioButton.ForeColor = System.Drawing.Color.Red;
            this.disadvantageRadioButton.Location = new System.Drawing.Point(215, 45);
            this.disadvantageRadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.disadvantageRadioButton.Name = "disadvantageRadioButton";
            this.disadvantageRadioButton.Size = new System.Drawing.Size(119, 23);
            this.disadvantageRadioButton.TabIndex = 13;
            this.disadvantageRadioButton.TabStop = true;
            this.disadvantageRadioButton.Text = "Disadvantage";
            this.disadvantageRadioButton.UseVisualStyleBackColor = true;
            // 
            // modifierUpDownSelect
            // 
            this.modifierUpDownSelect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierUpDownSelect.Location = new System.Drawing.Point(543, 423);
            this.modifierUpDownSelect.Margin = new System.Windows.Forms.Padding(10);
            this.modifierUpDownSelect.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.modifierUpDownSelect.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.modifierUpDownSelect.Name = "modifierUpDownSelect";
            this.modifierUpDownSelect.Size = new System.Drawing.Size(50, 27);
            this.modifierUpDownSelect.TabIndex = 14;
            this.modifierUpDownSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modifierInputLabel
            // 
            this.modifierInputLabel.AutoSize = true;
            this.modifierInputLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierInputLabel.ForeColor = System.Drawing.Color.White;
            this.modifierInputLabel.Location = new System.Drawing.Point(276, 423);
            this.modifierInputLabel.Margin = new System.Windows.Forms.Padding(10);
            this.modifierInputLabel.Name = "modifierInputLabel";
            this.modifierInputLabel.Size = new System.Drawing.Size(252, 19);
            this.modifierInputLabel.TabIndex = 15;
            this.modifierInputLabel.Text = "Select  the applicable roll modifier: ";
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rollButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rollButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(280, 480);
            this.rollButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(313, 40);
            this.rollButton.TabIndex = 16;
            this.rollButton.Text = "ROLL!";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // selectNumberOfDiceLable
            // 
            this.selectNumberOfDiceLable.AutoSize = true;
            this.selectNumberOfDiceLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNumberOfDiceLable.ForeColor = System.Drawing.Color.White;
            this.selectNumberOfDiceLable.Location = new System.Drawing.Point(276, 304);
            this.selectNumberOfDiceLable.Margin = new System.Windows.Forms.Padding(10);
            this.selectNumberOfDiceLable.Name = "selectNumberOfDiceLable";
            this.selectNumberOfDiceLable.Size = new System.Drawing.Size(225, 19);
            this.selectNumberOfDiceLable.TabIndex = 17;
            this.selectNumberOfDiceLable.Text = "How many dice are you rolling?";
            // 
            // selectNumberDiceUpDown
            // 
            this.selectNumberDiceUpDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNumberDiceUpDown.Location = new System.Drawing.Point(543, 302);
            this.selectNumberDiceUpDown.Margin = new System.Windows.Forms.Padding(10);
            this.selectNumberDiceUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.selectNumberDiceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectNumberDiceUpDown.Name = "selectNumberDiceUpDown";
            this.selectNumberDiceUpDown.Size = new System.Drawing.Size(50, 27);
            this.selectNumberDiceUpDown.TabIndex = 18;
            this.selectNumberDiceUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectNumberDiceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // individualRollResultsLabel
            // 
            this.individualRollResultsLabel.AutoSize = true;
            this.individualRollResultsLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.individualRollResultsLabel.ForeColor = System.Drawing.Color.White;
            this.individualRollResultsLabel.Location = new System.Drawing.Point(312, 560);
            this.individualRollResultsLabel.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.individualRollResultsLabel.MaximumSize = new System.Drawing.Size(800, 0);
            this.individualRollResultsLabel.Name = "individualRollResultsLabel";
            this.individualRollResultsLabel.Size = new System.Drawing.Size(259, 26);
            this.individualRollResultsLabel.TabIndex = 19;
            this.individualRollResultsLabel.Text = "Individual Results of the Roll";
            this.individualRollResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalRollResultLabel
            // 
            this.totalRollResultLabel.AutoSize = true;
            this.totalRollResultLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRollResultLabel.ForeColor = System.Drawing.Color.White;
            this.totalRollResultLabel.Location = new System.Drawing.Point(360, 671);
            this.totalRollResultLabel.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.totalRollResultLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.totalRollResultLabel.Name = "totalRollResultLabel";
            this.totalRollResultLabel.Size = new System.Drawing.Size(150, 26);
            this.totalRollResultLabel.TabIndex = 20;
            this.totalRollResultLabel.Text = "Total Roll Result";
            this.totalRollResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(342, 793);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 40);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(200, 40);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset!";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // selectAdvantagePanel
            // 
            this.selectAdvantagePanel.Controls.Add(this.advantageDisadvantageLabel);
            this.selectAdvantagePanel.Controls.Add(this.advantageRadioButton);
            this.selectAdvantagePanel.Controls.Add(this.disadvantageRadioButton);
            this.selectAdvantagePanel.Location = new System.Drawing.Point(253, 336);
            this.selectAdvantagePanel.Name = "selectAdvantagePanel";
            this.selectAdvantagePanel.Size = new System.Drawing.Size(356, 74);
            this.selectAdvantagePanel.TabIndex = 23;
            // 
            // d2RadioButton
            // 
            this.d2RadioButton.AutoSize = true;
            this.d2RadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.d2RadioButton.Location = new System.Drawing.Point(245, 173);
            this.d2RadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.d2RadioButton.Name = "d2RadioButton";
            this.d2RadioButton.Size = new System.Drawing.Size(44, 23);
            this.d2RadioButton.TabIndex = 10;
            this.d2RadioButton.TabStop = true;
            this.d2RadioButton.Text = "d2";
            this.d2RadioButton.UseVisualStyleBackColor = true;
            // 
            // d4RadioButton
            // 
            this.d4RadioButton.AutoSize = true;
            this.d4RadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d4RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.d4RadioButton.Location = new System.Drawing.Point(245, 130);
            this.d4RadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.d4RadioButton.Name = "d4RadioButton";
            this.d4RadioButton.Size = new System.Drawing.Size(44, 23);
            this.d4RadioButton.TabIndex = 9;
            this.d4RadioButton.TabStop = true;
            this.d4RadioButton.Text = "d4";
            this.d4RadioButton.UseVisualStyleBackColor = true;
            // 
            // d6RadioButton
            // 
            this.d6RadioButton.AutoSize = true;
            this.d6RadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d6RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.d6RadioButton.Location = new System.Drawing.Point(245, 87);
            this.d6RadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.d6RadioButton.Name = "d6RadioButton";
            this.d6RadioButton.Size = new System.Drawing.Size(44, 23);
            this.d6RadioButton.TabIndex = 8;
            this.d6RadioButton.TabStop = true;
            this.d6RadioButton.Text = "d6";
            this.d6RadioButton.UseVisualStyleBackColor = true;
            // 
            // d8RadioButton
            // 
            this.d8RadioButton.AutoSize = true;
            this.d8RadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d8RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.d8RadioButton.Location = new System.Drawing.Point(245, 44);
            this.d8RadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.d8RadioButton.Name = "d8RadioButton";
            this.d8RadioButton.Size = new System.Drawing.Size(44, 23);
            this.d8RadioButton.TabIndex = 7;
            this.d8RadioButton.TabStop = true;
            this.d8RadioButton.Text = "d8";
            this.d8RadioButton.UseVisualStyleBackColor = true;
            // 
            // d10RadioButton
            // 
            this.d10RadioButton.AutoSize = true;
            this.d10RadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d10RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.d10RadioButton.Location = new System.Drawing.Point(85, 173);
            this.d10RadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.d10RadioButton.Name = "d10RadioButton";
            this.d10RadioButton.Size = new System.Drawing.Size(52, 23);
            this.d10RadioButton.TabIndex = 6;
            this.d10RadioButton.TabStop = true;
            this.d10RadioButton.Text = "d10";
            this.d10RadioButton.UseVisualStyleBackColor = true;
            // 
            // d12RadioButton
            // 
            this.d12RadioButton.AutoSize = true;
            this.d12RadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d12RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.d12RadioButton.Location = new System.Drawing.Point(85, 130);
            this.d12RadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.d12RadioButton.Name = "d12RadioButton";
            this.d12RadioButton.Size = new System.Drawing.Size(52, 23);
            this.d12RadioButton.TabIndex = 5;
            this.d12RadioButton.TabStop = true;
            this.d12RadioButton.Text = "d12";
            this.d12RadioButton.UseVisualStyleBackColor = true;
            // 
            // d20RadioButton
            // 
            this.d20RadioButton.AutoSize = true;
            this.d20RadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d20RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.d20RadioButton.Location = new System.Drawing.Point(85, 87);
            this.d20RadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.d20RadioButton.Name = "d20RadioButton";
            this.d20RadioButton.Size = new System.Drawing.Size(52, 23);
            this.d20RadioButton.TabIndex = 4;
            this.d20RadioButton.TabStop = true;
            this.d20RadioButton.Text = "d20";
            this.d20RadioButton.UseVisualStyleBackColor = true;
            // 
            // d100RadioButton
            // 
            this.d100RadioButton.AutoSize = true;
            this.d100RadioButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d100RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.d100RadioButton.Location = new System.Drawing.Point(85, 44);
            this.d100RadioButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.d100RadioButton.Name = "d100RadioButton";
            this.d100RadioButton.Size = new System.Drawing.Size(60, 23);
            this.d100RadioButton.TabIndex = 3;
            this.d100RadioButton.TabStop = true;
            this.d100RadioButton.Text = "d100";
            this.d100RadioButton.UseVisualStyleBackColor = true;
            // 
            // selectDiceIntro
            // 
            this.selectDiceIntro.AutoSize = true;
            this.selectDiceIntro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDiceIntro.ForeColor = System.Drawing.Color.White;
            this.selectDiceIntro.Location = new System.Drawing.Point(81, 15);
            this.selectDiceIntro.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.selectDiceIntro.Name = "selectDiceIntro";
            this.selectDiceIntro.Size = new System.Drawing.Size(208, 19);
            this.selectDiceIntro.TabIndex = 2;
            this.selectDiceIntro.Text = "Select the type of dice to roll";
            // 
            // selectDiceTypePanel
            // 
            this.selectDiceTypePanel.Controls.Add(this.selectDiceIntro);
            this.selectDiceTypePanel.Controls.Add(this.d100RadioButton);
            this.selectDiceTypePanel.Controls.Add(this.d4RadioButton);
            this.selectDiceTypePanel.Controls.Add(this.d6RadioButton);
            this.selectDiceTypePanel.Controls.Add(this.d8RadioButton);
            this.selectDiceTypePanel.Controls.Add(this.d20RadioButton);
            this.selectDiceTypePanel.Controls.Add(this.d12RadioButton);
            this.selectDiceTypePanel.Controls.Add(this.d10RadioButton);
            this.selectDiceTypePanel.Controls.Add(this.d2RadioButton);
            this.selectDiceTypePanel.Location = new System.Drawing.Point(253, 91);
            this.selectDiceTypePanel.Name = "selectDiceTypePanel";
            this.selectDiceTypePanel.Size = new System.Drawing.Size(356, 198);
            this.selectDiceTypePanel.TabIndex = 24;
            // 
            // D20RollerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(850, 882);
            this.Controls.Add(this.selectDiceTypePanel);
            this.Controls.Add(this.selectAdvantagePanel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.totalRollResultLabel);
            this.Controls.Add(this.individualRollResultsLabel);
            this.Controls.Add(this.selectNumberDiceUpDown);
            this.Controls.Add(this.selectNumberOfDiceLable);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.modifierInputLabel);
            this.Controls.Add(this.modifierUpDownSelect);
            this.Controls.Add(this.applicationDecsription);
            this.Controls.Add(this.greetingText);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "D20RollerMain";
            this.Text = "D20 Roller";
            ((System.ComponentModel.ISupportInitialize)(this.modifierUpDownSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectNumberDiceUpDown)).EndInit();
            this.selectAdvantagePanel.ResumeLayout(false);
            this.selectAdvantagePanel.PerformLayout();
            this.selectDiceTypePanel.ResumeLayout(false);
            this.selectDiceTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingText;
        private System.Windows.Forms.Label applicationDecsription;
        private System.Windows.Forms.Label advantageDisadvantageLabel;
        private System.Windows.Forms.RadioButton advantageRadioButton;
        private System.Windows.Forms.RadioButton disadvantageRadioButton;
        private System.Windows.Forms.NumericUpDown modifierUpDownSelect;
        private System.Windows.Forms.Label modifierInputLabel;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label selectNumberOfDiceLable;
        private System.Windows.Forms.NumericUpDown selectNumberDiceUpDown;
        private System.Windows.Forms.Label individualRollResultsLabel;
        private System.Windows.Forms.Label totalRollResultLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel selectAdvantagePanel;
        private System.Windows.Forms.RadioButton d2RadioButton;
        private System.Windows.Forms.RadioButton d4RadioButton;
        private System.Windows.Forms.RadioButton d6RadioButton;
        private System.Windows.Forms.RadioButton d8RadioButton;
        private System.Windows.Forms.RadioButton d10RadioButton;
        private System.Windows.Forms.RadioButton d12RadioButton;
        private System.Windows.Forms.RadioButton d20RadioButton;
        private System.Windows.Forms.RadioButton d100RadioButton;
        private System.Windows.Forms.Label selectDiceIntro;
        private System.Windows.Forms.Panel selectDiceTypePanel;
    }
}


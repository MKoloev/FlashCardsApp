
namespace FlashCardsApp
{
	partial class LearningWindowForm
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
			this.backgroundPanel = new System.Windows.Forms.Panel();
			this.dontKnowTheAnswerButton = new System.Windows.Forms.Button();
			this.knowTheAnswerButton = new System.Windows.Forms.Button();
			this.showAnswerButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.responsetTextBox = new System.Windows.Forms.TextBox();
			this.TextAddingName = new System.Windows.Forms.Label();
			this.questionTextBox = new System.Windows.Forms.TextBox();
			this.header = new System.Windows.Forms.Label();
			this.closeWindow = new System.Windows.Forms.Button();
			this.backgroundPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// backgroundPanel
			// 
			this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
			this.backgroundPanel.Controls.Add(this.dontKnowTheAnswerButton);
			this.backgroundPanel.Controls.Add(this.knowTheAnswerButton);
			this.backgroundPanel.Controls.Add(this.showAnswerButton);
			this.backgroundPanel.Controls.Add(this.label1);
			this.backgroundPanel.Controls.Add(this.responsetTextBox);
			this.backgroundPanel.Controls.Add(this.TextAddingName);
			this.backgroundPanel.Controls.Add(this.questionTextBox);
			this.backgroundPanel.Controls.Add(this.header);
			this.backgroundPanel.Controls.Add(this.closeWindow);
			this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
			this.backgroundPanel.Name = "backgroundPanel";
			this.backgroundPanel.Size = new System.Drawing.Size(540, 415);
			this.backgroundPanel.TabIndex = 0;
			this.backgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseDown);
			this.backgroundPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseMove);
			// 
			// dontKnowTheAnswerButton
			// 
			this.dontKnowTheAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.dontKnowTheAnswerButton.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.dontKnowTheAnswerButton.ForeColor = System.Drawing.Color.White;
			this.dontKnowTheAnswerButton.Location = new System.Drawing.Point(321, 352);
			this.dontKnowTheAnswerButton.Name = "dontKnowTheAnswerButton";
			this.dontKnowTheAnswerButton.Size = new System.Drawing.Size(122, 42);
			this.dontKnowTheAnswerButton.TabIndex = 21;
			this.dontKnowTheAnswerButton.Text = "Не знаю";
			this.dontKnowTheAnswerButton.UseVisualStyleBackColor = false;
			// 
			// knowTheAnswerButton
			// 
			this.knowTheAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.knowTheAnswerButton.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.knowTheAnswerButton.ForeColor = System.Drawing.Color.White;
			this.knowTheAnswerButton.Location = new System.Drawing.Point(76, 352);
			this.knowTheAnswerButton.Name = "knowTheAnswerButton";
			this.knowTheAnswerButton.Size = new System.Drawing.Size(122, 42);
			this.knowTheAnswerButton.TabIndex = 20;
			this.knowTheAnswerButton.Text = "Знаю";
			this.knowTheAnswerButton.UseVisualStyleBackColor = false;
			// 
			// showAnswerButton
			// 
			this.showAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.showAnswerButton.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.showAnswerButton.ForeColor = System.Drawing.Color.White;
			this.showAnswerButton.Location = new System.Drawing.Point(125, 187);
			this.showAnswerButton.Name = "showAnswerButton";
			this.showAnswerButton.Size = new System.Drawing.Size(116, 44);
			this.showAnswerButton.TabIndex = 19;
			this.showAnswerButton.Text = "Показать";
			this.showAnswerButton.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(22, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 55);
			this.label1.TabIndex = 18;
			this.label1.Text = "Ответ";
			// 
			// responsetTextBox
			// 
			this.responsetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.responsetTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.responsetTextBox.Location = new System.Drawing.Point(22, 239);
			this.responsetTextBox.Multiline = true;
			this.responsetTextBox.Name = "responsetTextBox";
			this.responsetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.responsetTextBox.Size = new System.Drawing.Size(495, 98);
			this.responsetTextBox.TabIndex = 17;
			// 
			// TextAddingName
			// 
			this.TextAddingName.AutoSize = true;
			this.TextAddingName.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TextAddingName.ForeColor = System.Drawing.SystemColors.Desktop;
			this.TextAddingName.Location = new System.Drawing.Point(22, 25);
			this.TextAddingName.Name = "TextAddingName";
			this.TextAddingName.Size = new System.Drawing.Size(86, 55);
			this.TextAddingName.TabIndex = 16;
			this.TextAddingName.Text = "Вопрс";
			// 
			// questionTextBox
			// 
			this.questionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.questionTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.questionTextBox.Location = new System.Drawing.Point(22, 83);
			this.questionTextBox.Multiline = true;
			this.questionTextBox.Name = "questionTextBox";
			this.questionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.questionTextBox.Size = new System.Drawing.Size(495, 98);
			this.questionTextBox.TabIndex = 15;
			// 
			// header
			// 
			this.header.AutoSize = true;
			this.header.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.header.ForeColor = System.Drawing.SystemColors.Desktop;
			this.header.Location = new System.Drawing.Point(173, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(124, 55);
			this.header.TabIndex = 14;
			this.header.Text = "Обучение";
			// 
			// closeWindow
			// 
			this.closeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeWindow.BackgroundImage = global::FlashCardsApp.Properties.Resources.window_close_icon;
			this.closeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeWindow.Location = new System.Drawing.Point(500, 0);
			this.closeWindow.Name = "closeWindow";
			this.closeWindow.Size = new System.Drawing.Size(40, 40);
			this.closeWindow.TabIndex = 13;
			this.closeWindow.UseVisualStyleBackColor = true;
			this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
			// 
			// LearningWindowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 415);
			this.Controls.Add(this.backgroundPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LearningWindowForm";
			this.Text = "LearningWindowForm";
			this.backgroundPanel.ResumeLayout(false);
			this.backgroundPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel backgroundPanel;
		private System.Windows.Forms.Button closeWindow;
		private System.Windows.Forms.Label header;
		private System.Windows.Forms.Button showAnswerButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox responsetTextBox;
		private System.Windows.Forms.Label TextAddingName;
		private System.Windows.Forms.TextBox questionTextBox;
		private System.Windows.Forms.Button dontKnowTheAnswerButton;
		private System.Windows.Forms.Button knowTheAnswerButton;
	}
}
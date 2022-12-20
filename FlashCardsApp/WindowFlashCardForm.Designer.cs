
namespace FlashCardsApp
{
	partial class WindowFlashCardForm
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
			this.header = new System.Windows.Forms.Label();
			this.closeWindow = new System.Windows.Forms.Button();
			this.deleteFlashCard = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.responsetTextBox = new System.Windows.Forms.TextBox();
			this.TextAddingName = new System.Windows.Forms.Label();
			this.questionTextBox = new System.Windows.Forms.TextBox();
			this.backgroundPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// backgroundPanel
			// 
			this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
			this.backgroundPanel.Controls.Add(this.header);
			this.backgroundPanel.Controls.Add(this.closeWindow);
			this.backgroundPanel.Controls.Add(this.deleteFlashCard);
			this.backgroundPanel.Controls.Add(this.label1);
			this.backgroundPanel.Controls.Add(this.responsetTextBox);
			this.backgroundPanel.Controls.Add(this.TextAddingName);
			this.backgroundPanel.Controls.Add(this.questionTextBox);
			this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
			this.backgroundPanel.Name = "backgroundPanel";
			this.backgroundPanel.Size = new System.Drawing.Size(540, 415);
			this.backgroundPanel.TabIndex = 0;
			this.backgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseDown);
			this.backgroundPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseMove);
			// 
			// header
			// 
			this.header.AutoSize = true;
			this.header.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.header.ForeColor = System.Drawing.SystemColors.Desktop;
			this.header.Location = new System.Drawing.Point(176, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(152, 55);
			this.header.TabIndex = 13;
			this.header.Text = "Флеш карта";
			// 
			// closeWindow
			// 
			this.closeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeWindow.BackgroundImage = global::FlashCardsApp.Properties.Resources.window_close_icon;
			this.closeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeWindow.Location = new System.Drawing.Point(500, 3);
			this.closeWindow.Name = "closeWindow";
			this.closeWindow.Size = new System.Drawing.Size(40, 40);
			this.closeWindow.TabIndex = 12;
			this.closeWindow.UseVisualStyleBackColor = true;
			this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
			// 
			// deleteFlashCard
			// 
			this.deleteFlashCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteFlashCard.BackgroundImage = global::FlashCardsApp.Properties.Resources.delete_icon;
			this.deleteFlashCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.deleteFlashCard.Location = new System.Drawing.Point(3, 3);
			this.deleteFlashCard.Name = "deleteFlashCard";
			this.deleteFlashCard.Size = new System.Drawing.Size(40, 40);
			this.deleteFlashCard.TabIndex = 11;
			this.deleteFlashCard.UseVisualStyleBackColor = true;
			this.deleteFlashCard.Click += new System.EventHandler(this.deleteFlashCard_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(22, 209);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 55);
			this.label1.TabIndex = 10;
			this.label1.Text = "Ответ";
			// 
			// responsetTextBox
			// 
			this.responsetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.responsetTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.responsetTextBox.Location = new System.Drawing.Point(22, 267);
			this.responsetTextBox.Multiline = true;
			this.responsetTextBox.Name = "responsetTextBox";
			this.responsetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.responsetTextBox.Size = new System.Drawing.Size(495, 98);
			this.responsetTextBox.TabIndex = 9;
			this.responsetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.responsetTextBox_KeyPress);
			// 
			// TextAddingName
			// 
			this.TextAddingName.AutoSize = true;
			this.TextAddingName.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TextAddingName.ForeColor = System.Drawing.SystemColors.Desktop;
			this.TextAddingName.Location = new System.Drawing.Point(22, 53);
			this.TextAddingName.Name = "TextAddingName";
			this.TextAddingName.Size = new System.Drawing.Size(86, 55);
			this.TextAddingName.TabIndex = 8;
			this.TextAddingName.Text = "Вопрс";
			// 
			// questionTextBox
			// 
			this.questionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.questionTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.questionTextBox.Location = new System.Drawing.Point(22, 111);
			this.questionTextBox.Multiline = true;
			this.questionTextBox.Name = "questionTextBox";
			this.questionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.questionTextBox.Size = new System.Drawing.Size(495, 98);
			this.questionTextBox.TabIndex = 7;
			this.questionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.questionTextBox_KeyPress);
			// 
			// WindowFlashCardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 415);
			this.Controls.Add(this.backgroundPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WindowFlashCardForm";
			this.Text = "WindowFlashCardForm";
			this.backgroundPanel.ResumeLayout(false);
			this.backgroundPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel backgroundPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox responsetTextBox;
		private System.Windows.Forms.Label TextAddingName;
		private System.Windows.Forms.TextBox questionTextBox;
		private System.Windows.Forms.Button deleteFlashCard;
		private System.Windows.Forms.Button closeWindow;
		private System.Windows.Forms.Label header;
	}
}
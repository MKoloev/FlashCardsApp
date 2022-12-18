
namespace FlashCardsApp
{
	partial class AddingNewFlashCardForm
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
			this.closeFormButton = new System.Windows.Forms.Button();
			this.createFlashCardButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.responsetTextBox = new System.Windows.Forms.TextBox();
			this.TextAddingName = new System.Windows.Forms.Label();
			this.questionTextBox = new System.Windows.Forms.TextBox();
			this.NameFormPanel = new System.Windows.Forms.Panel();
			this.TextForm = new System.Windows.Forms.Label();
			this.CloseForm = new System.Windows.Forms.Button();
			this.CreateСollection = new System.Windows.Forms.Button();
			this.backgroundPanel.SuspendLayout();
			this.NameFormPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// backgroundPanel
			// 
			this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
			this.backgroundPanel.Controls.Add(this.closeFormButton);
			this.backgroundPanel.Controls.Add(this.createFlashCardButton);
			this.backgroundPanel.Controls.Add(this.label1);
			this.backgroundPanel.Controls.Add(this.responsetTextBox);
			this.backgroundPanel.Controls.Add(this.TextAddingName);
			this.backgroundPanel.Controls.Add(this.questionTextBox);
			this.backgroundPanel.Controls.Add(this.NameFormPanel);
			this.backgroundPanel.Controls.Add(this.CloseForm);
			this.backgroundPanel.Controls.Add(this.CreateСollection);
			this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
			this.backgroundPanel.Name = "backgroundPanel";
			this.backgroundPanel.Size = new System.Drawing.Size(558, 462);
			this.backgroundPanel.TabIndex = 1;
			this.backgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseDown);
			this.backgroundPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseMove);
			// 
			// closeFormButton
			// 
			this.closeFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.closeFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.closeFormButton.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.closeFormButton.ForeColor = System.Drawing.Color.White;
			this.closeFormButton.Location = new System.Drawing.Point(333, 390);
			this.closeFormButton.Name = "closeFormButton";
			this.closeFormButton.Size = new System.Drawing.Size(160, 60);
			this.closeFormButton.TabIndex = 8;
			this.closeFormButton.Text = "Отмена";
			this.closeFormButton.UseVisualStyleBackColor = false;
			this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
			// 
			// createFlashCardButton
			// 
			this.createFlashCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.createFlashCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.createFlashCardButton.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.createFlashCardButton.ForeColor = System.Drawing.Color.White;
			this.createFlashCardButton.Location = new System.Drawing.Point(53, 390);
			this.createFlashCardButton.Name = "createFlashCardButton";
			this.createFlashCardButton.Size = new System.Drawing.Size(160, 60);
			this.createFlashCardButton.TabIndex = 7;
			this.createFlashCardButton.Text = "Добавить";
			this.createFlashCardButton.UseVisualStyleBackColor = false;
			this.createFlashCardButton.Click += new System.EventHandler(this.createFlashCardButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(30, 217);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(187, 55);
			this.label1.TabIndex = 6;
			this.label1.Text = "Введите ответ";
			// 
			// responsetTextBox
			// 
			this.responsetTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.responsetTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.responsetTextBox.Location = new System.Drawing.Point(30, 275);
			this.responsetTextBox.Multiline = true;
			this.responsetTextBox.Name = "responsetTextBox";
			this.responsetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.responsetTextBox.Size = new System.Drawing.Size(495, 98);
			this.responsetTextBox.TabIndex = 5;
			// 
			// TextAddingName
			// 
			this.TextAddingName.AutoSize = true;
			this.TextAddingName.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TextAddingName.ForeColor = System.Drawing.SystemColors.Desktop;
			this.TextAddingName.Location = new System.Drawing.Point(30, 61);
			this.TextAddingName.Name = "TextAddingName";
			this.TextAddingName.Size = new System.Drawing.Size(179, 55);
			this.TextAddingName.TabIndex = 4;
			this.TextAddingName.Text = "Введите вопрс";
			// 
			// questionTextBox
			// 
			this.questionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.questionTextBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.questionTextBox.Location = new System.Drawing.Point(30, 119);
			this.questionTextBox.Multiline = true;
			this.questionTextBox.Name = "questionTextBox";
			this.questionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.questionTextBox.Size = new System.Drawing.Size(495, 98);
			this.questionTextBox.TabIndex = 3;
			// 
			// NameFormPanel
			// 
			this.NameFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
			this.NameFormPanel.Controls.Add(this.TextForm);
			this.NameFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.NameFormPanel.Location = new System.Drawing.Point(0, 0);
			this.NameFormPanel.Name = "NameFormPanel";
			this.NameFormPanel.Size = new System.Drawing.Size(558, 58);
			this.NameFormPanel.TabIndex = 2;
			// 
			// TextForm
			// 
			this.TextForm.AutoSize = true;
			this.TextForm.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TextForm.Location = new System.Drawing.Point(170, 0);
			this.TextForm.Name = "TextForm";
			this.TextForm.Size = new System.Drawing.Size(233, 51);
			this.TextForm.TabIndex = 0;
			this.TextForm.Text = "Добавть флеш карту";
			// 
			// CloseForm
			// 
			this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.CloseForm.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.CloseForm.ForeColor = System.Drawing.Color.White;
			this.CloseForm.Location = new System.Drawing.Point(220, 587);
			this.CloseForm.Name = "CloseForm";
			this.CloseForm.Size = new System.Drawing.Size(488, 60);
			this.CloseForm.TabIndex = 1;
			this.CloseForm.Text = "Отмена";
			this.CloseForm.UseVisualStyleBackColor = false;
			// 
			// CreateСollection
			// 
			this.CreateСollection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateСollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.CreateСollection.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.CreateСollection.ForeColor = System.Drawing.Color.White;
			this.CreateСollection.Location = new System.Drawing.Point(30, 587);
			this.CreateСollection.Name = "CreateСollection";
			this.CreateСollection.Size = new System.Drawing.Size(488, 60);
			this.CreateСollection.TabIndex = 0;
			this.CreateСollection.Text = "Добавить";
			this.CreateСollection.UseVisualStyleBackColor = false;
			// 
			// AddingNewFlashCardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 462);
			this.Controls.Add(this.backgroundPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddingNewFlashCardForm";
			this.Text = "AddingNewFleshCardForm";
			this.backgroundPanel.ResumeLayout(false);
			this.backgroundPanel.PerformLayout();
			this.NameFormPanel.ResumeLayout(false);
			this.NameFormPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel backgroundPanel;
		private System.Windows.Forms.Label TextAddingName;
		private System.Windows.Forms.TextBox questionTextBox;
		private System.Windows.Forms.Panel NameFormPanel;
		private System.Windows.Forms.Label TextForm;
		private System.Windows.Forms.Button CloseForm;
		private System.Windows.Forms.Button CreateСollection;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox responsetTextBox;
		private System.Windows.Forms.Button closeFormButton;
		private System.Windows.Forms.Button createFlashCardButton;
	}
}
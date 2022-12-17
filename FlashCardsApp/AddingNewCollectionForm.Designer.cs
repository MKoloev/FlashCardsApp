
namespace FlashCardsApp
{
	partial class AddingNewCollectionForm
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
			this.TextAddingName = new System.Windows.Forms.Label();
			this.NameCollectionTextBox = new System.Windows.Forms.TextBox();
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
			this.backgroundPanel.Controls.Add(this.TextAddingName);
			this.backgroundPanel.Controls.Add(this.NameCollectionTextBox);
			this.backgroundPanel.Controls.Add(this.NameFormPanel);
			this.backgroundPanel.Controls.Add(this.CloseForm);
			this.backgroundPanel.Controls.Add(this.CreateСollection);
			this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
			this.backgroundPanel.Name = "backgroundPanel";
			this.backgroundPanel.Size = new System.Drawing.Size(382, 303);
			this.backgroundPanel.TabIndex = 0;
			this.backgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseDown);
			this.backgroundPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseMove);
			// 
			// TextAddingName
			// 
			this.TextAddingName.AutoSize = true;
			this.TextAddingName.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TextAddingName.Location = new System.Drawing.Point(30, 83);
			this.TextAddingName.Name = "TextAddingName";
			this.TextAddingName.Size = new System.Drawing.Size(332, 55);
			this.TextAddingName.TabIndex = 4;
			this.TextAddingName.Text = "Введите название коллекции";
			// 
			// NameCollectionTextBox
			// 
			this.NameCollectionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.NameCollectionTextBox.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.NameCollectionTextBox.Location = new System.Drawing.Point(30, 141);
			this.NameCollectionTextBox.Multiline = true;
			this.NameCollectionTextBox.Name = "NameCollectionTextBox";
			this.NameCollectionTextBox.Size = new System.Drawing.Size(320, 57);
			this.NameCollectionTextBox.TabIndex = 3;
			this.NameCollectionTextBox.TextChanged += new System.EventHandler(this.NameCollectionTextBox_TextChanged);
			// 
			// NameFormPanel
			// 
			this.NameFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
			this.NameFormPanel.Controls.Add(this.TextForm);
			this.NameFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.NameFormPanel.Location = new System.Drawing.Point(0, 0);
			this.NameFormPanel.Name = "NameFormPanel";
			this.NameFormPanel.Size = new System.Drawing.Size(382, 58);
			this.NameFormPanel.TabIndex = 2;
			// 
			// TextForm
			// 
			this.TextForm.AutoSize = true;
			this.TextForm.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.TextForm.Location = new System.Drawing.Point(80, 2);
			this.TextForm.Name = "TextForm";
			this.TextForm.Size = new System.Drawing.Size(222, 51);
			this.TextForm.TabIndex = 0;
			this.TextForm.Text = "Добавть коллеццию";
			// 
			// CloseForm
			// 
			this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.CloseForm.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.CloseForm.ForeColor = System.Drawing.Color.White;
			this.CloseForm.Location = new System.Drawing.Point(220, 225);
			this.CloseForm.Name = "CloseForm";
			this.CloseForm.Size = new System.Drawing.Size(130, 60);
			this.CloseForm.TabIndex = 1;
			this.CloseForm.Text = "Отмена";
			this.CloseForm.UseVisualStyleBackColor = false;
			this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
			// 
			// CreateСollection
			// 
			this.CreateСollection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateСollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.CreateСollection.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.CreateСollection.ForeColor = System.Drawing.Color.White;
			this.CreateСollection.Location = new System.Drawing.Point(30, 225);
			this.CreateСollection.Name = "CreateСollection";
			this.CreateСollection.Size = new System.Drawing.Size(130, 60);
			this.CreateСollection.TabIndex = 0;
			this.CreateСollection.Text = "Добавить";
			this.CreateСollection.UseVisualStyleBackColor = false;
			this.CreateСollection.Click += new System.EventHandler(this.CreateСollection_Click);
			// 
			// AddingNewCollectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 303);
			this.Controls.Add(this.backgroundPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddingNewCollectionForm";
			this.Text = "AddingNewCollectionForm";
			this.Load += new System.EventHandler(this.AddingNewCollectionForm_Load);
			this.backgroundPanel.ResumeLayout(false);
			this.backgroundPanel.PerformLayout();
			this.NameFormPanel.ResumeLayout(false);
			this.NameFormPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel backgroundPanel;
		private System.Windows.Forms.Button CloseForm;
		private System.Windows.Forms.Button CreateСollection;
		private System.Windows.Forms.Panel NameFormPanel;
		private System.Windows.Forms.Label TextForm;
		private System.Windows.Forms.TextBox NameCollectionTextBox;
		private System.Windows.Forms.Label TextAddingName;
	}
}
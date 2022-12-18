
namespace FlashCardsApp
{
	partial class WindowCollectionForm
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
			this.collectionPanel = new System.Windows.Forms.Panel();
			this.flashCardsPanel = new System.Windows.Forms.Panel();
			this.addFlashCard = new System.Windows.Forms.Button();
			this.startLearning = new System.Windows.Forms.Button();
			this.nameCollection = new System.Windows.Forms.TextBox();
			this.deleteCollection = new System.Windows.Forms.Button();
			this.comeBackButton = new System.Windows.Forms.Button();
			this.backgroundPanel = new System.Windows.Forms.Panel();
			this.collectionPanel.SuspendLayout();
			this.backgroundPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// collectionPanel
			// 
			this.collectionPanel.AutoScroll = true;
			this.collectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
			this.collectionPanel.Controls.Add(this.flashCardsPanel);
			this.collectionPanel.Controls.Add(this.addFlashCard);
			this.collectionPanel.Controls.Add(this.startLearning);
			this.collectionPanel.Controls.Add(this.nameCollection);
			this.collectionPanel.Controls.Add(this.deleteCollection);
			this.collectionPanel.Controls.Add(this.comeBackButton);
			this.collectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collectionPanel.Location = new System.Drawing.Point(0, 0);
			this.collectionPanel.Name = "collectionPanel";
			this.collectionPanel.Size = new System.Drawing.Size(582, 553);
			this.collectionPanel.TabIndex = 0;
			this.collectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.collectionPanel_Paint);
			this.collectionPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.collectionPanel_MouseDown);
			this.collectionPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.collectionPanel_MouseMove);
			// 
			// flashCardsPanel
			// 
			this.flashCardsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flashCardsPanel.AutoScroll = true;
			this.flashCardsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
			this.flashCardsPanel.Location = new System.Drawing.Point(0, 42);
			this.flashCardsPanel.Name = "flashCardsPanel";
			this.flashCardsPanel.Size = new System.Drawing.Size(582, 425);
			this.flashCardsPanel.TabIndex = 7;
			// 
			// addFlashCard
			// 
			this.addFlashCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.addFlashCard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.addFlashCard.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addFlashCard.ForeColor = System.Drawing.Color.White;
			this.addFlashCard.Location = new System.Drawing.Point(0, 473);
			this.addFlashCard.Name = "addFlashCard";
			this.addFlashCard.Size = new System.Drawing.Size(582, 40);
			this.addFlashCard.TabIndex = 6;
			this.addFlashCard.Text = "Добавить новую флеш карту";
			this.addFlashCard.UseVisualStyleBackColor = false;
			this.addFlashCard.Click += new System.EventHandler(this.addFlashCard_Click);
			// 
			// startLearning
			// 
			this.startLearning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.startLearning.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.startLearning.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.startLearning.ForeColor = System.Drawing.Color.White;
			this.startLearning.Location = new System.Drawing.Point(0, 513);
			this.startLearning.Name = "startLearning";
			this.startLearning.Size = new System.Drawing.Size(582, 40);
			this.startLearning.TabIndex = 5;
			this.startLearning.Text = "Начать обучение";
			this.startLearning.UseVisualStyleBackColor = false;
			// 
			// nameCollection
			// 
			this.nameCollection.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nameCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.nameCollection.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.nameCollection.Location = new System.Drawing.Point(94, 0);
			this.nameCollection.Multiline = true;
			this.nameCollection.Name = "nameCollection";
			this.nameCollection.Size = new System.Drawing.Size(400, 40);
			this.nameCollection.TabIndex = 4;
			this.nameCollection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nameCollection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameCollection_KeyPress);
			// 
			// deleteCollection
			// 
			this.deleteCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteCollection.BackgroundImage = global::FlashCardsApp.Properties.Resources.delete_icon;
			this.deleteCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.deleteCollection.Location = new System.Drawing.Point(542, 0);
			this.deleteCollection.Name = "deleteCollection";
			this.deleteCollection.Size = new System.Drawing.Size(40, 40);
			this.deleteCollection.TabIndex = 3;
			this.deleteCollection.UseVisualStyleBackColor = true;
			this.deleteCollection.Click += new System.EventHandler(this.deleteCollection_Click);
			// 
			// comeBackButton
			// 
			this.comeBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239)))));
			this.comeBackButton.BackgroundImage = global::FlashCardsApp.Properties.Resources.back_arrow_left_icon;
			this.comeBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.comeBackButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.comeBackButton.Location = new System.Drawing.Point(0, 0);
			this.comeBackButton.Name = "comeBackButton";
			this.comeBackButton.Size = new System.Drawing.Size(55, 40);
			this.comeBackButton.TabIndex = 2;
			this.comeBackButton.UseVisualStyleBackColor = false;
			this.comeBackButton.Click += new System.EventHandler(this.ComeBackButton_Click);
			// 
			// backgroundPanel
			// 
			this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
			this.backgroundPanel.Controls.Add(this.collectionPanel);
			this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
			this.backgroundPanel.Name = "backgroundPanel";
			this.backgroundPanel.Size = new System.Drawing.Size(582, 553);
			this.backgroundPanel.TabIndex = 1;
			// 
			// WindowCollectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 553);
			this.Controls.Add(this.backgroundPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WindowCollectionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WindowCollectionForm";
			this.collectionPanel.ResumeLayout(false);
			this.collectionPanel.PerformLayout();
			this.backgroundPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel collectionPanel;
		private System.Windows.Forms.Panel flashCardsPanel;
		private System.Windows.Forms.Button addFlashCard;
		private System.Windows.Forms.Button startLearning;
		private System.Windows.Forms.TextBox nameCollection;
		private System.Windows.Forms.Button deleteCollection;
		private System.Windows.Forms.Button comeBackButton;
		private System.Windows.Forms.Panel backgroundPanel;
	}
}
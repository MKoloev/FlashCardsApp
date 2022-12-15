
using System.Drawing;

namespace FlashCardsApp
{
	partial class MainWindowForm
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
			this.addCollectionButton = new System.Windows.Forms.Button();
			this.backgroundPanel = new System.Windows.Forms.Panel();
			this.backgroundPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// collectionPanel
			// 
			this.collectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.collectionPanel.AutoScroll = true;
			this.collectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(211)))), ((int)(((byte)(166)))));
			this.collectionPanel.Location = new System.Drawing.Point(0, 0);
			this.collectionPanel.Name = "collectionPanel";
			this.collectionPanel.Size = new System.Drawing.Size(487, 477);
			this.collectionPanel.TabIndex = 0;
			this.collectionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.collectionPanel_Paint);
			// 
			// addCollectionButton
			// 
			this.addCollectionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.addCollectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23)))));
			this.addCollectionButton.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addCollectionButton.ForeColor = System.Drawing.Color.White;
			this.addCollectionButton.Location = new System.Drawing.Point(12, 499);
			this.addCollectionButton.Name = "addCollectionButton";
			this.addCollectionButton.Size = new System.Drawing.Size(463, 92);
			this.addCollectionButton.TabIndex = 0;
			this.addCollectionButton.Text = "Добавить Коллекцию";
			this.addCollectionButton.UseVisualStyleBackColor = false;
			this.addCollectionButton.Click += new System.EventHandler(this.addCollectionButton_Click);
			// 
			// backgroundPanel
			// 
			this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(146)))), ((int)(((byte)(66)))));
			this.backgroundPanel.Controls.Add(this.addCollectionButton);
			this.backgroundPanel.Controls.Add(this.collectionPanel);
			this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
			this.backgroundPanel.Name = "backgroundPanel";
			this.backgroundPanel.Size = new System.Drawing.Size(487, 603);
			this.backgroundPanel.TabIndex = 0;
			// 
			// MainWindowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 603);
			this.Controls.Add(this.backgroundPanel);
			this.Name = "MainWindowForm";
			this.Text = "MainWindowForm";
			this.backgroundPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel collectionPanel;
		private System.Windows.Forms.Button addCollectionButton;
		private System.Windows.Forms.Panel backgroundPanel;
	}
}
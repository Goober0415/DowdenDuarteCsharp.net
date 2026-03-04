namespace P7DoUndoJDD
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lblHeader = new System.Windows.Forms.Label();
			this.lblItemName = new System.Windows.Forms.Label();
			this.txtItemInput = new System.Windows.Forms.TextBox();
			this.btnAddOne = new System.Windows.Forms.Button();
			this.btnAddMultiple = new System.Windows.Forms.Button();
			this.btnUndo = new System.Windows.Forms.Button();
			this.lstInventory = new System.Windows.Forms.ListBox();
			this.lblCountDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblHeader
			// 
			this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.lblHeader.Location = new System.Drawing.Point(12, 9);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(370, 35);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "Inventory Manager (Command Pattern)";
			// 
			// lblItemName
			// 
			this.lblItemName.Location = new System.Drawing.Point(12, 60);
			this.lblItemName.Name = "lblItemName";
			this.lblItemName.Size = new System.Drawing.Size(100, 23);
			this.lblItemName.TabIndex = 1;
			this.lblItemName.Text = "Item Name:";
			// 
			// txtItemInput
			// 
			this.txtItemInput.Location = new System.Drawing.Point(118, 57);
			this.txtItemInput.Name = "txtItemInput";
			this.txtItemInput.Size = new System.Drawing.Size(264, 31);
			this.txtItemInput.TabIndex = 2;
			// 
			// btnAddOne
			// 
			this.btnAddOne.Location = new System.Drawing.Point(12, 100);
			this.btnAddOne.Name = "btnAddOne";
			this.btnAddOne.Size = new System.Drawing.Size(120, 40);
			this.btnAddOne.TabIndex = 3;
			this.btnAddOne.Text = "Add One";
			this.btnAddOne.UseVisualStyleBackColor = true;
			// 
			// btnAddMultiple
			// 
			this.btnAddMultiple.Location = new System.Drawing.Point(138, 100);
			this.btnAddMultiple.Name = "btnAddMultiple";
			this.btnAddMultiple.Size = new System.Drawing.Size(120, 40);
			this.btnAddMultiple.TabIndex = 4;
			this.btnAddMultiple.Text = "Add Random";
			this.btnAddMultiple.UseVisualStyleBackColor = true;
			// 
			// btnUndo
			// 
			this.btnUndo.Location = new System.Drawing.Point(264, 100);
			this.btnUndo.Name = "btnUndo";
			this.btnUndo.Size = new System.Drawing.Size(118, 40);
			this.btnUndo.TabIndex = 5;
			this.btnUndo.Text = "Undo Last";
			this.btnUndo.UseVisualStyleBackColor = true;
			// 
			// lstInventory
			// 
			this.lstInventory.FormattingEnabled = true;
			this.lstInventory.ItemHeight = 25;
			this.lstInventory.Location = new System.Drawing.Point(12, 160);
			this.lstInventory.Name = "lstInventory";
			this.lstInventory.Size = new System.Drawing.Size(370, 304);
			this.lstInventory.TabIndex = 6;
			// 
			// lblCountDisplay
			// 
			this.lblCountDisplay.AutoSize = true;
			this.lblCountDisplay.Location = new System.Drawing.Point(12, 475);
			this.lblCountDisplay.Name = "lblCountDisplay";
			this.lblCountDisplay.Size = new System.Drawing.Size(131, 25);
			this.lblCountDisplay.TabIndex = 7;
			this.lblCountDisplay.Text = "Total Items: 0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 520);
			this.Controls.Add(this.lblCountDisplay);
			this.Controls.Add(this.lstInventory);
			this.Controls.Add(this.btnUndo);
			this.Controls.Add(this.btnAddMultiple);
			this.Controls.Add(this.btnAddOne);
			this.Controls.Add(this.txtItemInput);
			this.Controls.Add(this.lblItemName);
			this.Controls.Add(this.lblHeader);
			this.Name = "Form1";
			this.Text = "Inventory System";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Label lblItemName;
		private System.Windows.Forms.TextBox txtItemInput;
		private System.Windows.Forms.Button btnAddOne;
		private System.Windows.Forms.Button btnAddMultiple;
		private System.Windows.Forms.Button btnUndo;
		private System.Windows.Forms.ListBox lstInventory;
		private System.Windows.Forms.Label lblCountDisplay;
	}
}
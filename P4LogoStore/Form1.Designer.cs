namespace P4LogoStore
{
    partial class LogoOrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOrderNumber = new Label();
            lblNumberOfItems = new Label();
            lblItemType = new Label();
            lblText = new Label();
            lblNumberOfColors = new Label();
            textOrderNumber = new TextBox();
            textNumberOfItems = new TextBox();
            textItemType = new TextBox();
            textEngrave = new TextBox();
            textNumberColors = new TextBox();
            groupItems = new GroupBox();
            radioUSB = new RadioButton();
            radioMug = new RadioButton();
            radioPen = new RadioButton();
            checkLogo = new CheckBox();
            buttonSubmit = new Button();
            buttonClear = new Button();
            lblOrderSummary = new Label();
            textResult = new TextBox();
            groupItems.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(22, 9);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(123, 25);
            lblOrderNumber.TabIndex = 0;
            lblOrderNumber.Text = "OrderNumber";
            // 
            // lblNumberOfItems
            // 
            lblNumberOfItems.AutoSize = true;
            lblNumberOfItems.Location = new Point(22, 48);
            lblNumberOfItems.Name = "lblNumberOfItems";
            lblNumberOfItems.Size = new Size(148, 25);
            lblNumberOfItems.TabIndex = 1;
            lblNumberOfItems.Text = "Number of Items";
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = true;
            lblItemType.Location = new Point(22, 84);
            lblItemType.Name = "lblItemType";
            lblItemType.Size = new Size(90, 25);
            lblItemType.TabIndex = 2;
            lblItemType.Text = "Item Type";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(22, 122);
            lblText.Name = "lblText";
            lblText.Size = new Size(132, 25);
            lblText.TabIndex = 3;
            lblText.Text = "Text to Engrave";
            // 
            // lblNumberOfColors
            // 
            lblNumberOfColors.AutoSize = true;
            lblNumberOfColors.Location = new Point(22, 166);
            lblNumberOfColors.Name = "lblNumberOfColors";
            lblNumberOfColors.Size = new Size(152, 25);
            lblNumberOfColors.TabIndex = 4;
            lblNumberOfColors.Text = "Number of colors";
            // 
            // textOrderNumber
            // 
            textOrderNumber.Location = new Point(170, 9);
            textOrderNumber.Name = "textOrderNumber";
            textOrderNumber.Size = new Size(488, 31);
            textOrderNumber.TabIndex = 6;
            // 
            // textNumberOfItems
            // 
            textNumberOfItems.Location = new Point(170, 48);
            textNumberOfItems.Name = "textNumberOfItems";
            textNumberOfItems.Size = new Size(488, 31);
            textNumberOfItems.TabIndex = 7;
            // 
            // textItemType
            // 
            textItemType.Location = new Point(170, 85);
            textItemType.Name = "textItemType";
            textItemType.Size = new Size(488, 31);
            textItemType.TabIndex = 8;
            // 
            // textEngrave
            // 
            textEngrave.Location = new Point(170, 132);
            textEngrave.Name = "textEngrave";
            textEngrave.Size = new Size(488, 31);
            textEngrave.TabIndex = 9;
            // 
            // textNumberColors
            // 
            textNumberColors.Location = new Point(170, 169);
            textNumberColors.Name = "textNumberColors";
            textNumberColors.Size = new Size(488, 31);
            textNumberColors.TabIndex = 10;
            // 
            // groupItems
            // 
            groupItems.Controls.Add(radioUSB);
            groupItems.Controls.Add(radioMug);
            groupItems.Controls.Add(radioPen);
            groupItems.Location = new Point(12, 254);
            groupItems.Name = "groupItems";
            groupItems.Size = new Size(299, 184);
            groupItems.TabIndex = 12;
            groupItems.TabStop = false;
            groupItems.Text = "Items";
            // 
            // radioUSB
            // 
            radioUSB.AutoSize = true;
            radioUSB.Location = new Point(8, 121);
            radioUSB.Name = "radioUSB";
            radioUSB.Size = new Size(69, 29);
            radioUSB.TabIndex = 13;
            radioUSB.TabStop = true;
            radioUSB.Text = "USB";
            radioUSB.UseVisualStyleBackColor = true;
            // 
            // radioMug
            // 
            radioMug.AutoSize = true;
            radioMug.Location = new Point(8, 74);
            radioMug.Name = "radioMug";
            radioMug.Size = new Size(74, 29);
            radioMug.TabIndex = 13;
            radioMug.TabStop = true;
            radioMug.Text = "Mug";
            radioMug.UseVisualStyleBackColor = true;
            // 
            // radioPen
            // 
            radioPen.AutoSize = true;
            radioPen.Location = new Point(10, 30);
            radioPen.Name = "radioPen";
            radioPen.Size = new Size(65, 29);
            radioPen.TabIndex = 13;
            radioPen.TabStop = true;
            radioPen.Text = "Pen";
            radioPen.UseVisualStyleBackColor = true;
            // 
            // checkLogo
            // 
            checkLogo.AutoSize = true;
            checkLogo.Location = new Point(339, 271);
            checkLogo.Name = "checkLogo";
            checkLogo.Size = new Size(329, 29);
            checkLogo.TabIndex = 13;
            checkLogo.Text = "Has Logo(+.10/item, +.03color/item)";
            checkLogo.UseVisualStyleBackColor = true;
            checkLogo.CheckedChanged += checkLogo_CheckedChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(556, 404);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(112, 34);
            buttonSubmit.TabIndex = 14;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(373, 404);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 34);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Location = new Point(12, 450);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(139, 25);
            lblOrderSummary.TabIndex = 16;
            lblOrderSummary.Text = "Order Summary";
            // 
            // textResult
            // 
            textResult.Location = new Point(22, 478);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.ScrollBars = ScrollBars.Vertical;
            textResult.Size = new Size(741, 119);
            textResult.TabIndex = 17;
            // 
            // LogoOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 651);
            Controls.Add(textResult);
            Controls.Add(lblOrderSummary);
            Controls.Add(buttonClear);
            Controls.Add(buttonSubmit);
            Controls.Add(checkLogo);
            Controls.Add(groupItems);
            Controls.Add(textNumberColors);
            Controls.Add(textEngrave);
            Controls.Add(textItemType);
            Controls.Add(textNumberOfItems);
            Controls.Add(textOrderNumber);
            Controls.Add(lblNumberOfColors);
            Controls.Add(lblText);
            Controls.Add(lblItemType);
            Controls.Add(lblNumberOfItems);
            Controls.Add(lblOrderNumber);
            Name = "LogoOrderForm";
            Text = "Logo Order Form";
            groupItems.ResumeLayout(false);
            groupItems.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderNumber;
        private Label lblNumberOfItems;
        private Label lblItemType;
        private Label lblText;
        private Label lblNumberOfColors;
        private TextBox textOrderNumber;
        private TextBox textNumberOfItems;
        private TextBox textItemType;
        private TextBox textEngrave;
        private TextBox textNumberColors;
        private GroupBox groupItems;
        private RadioButton radioUSB;
        private RadioButton radioMug;
        private RadioButton radioPen;
        private CheckBox checkLogo;
        private Button buttonSubmit;
        private Button buttonClear;
        private Label lblOrderSummary;
        private TextBox textResult;
    }
}

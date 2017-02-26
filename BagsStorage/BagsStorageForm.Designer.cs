namespace BagsStorage
{
    partial class BagsStorageForm
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
            this.listViewBags = new System.Windows.Forms.ListView();
            this.columnBags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewBagDetails = new System.Windows.Forms.ListView();
            this.columnBagDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddBag = new System.Windows.Forms.Button();
            this.textBoxNewBagName = new System.Windows.Forms.TextBox();
            this.buttonRemoveBag = new System.Windows.Forms.Button();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.comboBoxBagItemType = new System.Windows.Forms.ComboBox();
            this.comboBoxSizesTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxSizeTo = new System.Windows.Forms.ComboBox();
            this.comboBoxSizeFrom = new System.Windows.Forms.ComboBox();
            this.buttonAddBagItem = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.groupBoxBottom = new System.Windows.Forms.GroupBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBags
            // 
            this.listViewBags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBags});
            this.listViewBags.Location = new System.Drawing.Point(4, 4);
            this.listViewBags.Name = "listViewBags";
            this.listViewBags.Size = new System.Drawing.Size(195, 319);
            this.listViewBags.TabIndex = 0;
            this.listViewBags.UseCompatibleStateImageBehavior = false;
            this.listViewBags.View = System.Windows.Forms.View.Details;
            this.listViewBags.SelectedIndexChanged += new System.EventHandler(this.listViewBags_SelectedIndexChanged);
            // 
            // columnBags
            // 
            this.columnBags.Text = "Перелік мішків:";
            this.columnBags.Width = 162;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMessage});
            this.statusStrip.Location = new System.Drawing.Point(0, 326);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(679, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusMessage
            // 
            this.toolStripStatusMessage.Name = "toolStripStatusMessage";
            this.toolStripStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // listViewBagDetails
            // 
            this.listViewBagDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBagDetails});
            this.listViewBagDetails.Location = new System.Drawing.Point(203, 4);
            this.listViewBagDetails.Name = "listViewBagDetails";
            this.listViewBagDetails.Size = new System.Drawing.Size(282, 319);
            this.listViewBagDetails.TabIndex = 2;
            this.listViewBagDetails.UseCompatibleStateImageBehavior = false;
            this.listViewBagDetails.View = System.Windows.Forms.View.Details;
            this.listViewBagDetails.SelectedIndexChanged += new System.EventHandler(this.listViewBagDetails_SelectedIndexChanged);
            // 
            // columnBagDetails
            // 
            this.columnBagDetails.Text = "Вміст мішка:";
            this.columnBagDetails.Width = 256;
            // 
            // buttonAddBag
            // 
            this.buttonAddBag.Location = new System.Drawing.Point(6, 45);
            this.buttonAddBag.Name = "buttonAddBag";
            this.buttonAddBag.Size = new System.Drawing.Size(170, 23);
            this.buttonAddBag.TabIndex = 3;
            this.buttonAddBag.Text = "Додати мішок";
            this.buttonAddBag.UseVisualStyleBackColor = true;
            this.buttonAddBag.Click += new System.EventHandler(this.buttonAddBag_Click);
            // 
            // textBoxNewBagName
            // 
            this.textBoxNewBagName.Location = new System.Drawing.Point(6, 19);
            this.textBoxNewBagName.Name = "textBoxNewBagName";
            this.textBoxNewBagName.Size = new System.Drawing.Size(170, 20);
            this.textBoxNewBagName.TabIndex = 4;
            this.textBoxNewBagName.Text = "назва мішка...";
            // 
            // buttonRemoveBag
            // 
            this.buttonRemoveBag.Location = new System.Drawing.Point(6, 74);
            this.buttonRemoveBag.Name = "buttonRemoveBag";
            this.buttonRemoveBag.Size = new System.Drawing.Size(170, 23);
            this.buttonRemoveBag.TabIndex = 5;
            this.buttonRemoveBag.Text = "Видалити мішок";
            this.buttonRemoveBag.UseVisualStyleBackColor = true;
            this.buttonRemoveBag.Click += new System.EventHandler(this.buttonRemoveBag_Click);
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.buttonRemoveBag);
            this.groupBoxTop.Controls.Add(this.buttonAddBag);
            this.groupBoxTop.Controls.Add(this.textBoxNewBagName);
            this.groupBoxTop.Location = new System.Drawing.Point(491, 4);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(184, 108);
            this.groupBoxTop.TabIndex = 10;
            this.groupBoxTop.TabStop = false;
            this.groupBoxTop.Text = "Мішки :";
            // 
            // comboBoxBagItemType
            // 
            this.comboBoxBagItemType.FormattingEnabled = true;
            this.comboBoxBagItemType.Location = new System.Drawing.Point(6, 19);
            this.comboBoxBagItemType.Name = "comboBoxBagItemType";
            this.comboBoxBagItemType.Size = new System.Drawing.Size(168, 21);
            this.comboBoxBagItemType.TabIndex = 6;
            this.comboBoxBagItemType.Text = "-Тип-";
            // 
            // comboBoxSizesTypes
            // 
            this.comboBoxSizesTypes.FormattingEnabled = true;
            this.comboBoxSizesTypes.Location = new System.Drawing.Point(6, 46);
            this.comboBoxSizesTypes.Name = "comboBoxSizesTypes";
            this.comboBoxSizesTypes.Size = new System.Drawing.Size(62, 21);
            this.comboBoxSizesTypes.TabIndex = 13;
            this.comboBoxSizesTypes.Text = "-Тип-";
            this.comboBoxSizesTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxSizeTo
            // 
            this.comboBoxSizeTo.FormattingEnabled = true;
            this.comboBoxSizeTo.Location = new System.Drawing.Point(128, 46);
            this.comboBoxSizeTo.Name = "comboBoxSizeTo";
            this.comboBoxSizeTo.Size = new System.Drawing.Size(48, 21);
            this.comboBoxSizeTo.TabIndex = 12;
            // 
            // comboBoxSizeFrom
            // 
            this.comboBoxSizeFrom.FormattingEnabled = true;
            this.comboBoxSizeFrom.Location = new System.Drawing.Point(74, 46);
            this.comboBoxSizeFrom.Name = "comboBoxSizeFrom";
            this.comboBoxSizeFrom.Size = new System.Drawing.Size(48, 21);
            this.comboBoxSizeFrom.TabIndex = 13;
            // 
            // buttonAddBagItem
            // 
            this.buttonAddBagItem.Location = new System.Drawing.Point(8, 117);
            this.buttonAddBagItem.Name = "buttonAddBagItem";
            this.buttonAddBagItem.Size = new System.Drawing.Size(170, 23);
            this.buttonAddBagItem.TabIndex = 14;
            this.buttonAddBagItem.Text = "Додати мотлох";
            this.buttonAddBagItem.UseVisualStyleBackColor = true;
            this.buttonAddBagItem.Click += new System.EventHandler(this.buttonAddBagItem_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(6, 147);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(170, 23);
            this.buttonRemoveItem.TabIndex = 15;
            this.buttonRemoveItem.Text = "Видалити мотлох";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Location = new System.Drawing.Point(6, 176);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(170, 23);
            this.buttonUpdateItem.TabIndex = 16;
            this.buttonUpdateItem.Text = "Змінити мотлох";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // groupBoxBottom
            // 
            this.groupBoxBottom.Controls.Add(this.comboBoxSizeTo);
            this.groupBoxBottom.Controls.Add(this.textBoxDetails);
            this.groupBoxBottom.Controls.Add(this.comboBoxBagItemType);
            this.groupBoxBottom.Controls.Add(this.buttonRemoveItem);
            this.groupBoxBottom.Controls.Add(this.buttonUpdateItem);
            this.groupBoxBottom.Controls.Add(this.comboBoxSizesTypes);
            this.groupBoxBottom.Controls.Add(this.buttonAddBagItem);
            this.groupBoxBottom.Controls.Add(this.comboBoxSizeFrom);
            this.groupBoxBottom.Location = new System.Drawing.Point(491, 118);
            this.groupBoxBottom.Name = "groupBoxBottom";
            this.groupBoxBottom.Size = new System.Drawing.Size(184, 205);
            this.groupBoxBottom.TabIndex = 18;
            this.groupBoxBottom.TabStop = false;
            this.groupBoxBottom.Text = "Мотлох :";
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(6, 73);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(168, 38);
            this.textBoxDetails.TabIndex = 17;
            this.textBoxDetails.Text = "- Деталі -";
            // 
            // BagsStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 348);
            this.Controls.Add(this.listViewBagDetails);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listViewBags);
            this.Controls.Add(this.groupBoxTop);
            this.Controls.Add(this.groupBoxBottom);
            this.Name = "BagsStorageForm";
            this.ShowIcon = false;
            this.Text = "Сховище мішків";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.groupBoxBottom.ResumeLayout(false);
            this.groupBoxBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBags;
        private System.Windows.Forms.ColumnHeader columnBags;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
        private System.Windows.Forms.ListView listViewBagDetails;
        private System.Windows.Forms.ColumnHeader columnBagDetails;
        private System.Windows.Forms.Button buttonAddBag;
        private System.Windows.Forms.TextBox textBoxNewBagName;
        private System.Windows.Forms.Button buttonRemoveBag;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.ComboBox comboBoxBagItemType;
        private System.Windows.Forms.ComboBox comboBoxSizesTypes;
        private System.Windows.Forms.ComboBox comboBoxSizeTo;
        private System.Windows.Forms.ComboBox comboBoxSizeFrom;
        private System.Windows.Forms.Button buttonAddBagItem;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.GroupBox groupBoxBottom;
        private System.Windows.Forms.TextBox textBoxDetails;
    }
}


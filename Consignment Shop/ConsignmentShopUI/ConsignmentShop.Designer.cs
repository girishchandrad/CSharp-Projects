﻿namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBoxLabel = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabels = new System.Windows.Forms.Label();
            this.purchaseItem = new System.Windows.Forms.Button();
            this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.ShoppingListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(56, 33);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(405, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.FormattingEnabled = true;
            this.itemsListBoxLabel.ItemHeight = 20;
            this.itemsListBoxLabel.Location = new System.Drawing.Point(63, 140);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(295, 244);
            this.itemsListBoxLabel.TabIndex = 1;
            // 
            // itemsListBoxLabels
            // 
            this.itemsListBoxLabels.AutoSize = true;
            this.itemsListBoxLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabels.Location = new System.Drawing.Point(59, 105);
            this.itemsListBoxLabels.Name = "itemsListBoxLabels";
            this.itemsListBoxLabels.Size = new System.Drawing.Size(103, 20);
            this.itemsListBoxLabels.TabIndex = 2;
            this.itemsListBoxLabels.Text = "Store Items";
            // 
            // purchaseItem
            // 
            this.purchaseItem.Location = new System.Drawing.Point(404, 231);
            this.purchaseItem.Name = "purchaseItem";
            this.purchaseItem.Size = new System.Drawing.Size(146, 60);
            this.purchaseItem.TabIndex = 3;
            this.purchaseItem.Text = "Add To Cart -->";
            this.purchaseItem.UseVisualStyleBackColor = true;
            this.purchaseItem.Click += new System.EventHandler(this.PurchaseItem_Click);
            // 
            // shoppingCartListBoxLabel
            // 
            this.shoppingCartListBoxLabel.AutoSize = true;
            this.shoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(591, 105);
            this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
            this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.shoppingCartListBoxLabel.TabIndex = 5;
            this.shoppingCartListBoxLabel.Text = "Store Items";
            // 
            // ShoppingListBox
            // 
            this.ShoppingListBox.FormattingEnabled = true;
            this.ShoppingListBox.ItemHeight = 20;
            this.ShoppingListBox.Location = new System.Drawing.Point(595, 140);
            this.ShoppingListBox.Name = "ShoppingListBox";
            this.ShoppingListBox.Size = new System.Drawing.Size(295, 244);
            this.ShoppingListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(744, 406);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(146, 60);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.MakePurchase_Click);
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListboxLabel.Location = new System.Drawing.Point(70, 401);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(76, 20);
            this.vendorListboxLabel.TabIndex = 8;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 20;
            this.vendorListBox.Location = new System.Drawing.Point(74, 436);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(295, 244);
            this.vendorListBox.TabIndex = 7;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(591, 526);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(111, 20);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit :";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(726, 526);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(59, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$ 0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListBoxLabel);
            this.Controls.Add(this.ShoppingListBox);
            this.Controls.Add(this.purchaseItem);
            this.Controls.Add(this.itemsListBoxLabels);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBoxLabel;
        private System.Windows.Forms.Label itemsListBoxLabels;
        private System.Windows.Forms.Button purchaseItem;
        private System.Windows.Forms.Label shoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox ShoppingListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}


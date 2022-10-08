namespace LunchOrder
{
    partial class frmLunchOrder
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.radioSalad = new System.Windows.Forms.RadioButton();
            this.radioPizza = new System.Windows.Forms.RadioButton();
            this.radioHamburger = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxAddOnItems = new System.Windows.Forms.GroupBox();
            this.checkBoxAddOnThree = new System.Windows.Forms.CheckBox();
            this.checkBoxAddOnTwo = new System.Windows.Forms.CheckBox();
            this.checkBoxAddOnOne = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.gbxMainCourse.SuspendLayout();
            this.gbxAddOnItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaceOrder.Location = new System.Drawing.Point(353, 175);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(117, 28);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrderTotal);
            this.GroupBox1.Controls.Add(this.lblSalesTax);
            this.GroupBox1.Controls.Add(this.lblSubtotal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(23, 165);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(299, 128);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(139, 89);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(117, 25);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(139, 59);
            this.lblSalesTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(117, 25);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(139, 30);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(117, 25);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(21, 89);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Order total:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(21, 59);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax (13%):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(21, 30);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.radioSalad);
            this.gbxMainCourse.Controls.Add(this.radioPizza);
            this.gbxMainCourse.Controls.Add(this.radioHamburger);
            this.gbxMainCourse.Location = new System.Drawing.Point(23, 17);
            this.gbxMainCourse.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMainCourse.Size = new System.Drawing.Size(192, 128);
            this.gbxMainCourse.TabIndex = 19;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // radioSalad
            // 
            this.radioSalad.AutoSize = true;
            this.radioSalad.Location = new System.Drawing.Point(24, 88);
            this.radioSalad.Name = "radioSalad";
            this.radioSalad.Size = new System.Drawing.Size(105, 20);
            this.radioSalad.TabIndex = 2;
            this.radioSalad.TabStop = true;
            this.radioSalad.Text = "Salad - $4.95";
            this.radioSalad.UseVisualStyleBackColor = true;
            this.radioSalad.CheckedChanged += new System.EventHandler(this.radioSalad_CheckedChanged);
            // 
            // radioPizza
            // 
            this.radioPizza.AutoSize = true;
            this.radioPizza.Location = new System.Drawing.Point(24, 61);
            this.radioPizza.Name = "radioPizza";
            this.radioPizza.Size = new System.Drawing.Size(101, 20);
            this.radioPizza.TabIndex = 1;
            this.radioPizza.TabStop = true;
            this.radioPizza.Text = "Pizza - $5.95";
            this.radioPizza.UseVisualStyleBackColor = true;
            this.radioPizza.CheckedChanged += new System.EventHandler(this.radioPizza_CheckedChanged);
            // 
            // radioHamburger
            // 
            this.radioHamburger.AutoSize = true;
            this.radioHamburger.Location = new System.Drawing.Point(24, 34);
            this.radioHamburger.Name = "radioHamburger";
            this.radioHamburger.Size = new System.Drawing.Size(137, 20);
            this.radioHamburger.TabIndex = 0;
            this.radioHamburger.TabStop = true;
            this.radioHamburger.Text = "Hamburger - $6.95";
            this.radioHamburger.UseVisualStyleBackColor = true;
            this.radioHamburger.CheckedChanged += new System.EventHandler(this.radioHamburger_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(353, 263);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxAddOnItems
            // 
            this.gbxAddOnItems.Controls.Add(this.checkBoxAddOnThree);
            this.gbxAddOnItems.Controls.Add(this.checkBoxAddOnTwo);
            this.gbxAddOnItems.Controls.Add(this.checkBoxAddOnOne);
            this.gbxAddOnItems.Location = new System.Drawing.Point(222, 17);
            this.gbxAddOnItems.Name = "gbxAddOnItems";
            this.gbxAddOnItems.Size = new System.Drawing.Size(248, 128);
            this.gbxAddOnItems.TabIndex = 22;
            this.gbxAddOnItems.TabStop = false;
            this.gbxAddOnItems.Text = "Add-on items($.75/each)";
          //  this.gbxAddOnItems.Enter += new System.EventHandler(this.gbxAddOnItems_Enter);
            // 
            // checkBoxAddOnThree
            // 
            this.checkBoxAddOnThree.AutoSize = true;
            this.checkBoxAddOnThree.Location = new System.Drawing.Point(6, 89);
            this.checkBoxAddOnThree.Name = "checkBoxAddOnThree";
            this.checkBoxAddOnThree.Size = new System.Drawing.Size(98, 20);
            this.checkBoxAddOnThree.TabIndex = 2;
            this.checkBoxAddOnThree.Text = "French fries";
            this.checkBoxAddOnThree.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddOnTwo
            // 
            this.checkBoxAddOnTwo.AutoSize = true;
            this.checkBoxAddOnTwo.Location = new System.Drawing.Point(6, 61);
            this.checkBoxAddOnTwo.Name = "checkBoxAddOnTwo";
            this.checkBoxAddOnTwo.Size = new System.Drawing.Size(197, 20);
            this.checkBoxAddOnTwo.TabIndex = 1;
            this.checkBoxAddOnTwo.Text = "Ketchup, mustard, and mayo";
            this.checkBoxAddOnTwo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddOnOne
            // 
            this.checkBoxAddOnOne.AutoSize = true;
            this.checkBoxAddOnOne.Location = new System.Drawing.Point(6, 34);
            this.checkBoxAddOnOne.Name = "checkBoxAddOnOne";
            this.checkBoxAddOnOne.Size = new System.Drawing.Size(198, 20);
            this.checkBoxAddOnOne.TabIndex = 0;
            this.checkBoxAddOnOne.Text = "Lettuce, tomato, and oninons";
            this.checkBoxAddOnOne.UseVisualStyleBackColor = true;
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(524, 347);
            this.Controls.Add(this.gbxAddOnItems);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLunchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSD-2354 Lunch Order";
            this.GroupBox1.ResumeLayout(false);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gbxAddOnItems.ResumeLayout(false);
            this.gbxAddOnItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.Label lblSalesTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox gbxMainCourse;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioSalad;
        private System.Windows.Forms.RadioButton radioPizza;
        private System.Windows.Forms.RadioButton radioHamburger;
        private System.Windows.Forms.GroupBox gbxAddOnItems;
        private System.Windows.Forms.CheckBox checkBoxAddOnThree;
        private System.Windows.Forms.CheckBox checkBoxAddOnTwo;
        private System.Windows.Forms.CheckBox checkBoxAddOnOne;
    }
}


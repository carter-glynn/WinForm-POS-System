namespace Cglynn_Assignment4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.delivery = new System.Windows.Forms.RadioButton();
            this.pickup = new System.Windows.Forms.RadioButton();
            this.cxName = new System.Windows.Forms.TextBox();
            this.cxNumber = new System.Windows.Forms.TextBox();
            this.prod1 = new System.Windows.Forms.TextBox();
            this.prod2 = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.receipt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.receiptGen = new System.Windows.Forms.Button();
            this.clrForm = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelProd1 = new System.Windows.Forms.Label();
            this.labelProd2 = new System.Windows.Forms.Label();
            this.cxLabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.tipName = new System.Windows.Forms.TextBox();
            this.tipPhone = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.postalCode = new System.Windows.Forms.TextBox();
            this.codeTip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Location = new System.Drawing.Point(241, 330);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(67, 19);
            this.delivery.TabIndex = 10;
            this.delivery.Text = "Delivery";
            this.delivery.UseVisualStyleBackColor = true;
            this.delivery.CheckedChanged += new System.EventHandler(this.delivery_CheckedChanged);
            // 
            // pickup
            // 
            this.pickup.AutoSize = true;
            this.pickup.Checked = true;
            this.pickup.Location = new System.Drawing.Point(374, 330);
            this.pickup.Name = "pickup";
            this.pickup.Size = new System.Drawing.Size(67, 19);
            this.pickup.TabIndex = 11;
            this.pickup.TabStop = true;
            this.pickup.Text = "Pick-Up";
            this.pickup.UseVisualStyleBackColor = true;
            this.pickup.CheckedChanged += new System.EventHandler(this.pickup_CheckedChanged);
            // 
            // cxName
            // 
            this.cxName.Location = new System.Drawing.Point(123, 86);
            this.cxName.Name = "cxName";
            this.cxName.PlaceholderText = "ex. John Smith";
            this.cxName.Size = new System.Drawing.Size(100, 23);
            this.cxName.TabIndex = 2;
            //this.cxName.TextChanged += new System.EventHandler(this.cxName_TextChanged);
            this.cxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cxName_KeyPress);
            // 
            // cxNumber
            // 
            this.cxNumber.Location = new System.Drawing.Point(123, 140);
            this.cxNumber.MaxLength = 10;
            this.cxNumber.Name = "cxNumber";
            this.cxNumber.PlaceholderText = "ex. 5193712345";
            this.cxNumber.Size = new System.Drawing.Size(100, 23);
            this.cxNumber.TabIndex = 4;
            //this.cxNumber.TextChanged += new System.EventHandler(this.cxNumber_TextChanged);
            this.cxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cxNumber_KeyPress);
            // 
            // prod1
            // 
            this.prod1.Location = new System.Drawing.Point(123, 238);
            this.prod1.Name = "prod1";
            this.prod1.PlaceholderText = "ex. 10";
            this.prod1.Size = new System.Drawing.Size(100, 23);
            this.prod1.TabIndex = 7;
            //this.prod1.TextChanged += new System.EventHandler(this.prod1_TextChanged);
            this.prod1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prod1_KeyPress);
            // 
            // prod2
            // 
            this.prod2.Location = new System.Drawing.Point(123, 293);
            this.prod2.Name = "prod2";
            this.prod2.PlaceholderText = "ex. 10";
            this.prod2.Size = new System.Drawing.Size(100, 23);
            this.prod2.TabIndex = 9;
            //this.prod2.TextChanged += new System.EventHandler(this.prod2_TextChanged);
            this.prod2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prod2_KeyPress);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(292, 355);
            this.address.Name = "address";
            this.address.PlaceholderText = "ex. 123 Pleasant Lane";
            this.address.Size = new System.Drawing.Size(100, 23);
            this.address.TabIndex = 12;
            this.address.Visible = false;
            //this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // receipt
            // 
            this.receipt.Location = new System.Drawing.Point(467, 64);
            this.receipt.Multiline = true;
            this.receipt.Name = "receipt";
            this.receipt.ReadOnly = true;
            this.receipt.Size = new System.Drawing.Size(294, 328);
            this.receipt.TabIndex = 15;
            this.receipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.receipt.Visible = false;
            //this.receipt.TextChanged += new System.EventHandler(this.receipt_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 13;
            //this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // receiptGen
            // 
            this.receiptGen.Location = new System.Drawing.Point(559, 25);
            this.receiptGen.Name = "receiptGen";
            this.receiptGen.Size = new System.Drawing.Size(113, 33);
            this.receiptGen.TabIndex = 14;
            this.receiptGen.Text = "Generate Receipt";
            this.receiptGen.UseVisualStyleBackColor = true;
            this.receiptGen.Click += new System.EventHandler(this.receiptGen_Click);
            // 
            // clrForm
            // 
            this.clrForm.Location = new System.Drawing.Point(123, 354);
            this.clrForm.Name = "clrForm";
            this.clrForm.Size = new System.Drawing.Size(75, 23);
            this.clrForm.TabIndex = 16;
            this.clrForm.Text = "Clear Form";
            this.clrForm.UseVisualStyleBackColor = true;
            this.clrForm.Click += new System.EventHandler(this.clrForm_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(99, 68);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Full Name";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(99, 122);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(88, 15);
            this.labelNumber.TabIndex = 3;
            this.labelNumber.Text = "Phone Number";
            // 
            // labelProd1
            // 
            this.labelProd1.AutoSize = true;
            this.labelProd1.Location = new System.Drawing.Point(99, 220);
            this.labelProd1.Name = "labelProd1";
            this.labelProd1.Size = new System.Drawing.Size(119, 15);
            this.labelProd1.TabIndex = 6;
            this.labelProd1.Text = "Amount of Product 1";
            // 
            // labelProd2
            // 
            this.labelProd2.AutoSize = true;
            this.labelProd2.Location = new System.Drawing.Point(99, 275);
            this.labelProd2.Name = "labelProd2";
            this.labelProd2.Size = new System.Drawing.Size(119, 15);
            this.labelProd2.TabIndex = 8;
            this.labelProd2.Text = "Amount of Product 2";
            // 
            // cxLabel
            // 
            this.cxLabel.AutoSize = true;
            this.cxLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cxLabel.Location = new System.Drawing.Point(62, 34);
            this.cxLabel.Name = "cxLabel";
            this.cxLabel.Size = new System.Drawing.Size(170, 20);
            this.cxLabel.TabIndex = 0;
            this.cxLabel.Text = "Customer Information:";
            //this.cxLabel.Click += new System.EventHandler(this.cxLabel_Click);
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prodLabel.Location = new System.Drawing.Point(62, 189);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(157, 20);
            this.prodLabel.TabIndex = 5;
            this.prodLabel.Text = "Product Information:";
            //this.prodLabel.Click += new System.EventHandler(this.prodLabel_Click);
            // 
            // tipName
            // 
            this.tipName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tipName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipName.Cursor = System.Windows.Forms.Cursors.Help;
            this.tipName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipName.Location = new System.Drawing.Point(229, 89);
            this.tipName.Name = "tipName";
            this.tipName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipName.Size = new System.Drawing.Size(16, 16);
            this.tipName.TabIndex = 17;
            this.tipName.Text = "i";
            this.tipName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // tipPhone
            // 
            this.tipPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tipPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipPhone.Cursor = System.Windows.Forms.Cursors.Help;
            this.tipPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tipPhone.Location = new System.Drawing.Point(229, 143);
            this.tipPhone.Name = "tipPhone";
            this.tipPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tipPhone.Size = new System.Drawing.Size(16, 16);
            this.tipPhone.TabIndex = 18;
            this.tipPhone.Text = "i";
            this.tipPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipPhone.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseMove);
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(292, 384);
            this.postalCode.MaxLength = 6;
            this.postalCode.Name = "postalCode";
            this.postalCode.PlaceholderText = "Postal Code";
            this.postalCode.Size = new System.Drawing.Size(100, 23);
            this.postalCode.TabIndex = 19;
            this.postalCode.Visible = false;
            this.postalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.postalCode_KeyPress);
            // 
            // codeTip
            // 
            this.codeTip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.codeTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeTip.Cursor = System.Windows.Forms.Cursors.Help;
            this.codeTip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeTip.Location = new System.Drawing.Point(398, 387);
            this.codeTip.Name = "codeTip";
            this.codeTip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.codeTip.Size = new System.Drawing.Size(16, 16);
            this.codeTip.TabIndex = 20;
            this.codeTip.Text = "i";
            this.codeTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeTip.Visible = false;
            this.codeTip.TextChanged += new System.EventHandler(this.codeTip_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codeTip);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.tipPhone);
            this.Controls.Add(this.tipName);
            this.Controls.Add(this.prodLabel);
            this.Controls.Add(this.cxLabel);
            this.Controls.Add(this.labelProd2);
            this.Controls.Add(this.labelProd1);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.clrForm);
            this.Controls.Add(this.receiptGen);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.address);
            this.Controls.Add(this.prod2);
            this.Controls.Add(this.prod1);
            this.Controls.Add(this.cxNumber);
            this.Controls.Add(this.cxName);
            this.Controls.Add(this.pickup);
            this.Controls.Add(this.delivery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton delivery;
        private RadioButton pickup;
        private TextBox cxName;
        private TextBox cxNumber;
        private TextBox prod1;
        private TextBox prod2;
        private TextBox address;
        private TextBox receipt;
        private DateTimePicker dateTimePicker1;
        private Button receiptGen;
        private Button clrForm;
        private Label labelName;
        private Label labelNumber;
        private Label labelProd1;
        private Label labelProd2;
        private Label cxLabel;
        private Label prodLabel;
        private TextBox tipName;
        private TextBox tipPhone;
        private ToolTip toolTip1;
        private TextBox postalCode;
        private TextBox codeTip;
    }
}
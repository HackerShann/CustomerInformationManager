namespace Person_CustomerClasses
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.txtBox_Phone = new System.Windows.Forms.TextBox();
            this.txtBox_Customer = new System.Windows.Forms.TextBox();
            this.OnMailingList = new System.Windows.Forms.CheckBox();
            this.btn_Display = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Number";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(418, 52);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(300, 31);
            this.txtBox_Name.TabIndex = 4;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Location = new System.Drawing.Point(418, 114);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(300, 31);
            this.txtBox_Address.TabIndex = 5;
            // 
            // txtBox_Phone
            // 
            this.txtBox_Phone.Location = new System.Drawing.Point(418, 186);
            this.txtBox_Phone.Name = "txtBox_Phone";
            this.txtBox_Phone.Size = new System.Drawing.Size(300, 31);
            this.txtBox_Phone.TabIndex = 6;
            // 
            // txtBox_Customer
            // 
            this.txtBox_Customer.Location = new System.Drawing.Point(418, 246);
            this.txtBox_Customer.Name = "txtBox_Customer";
            this.txtBox_Customer.Size = new System.Drawing.Size(300, 31);
            this.txtBox_Customer.TabIndex = 7;
            // 
            // OnMailingList
            // 
            this.OnMailingList.AutoSize = true;
            this.OnMailingList.Location = new System.Drawing.Point(82, 331);
            this.OnMailingList.Name = "OnMailingList";
            this.OnMailingList.Size = new System.Drawing.Size(165, 29);
            this.OnMailingList.TabIndex = 8;
            this.OnMailingList.Text = "Mailing List?";
            this.OnMailingList.UseVisualStyleBackColor = true;
            this.OnMailingList.CheckedChanged += new System.EventHandler(this.OnMailingList_CheckedChanged);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(77, 411);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(190, 82);
            this.btn_Display.TabIndex = 9;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_output.Location = new System.Drawing.Point(77, 546);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(638, 229);
            this.lbl_output.TabIndex = 10;
            this.lbl_output.Click += new System.EventHandler(this.lbl_output_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(316, 411);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(184, 82);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(531, 411);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(184, 82);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 861);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.OnMailingList);
            this.Controls.Add(this.txtBox_Customer);
            this.Controls.Add(this.txtBox_Phone);
            this.Controls.Add(this.txtBox_Address);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.TextBox txtBox_Phone;
        private System.Windows.Forms.TextBox txtBox_Customer;
        private System.Windows.Forms.CheckBox OnMailingList;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}


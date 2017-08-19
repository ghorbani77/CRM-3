﻿namespace CRM
{
    partial class FrmCustomerAddModify
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
            this.tb_main = new System.Windows.Forms.TabControl();
            this.tp_main = new System.Windows.Forms.TabPage();
            this.dt_dob = new System.Windows.Forms.DateTimePicker();
            this.lb_dob = new System.Windows.Forms.Label();
            this.gb_address = new System.Windows.Forms.GroupBox();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.lb_no = new System.Windows.Forms.Label();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.lb_city = new System.Windows.Forms.Label();
            this.tb_street = new System.Windows.Forms.TextBox();
            this.lb_street = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.lb_code = new System.Windows.Forms.Label();
            this.cb_state = new System.Windows.Forms.ComboBox();
            this.lb_state = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.lb_surname = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tp_aditional = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_main.SuspendLayout();
            this.tp_main.SuspendLayout();
            this.gb_address.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Controls.Add(this.tp_main);
            this.tb_main.Controls.Add(this.tp_aditional);
            this.tb_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_main.Location = new System.Drawing.Point(0, 0);
            this.tb_main.Margin = new System.Windows.Forms.Padding(4);
            this.tb_main.Name = "tb_main";
            this.tb_main.SelectedIndex = 0;
            this.tb_main.Size = new System.Drawing.Size(1045, 734);
            this.tb_main.TabIndex = 0;
            // 
            // tp_main
            // 
            this.tp_main.Controls.Add(this.dt_dob);
            this.tp_main.Controls.Add(this.lb_dob);
            this.tp_main.Controls.Add(this.gb_address);
            this.tp_main.Controls.Add(this.tb_surname);
            this.tp_main.Controls.Add(this.lb_surname);
            this.tp_main.Controls.Add(this.tb_name);
            this.tp_main.Controls.Add(this.lb_name);
            this.tp_main.Location = new System.Drawing.Point(4, 26);
            this.tp_main.Margin = new System.Windows.Forms.Padding(4);
            this.tp_main.Name = "tp_main";
            this.tp_main.Padding = new System.Windows.Forms.Padding(4);
            this.tp_main.Size = new System.Drawing.Size(1037, 704);
            this.tp_main.TabIndex = 0;
            this.tp_main.Text = "main";
            this.tp_main.UseVisualStyleBackColor = true;
            // 
            // dt_dob
            // 
            this.dt_dob.Location = new System.Drawing.Point(76, 107);
            this.dt_dob.Name = "dt_dob";
            this.dt_dob.Size = new System.Drawing.Size(216, 24);
            this.dt_dob.TabIndex = 3;
            // 
            // lb_dob
            // 
            this.lb_dob.AutoSize = true;
            this.lb_dob.Location = new System.Drawing.Point(9, 107);
            this.lb_dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_dob.Name = "lb_dob";
            this.lb_dob.Size = new System.Drawing.Size(36, 17);
            this.lb_dob.TabIndex = 5;
            this.lb_dob.Text = "DOB";
            // 
            // gb_address
            // 
            this.gb_address.Controls.Add(this.tb_no);
            this.gb_address.Controls.Add(this.lb_no);
            this.gb_address.Controls.Add(this.tb_city);
            this.gb_address.Controls.Add(this.lb_city);
            this.gb_address.Controls.Add(this.tb_street);
            this.gb_address.Controls.Add(this.lb_street);
            this.gb_address.Controls.Add(this.tb_code);
            this.gb_address.Controls.Add(this.lb_code);
            this.gb_address.Controls.Add(this.cb_state);
            this.gb_address.Controls.Add(this.lb_state);
            this.gb_address.Location = new System.Drawing.Point(12, 140);
            this.gb_address.Name = "gb_address";
            this.gb_address.Size = new System.Drawing.Size(427, 216);
            this.gb_address.TabIndex = 4;
            this.gb_address.TabStop = false;
            this.gb_address.Text = "Address";
            // 
            // tb_no
            // 
            this.tb_no.Location = new System.Drawing.Point(64, 166);
            this.tb_no.Name = "tb_no";
            this.tb_no.Size = new System.Drawing.Size(216, 24);
            this.tb_no.TabIndex = 9;
            // 
            // lb_no
            // 
            this.lb_no.AutoSize = true;
            this.lb_no.Location = new System.Drawing.Point(12, 170);
            this.lb_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_no.Name = "lb_no";
            this.lb_no.Size = new System.Drawing.Size(25, 17);
            this.lb_no.TabIndex = 9;
            this.lb_no.Text = "No";
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(64, 99);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(216, 24);
            this.tb_city.TabIndex = 7;
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Location = new System.Drawing.Point(12, 103);
            this.lb_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(32, 17);
            this.lb_city.TabIndex = 7;
            this.lb_city.Text = "City";
            // 
            // tb_street
            // 
            this.tb_street.Location = new System.Drawing.Point(64, 132);
            this.tb_street.Name = "tb_street";
            this.tb_street.Size = new System.Drawing.Size(216, 24);
            this.tb_street.TabIndex = 8;
            // 
            // lb_street
            // 
            this.lb_street.AutoSize = true;
            this.lb_street.Location = new System.Drawing.Point(12, 136);
            this.lb_street.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_street.Name = "lb_street";
            this.lb_street.Size = new System.Drawing.Size(45, 17);
            this.lb_street.TabIndex = 5;
            this.lb_street.Text = "Street";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(102, 65);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(178, 24);
            this.tb_code.TabIndex = 6;
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Location = new System.Drawing.Point(12, 68);
            this.lb_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(78, 17);
            this.lb_code.TabIndex = 3;
            this.lb_code.Text = "Postal code";
            // 
            // cb_state
            // 
            this.cb_state.FormattingEnabled = true;
            this.cb_state.Location = new System.Drawing.Point(64, 24);
            this.cb_state.Name = "cb_state";
            this.cb_state.Size = new System.Drawing.Size(344, 25);
            this.cb_state.TabIndex = 5;
            // 
            // lb_state
            // 
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(12, 32);
            this.lb_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(40, 17);
            this.lb_state.TabIndex = 1;
            this.lb_state.Text = "State";
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(76, 65);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(216, 24);
            this.tb_surname.TabIndex = 2;
            // 
            // lb_surname
            // 
            this.lb_surname.AutoSize = true;
            this.lb_surname.Location = new System.Drawing.Point(9, 68);
            this.lb_surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_surname.Name = "lb_surname";
            this.lb_surname.Size = new System.Drawing.Size(63, 17);
            this.lb_surname.TabIndex = 2;
            this.lb_surname.Text = "Surname";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(76, 26);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(216, 24);
            this.tb_name.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(9, 29);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(43, 17);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Name";
            // 
            // tp_aditional
            // 
            this.tp_aditional.Location = new System.Drawing.Point(4, 26);
            this.tp_aditional.Margin = new System.Windows.Forms.Padding(4);
            this.tp_aditional.Name = "tp_aditional";
            this.tp_aditional.Padding = new System.Windows.Forms.Padding(4);
            this.tp_aditional.Size = new System.Drawing.Size(1037, 704);
            this.tp_aditional.TabIndex = 1;
            this.tp_aditional.Text = "Additional";
            this.tp_aditional.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 683);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 51);
            this.panel1.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(914, 8);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(833, 8);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 32);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FrmCustomerAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_main);
            this.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomerAddModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer";
            this.Activated += new System.EventHandler(this.FrmCustomerAddModify_Activated);
            this.tb_main.ResumeLayout(false);
            this.tp_main.ResumeLayout(false);
            this.tp_main.PerformLayout();
            this.gb_address.ResumeLayout(false);
            this.gb_address.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_main;
        private System.Windows.Forms.TabPage tp_main;
        private System.Windows.Forms.TabPage tp_aditional;
        private System.Windows.Forms.DateTimePicker dt_dob;
        private System.Windows.Forms.Label lb_dob;
        private System.Windows.Forms.GroupBox gb_address;
        private System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.Label lb_no;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.TextBox tb_street;
        private System.Windows.Forms.Label lb_street;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.ComboBox cb_state;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}
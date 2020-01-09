namespace SportsCommunity.UserControls
{
    partial class CtrlCreateEvent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbEventTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbEventType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEventContext = new System.Windows.Forms.TextBox();
            this.btnCreateEventType = new System.Windows.Forms.Button();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateCity = new System.Windows.Forms.Button();
            this.btnCreateLocation = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCitys = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(882, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 32);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(159, 14);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(345, 20);
            this.tbName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date and Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(345, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // cbEventTypes
            // 
            this.cbEventTypes.FormattingEnabled = true;
            this.cbEventTypes.Location = new System.Drawing.Point(159, 95);
            this.cbEventTypes.Name = "cbEventTypes";
            this.cbEventTypes.Size = new System.Drawing.Size(345, 21);
            this.cbEventTypes.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Choose Event Type:";
            // 
            // cbLocations
            // 
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(159, 68);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(345, 21);
            this.cbLocations.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(22, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Choose Location:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(159, 122);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(345, 28);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "Create Event";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbEventType
            // 
            this.tbEventType.Location = new System.Drawing.Point(159, 178);
            this.tbEventType.Name = "tbEventType";
            this.tbEventType.Size = new System.Drawing.Size(345, 20);
            this.tbEventType.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(22, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Add Event Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(22, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Event Context:";
            // 
            // tbEventContext
            // 
            this.tbEventContext.Location = new System.Drawing.Point(159, 206);
            this.tbEventContext.Multiline = true;
            this.tbEventContext.Name = "tbEventContext";
            this.tbEventContext.Size = new System.Drawing.Size(345, 97);
            this.tbEventContext.TabIndex = 30;
            // 
            // btnCreateEventType
            // 
            this.btnCreateEventType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEventType.Location = new System.Drawing.Point(159, 309);
            this.btnCreateEventType.Name = "btnCreateEventType";
            this.btnCreateEventType.Size = new System.Drawing.Size(345, 28);
            this.btnCreateEventType.TabIndex = 31;
            this.btnCreateEventType.Text = "Create Event Type";
            this.btnCreateEventType.UseVisualStyleBackColor = true;
            this.btnCreateEventType.Click += new System.EventHandler(this.btnCreateEventType_Click);
            // 
            // tbCityName
            // 
            this.tbCityName.Location = new System.Drawing.Point(159, 482);
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.Size = new System.Drawing.Size(345, 20);
            this.tbCityName.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(22, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Add City Name:";
            // 
            // btnCreateCity
            // 
            this.btnCreateCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCity.Location = new System.Drawing.Point(159, 508);
            this.btnCreateCity.Name = "btnCreateCity";
            this.btnCreateCity.Size = new System.Drawing.Size(345, 28);
            this.btnCreateCity.TabIndex = 34;
            this.btnCreateCity.Text = "Create City";
            this.btnCreateCity.UseVisualStyleBackColor = true;
            this.btnCreateCity.Click += new System.EventHandler(this.btnCreateCity_Click);
            // 
            // btnCreateLocation
            // 
            this.btnCreateLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLocation.Location = new System.Drawing.Point(159, 415);
            this.btnCreateLocation.Name = "btnCreateLocation";
            this.btnCreateLocation.Size = new System.Drawing.Size(345, 28);
            this.btnCreateLocation.TabIndex = 37;
            this.btnCreateLocation.Text = "Create Location";
            this.btnCreateLocation.UseVisualStyleBackColor = true;
            this.btnCreateLocation.Click += new System.EventHandler(this.btnCreateLocation_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(159, 365);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(345, 20);
            this.tbAddress.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(22, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Add Address:";
            // 
            // cbCitys
            // 
            this.cbCitys.FormattingEnabled = true;
            this.cbCitys.Location = new System.Drawing.Point(159, 391);
            this.cbCitys.Name = "cbCitys";
            this.cbCitys.Size = new System.Drawing.Size(345, 21);
            this.cbCitys.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(22, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Choose City:";
            // 
            // CtrlCreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cbCitys);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCreateLocation);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreateCity);
            this.Controls.Add(this.tbCityName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCreateEventType);
            this.Controls.Add(this.tbEventContext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEventType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbEventTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "CtrlCreateEvent";
            this.Size = new System.Drawing.Size(932, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbEventTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbEventType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEventContext;
        private System.Windows.Forms.Button btnCreateEventType;
        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateCity;
        private System.Windows.Forms.Button btnCreateLocation;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCitys;
        private System.Windows.Forms.Label label9;
    }
}

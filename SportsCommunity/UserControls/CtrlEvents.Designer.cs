namespace SportsCommunity.UserControls
{
    partial class CtrlEvents
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
            this.labelEvent = new System.Windows.Forms.Label();
            this.lbMyEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.BtnTimeSort = new System.Windows.Forms.Button();
            this.btnLocationSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCitys = new System.Windows.Forms.ComboBox();
            this.btnEventTypeSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEventTypes = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEvent.Location = new System.Drawing.Point(309, 61);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(0, 21);
            this.labelEvent.TabIndex = 0;
            // 
            // lbMyEvents
            // 
            this.lbMyEvents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyEvents.FormattingEnabled = true;
            this.lbMyEvents.ItemHeight = 21;
            this.lbMyEvents.Location = new System.Drawing.Point(37, 61);
            this.lbMyEvents.Name = "lbMyEvents";
            this.lbMyEvents.Size = new System.Drawing.Size(250, 340);
            this.lbMyEvents.TabIndex = 1;
            this.lbMyEvents.SelectedIndexChanged += new System.EventHandler(this.lbMyEvents_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Events";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.White;
            this.btnAddEvent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(37, 417);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(110, 36);
            this.btnAddEvent.TabIndex = 4;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.Color.White;
            this.btnCreateEvent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.Location = new System.Drawing.Point(37, 459);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(110, 36);
            this.btnCreateEvent.TabIndex = 5;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // BtnTimeSort
            // 
            this.BtnTimeSort.BackColor = System.Drawing.Color.White;
            this.BtnTimeSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTimeSort.Location = new System.Drawing.Point(313, 365);
            this.BtnTimeSort.Name = "BtnTimeSort";
            this.BtnTimeSort.Size = new System.Drawing.Size(110, 36);
            this.BtnTimeSort.TabIndex = 6;
            this.BtnTimeSort.Text = "Sort By Time";
            this.BtnTimeSort.UseVisualStyleBackColor = false;
            this.BtnTimeSort.Click += new System.EventHandler(this.BtnTimeSort_Click);
            // 
            // btnLocationSort
            // 
            this.btnLocationSort.BackColor = System.Drawing.Color.White;
            this.btnLocationSort.Enabled = false;
            this.btnLocationSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationSort.Location = new System.Drawing.Point(497, 365);
            this.btnLocationSort.Name = "btnLocationSort";
            this.btnLocationSort.Size = new System.Drawing.Size(146, 36);
            this.btnLocationSort.TabIndex = 7;
            this.btnLocationSort.Text = "Sort By City";
            this.btnLocationSort.UseVisualStyleBackColor = false;
            this.btnLocationSort.Click += new System.EventHandler(this.btnLocationSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(493, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose City";
            // 
            // cbCitys
            // 
            this.cbCitys.FormattingEnabled = true;
            this.cbCitys.Location = new System.Drawing.Point(497, 432);
            this.cbCitys.Name = "cbCitys";
            this.cbCitys.Size = new System.Drawing.Size(146, 21);
            this.cbCitys.TabIndex = 10;
            this.cbCitys.SelectedIndexChanged += new System.EventHandler(this.cbCitys_SelectedIndexChanged);
            // 
            // btnEventTypeSort
            // 
            this.btnEventTypeSort.BackColor = System.Drawing.Color.White;
            this.btnEventTypeSort.Enabled = false;
            this.btnEventTypeSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventTypeSort.Location = new System.Drawing.Point(713, 365);
            this.btnEventTypeSort.Name = "btnEventTypeSort";
            this.btnEventTypeSort.Size = new System.Drawing.Size(166, 36);
            this.btnEventTypeSort.TabIndex = 11;
            this.btnEventTypeSort.Text = "Sort By Event Type";
            this.btnEventTypeSort.UseVisualStyleBackColor = false;
            this.btnEventTypeSort.Click += new System.EventHandler(this.btnEventTypeSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(719, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Choose Event Type";
            // 
            // cbEventTypes
            // 
            this.cbEventTypes.FormattingEnabled = true;
            this.cbEventTypes.Location = new System.Drawing.Point(723, 432);
            this.cbEventTypes.Name = "cbEventTypes";
            this.cbEventTypes.Size = new System.Drawing.Size(166, 21);
            this.cbEventTypes.TabIndex = 13;
            this.cbEventTypes.SelectedIndexChanged += new System.EventHandler(this.cbEventTypes_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(871, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 32);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CtrlEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbEventTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEventTypeSort);
            this.Controls.Add(this.cbCitys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLocationSort);
            this.Controls.Add(this.BtnTimeSort);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMyEvents);
            this.Controls.Add(this.labelEvent);
            this.Name = "CtrlEvents";
            this.Size = new System.Drawing.Size(918, 534);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.ListBox lbMyEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button BtnTimeSort;
        private System.Windows.Forms.Button btnLocationSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCitys;
        private System.Windows.Forms.Button btnEventTypeSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEventTypes;
        private System.Windows.Forms.Button btnBack;
    }
}

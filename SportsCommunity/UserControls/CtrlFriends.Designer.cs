namespace SportsCommunity.UserControls
{
    partial class CtrlFriends
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMyFriends = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFriendsEvents = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Friends:";
            // 
            // lbMyFriends
            // 
            this.lbMyFriends.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyFriends.FormattingEnabled = true;
            this.lbMyFriends.ItemHeight = 21;
            this.lbMyFriends.Location = new System.Drawing.Point(33, 32);
            this.lbMyFriends.Name = "lbMyFriends";
            this.lbMyFriends.Size = new System.Drawing.Size(250, 340);
            this.lbMyFriends.TabIndex = 3;
            this.lbMyFriends.SelectedIndexChanged += new System.EventHandler(this.lbMyFriends_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(397, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Friends Events:";
            // 
            // lbFriendsEvents
            // 
            this.lbFriendsEvents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFriendsEvents.FormattingEnabled = true;
            this.lbFriendsEvents.ItemHeight = 21;
            this.lbFriendsEvents.Location = new System.Drawing.Point(401, 32);
            this.lbFriendsEvents.Name = "lbFriendsEvents";
            this.lbFriendsEvents.Size = new System.Drawing.Size(250, 340);
            this.lbFriendsEvents.TabIndex = 5;
            this.lbFriendsEvents.SelectedIndexChanged += new System.EventHandler(this.lbFriendsEvents_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(690, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 21);
            this.label.TabIndex = 7;
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.Location = new System.Drawing.Point(94, 411);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(99, 36);
            this.btnAddFriend.TabIndex = 8;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(919, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 32);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CtrlFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFriendsEvents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMyFriends);
            this.Name = "CtrlFriends";
            this.Size = new System.Drawing.Size(1007, 483);
            this.Load += new System.EventHandler(this.CtrlFriends_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMyFriends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFriendsEvents;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.Button btnBack;
    }
}

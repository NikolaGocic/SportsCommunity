namespace SportsCommunity.UserControls
{
    partial class CtrlAddFriend
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
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllClients = new System.Windows.Forms.ListBox();
            this.tbSerch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.Location = new System.Drawing.Point(129, 402);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(99, 36);
            this.btnAddFriend.TabIndex = 11;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(64, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Find Friends: ";
            // 
            // lbAllClients
            // 
            this.lbAllClients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllClients.FormattingEnabled = true;
            this.lbAllClients.ItemHeight = 21;
            this.lbAllClients.Location = new System.Drawing.Point(68, 23);
            this.lbAllClients.Name = "lbAllClients";
            this.lbAllClients.Size = new System.Drawing.Size(250, 340);
            this.lbAllClients.TabIndex = 9;
            // 
            // tbSerch
            // 
            this.tbSerch.Location = new System.Drawing.Point(184, -1);
            this.tbSerch.Name = "tbSerch";
            this.tbSerch.Size = new System.Drawing.Size(134, 20);
            this.tbSerch.TabIndex = 12;
            this.tbSerch.TextChanged += new System.EventHandler(this.tbSerch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(616, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 32);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CtrlAddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbSerch);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAllClients);
            this.Name = "CtrlAddFriend";
            this.Size = new System.Drawing.Size(763, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAllClients;
        private System.Windows.Forms.TextBox tbSerch;
        private System.Windows.Forms.Button btnBack;
    }
}

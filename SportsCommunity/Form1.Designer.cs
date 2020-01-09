namespace SportsCommunity
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
            this.Panel = new System.Windows.Forms.Panel();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "SportCommunity";
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Location = new System.Drawing.Point(71, 65);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1045, 544);
            this.Panel.TabIndex = 2;
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.BackColor = System.Drawing.Color.Transparent;
            this.labelLogIn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogIn.Location = new System.Drawing.Point(67, 27);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(0, 21);
            this.labelLogIn.TabIndex = 3;
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(1027, 21);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(89, 32);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Log out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SportsCommunity.Properties.Resources.bicycle_wall_sports_120826_3840x2400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 656);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Button logOut;
    }
}


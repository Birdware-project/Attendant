namespace TimeLogin
{
    partial class Member
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
            this.label4 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dataView_member = new System.Windows.Forms.DataGridView();
            this.bt_back = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.on_time = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_member)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KhmerDLStation TNRB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(35, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = " User Name :";
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.Blue;
            this.bt_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_save.Location = new System.Drawing.Point(12, 252);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(124, 46);
            this.bt_save.TabIndex = 13;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(190, 87);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(156, 35);
            this.txt_name.TabIndex = 11;
            // 
            // dataView_member
            // 
            this.dataView_member.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_member.Location = new System.Drawing.Point(12, 304);
            this.dataView_member.Name = "dataView_member";
            this.dataView_member.RowHeadersWidth = 51;
            this.dataView_member.RowTemplate.Height = 24;
            this.dataView_member.Size = new System.Drawing.Size(892, 233);
            this.dataView_member.TabIndex = 27;
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.Blue;
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_back.Location = new System.Drawing.Point(350, 263);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(93, 35);
            this.bt_back.TabIndex = 28;
            this.bt_back.Text = "Close";
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeINToolStripMenuItem,
            this.timeOUTToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // timeINToolStripMenuItem
            // 
            this.timeINToolStripMenuItem.Name = "timeINToolStripMenuItem";
            this.timeINToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.timeINToolStripMenuItem.Text = "Enter and Exit";
            this.timeINToolStripMenuItem.Click += new System.EventHandler(this.timeINToolStripMenuItem_Click);
            // 
            // timeOUTToolStripMenuItem
            // 
            this.timeOUTToolStripMenuItem.Name = "timeOUTToolStripMenuItem";
            this.timeOUTToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.timeOUTToolStripMenuItem.Text = "Attendant";
            this.timeOUTToolStripMenuItem.Click += new System.EventHandler(this.timeOUTToolStripMenuItem_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("KhmerDLStation TNRB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt.Location = new System.Drawing.Point(50, 149);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(106, 31);
            this.txt.TabIndex = 32;
            this.txt.Text = "Password :";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(190, 149);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(156, 35);
            this.txt_password.TabIndex = 31;
            // 
            // on_time
            // 
            this.on_time.AutoSize = true;
            this.on_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.on_time.Location = new System.Drawing.Point(801, 44);
            this.on_time.Name = "on_time";
            this.on_time.Size = new System.Drawing.Size(94, 20);
            this.on_time.TabIndex = 33;
            this.on_time.Text = "after 12 am";
            this.on_time.UseVisualStyleBackColor = true;
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(916, 562);
            this.Controls.Add(this.on_time);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.dataView_member);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Member";
            this.Text = "Member";
            ((System.ComponentModel.ISupportInitialize)(this.dataView_member)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView dataView_member;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeOUTToolStripMenuItem;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.CheckBox on_time;
    }
}
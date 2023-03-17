namespace TimeLogin
{
    partial class ViewTimelogin
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
            this.datatime_In = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datatime_In)).BeginInit();
            this.SuspendLayout();
            // 
            // datatime_In
            // 
            this.datatime_In.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datatime_In.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatime_In.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatime_In.Location = new System.Drawing.Point(12, 107);
            this.datatime_In.Name = "datatime_In";
            this.datatime_In.RowHeadersWidth = 51;
            this.datatime_In.RowTemplate.Height = 24;
            this.datatime_In.Size = new System.Drawing.Size(1020, 377);
            this.datatime_In.TabIndex = 0;
            // 
            // ViewTimelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1044, 496);
            this.Controls.Add(this.datatime_In);
            this.Name = "ViewTimelogin";
            this.Text = "ViewTimelogin";
            ((System.ComponentModel.ISupportInitialize)(this.datatime_In)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datatime_In;
    }
}
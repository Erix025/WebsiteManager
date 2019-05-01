namespace WebsiteManager
{
    partial class frm_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Edit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.but_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "网址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "网页名";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(74, 16);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(243, 26);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(74, 55);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(243, 26);
            this.txt_URL.TabIndex = 3;
            // 
            // but_Confirm
            // 
            this.but_Confirm.Location = new System.Drawing.Point(350, 80);
            this.but_Confirm.Name = "but_Confirm";
            this.but_Confirm.Size = new System.Drawing.Size(75, 26);
            this.but_Confirm.TabIndex = 4;
            this.but_Confirm.Text = "确认";
            this.but_Confirm.UseVisualStyleBackColor = true;
            this.but_Confirm.Click += new System.EventHandler(this.but_Confirm_Click);
            // 
            // frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 118);
            this.Controls.Add(this.but_Confirm);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Edit";
            this.Text = "frm_Edit";
            this.Load += new System.EventHandler(this.frm_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Button but_Confirm;
    }
}
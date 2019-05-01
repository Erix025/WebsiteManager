namespace WebsiteManager
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_Main = new System.Windows.Forms.ListBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_URL = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.but_Delete = new System.Windows.Forms.Button();
            this.but_Edit = new System.Windows.Forms.Button();
            this.but_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Main
            // 
            this.lst_Main.FormattingEnabled = true;
            this.lst_Main.ItemHeight = 16;
            this.lst_Main.Location = new System.Drawing.Point(13, 13);
            this.lst_Main.Margin = new System.Windows.Forms.Padding(4);
            this.lst_Main.Name = "lst_Main";
            this.lst_Main.Size = new System.Drawing.Size(163, 388);
            this.lst_Main.TabIndex = 0;
            this.lst_Main.SelectedIndexChanged += new System.EventHandler(this.lst_Main_SelectedIndexChanged);
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("宋体", 18F);
            this.lab_Name.Location = new System.Drawing.Point(183, 13);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(0, 24);
            this.lab_Name.TabIndex = 1;
            // 
            // lab_URL
            // 
            this.lab_URL.Location = new System.Drawing.Point(183, 46);
            this.lab_URL.Name = "lab_URL";
            this.lab_URL.Size = new System.Drawing.Size(210, 90);
            this.lab_URL.TabIndex = 2;
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(183, 371);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(75, 30);
            this.but_Add.TabIndex = 3;
            this.but_Add.Text = "添加";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // but_Delete
            // 
            this.but_Delete.Enabled = false;
            this.but_Delete.Location = new System.Drawing.Point(183, 335);
            this.but_Delete.Name = "but_Delete";
            this.but_Delete.Size = new System.Drawing.Size(75, 30);
            this.but_Delete.TabIndex = 4;
            this.but_Delete.Text = "删除";
            this.but_Delete.UseVisualStyleBackColor = true;
            this.but_Delete.Click += new System.EventHandler(this.but_Delete_Click);
            // 
            // but_Edit
            // 
            this.but_Edit.Enabled = false;
            this.but_Edit.Location = new System.Drawing.Point(183, 299);
            this.but_Edit.Name = "but_Edit";
            this.but_Edit.Size = new System.Drawing.Size(75, 30);
            this.but_Edit.TabIndex = 5;
            this.but_Edit.Text = "编辑";
            this.but_Edit.UseVisualStyleBackColor = true;
            this.but_Edit.Click += new System.EventHandler(this.but_Edit_Click);
            // 
            // but_Open
            // 
            this.but_Open.Enabled = false;
            this.but_Open.Location = new System.Drawing.Point(183, 263);
            this.but_Open.Name = "but_Open";
            this.but_Open.Size = new System.Drawing.Size(75, 30);
            this.but_Open.TabIndex = 5;
            this.but_Open.Text = "打开";
            this.but_Open.UseVisualStyleBackColor = true;
            this.but_Open.Click += new System.EventHandler(this.but_Open_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 420);
            this.Controls.Add(this.but_Open);
            this.Controls.Add(this.but_Edit);
            this.Controls.Add(this.but_Delete);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.lab_URL);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.lst_Main);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.Text = "网页收藏夹";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Main;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_URL;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_Delete;
        private System.Windows.Forms.Button but_Edit;
        private System.Windows.Forms.Button but_Open;
    }
}


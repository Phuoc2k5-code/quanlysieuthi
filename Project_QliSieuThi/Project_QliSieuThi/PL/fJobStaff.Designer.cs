namespace Project_QliSieuThi.PL
{
    partial class fJobStaff
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
            this.btn_XoaCV = new System.Windows.Forms.Button();
            this.btn_SuaCV = new System.Windows.Forms.Button();
            this.btn_ThemCV = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_XoaCV
            // 
            this.btn_XoaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaCV.Location = new System.Drawing.Point(404, 220);
            this.btn_XoaCV.Name = "btn_XoaCV";
            this.btn_XoaCV.Size = new System.Drawing.Size(124, 37);
            this.btn_XoaCV.TabIndex = 16;
            this.btn_XoaCV.Text = "Xóa CV";
            this.btn_XoaCV.UseVisualStyleBackColor = true;
            // 
            // btn_SuaCV
            // 
            this.btn_SuaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaCV.Location = new System.Drawing.Point(404, 115);
            this.btn_SuaCV.Name = "btn_SuaCV";
            this.btn_SuaCV.Size = new System.Drawing.Size(124, 37);
            this.btn_SuaCV.TabIndex = 15;
            this.btn_SuaCV.Text = "Sửa CV";
            this.btn_SuaCV.UseVisualStyleBackColor = true;
            this.btn_SuaCV.Click += new System.EventHandler(this.btn_SuaCV_Click);
            // 
            // btn_ThemCV
            // 
            this.btn_ThemCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemCV.Location = new System.Drawing.Point(404, 12);
            this.btn_ThemCV.Name = "btn_ThemCV";
            this.btn_ThemCV.Size = new System.Drawing.Size(124, 37);
            this.btn_ThemCV.TabIndex = 14;
            this.btn_ThemCV.Text = "Thêm CV";
            this.btn_ThemCV.UseVisualStyleBackColor = true;
            this.btn_ThemCV.Click += new System.EventHandler(this.btn_ThemCV_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(353, 485);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fJobStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(559, 509);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_XoaCV);
            this.Controls.Add(this.btn_SuaCV);
            this.Controls.Add(this.btn_ThemCV);
            this.Name = "fJobStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Staff";
            this.Load += new System.EventHandler(this.fJobStaff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaCV;
        private System.Windows.Forms.Button btn_SuaCV;
        private System.Windows.Forms.Button btn_ThemCV;
        private System.Windows.Forms.ListView listView1;
    }
}
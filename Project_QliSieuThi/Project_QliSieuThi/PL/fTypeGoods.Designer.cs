namespace Project_QliSieuThi.PL
{
    partial class fTypeGoods
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
            this.btn_SuaLoai = new System.Windows.Forms.Button();
            this.btn_XoaLoai = new System.Windows.Forms.Button();
            this.btn_ThemLoai = new System.Windows.Forms.Button();
            this.lv_lsp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_SuaLoai
            // 
            this.btn_SuaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaLoai.Location = new System.Drawing.Point(434, 145);
            this.btn_SuaLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SuaLoai.Name = "btn_SuaLoai";
            this.btn_SuaLoai.Size = new System.Drawing.Size(140, 46);
            this.btn_SuaLoai.TabIndex = 11;
            this.btn_SuaLoai.Text = "Sửa loại";
            this.btn_SuaLoai.UseVisualStyleBackColor = true;
            this.btn_SuaLoai.Click += new System.EventHandler(this.btn_SuaLoai_Click);
            // 
            // btn_XoaLoai
            // 
            this.btn_XoaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaLoai.Location = new System.Drawing.Point(434, 276);
            this.btn_XoaLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaLoai.Name = "btn_XoaLoai";
            this.btn_XoaLoai.Size = new System.Drawing.Size(140, 46);
            this.btn_XoaLoai.TabIndex = 12;
            this.btn_XoaLoai.Text = "Xóa loại";
            this.btn_XoaLoai.UseVisualStyleBackColor = true;
            this.btn_XoaLoai.Click += new System.EventHandler(this.btn_XoaLoai_Click);
            // 
            // btn_ThemLoai
            // 
            this.btn_ThemLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemLoai.Location = new System.Drawing.Point(434, 20);
            this.btn_ThemLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemLoai.Name = "btn_ThemLoai";
            this.btn_ThemLoai.Size = new System.Drawing.Size(140, 46);
            this.btn_ThemLoai.TabIndex = 13;
            this.btn_ThemLoai.Text = "Thêm loại";
            this.btn_ThemLoai.UseVisualStyleBackColor = true;
            this.btn_ThemLoai.Click += new System.EventHandler(this.btn_ThemLoai_Click);
            // 
            // lv_lsp
            // 
            this.lv_lsp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_lsp.HideSelection = false;
            this.lv_lsp.Location = new System.Drawing.Point(13, 20);
            this.lv_lsp.Name = "lv_lsp";
            this.lv_lsp.Size = new System.Drawing.Size(358, 617);
            this.lv_lsp.TabIndex = 14;
            this.lv_lsp.UseCompatibleStateImageBehavior = false;
            this.lv_lsp.View = System.Windows.Forms.View.Details;
            this.lv_lsp.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "malsp";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "tenlsp";
            this.columnHeader2.Width = 151;
            // 
            // fTypeGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 636);
            this.Controls.Add(this.lv_lsp);
            this.Controls.Add(this.btn_ThemLoai);
            this.Controls.Add(this.btn_XoaLoai);
            this.Controls.Add(this.btn_SuaLoai);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fTypeGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type Goods";
            this.Load += new System.EventHandler(this.fTypeGoods_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_SuaLoai;
        private System.Windows.Forms.Button btn_XoaLoai;
        private System.Windows.Forms.Button btn_ThemLoai;
        private System.Windows.Forms.ListView lv_lsp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
namespace Project_QliSieuThi.Views
{
    partial class fUpdateTypeGoods
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl_vinv_MaNV = new System.Windows.Forms.Label();
            this.txt_ChinhSua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_DsLoai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Ok.Location = new System.Drawing.Point(376, 149);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(124, 37);
            this.btn_Ok.TabIndex = 79;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // lbl_vinv_MaNV
            // 
            this.lbl_vinv_MaNV.AutoSize = true;
            this.lbl_vinv_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_vinv_MaNV.Location = new System.Drawing.Point(80, 26);
            this.lbl_vinv_MaNV.Name = "lbl_vinv_MaNV";
            this.lbl_vinv_MaNV.Size = new System.Drawing.Size(131, 18);
            this.lbl_vinv_MaNV.TabIndex = 77;
            this.lbl_vinv_MaNV.Tag = "";
            this.lbl_vinv_MaNV.Text = "Chọn loại cần sửa:";
            // 
            // txt_ChinhSua
            // 
            this.txt_ChinhSua.Location = new System.Drawing.Point(83, 123);
            this.txt_ChinhSua.Name = "txt_ChinhSua";
            this.txt_ChinhSua.Size = new System.Drawing.Size(182, 22);
            this.txt_ChinhSua.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(80, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 80;
            this.label1.Tag = "";
            this.label1.Text = "Chỉnh sửa:";
            // 
            // cbb_DsLoai
            // 
            this.cbb_DsLoai.FormattingEnabled = true;
            this.cbb_DsLoai.Location = new System.Drawing.Point(83, 58);
            this.cbb_DsLoai.Name = "cbb_DsLoai";
            this.cbb_DsLoai.Size = new System.Drawing.Size(182, 24);
            this.cbb_DsLoai.TabIndex = 82;
            // 
            // fUpdateTypeGoodscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 202);
            this.Controls.Add(this.cbb_DsLoai);
            this.Controls.Add(this.txt_ChinhSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_vinv_MaNV);
            this.Name = "fUpdateTypeGoodscs";
            this.Text = "Update Type Goods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_vinv_MaNV;
        private System.Windows.Forms.TextBox txt_ChinhSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_DsLoai;
    }
}
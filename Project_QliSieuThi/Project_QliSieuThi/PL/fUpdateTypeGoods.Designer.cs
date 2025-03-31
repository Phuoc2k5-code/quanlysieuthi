namespace Project_QliSieuThi.PL
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
            this.txt_malsp = new System.Windows.Forms.TextBox();
            this.txt_tenlsp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Ok.Location = new System.Drawing.Point(360, 168);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(124, 37);
            this.btn_Ok.TabIndex = 79;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click_1);
            // 
            // lbl_vinv_MaNV
            // 
            this.lbl_vinv_MaNV.AutoSize = true;
            this.lbl_vinv_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_vinv_MaNV.Location = new System.Drawing.Point(81, 106);
            this.lbl_vinv_MaNV.Name = "lbl_vinv_MaNV";
            this.lbl_vinv_MaNV.Size = new System.Drawing.Size(131, 18);
            this.lbl_vinv_MaNV.TabIndex = 77;
            this.lbl_vinv_MaNV.Tag = "";
            this.lbl_vinv_MaNV.Text = "Chọn loại cần sửa:";
            // 
            // txt_malsp
            // 
            this.txt_malsp.Location = new System.Drawing.Point(84, 71);
            this.txt_malsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_malsp.Name = "txt_malsp";
            this.txt_malsp.Size = new System.Drawing.Size(182, 22);
            this.txt_malsp.TabIndex = 84;
            // 
            // txt_tenlsp
            // 
            this.txt_tenlsp.Location = new System.Drawing.Point(84, 138);
            this.txt_tenlsp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenlsp.Name = "txt_tenlsp";
            this.txt_tenlsp.Size = new System.Drawing.Size(182, 22);
            this.txt_tenlsp.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(81, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 86;
            this.label3.Tag = "";
            this.label3.Text = "Mã loại sản phẩm:";
            // 
            // fUpdateTypeGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 224);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenlsp);
            this.Controls.Add(this.txt_malsp);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_vinv_MaNV);
            this.Name = "fUpdateTypeGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Type Goods";
            this.Load += new System.EventHandler(this.fUpdateTypeGoods_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_vinv_MaNV;
        private System.Windows.Forms.TextBox txt_malsp;
        private System.Windows.Forms.TextBox txt_tenlsp;
        private System.Windows.Forms.Label label3;
    }
}
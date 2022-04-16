namespace ChuyenDeCNPM_De2
{
    partial class MainForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLamLai = new System.Windows.Forms.Button();
            this.buttonMuaBan = new System.Windows.Forms.Button();
            this.spinEditGia = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditKhoiLuong = new DevExpress.XtraEditors.SpinEdit();
            this.comboBoxMuaBan = new System.Windows.Forms.ComboBox();
            this.comboBoxLoaiLenh = new System.Windows.Forms.ComboBox();
            this.textEditMaCP = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridViewBangGiaTT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditKhoiLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangGiaTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.buttonLamLai);
            this.panelControl1.Controls.Add(this.buttonMuaBan);
            this.panelControl1.Controls.Add(this.spinEditGia);
            this.panelControl1.Controls.Add(this.spinEditKhoiLuong);
            this.panelControl1.Controls.Add(this.comboBoxMuaBan);
            this.panelControl1.Controls.Add(this.comboBoxLoaiLenh);
            this.panelControl1.Controls.Add(this.textEditMaCP);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 346);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(920, 153);
            this.panelControl1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // buttonLamLai
            // 
            this.buttonLamLai.Location = new System.Drawing.Point(483, 103);
            this.buttonLamLai.Name = "buttonLamLai";
            this.buttonLamLai.Size = new System.Drawing.Size(75, 23);
            this.buttonLamLai.TabIndex = 7;
            this.buttonLamLai.Text = "Làm lại";
            this.buttonLamLai.UseVisualStyleBackColor = true;
            this.buttonLamLai.Click += new System.EventHandler(this.buttonLamLai_Click);
            // 
            // buttonMuaBan
            // 
            this.buttonMuaBan.Location = new System.Drawing.Point(395, 103);
            this.buttonMuaBan.Name = "buttonMuaBan";
            this.buttonMuaBan.Size = new System.Drawing.Size(75, 23);
            this.buttonMuaBan.TabIndex = 6;
            this.buttonMuaBan.Text = "Mua";
            this.buttonMuaBan.UseVisualStyleBackColor = true;
            this.buttonMuaBan.Click += new System.EventHandler(this.buttonMuaBan_Click);
            // 
            // spinEditGia
            // 
            this.spinEditGia.EditValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditGia.Location = new System.Drawing.Point(458, 62);
            this.spinEditGia.Name = "spinEditGia";
            this.spinEditGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditGia.Properties.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spinEditGia.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditGia.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditGia.Size = new System.Drawing.Size(100, 20);
            this.spinEditGia.TabIndex = 5;
            // 
            // spinEditKhoiLuong
            // 
            this.spinEditKhoiLuong.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditKhoiLuong.Location = new System.Drawing.Point(458, 19);
            this.spinEditKhoiLuong.Name = "spinEditKhoiLuong";
            this.spinEditKhoiLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditKhoiLuong.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditKhoiLuong.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditKhoiLuong.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditKhoiLuong.Size = new System.Drawing.Size(100, 20);
            this.spinEditKhoiLuong.TabIndex = 4;
            // 
            // comboBoxMuaBan
            // 
            this.comboBoxMuaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuaBan.FormattingEnabled = true;
            this.comboBoxMuaBan.Location = new System.Drawing.Point(109, 105);
            this.comboBoxMuaBan.Name = "comboBoxMuaBan";
            this.comboBoxMuaBan.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMuaBan.TabIndex = 3;
            this.comboBoxMuaBan.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuaBan_SelectedIndexChanged);
            // 
            // comboBoxLoaiLenh
            // 
            this.comboBoxLoaiLenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiLenh.FormattingEnabled = true;
            this.comboBoxLoaiLenh.Location = new System.Drawing.Point(107, 62);
            this.comboBoxLoaiLenh.Name = "comboBoxLoaiLenh";
            this.comboBoxLoaiLenh.Size = new System.Drawing.Size(123, 21);
            this.comboBoxLoaiLenh.TabIndex = 2;
            // 
            // textEditMaCP
            // 
            this.textEditMaCP.Location = new System.Drawing.Point(107, 19);
            this.textEditMaCP.Name = "textEditMaCP";
            this.textEditMaCP.Size = new System.Drawing.Size(123, 20);
            this.textEditMaCP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(920, 39);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.dataGridViewBangGiaTT);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 39);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(920, 307);
            this.panelControl3.TabIndex = 2;
            // 
            // dataGridViewBangGiaTT
            // 
            this.dataGridViewBangGiaTT.AllowUserToAddRows = false;
            this.dataGridViewBangGiaTT.AllowUserToDeleteRows = false;
            this.dataGridViewBangGiaTT.AllowUserToResizeRows = false;
            this.dataGridViewBangGiaTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBangGiaTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBangGiaTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBangGiaTT.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewBangGiaTT.MultiSelect = false;
            this.dataGridViewBangGiaTT.Name = "dataGridViewBangGiaTT";
            this.dataGridViewBangGiaTT.ReadOnly = true;
            this.dataGridViewBangGiaTT.RowHeadersVisible = false;
            this.dataGridViewBangGiaTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBangGiaTT.Size = new System.Drawing.Size(916, 303);
            this.dataGridViewBangGiaTT.TabIndex = 0;
            this.dataGridViewBangGiaTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBangGiaTT_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 499);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditKhoiLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBangGiaTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.DataGridView dataGridViewBangGiaTT;
        private DevExpress.XtraEditors.TextEdit textEditMaCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLoaiLenh;
        private System.Windows.Forms.ComboBox comboBoxMuaBan;
        private DevExpress.XtraEditors.SpinEdit spinEditKhoiLuong;
        private DevExpress.XtraEditors.SpinEdit spinEditGia;
        private System.Windows.Forms.Button buttonMuaBan;
        private System.Windows.Forms.Button buttonLamLai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
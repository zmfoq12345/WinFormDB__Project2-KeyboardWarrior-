namespace WinFormDB__Project2_KeyboardWarrior_
{
    partial class MainForm
{
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_search = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.키보드 = new System.Windows.Forms.RadioButton();
            this.마우스 = new System.Windows.Forms.RadioButton();
            this.이어폰 = new System.Windows.Forms.RadioButton();
            this.모니터 = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.search_list = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(4, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(422, 55);
            this.title.TabIndex = 1;
            this.title.Text = "KeyBoard Warrior";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(577, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "MODE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.UseMnemonic = false;
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(695, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "님 환영합니다!";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(130, 79);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(343, 21);
            this.tb_search.TabIndex = 4;
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(11, 83);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(41, 12);
            this.lb_search.TabIndex = 5;
            this.lb_search.Text = "검색 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.키보드);
            this.groupBox1.Controls.Add(this.마우스);
            this.groupBox1.Controls.Add(this.이어폰);
            this.groupBox1.Controls.Add(this.모니터);
            this.groupBox1.Location = new System.Drawing.Point(518, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "제품종류";
            // 
            // 키보드
            // 
            this.키보드.AutoSize = true;
            this.키보드.Location = new System.Drawing.Point(151, 45);
            this.키보드.Name = "키보드";
            this.키보드.Size = new System.Drawing.Size(59, 16);
            this.키보드.TabIndex = 3;
            this.키보드.TabStop = true;
            this.키보드.Text = "키보드";
            this.키보드.UseVisualStyleBackColor = true;
            this.키보드.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // 마우스
            // 
            this.마우스.AutoSize = true;
            this.마우스.Location = new System.Drawing.Point(151, 18);
            this.마우스.Name = "마우스";
            this.마우스.Size = new System.Drawing.Size(59, 16);
            this.마우스.TabIndex = 2;
            this.마우스.TabStop = true;
            this.마우스.Text = "마우스";
            this.마우스.UseVisualStyleBackColor = true;
            this.마우스.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // 이어폰
            // 
            this.이어폰.AutoSize = true;
            this.이어폰.Location = new System.Drawing.Point(28, 45);
            this.이어폰.Name = "이어폰";
            this.이어폰.Size = new System.Drawing.Size(59, 16);
            this.이어폰.TabIndex = 1;
            this.이어폰.TabStop = true;
            this.이어폰.Text = "이어폰";
            this.이어폰.UseVisualStyleBackColor = true;
            this.이어폰.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // 모니터
            // 
            this.모니터.AutoSize = true;
            this.모니터.Location = new System.Drawing.Point(29, 18);
            this.모니터.Name = "모니터";
            this.모니터.Size = new System.Drawing.Size(59, 16);
            this.모니터.TabIndex = 0;
            this.모니터.TabStop = true;
            this.모니터.Text = "모니터";
            this.모니터.UseVisualStyleBackColor = true;
            this.모니터.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(468, 77);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(41, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // search_list
            // 
            this.search_list.FormattingEnabled = true;
            this.search_list.Location = new System.Drawing.Point(50, 79);
            this.search_list.Name = "search_list";
            this.search_list.Size = new System.Drawing.Size(81, 20);
            this.search_list.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinFormDB__Project2_KeyboardWarrior_.Properties.Resources.update;
            this.pictureBox4.Location = new System.Drawing.Point(745, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormDB__Project2_KeyboardWarrior_.Properties.Resources.minus;
            this.pictureBox3.Location = new System.Drawing.Point(707, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::WinFormDB__Project2_KeyboardWarrior_.Properties.Resources.plus;
            this.pictureBox2.Location = new System.Drawing.Point(669, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormDB__Project2_KeyboardWarrior_.Properties.Resources.maxresdefault_live1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WinFormDB__Project2_KeyboardWarrior_.Properties.Resources.ad;
            this.pictureBox5.Location = new System.Drawing.Point(262, 106);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(247, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(797, 516);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.search_list);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "HANBIT_MART";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label title;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tb_search;
    private System.Windows.Forms.Label lb_search;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton 마우스;
    private System.Windows.Forms.RadioButton 이어폰;
    private System.Windows.Forms.RadioButton 모니터;
    private System.Windows.Forms.RadioButton 키보드;
    private System.Windows.Forms.Button btn_search;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ComboBox search_list;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

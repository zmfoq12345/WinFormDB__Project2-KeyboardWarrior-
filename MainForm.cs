using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB__Project2_KeyboardWarrior_
{
    public partial class MainForm : Form
    {
        int[] radioCount = new int[6]; // 음식A 침구B 의류C 가전제품D 도서E 생필품F
        static string TABLE = "Monitor";
        public MainForm()
        {
            InitializeComponent();
        }
        LoginForm lform = new LoginForm();
        MySqlDataAdapter adapter;
        DataSet dataSet;
        string admin = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT * FROM "+TABLE, lform.conn); // dataSet과 DB 연결
            dataSet = new DataSet(); // 메모리상의 가상 DataTable 관리
            search_list.Items.Add("가격(>)");
            search_list.Items.Add("가격(<)");
            search_list.Items.Add("상품명");
            adapter.Fill(dataSet, "Monitor");
            dataGridView1.DataSource = dataSet.Tables["Monitor"];
            LoginForm lformtmp = Owner as LoginForm;
            if (lformtmp != null)
            {
                admin = lformtmp.name;
                if (admin == "Admin")
                {
                    dataGridView1.ReadOnly = false;
                    this.title.Location = new System.Drawing.Point(4, 12);
                    this.btn_search.Location = new System.Drawing.Point(468, 147);
                    this.search_list.Location = new System.Drawing.Point(50, 149);
                    this.lb_search.Location = new System.Drawing.Point(11, 153);
                    this.tb_search.Location = new System.Drawing.Point(130, 149);
                    title.Text = "KeyBoard Warrior\nMANAGEMENT";
                    pictureBox1.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                }
                else
                {
                    dataGridView1.ReadOnly = true;
                    this.title.Location = new System.Drawing.Point(195, 9);
                    this.tb_search.Location = new System.Drawing.Point(130, 79);
                    this.lb_search.Location = new System.Drawing.Point(11, 83);
                    this.btn_search.Location = new System.Drawing.Point(468, 77);
                    this.search_list.Location = new System.Drawing.Point(50, 79);
                    title.Text = "KeyBoard Warrior";
                    pictureBox1.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                }
                label1.Text = lformtmp.name;
            }
        }

        public void Search(string sql = "")// substr(ShoppingMall_item_name, 1,1) = @a")
        {
            if (sql == "") sql = "SELECT * FROM " + TABLE;
            adapter.SelectCommand = new MySqlCommand(sql, lform.conn);

            try
            {
                lform.conn.Open();
                dataSet.Clear();
                if (adapter.Fill(dataSet, TABLE) > 0)
                {
                    dataGridView1.DataSource = dataSet.Tables[TABLE];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lform.conn.Close();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (tb_search.Text == "")
            {
                Search();
            }
            else
            {
                string s = "ShoppingMall_item_name ";
                if (search_list.Text == "가격(>)") s = "price >";
                else if (search_list.Text == "가격(<)") s = "price <";
                Search("SELECT * FROM "+TABLE+" WHERE " + s + "= \""+tb_search.Text+"\"");
            }
            모니터.Checked = false;
            이어폰.Checked = false;
            마우스.Checked = false;
            키보드.Checked = false;
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            string sql = "delete from "+TABLE+ " where ShoppingMall_item_name = @num";
            adapter.DeleteCommand = new MySqlCommand(sql, lform.conn);
            string num = dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value.ToString();
            adapter.DeleteCommand.Parameters.AddWithValue("@num", num);
            try
            {
                lform.conn.Open();
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    dataSet.Clear();
                    adapter.Fill(dataSet, TABLE);
                    dataGridView1.DataSource = dataSet.Tables[TABLE];
                    MessageBox.Show("물품이 삭제되었습니다..");
                }
                else
                {
                    MessageBox.Show("삭제된 데이터가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lform.conn.Close();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            //AddForm addForm = new addform();
            //addform.show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (TABLE == "Monitor")
            {
                string sql = $"update " + TABLE + $" set ShoppingMall_item_name=@name, price=@price, hz=@hz, inche=@inche, item_amount=@item_amount where ShoppingMall_item_name = \"{dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value.ToString()}\"";
                adapter.UpdateCommand = new MySqlCommand(sql, lform.conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@name", dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value.ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("@price", dataGridView1.SelectedRows[0].Cells["price"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@hz", dataGridView1.SelectedRows[0].Cells["hz"].Value.ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("@inche", dataGridView1.SelectedRows[0].Cells["inche"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@item_amount", dataGridView1.SelectedRows[0].Cells["item_amount"].Value);
            }
            else if (TABLE == "Keyboard")
            {
                string sql = $"update " + TABLE + $" set ShoppingMall_item_name=@name, price=@price, switch=@switch, infinity_input=@infinity_input, item_amount=@item_amount, color=@color where ShoppingMall_item_name = \"{dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value.ToString()}\"";
                adapter.UpdateCommand = new MySqlCommand(sql, lform.conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@name", dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value.ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("@price", dataGridView1.SelectedRows[0].Cells["price"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@switch", dataGridView1.SelectedRows[0].Cells["switch"].Value.ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("@infinity_input", dataGridView1.SelectedRows[0].Cells["infinity_input"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@item_amount", dataGridView1.SelectedRows[0].Cells["item_amount"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@color", dataGridView1.SelectedRows[0].Cells["color"].Value.ToString());
            }
            else if (TABLE == "Mouse")
            {
                string sql = $"update " + TABLE + $" set ShoppingMall_item_name=@name, price=@price, sensor=@sensor, btn_num=@btn_num, item_amount=@item_amount, wireless=@wireless where ShoppingMall_item_name = \"{dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value.ToString()}\"";
                adapter.UpdateCommand = new MySqlCommand(sql, lform.conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@name", dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@price", dataGridView1.SelectedRows[0].Cells["price"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@sensor", dataGridView1.SelectedRows[0].Cells["sensor"].Value.ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("@btn_num", dataGridView1.SelectedRows[0].Cells["btn_num"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@item_amount", dataGridView1.SelectedRows[0].Cells["item_amount"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@wireless", dataGridView1.SelectedRows[0].Cells["wireless"].Value);
            }
            else if (TABLE == "Earphone")
            {
                string sql = $"update " + TABLE + $" set ShoppingMall_item_name=@name, price=@price, wireless=@wireless, capcolor=@capcolor , item_amount=@item_amount, color=@color where ShoppingMall_item_name = \"{dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value.ToString()}\"";
                adapter.UpdateCommand = new MySqlCommand(sql, lform.conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@name", dataGridView1.SelectedRows[0].Cells["ShoppingMall_item_name"].Value.ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("@price", dataGridView1.SelectedRows[0].Cells["price"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@wireless", dataGridView1.SelectedRows[0].Cells["wireless"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@capcolor", dataGridView1.SelectedRows[0].Cells["capcolor"].Value.ToString());
                adapter.UpdateCommand.Parameters.AddWithValue("@item_amount", dataGridView1.SelectedRows[0].Cells["item_amount"].Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@color", dataGridView1.SelectedRows[0].Cells["color"].Value.ToString());
            }


            try
            {
                lform.conn.Open();
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    dataSet.Clear();
                    adapter.Fill(dataSet, TABLE); // DB -> 메모리
                    dataGridView1.DataSource = dataSet.Tables[TABLE];
                    MessageBox.Show("물품 정보가 수정되었습니다.");
                }
                else
                {
                    MessageBox.Show("수정된 데이터가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lform.conn.Close();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && admin == "Admin")
            {
                btn_update_Click(sender, e);
            }

        }

        #region radioButton
        private void radioButton1_Click(object sender, EventArgs e)
        {
            TABLE = "Monitor";
            Search();
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            TABLE = "Earphone";
            Search();
        }
        private void radioButton3_Click(object sender, EventArgs e)
        {
            TABLE = "Mouse";
            Search();
        }
        private void radioButton4_Click(object sender, EventArgs e)
        {
            TABLE = "Keyboard";
            Search();
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            lform.Show();
            admin = "";
            this.Hide();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (TABLE == "Monitor")
            {
                dataGridView1.Columns["ShoppingMall_item_name"].DisplayIndex = 0;
                dataGridView1.Columns["price"].DisplayIndex = 4;
                dataGridView1.Columns[0].HeaderText = "가격";
                dataGridView1.Columns[1].HeaderText = "주사율(HZ)";
                dataGridView1.Columns[2].HeaderText = "인치";
                dataGridView1.Columns[3].HeaderText = "재고량";
                dataGridView1.Columns[4].HeaderText = "상품명";
            }
            else if (TABLE == "Keyboard")
            {
                dataGridView1.Columns["ShoppingMall_item_name"].DisplayIndex = 0;
                dataGridView1.Columns["price"].DisplayIndex = 4;
                dataGridView1.Columns[0].HeaderText = "가격";
                dataGridView1.Columns[1].HeaderText = "색상";
                dataGridView1.Columns[2].HeaderText = "축";
                dataGridView1.Columns[3].HeaderText = "동시입력";
                dataGridView1.Columns[4].HeaderText = "재고량";
                dataGridView1.Columns[5].HeaderText = "상품명";
            }
            else if (TABLE == "Mouse")
            {
                dataGridView1.Columns["ShoppingMall_item_name"].DisplayIndex = 0;
                dataGridView1.Columns["price"].DisplayIndex = 4;
                dataGridView1.Columns[0].HeaderText = "가격";
                dataGridView1.Columns[1].HeaderText = "센서";
                dataGridView1.Columns[2].HeaderText = "버튼 수";
                dataGridView1.Columns[3].HeaderText = "무선";
                dataGridView1.Columns[4].HeaderText = "재고량";
                dataGridView1.Columns[5].HeaderText = "상품명";
            }
            else if (TABLE == "Earphone")
            {
                dataGridView1.Columns["ShoppingMall_item_name"].DisplayIndex = 0;
                dataGridView1.Columns["price"].DisplayIndex = 4;
                dataGridView1.Columns[0].HeaderText = "가격";
                dataGridView1.Columns[1].HeaderText = "색상";
                dataGridView1.Columns[2].HeaderText = "캡 색상";
                dataGridView1.Columns[3].HeaderText = "무선";
                dataGridView1.Columns[4].HeaderText = "재고량";
                dataGridView1.Columns[5].HeaderText = "상품명";
            }
        }
    }
}
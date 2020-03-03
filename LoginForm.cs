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
    public partial class LoginForm : Form
    {
        public bool login_Check = false;
        public MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=mydb;username=root;password=[Your PW]");
        public LoginForm()
        {
            InitializeComponent();
        }
        public string name = "";
        public string level = "";

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string pw = tb_pw.Text;

            if (btn_login.Text == "Sign in")
            {
                if (tb_name.Text == "Admin")
                {
                    MessageBox.Show("관리자 계정 생성을 시도했습니다.\n관리자 계정은 특별한 경로로 생성 가능합니다.");
                    return;
                }
                if (id == "" || pw == "" || tb_name.Text == "")
                {
                    MessageBox.Show("빈칸을 모두 입력해 주세요");
                    return;
                }
                InsertUser(id, pw, tb_name.Text);
            }
            else
            {
                if (id == "" || pw == "")
                {
                    MessageBox.Show("아이디와 비밀번호를 모두 입력해 주세요");
                    return;
                }
                islogin(id, pw);
                if (login_Check)
                {
                    MainForm form1 = new MainForm();
                    form1.Owner = this;
                    form1.Show();
                    this.Hide();
                }
            }

        }

        private void InsertUser(string id, string pw, string name)
        {
            string sql = "insert into login (id, pw, name) values (@id, @pw, @name)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pw", pw);
            cmd.Parameters.AddWithValue("@name", name);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    conn.Close();
                    MakeClient(id, name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미 존재하는 회원입니다.");
            }
            finally
            {
                conn.Close();
            }
        }
        private void MakeClient(string id, string name)
        {
            string sql = "insert into userinfo(id, point, level, name) values (@id, @point, @rank, @name)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@point", 100);
            cmd.Parameters.AddWithValue("@rank", "Bronze");
            cmd.Parameters.AddWithValue("@name", name);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("회원가입 완료!");
                    btn_signin.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미 존재하는 회원입니다.");
            }
            finally
            {
                conn.Close();
            }
        }


        private void islogin(string id, string pw)
        {
            string sql = "SELECT name FROM login WHERE id = @id and pw = @pw";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pw", pw);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    name = reader.GetString("name");
                    login_Check = true;
                }
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가\n일치하지 않습니다.");
                    login_Check = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                login_Check = false;
            }
            finally
            {
                conn.Close();
            }
        }
        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (mode.Text == "회원가입하기")
            {
                tb_id.Clear();
                tb_pw.Clear();
                tb_name.Hide();
                lb_name.Hide();

                mode.Text = "로그인하기";
                btn_login.Text = "Login";
                btn_login.Location = new System.Drawing.Point(571, 408);
                btn_signin.Text = "회원가입";

            }
            else
            {
                mode.Text = "회원가입하기";
                btn_login.Text = "Sign in";
                tb_name.Show();
                lb_name.Show();
                btn_login.Location = new System.Drawing.Point(571, 438);
                btn_signin.Text = "취소";
            }

        }


        private void tb_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

    }
}

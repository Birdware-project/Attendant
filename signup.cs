using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace TimeLogin
{
    public partial class signup : Form
    {
        SqlConnection cnn;
        SqlCommand Con;
        SqlDataAdapter Adapter;
        DataTable dt;
        bool _onTime;
        string connectionString;
        public signup(string connectionSource,bool onTime)
        {
            InitializeComponent();
            this.connectionString = connectionSource;
            cnn = new SqlConnection(connectionSource);
            _onTime = onTime;
            if(!onTime)
            {
                bt_logout.Enabled = false;
            }
            else
            {
                bt_Login.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_day.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            Con = new SqlCommand();
            Con.CommandText = "select * from users where name=@username";
            Con.Parameters.Add("@username", SqlDbType.VarChar).Value = this.txt_username.Text;
            Con.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            kd = Con.ExecuteReader();
            if (!kd.HasRows)
            {
                MessageBox.Show("Incorrect User  Login !");
            }
            while (kd.Read())
            {
                var _ID = kd["ID"].ToString();
                var _username = kd["name"].ToString();
                var _password = kd["password"].ToString();

                if (this.txt_username.Text == _username
                && this.txt_password.Text == _password)
                {
                    if (!checkAlreadyLogin(int.Parse(_ID)))
                    {
                        cnn.Close();
                        Con = new SqlCommand();
                        Con.Connection = cnn;
                        cnn.Open();
                        Con.CommandText = "insert into attendant(userid,timein)" +
                            "values(@userid,@timein)";
                        Con.Parameters.Add("@userid", SqlDbType.VarChar, 250).Value = _ID;
                        Con.Parameters.Add("@timein", SqlDbType.DateTime).Value = lb_day.Text;
                        Con.ExecuteNonQuery();
                        MessageBox.Show("Success !");
                    }
                    else
                    {
                        MessageBox.Show("You already login today");
                    }   
                    break;
                }

            }
            cnn.Close();
        }
        private bool checkAlreadyLogin(int id)
        {
            //MessageBox.Show(DateTime.ParseExact(DateTime.Now.ToString("MM/dd/yyyy 23:00"), "M/d/yyyy HH:mm", CultureInfo.InvariantCulture).ToString());

            var _timeIn = "";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand Con = new SqlCommand();
            Con.CommandText = "select * from attendant where userid=@id and @mintoday < timein " +
                "and @maxtoday > timein ";
            Con.Parameters.Add("@id", SqlDbType.Int).Value = id;
            Con.Parameters.Add("@mintoday", SqlDbType.DateTime).Value 
                = DateTime.ParseExact(DateTime.Now.ToString("M/d/yyyy 1:00:00"), "M/d/yyyy h:mm:ss", CultureInfo.InvariantCulture);
            
            Con.Parameters.Add("@maxtoday", SqlDbType.DateTime).Value 
                = DateTime.ParseExact(DateTime.Now.ToString("M/d/yyyy 23:00:00"), "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Con.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            kd = Con.ExecuteReader();
            if (!kd.HasRows)
            {
                MessageBox.Show("no row");
            }
            while (kd.Read())
            {
                _timeIn = kd["timein"].ToString();
            }
            cnn.Close();
            return string.IsNullOrEmpty(_timeIn)? false:true;
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Con = new SqlCommand();
            Con.CommandText = "select * from users where name=@username";
            Con.Parameters.Add("@username", SqlDbType.VarChar).Value = this.txt_username.Text;
            Con.Connection = cnn;
            cnn.Open();
            SqlDataReader kd;
            kd = Con.ExecuteReader();
            if (!kd.HasRows)
            {
                MessageBox.Show("Incorrect User  Login !");
            }
            while (kd.Read())
            {
                var _ID = kd["ID"].ToString();
                var _username = kd["name"].ToString();
                var _password = kd["password"].ToString();

                if (this.txt_username.Text == _username && this.txt_password.Text == _password)
                {
                    cnn.Close();
                    Con = new SqlCommand();
                    Con.Connection = cnn;
                    cnn.Open();
                    Con.CommandText = "update attendant set timeout = @timeout " +
                        "where userid = @userid and timein < @now";
                    Con.Parameters.Add("@userid", SqlDbType.VarChar, 250).Value = _ID;
                    Con.Parameters.Add("@timeout", SqlDbType.DateTime).Value = lb_day.Text;
                    Con.Parameters.Add("@now", SqlDbType.DateTime).Value = DateTime.Now;
                    //cnn.Open();
                    Con.Connection = cnn;
                    Con.ExecuteNonQuery();
                    MessageBox.Show("Success !");
                    break;
                }

            }
            cnn.Close();
        }
    }
}

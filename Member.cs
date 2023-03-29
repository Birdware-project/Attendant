using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeLogin
{

    public partial class Member : Form
    {
        SqlConnection cnn;
        SqlCommand Con;
        SqlDataAdapter Adapter;
        DataTable dt;
        string connection;

        public Member(string connectionSource)
        {
            InitializeComponent();
            connection= connectionSource;
            cnn= new SqlConnection(connectionSource);
            ShowData();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            Con = new SqlCommand();
            Con.CommandText = "insert into users(Name,Password)" +
                "values(@name,@password)";
            Con.Parameters.Add("@name", SqlDbType.NChar, 250).Value = txt_name.Text;
            Con.Parameters.Add("@password", SqlDbType.VarChar,250).Value = txt_password.Text;
            cnn.Open();
            Con.Connection = cnn;
            Con.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Data Insert Success !");
            ShowData();
        }
        private void ShowData()
        {
            Adapter = new SqlDataAdapter("select * from Users", cnn);
            dt = new DataTable();
            Adapter.Fill(dt);
            dataView_member.DataSource = dt;
        }

        private void timeINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signup time = new signup(connection,on_time.Checked);
            time.Show();
        }

        private void timeOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTimelogin t = new ViewTimelogin(connection);
            t.Show();
        }
    }

}

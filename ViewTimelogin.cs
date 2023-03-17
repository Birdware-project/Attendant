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

namespace TimeLogin
{
    public partial class ViewTimelogin : Form
    {
        SqlConnection cnn;
        SqlDataAdapter Adapter;
        DataTable dt;

        public ViewTimelogin(string connectionSource)
        {
            InitializeComponent();
            cnn = new SqlConnection(connectionSource);
            ShowDatain();
        }
        private void ShowDatain()
        {
            Adapter = new SqlDataAdapter("select * from attendant", cnn);
            dt = new DataTable();
            Adapter.Fill(dt);
            datatime_In.DataSource = dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOAN
{
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=DESKTOP-IGPUUV0;Initial Catalog=CHUNGKHOAN;User ID=sa;Password=123";
        string dependencyCommand = "SELECT IDKHOP, NGAYKHOP, SOLUONGKHOP, GIAKHOP, IDLENHDAT FROM DBO.LENHKHOP";
        string commandDat = "SELECT * FROM LENHDAT";
        public SqlConnection connector;
        public delegate void SyncFunc();
        public event SyncFunc OnSyncFunc;

        public Form2()
        {
            InitializeComponent();
            InitDependency();
            LoadMaCK();
            LoadTableDat();
            ResetValues();
        }

        private void InitDependency()
        {
            SqlDependency.Start(connectionString);
            connector = new SqlConnection(connectionString);

            OnSyncFunc += new SyncFunc(Form2_OnSyncFunc);//tab
            //load data vao datagrid
            LoadDependencyTableKhop();
        }

        public void Form2_OnSyncFunc()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                SyncFunc dd = new SyncFunc(Form2_OnSyncFunc);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadDependencyTableKhop();
        }

        //Ham load data
        void LoadDependencyTableKhop()
        {
            DataTable dt = new DataTable();
            if (connector.State == ConnectionState.Closed)
            {
                connector.Open();
            }

            SqlCommand cmd = new SqlCommand(dependencyCommand, connector);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));

            dataGridViewKhop.DataSource = dt;
            dataGridViewKhop.FirstDisplayedScrollingRowIndex = dataGridViewKhop.RowCount-1;
        }

        void LoadTableDat()
        {
            DataTable dt = new DataTable();
            if (connector.State == ConnectionState.Closed)
            {
                connector.Open();
            }

            SqlCommand cmd = new SqlCommand(commandDat, connector);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridViewDat.DataSource = dt;
            dataGridViewDat.FirstDisplayedScrollingRowIndex = dataGridViewDat.RowCount-1;
        }

        void ResetValues()
        {
            numericUpDownGia.Value = 0;
            numericUpDownKL.Value = 0;
            comboBoxMaCK.SelectedIndex = comboBoxMaCK.Items.Count > 0 ? 0 : -1;
            comboBoxLenh.SelectedIndex = 0;
            comboBoxMuaBan.SelectedIndex = 0;
        }

        bool CheckInsertValues()
        {
            bool ret = true;
            string alert = "";

            if (numericUpDownGia.Value < 10)
            {
                ret = false;
                alert += "[Giá đặt] không được dưới 10.000VND \n";
            }

            if (numericUpDownKL.Value < 100)
            {
                ret = false;
                alert += "[Khối lượng] không được dưới 100\n";
            }

            if (!ret)
                MessageBox.Show(alert, "Lệnh sai quy định");

            return ret;
        }

        void LoadMaCK()
        {
            comboBoxMaCK.Items.Clear();

            if (connector.State == ConnectionState.Closed)
            {
                connector.Open();
            }

            string sql = "SELECT MACK FROM BANGGIATRUCTUYEN";
            SqlCommand cmd = new SqlCommand(sql, connector);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxMaCK.Items.Add(reader.GetString(0));
            }

            connector.Close();
        }

        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;

            if (OnSyncFunc != null)
            {
                OnSyncFunc();
            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            if (!CheckInsertValues())
                return;

            string sql = "INSERT INTO LENHDAT (MACP,LOAIGD,LOAILENH,SOLUONG,GIADAT,TRANGTHAILENH) VALUES (@ma,@loai,@lenh,@sl,@gia,@stt)";
            if (connector.State == ConnectionState.Closed)
            {
                connector.Open();
            }

            SqlCommand cmd = new SqlCommand(sql, connector);
            cmd.Parameters.AddWithValue("@ma", comboBoxMaCK.Text);
            cmd.Parameters.AddWithValue("@loai", comboBoxMuaBan.Text[0]);
            cmd.Parameters.AddWithValue("@lenh", comboBoxLenh.Text);
            cmd.Parameters.AddWithValue("@sl", Convert.ToInt32(numericUpDownKL.Value));
            cmd.Parameters.AddWithValue("@gia", Convert.ToSingle(numericUpDownGia.Value * 1000));
            cmd.Parameters.AddWithValue("@stt", "Chờ khớp");

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đặt lệnh thành công");
                LoadTableDat();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}

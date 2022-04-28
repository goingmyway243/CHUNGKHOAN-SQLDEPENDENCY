using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CHUNGKHOAN
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-IGPUUV0;Initial Catalog=CHUNGKHOAN;User ID=sa;Password=123";
        string dependencyCommand = "SELECT MACK,GIAMUA3,KLMUA3,GIAMUA2,KLMUA2,GIAMUA1,KLMUA1," +
                "GIAMOINHAT,KLMOINHAT," +
                "GIABAN1,KLBAN1,GIABAN2,KLBAN2,GIABAN3,KLBAN3,TONGKL FROM DBO.BANGGIATRUCTUYEN";
        public SqlConnection connector;
        public delegate void SyncFunc();
        public event SyncFunc OnSyncFunc;
        public Form1()
        {
            InitializeComponent();
            InitDependency();
        }

        private void InitDependency()
        {
            SqlDependency.Start(connectionString);
            connector = new SqlConnection(connectionString);

            OnSyncFunc += new SyncFunc(Form1_OnSyncFunc);//tab
            //load data vao datagrid
            LoadData();
        }

        public void Form1_OnSyncFunc()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                SyncFunc dd = new SyncFunc(Form1_OnSyncFunc);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();
        }

        //Ham load data
        void LoadData()
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
            int index = 0;
            if (dataGridView.FirstDisplayedCell != null)
                index = dataGridView.FirstDisplayedCell.RowIndex;

            dataGridView.DataSource = dt;
            dataGridView.FirstDisplayedScrollingRowIndex = index;
            customColumn();
        }

        private void customColumn()
        {
            // MACK
            dataGridView.Columns["MACK"].HeaderText = "Mã CK";
            dataGridView.Columns["MACK"].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
            // MUA
            dataGridView.Columns["GIAMUA3"].HeaderText = "Giá mua 3";
            dataGridView.Columns["GIAMUA3"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            dataGridView.Columns["KLMUA3"].HeaderText = "KL mua 3";
            dataGridView.Columns["KLMUA3"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            dataGridView.Columns["GIAMUA2"].HeaderText = "Giá mua 2";
            dataGridView.Columns["GIAMUA2"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            dataGridView.Columns["KLMUA2"].HeaderText = "KL mua 2";
            dataGridView.Columns["KLMUA2"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            dataGridView.Columns["GIAMUA1"].HeaderText = "Giá mua 1";
            dataGridView.Columns["GIAMUA1"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            dataGridView.Columns["KLMUA1"].HeaderText = "KL mua 1";
            dataGridView.Columns["KLMUA1"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            // MOINHAT
            dataGridView.Columns["GIAMOINHAT"].HeaderText = "Giá mới nhất";
            dataGridView.Columns["GIAMOINHAT"].DefaultCellStyle.BackColor = System.Drawing.Color.Salmon;
            dataGridView.Columns["KLMOINHAT"].HeaderText = "KL mới nhất";
            dataGridView.Columns["KLMOINHAT"].DefaultCellStyle.BackColor = System.Drawing.Color.Salmon;
            // BAN
            dataGridView.Columns["GIABAN1"].HeaderText = "Giá bán 1";
            dataGridView.Columns["GIABAN1"].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            dataGridView.Columns["KLBAN1"].HeaderText = "KL bán 1";
            dataGridView.Columns["KLBAN1"].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            dataGridView.Columns["GIABAN2"].HeaderText = "Giá bán 2";
            dataGridView.Columns["GIABAN2"].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            dataGridView.Columns["KLBAN2"].HeaderText = "KL bán 2";
            dataGridView.Columns["KLBAN2"].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            dataGridView.Columns["GIABAN3"].HeaderText = "Giá bán 3";
            dataGridView.Columns["GIABAN3"].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            dataGridView.Columns["KLBAN3"].HeaderText = "KL bán 3";
            dataGridView.Columns["KLBAN3"].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            //TONGKL
            dataGridView.Columns["TONGKL"].HeaderText = "Tổng KL";
            dataGridView.Columns["TONGKL"].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
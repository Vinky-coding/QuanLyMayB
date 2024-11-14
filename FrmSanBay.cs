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

namespace QuanLiSanBay
{
    public partial class FrmSanBay : Form
    {
        class KetNoi
        {
            string conStr = @"Data Source=LAPTOP-R05C93UB;Initial Catalog=MayBay;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            SqlConnection conn;
            public KetNoi() => conn = new SqlConnection(conStr);
            public DataSet LayDuLieu(string truyvan)
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                    da.Fill(ds);
                    return ds;
                }
                catch
                {
                    return null;
                }
            }
            public bool ThucThi(string truyvan)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(truyvan, conn);
                    int r = cmd.ExecuteNonQuery();
                    conn.Close();
                    return r > 0;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
        public FrmSanBay()
        {
            InitializeComponent(); getData();
        }
        KetNoi kn = new KetNoi();
        private void FrmSanBay_Load(object sender, EventArgs e)
        { 
            getData();
        }
        public void clearText()
        {
            txtMamb.Enabled = true;
            btnThem.Enabled = true;
            
            txtMamb.Text = "";
            txtTenmb.Text = "";
          
            txtNam.Text = "";
            txtSogio.Text = "";
           
        }

        public void getData()
        {
            string query = "SELECT * FROM Maybay";
            DataSet ds = kn.LayDuLieu(query);
            if (ds != null)
            {
                dgvMaybay.DataSource = ds.Tables[0];
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMamb.Enabled = false;
                btnThem.Enabled = false;
                
                txtMamb.Text = dgvMaybay.Rows[r].Cells["MaSP"].Value.ToString();
                txtTenmb.Text = dgvMaybay.Rows[r].Cells["Ten"].Value.ToString();
                txtNam.Text = dgvMaybay.Rows[r].Cells["DonGia"].Value.ToString();
                txtSogio.Text = dgvMaybay.Rows[r].Cells["HinhAnh"].Value.ToString();
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                 "insert into SanPham VALUES('{0}', N'{1}', {2}, N'{3}')",
                 txtMamb.Text,
                 txtTenmb.Text,
                 txtNam.Text,
                 txtSogio.Text
                 
             );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                button1.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }
    }
}

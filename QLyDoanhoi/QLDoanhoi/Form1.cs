using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace QLDoanhoi
{
    public partial class frmChuongTrinh : Form
    {
        string cnStr;  
        SqlConnection cn;

        public frmChuongTrinh() 
        {
            InitializeComponent();
        }

        private void frmChuongTrinh_Load(object sender, EventArgs e)
        {
            cnStr = @"Server = .; Database = QLBanhang; Integrated security = true"; 
            cn = new SqlConnection(cnStr);
            dgvChuongtrinh.DataSource = GetChuongTrinh().Tables[0];
        }
    
    


        private void Connect()
        {
            try
            {
                if (cn.State == ConnectionState.Closed && cn != null)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Disconnect()
        {
            if (cn.State == ConnectionState.Open && cn != null)
            {
                cn.Close();
            }
        }

        public List<ChuongTrinh> GetChuongTrinh()
        {
            Connect();
            List<ChuongTrinh> list = new List<ChuongTrinh>();
            try
            {
                string sql = "SELECT * FROM ChuongTrinh";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                string MaCT, TenCT, CapDoCT, ThoiGianBD; 
                while (dr.Read())
                {
                    MaCT = dr.GetString(0);
                    TenCT = dr.GetString(1);
                    CapDoCT = dr.GetString(2);
                    ThoiGianBD = dr.GetString(3);

                    ChuongTrinh ctr = new ChuongTrinh( MaCT, TenCT, CapDoCT, ThoiGianBD);
                    list.Add(ctr);
                }
                dr.Close();
            }
            
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "uspAddChuongTrinh";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCT", txtMa.Text));
                cmd.Parameters.Add(new SqlParameter("@TenCT", txtTen.Text));
                cmd.Parameters.Add(new SqlParameter("@CapDoCT", txtCapDo.Text));
                cmd.Parameters.Add(new SqlParameter("@ThoiGianBD", txtThoiGian.Text));
                int numOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show("Chương trình đã thêm: " + numOfRows);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            } 
            finally
            {
                Disconnect();
            }
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        Connect();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "uspAddChuongTrinh";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaCT", txtMa.Text));
                cmd.Parameters.Add(new SqlParameter("@TenCT", txtTen.Text));
                cmd.Parameters.Add(new SqlParameter("@CapDoCT", txtCapDo.Text));
                cmd.Parameters.Add(new SqlParameter("@ThoiGianBD", txtThoiGian.Text));
                int numOfRows = cmd.ExecuteNonQuery();
                MessageBox.Show("Chương trình đã thêm: " + numOfRows);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                Disconnect();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                Disconnect();
            }

        }
    }
     

       



        
        
         
         

       
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.Office.Tools.Excel;
using QUANLYKHOHANG;


namespace QUANLYKHOHANG
{
    public partial class FmSanPham : Form
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True");
        SQL dt = new SQL();
        SqlCommand cmd;
        Modify modify = new Modify();
        string ImageName = "";
        public FmSanPham()
        {
            InitializeComponent();
            _cnn.Open();
        }
        void LoadComBoxNCC()
        {

            var cmd = new SqlCommand("select MA_NCC from NHA_CUNG_CAP", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaNCC.DisplayMember = "MA_NCC";
            cmMaNCC.DataSource = dt;

        }
        void LoadComBoxKHO()
        {

            var cmd = new SqlCommand("select MAKHO from KHO_HANG", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaKho.DisplayMember = "MAKHO";
            cmMaKho.DataSource = dt;

        }
        void LoadComBoxLSP()
        {

            var cmd = new SqlCommand("select MALOAI from LOAISP", _cnn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmMaLSp.DisplayMember = "MALOAI";
            cmMaLSp.DataSource = dt;

        }

        private void FmSanPham_Load(object sender, EventArgs e)
        {
            LoadComBoxNCC();
            LoadComBoxKHO();
            LoadComBoxLSP();
            //string stringconn = @"Data Source=LAPTOP-OJDSJCBC;Initial Catalog=QUANLYKHOHANG;Integrated Security=True";
            //SqlConnection sqlconn = new SqlConnection(stringconn);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataAdapter sda = new SqlDataAdapter();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "danhsachsanpham";
            //cmd.Connection = sqlconn;
            //sda.SelectCommand = cmd;
            //DataTable da = new DataTable();
            //sda.Fill(da);
            //DataSanPham.DataSource = da;
            DataSanPham.DataSource = modify.DataTable("select * from SAN_PHAM");
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)DataSanPham.Columns[10];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataSanPham.DataSource = dt.LoadSP();
        }

        private void txtPhanLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            this.errorProvider1.Clear();
        }

        private void txtSoLuongSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHinh_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.ipeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

            }

        }
        SANPHAM sanpham;
        private void GetValue()
        {
            string masp = txtMaSp.Text;
            string mancc = cmMaNCC.Text;
            string TenSp = txtTenSp.Text;
            DateTime NgaySX = dateNSX.Value;
            DateTime HSD = dateHSD.Value;
            string SoLuong = txtSoLuong.Text;
            string maloaisp = cmMaLSp.Text;
            string gia = txtGiaSp.Text;
            string ghichu = txtGhiChuSp.Text;
            string makho = cmMaKho.Text;
            byte[] anh = ImageToByArray(pictureBox1);
            sanpham = new SANPHAM(masp, mancc, TenSp, NgaySX, HSD, SoLuong, maloaisp, gia, ghichu, makho, anh);
        }
        private byte[] ImageToByArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            return ms.ToArray();
        }

        private void DataSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSp.Text = DataSanPham.SelectedRows[0].Cells[0].Value.ToString();
            cmMaNCC.Text = DataSanPham.SelectedRows[0].Cells[1].Value.ToString();
            txtTenSp.Text = DataSanPham.SelectedRows[0].Cells[2].Value.ToString();
            cmMaLSp.Text = DataSanPham.SelectedRows[0].Cells[3].Value.ToString();
            dateNSX.Text = DataSanPham.SelectedRows[0].Cells[4].Value.ToString();
            dateHSD.Text = DataSanPham.SelectedRows[0].Cells[5].Value.ToString();
            txtSoLuong.Text = DataSanPham.SelectedRows[0].Cells[6].Value.ToString();
            txtGiaSp.Text = DataSanPham.SelectedRows[0].Cells[7].Value.ToString();
            txtGhiChuSp.Text = DataSanPham.SelectedRows[0].Cells[8].Value.ToString();
            cmMaKho.Text = DataSanPham.SelectedRows[0].Cells[9].Value.ToString();
            if (DataSanPham.SelectedRows[0].Cells[10].Value.ToString() != "")
            {
                MemoryStream ms = new MemoryStream((byte[])DataSanPham.SelectedRows[0].Cells[10].Value);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.ipeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

            }
        }

       
        private void btnThemSp_Click(object sender, EventArgs e)
        {
            btnXoaSp.Enabled = true;
            btnSuaSP.Enabled = true;
            btnInThongKe.Enabled = true;
            btnAnh.Enabled = true;
            errorProvider1.SetError(txtMaSp, "Bạn Chưa Nhập Mã Sản Phẩm");
            errorProvider1.SetError(cmMaNCC, "Bạn Chưa Chọn Mã Nhà Cung Cấp");
            errorProvider1.SetError(txtTenSp, "Bạn Chưa Nhập Tên Sản Phẩm");
            errorProvider1.SetError(cmMaLSp, "Bạn Chưa Chọn Mã Loại Sản Phẩm");
            errorProvider1.SetError(txtSoLuong, "Bạn Chưa Nhập Số Lượng Sản Phẩm");
            errorProvider1.SetError(txtGiaSp, "Bạn Chưa Nhập Giá Sản Phẩm");
            errorProvider1.SetError(cmMaKho, "Bạn Chưa Nhập Mã Kho Hàng");
            if (MessageBox.Show("Bạn có chắc chắn thêm không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string query = "insert into SAN_PHAM values (@MA_SP,@MA_NCC,@TEN_SP,@NGAYSX,@HSD,@SOLUONG_SP,@MALOAI,@GIA,@GHICHU_SP,@MAKHO,@ANH)";
                try
                {
                    GetValue();
                    modify.Command(sanpham, query);
                    MessageBox.Show("Thêm Thành Công");
                    FmSanPham_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm:" + ex.Message);

                }
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string query = "update SAN_PHAM set ANH= @ANH , MA_SP= '" + txtMaSp.Text + "',MA_NCC= '" + cmMaNCC.Text + "', TEN_SP='" + txtTenSp.Text + "', NGAYSX= '" + dateNSX.Value.ToString("yyyy-MM-dd") + "',HSD= '" + dateHSD.Value.ToString("yyyy-MM-dd") + "' ,SOLUONG_SP= '" + txtSoLuong.Text + "' ,MALOAI= '" + cmMaLSp.Text + "',GIA= '" + txtGiaSp.Text + "', GHICHU_SP= '" + txtGhiChuSp.Text + "'where MAKHO= '" + cmMaKho.Text + "'";
                try
                {
                    GetValue();
                    modify.Command(sanpham, query);
                    MessageBox.Show("SửaThành Công");
                    FmSanPham_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thêm:" + ex.Message);
                }
            }
        }

        private void btnXoaSp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn Xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string choose = DataSanPham.SelectedRows[0].Cells[0].Value.ToString();
                if (DataSanPham.Rows.Count > 1)
                {
                    string query = "DELETE SAN_PHAM ";
                    query += "where MA_SP= '" + choose + "'";
                    try
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        {
                            GetValue();
                            modify.Command(sanpham, query);
                            MessageBox.Show("Xóa Thành Công");
                            FmSanPham_Load(sender, e);
                        }
                        else
                            return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm:" + ex.Message);
                    }
                }
            }
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataColumn clo1 = new DataColumn("Mã Sp");
            DataColumn clo2 = new DataColumn("Mã NCC");
            DataColumn clo3 = new DataColumn("Tên Sp");
            DataColumn clo4 = new DataColumn("Mã Kho");
            DataColumn clo5 = new DataColumn("Ngày Sản Xuất");
            DataColumn clo6 = new DataColumn("Hạn Sử Dụng");
            DataColumn clo7 = new DataColumn("Số lượng");
            DataColumn clo8 = new DataColumn("Mã loại SP");
            DataColumn clo9 = new DataColumn("Giá");
            DataColumn clo10 = new DataColumn("Ghi Chú");
            DataColumn clo11 = new DataColumn("Ảnh");

            dataTable.Columns.Add(clo1);
            dataTable.Columns.Add(clo2);
            dataTable.Columns.Add(clo3);
            dataTable.Columns.Add(clo4);
            dataTable.Columns.Add(clo5);
            dataTable.Columns.Add(clo6);
            dataTable.Columns.Add(clo7);
            dataTable.Columns.Add(clo8);
            dataTable.Columns.Add(clo9);
            dataTable.Columns.Add(clo10);
            dataTable.Columns.Add(clo11);
            foreach (DataGridViewRow dtgRow in DataSanPham.Rows)
            {
                DataRow dtrow = dataTable.NewRow();
                dtrow[0] = dtgRow.Cells[0].Value;
                dtrow[1] = dtgRow.Cells[1].Value;
                dtrow[2] = dtgRow.Cells[2].Value;
                dtrow[3] = dtgRow.Cells[3].Value;
                dtrow[4] = dtgRow.Cells[4].Value;
                dtrow[5] = dtgRow.Cells[5].Value;
                dtrow[6] = dtgRow.Cells[6].Value;
                dtrow[7] = dtgRow.Cells[7].Value;
                dtrow[8] = dtgRow.Cells[8].Value;
                dtrow[9] = dtgRow.Cells[9].Value;
                dtrow[10] = dtgRow.Cells[10].Value;
                dataTable.Rows.Add(dtrow);
            }
            ExportFile(dataTable, "Danh Sách", "DANH SÁCH SẢN PHẨM");
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Sản Phẩm";

            cl1.ColumnWidth = 14.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã NCC";

            cl2.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Mã Kho";
            cl3.ColumnWidth = 10.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Tên Sản Phẩm";

            cl4.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Ngày sản xuất";

            cl5.ColumnWidth = 17.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Hạn Sử Dụng";

            cl6.ColumnWidth = 17.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Số lượng";

            cl7.ColumnWidth = 10.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Mã Loại SP";

            cl8.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Giá";

            cl9.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

            cl10.Value2 = "Ghi Chú";

            cl10.ColumnWidth = 34.0;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

            cl11.Value2 = "Ảnh";

            cl11.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "K3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnTKn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.ipeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

            }
        }
    }
}

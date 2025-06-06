﻿using CMS.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Drawing;
using System.IO;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;

namespace CMS.UTIL
{
    public class UTIL
    {
        //hàm show dữ liệu lên DataGridView
        public static void showDataToDataGridview(DataGridView dataGridView, string chuoiQuery, string[] headTitle)
        {
            using (SqlConnection c = new SqlConnection(DAL.sqlDatabase.getConnectString()))
            {
                // tạo đối tượng đưa data vào bảng = class sqlDatabase gọi hàm lấy kết nối sqlConnection getConnection();
                using (SqlDataAdapter sql_DataAdapter = new SqlDataAdapter(chuoiQuery, c))
                {
                    //tạo đối tượng  DataTable để lưu tạm thời kết quả truy vấn sql trước khi đưa lên dataGridView
                    DataTable dataTable = new DataTable();

                    //làm sạch DataTable trước khi đổ dữ liệu vào
                    dataTable.Clear();

                    //đổ dữ liệu từ kết quả truy vấn sql vào một bảng dữ liệu trong bộ nhớ dataTable
                    sql_DataAdapter.Fill(dataTable);

                    //Gán DataGridView = null trước khi đưa dữu liệu vào
                    dataGridView.DataSource = null;

                    //Đưa dữ liệu lên DataGridView
                    dataGridView.DataSource = dataTable;

                    //dặt tên tiêu đề cột
                    for (int i = 0; i < headTitle.Length; i++)
                    {
                        dataGridView.Columns[i].HeaderText = headTitle[i];
                    }

                    //tự động chỉnh size
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //canh giữa header 
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
        }
        // Hàm đưa dữ liệu từ kết quả truy vấn SQL vào ComboBox
        public static void AddDataToComboBoxWithSQLQuery(string query, ComboBox comboBox, string columnName)
        {
            // Kiểm tra xem query, connectionString và ComboBox có null hoặc rỗng không
            if (string.IsNullOrEmpty(query) || comboBox == null)
            {
                return; // Thoát hàm nếu tham số không hợp lệ
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DAL.sqlDatabase.getConnectString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa các mục hiện có trong ComboBox
                    comboBox.Items.Clear();

                    // Lặp qua từng dòng trong kết quả truy vấn
                    while (reader.Read())
                    {
                        // Lấy giá trị từ cột được chỉ định bởi columnName
                        string value = reader[columnName].ToString();

                        // Thêm giá trị vào ComboBox
                        comboBox.Items.Add(value);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // hàm dành cho event CellClick của Datagridview: lấy dữ liệu từ Datagridview lên textbox
        public static void getDataFromDatagridviewFillTextbox(TextBox textbox, DataGridView dataGridView, int collum, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textbox.Text = dataGridView.Rows[e.RowIndex].Cells[collum].Value.ToString();
            }
        }
        // hàm dành cho event CellClick của Datagridview: lấy dữ liệu từ Datagridview lên date time picker
        public static void getDataFromDatagridviewFillDateTimePicker(DateTimePicker dateTimePicker, DataGridView dataGridView, int column, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView.Rows[e.RowIndex].Cells[column].Value != null && dataGridView.Rows[e.RowIndex].Cells[column].Value != DBNull.Value)
                {
                    try
                    {
                        // Lấy giá trị từ ô trong DataGridView và chuyển đổi sang DateTime
                        DateTime selectedDateTime = Convert.ToDateTime(dataGridView.Rows[e.RowIndex].Cells[column].Value);

                        // Gán giá trị DateTime vào DateTimePicker
                        dateTimePicker.Value = selectedDateTime;
                    }
                    catch (FormatException ex)
                    {
                        // Xử lý lỗi nếu giá trị trong ô không phải là DateTime hợp lệ
                        MessageBox.Show("Giá trị trong cột không phải là định dạng ngày giờ hợp lệ. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý các lỗi khác
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Xử lý trường hợp giá trị trong ô là null hoặc DBNull
                    MessageBox.Show("Ô dữ liệu trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // hàm dành cho event CellClick của Datagridview: lấy dữ liệu từ Datagridview lên COMBOBOX
        public static void getDataFromDatagridviewFillCombobox(ComboBox comboBox, DataGridView dataGridView, int collum, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboBox.SelectedItem = dataGridView.Rows[e.RowIndex].Cells[collum].Value.ToString();
            }
        }
        //hàm cho sự kiện keyPress chỉ cho nhập số
        public static void Textbox_KeyPress_OnlyNumber(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự vừa nhập có phải là số hoặc các phím điều khiển đặc biệt không
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải số và không phải phím điều khiển, hủy bỏ sự kiện KeyPress
                e.Handled = true;
            }
        }
        //hàm cho sự kiện keyPress chỉ cho nhập giới hạn số lượng ký tự
        public static void Textbox_KeyPress_LimitChar(object sender, KeyPressEventArgs e, int count)
        {
            TextBox textBox = (TextBox)sender;
            // Kiểm tra xem độ dài văn bản hiện tại đã đạt đến giới hạn (count ký tự) hay chưa
            if (textBox.Text.Length >= count && !char.IsControl(e.KeyChar))
            {
                // Nếu đã đạt giới hạn và ký tự vừa nhập không phải là phím điều khiển,
                // thì hủy bỏ sự kiện KeyPress, ngăn không cho ký tự được nhập vào TextBox.
                e.Handled = true;
            }
        }
        //Hàm chèn ảnh vào control
        public static void fillImgToControl(object control, byte[] resourceBytes)
        {
            using (var ms = new MemoryStream(resourceBytes))
            {
                var img = new Bitmap(ms);
                switch (control)
                {
                    case System.Windows.Forms.Button btn: btn.Image = img; break;
                    case Guna.UI2.WinForms.Guna2Button gBtn: gBtn.Image = img; break;
                    case Guna.UI2.WinForms.Guna2CircleButton cBtn: cBtn.Image = img; break;
                    case System.Windows.Forms.ToolStripMenuItem menu: menu.Image = img; break;
                    case System.Windows.Forms.PictureBox pb: pb.Image = img; break;
                    default: throw new ArgumentException(LanguageManager.GetString("ControlNotSupported"));
                }
            }
        }
        //Hàm thiết lập ngôn ngữ
        public static void SetFormLanguage()
        {
            LanguageManager.SetLanguage(Language.Lang == "vn" ? "vi-VN" : "en-US");
        }
        // Hàm hiển thị MessageBox đa ngôn ngữ
        public static DialogResult ShowMessage(string messageKey, string titleKey, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            string message = LanguageManager.GetString(messageKey);
            string title = LanguageManager.GetString(titleKey);
            return MessageBox.Show(message, title, buttons, icon);
        }
        //Hàm làm mở ảnh nền
        public static Bitmap MakeImageTransparent(Bitmap originalImage, float opacity)
        {
            // Tạo một Bitmap mới với cùng kích thước
            Bitmap blurredImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(blurredImage))
            {
                // Tạo một ColorMatrix để điều chỉnh độ trong suốt
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // Độ trong suốt (0.0f = hoàn toàn trong suốt, 1.0f = không trong suốt)

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Vẽ ảnh gốc lên ảnh mới với độ trong suốt
                g.DrawImage(originalImage,
                    new Rectangle(0, 0, blurredImage.Width, blurredImage.Height),
                    0, 0, originalImage.Width, originalImage.Height,
                    GraphicsUnit.Pixel, attributes);
            }
            return blurredImage;
        }
    }
}
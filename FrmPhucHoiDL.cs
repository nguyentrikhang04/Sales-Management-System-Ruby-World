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

namespace _4196_NguyenTriKhang_KLTN_
{
    public partial class FrmPhucHoiDL : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-168ITQ3D;Initial Catalog=QLRBW;User ID=sa;Password=123;Encrypt=False;TrustServerCertificate=True");
        public FrmPhucHoiDL()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                backupButton.Enabled = true;
            }
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập Nơi lưu trữ File Sao Lưu");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK= '" + textBox1.Text + "\\" + "QLRBW" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Dữ liệu Sao Lưu thành công!!");
                con.Close();
                backupButton.Enabled = false;
            }
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Databse restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                restoreButton.Enabled = true;
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();

            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox2.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Dữ liệu phục hồi thành công!!");
                con.Close();
            }
            catch
            {

            }
        }
    }
}

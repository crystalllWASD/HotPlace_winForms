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

namespace HotPleasure_winForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateData();
        }

        void Connection(string arg, DataGridView dataGridView)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader sdr;
            DataTable table;
            DataRow row;
            string cs;
            table = new DataTable();
            cs = "Data Source=DESKTOP-R13SFHK\\SQLEXPRESS01; Initial Catalog=HotPlace; User=DESKTOP-R13SFHK\\crystalll; Integrated Security=SSPI";
            con = new SqlConnection(cs);
            con.Open();
            cmd = new SqlCommand($"{arg}", con);
            sdr = cmd.ExecuteReader();
            bool flag = true;
            while (sdr.Read())
            {
                if (flag)
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        table.Columns.Add(sdr.GetName(i));
                    }
                    flag = false;
                }
                row = table.NewRow();
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    row[i] = sdr[i];
                }
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
            con.Close();
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                AddClean();
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                DelClean();
            }
        }

        void AddClean()
        {
            int rowIndex = FreeDGV.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(FreeDGV.Rows[rowIndex].Cells["ID"].Value);

            string cs = "Data Source=DESKTOP-R13SFHK\\SQLEXPRESS01; Initial Catalog=HotPlace; User=DESKTOP-R13SFHK\\crystalll; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE HotelNumber SET statusnumberID = @statusId WHERE id = @id", con))
                {
                    cmd.Parameters.Add("@statusId", SqlDbType.Int).Value = 3;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
            UpdateData();
        }

        void DelClean()
        {
            int rowIndex = cleanerDGV.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(cleanerDGV.Rows[rowIndex].Cells["ID"].Value);

            string cs = "Data Source=DESKTOP-R13SFHK\\SQLEXPRESS01; Initial Catalog=HotPlace; User=DESKTOP-R13SFHK\\crystalll; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE HotelNumber SET statusnumberID = @statusId WHERE id = @id", con))
                {
                    cmd.Parameters.Add("@statusId", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
            UpdateData();
        }

        private void UpdateData()
        {
            Connection("SELECT HotelNumber.place AS Номер, HotelNumber.[floor] AS Этаж, StatusNumber.[status] AS Статус, HotelNumber.id AS ID FROM HotelNumber INNER JOIN StatusNumber ON HotelNumber.statusnumberID = StatusNumber.id WHERE StatusNumber.id = 1", FreeDGV);
            Connection("SELECT Visitor.surname AS Фамилия, Visitor.[name] AS Имя, Visitor.patronymic AS Отчество, HotelNumber.dateFrom AS Дата_С, HotelNumber.dateTo AS Дата_До, HotelNumber.place AS Номер, HotelNumber.[floor] AS Этаж, StatusNumber.[status] AS Статус, HotelNumber.id AS ID FROM HotelNumber INNER JOIN StatusNumber ON HotelNumber.statusnumberID = StatusNumber.id INNER JOIN Visitor ON HotelNumber.visitorId = Visitor.id", bookDGV);
            Connection("SELECT HotelNumber.place AS Номер, HotelNumber.[floor] AS Этаж, StatusNumber.[status] AS Статус, HotelNumber.id AS ID FROM HotelNumber INNER JOIN StatusNumber ON HotelNumber.statusnumberID = StatusNumber.id WHERE StatusNumber.id = 4", paymentDGV);
            Connection("SELECT HotelNumber.place AS Номер, HotelNumber.[floor] AS Этаж, StatusNumber.[status] AS Статус, HotelNumber.id AS ID FROM HotelNumber INNER JOIN StatusNumber ON HotelNumber.statusnumberID = StatusNumber.id WHERE StatusNumber.id = 3", cleanerDGV);
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}

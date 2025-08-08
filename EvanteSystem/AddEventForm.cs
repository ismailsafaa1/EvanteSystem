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

namespace EvanteSystem
{
    public partial class AddEventForm : Form
    {
        public AddEventForm()
        {
            InitializeComponent();
            dtStartTime.Format = DateTimePickerFormat.Time;
            dtEndTime.Format = DateTimePickerFormat.Time;
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtEndDate.Format = DateTimePickerFormat.Short;
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtEventName.Text;
            string desc = txtDescription.Text;
            string phone = txtPhone.Text;
            string location = txtLocationDesc.Text;

            DateTime start = dtStartDate.Value.Date + dtStartTime.Value.TimeOfDay;
            DateTime end = dtEndDate.Value.Date + dtEndTime.Value.TimeOfDay;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول المطلوبة.");
                return;
            }

            // الاتصال بقاعدة البيانات
            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);

            try
            {
                con.Open();
                string query = @"INSERT INTO Events 
                                (Name, Description, ContactPhone, StartDateTime, EndDateTime , LocationEvante)
                                VALUES (@Name, @Description, @Phone, @Start, @End,@location)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Start", start);
                cmd.Parameters.AddWithValue("@End", end);
                cmd.Parameters.AddWithValue("@location", location);

                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت إضافة الفعالية بنجاح!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MapForm f = new MapForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtLocationDesc.Text = f.SelectedLocation;
            }
        }
    }
}

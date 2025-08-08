using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;

namespace EvanteSystem
{
    public partial class StatsForm : Form
    {
       
        public StatsForm()
        {
            InitializeComponent();
            if (cmbEvents.SelectedValue != null && int.TryParse(cmbEvents.SelectedValue.ToString(), out int eventId))
            {
                LoadEventStats(eventId);
            }
        }
        private void LoadEventStats(int eventId)
        {
            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                // 1. عدد الدعوات
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Invitations WHERE EventID = @EID", con);
                cmd1.Parameters.AddWithValue("@EID", eventId);
                int totalInvites = (int)cmd1.ExecuteScalar();

                // 2. العدد الإجمالي للأشخاص المدعوين
                SqlCommand cmd2 = new SqlCommand("SELECT SUM(PeopleCount) FROM Invitations WHERE EventID = @EID", con);
                cmd2.Parameters.AddWithValue("@EID", eventId);
                object result2 = cmd2.ExecuteScalar();
                int totalGuests = result2 != DBNull.Value ? Convert.ToInt32(result2) : 0;

                // 3. الحضور الفعلي
                SqlCommand cmd3 = new SqlCommand(@"
            SELECT SUM(A.AttendedPeople)
            FROM Attendance A
            INNER JOIN Invitations I ON A.InvitationID = I.InvitationID
            WHERE I.EventID = @EID", con);
                cmd3.Parameters.AddWithValue("@EID", eventId);
                object result3 = cmd3.ExecuteScalar();
                int totalAttendance = result3 != DBNull.Value ? Convert.ToInt32(result3) : 0;

                // تحديث الليبلات
                lblTotalInvites.Text = $"عدد الدعوات: {totalInvites}";
                lblTotalGuests.Text = $"الإجمالي المسموح: {totalGuests}";
                lblTotalAttendance.Text = $"الحضور الفعلي: {totalAttendance}";
            }
        }

        private void LoadEvents()
        {
            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT EventID, Name FROM Events", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbEvents.DataSource = dt;
                cmbEvents.DisplayMember = "Name";
                cmbEvents.ValueMember = "EventID";
            }
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
            if (cmbEvents.SelectedValue != null && int.TryParse(cmbEvents.SelectedValue.ToString(), out int eventId))
            {
                LoadEventStats(eventId);
            }
        }

        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEvents.SelectedValue != null && int.TryParse(cmbEvents.SelectedValue.ToString(), out int selectedId))
            {
                LoadEventStats(selectedId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbEvents.SelectedValue != null && int.TryParse(cmbEvents.SelectedValue.ToString(), out int eventId))
            {
                LoadEventStats(eventId);
            }
        }

       
       
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
      
    }
}

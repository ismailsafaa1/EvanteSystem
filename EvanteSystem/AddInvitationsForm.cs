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
    public partial class AddInvitationsForm : Form
    {
        public AddInvitationsForm()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void AddInvitationsForm_Load(object sender, EventArgs e)
        {

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

        private void btnAddInvitation_Click(object sender, EventArgs e)
        {
            if (cmbEvents.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtGuestName.Text) || string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول");
                return;
            }

            int eventId = Convert.ToInt32(cmbEvents.SelectedValue);
            string guestName = txtGuestName.Text.Trim();
            int peopleCount = (int)numPeopleCount.Value;
            string code = txtCode.Text.Trim();

            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = @"INSERT INTO Invitations (EventID, GuestName, PeopleCount, QRCodeText)
                         VALUES (@EventID, @GuestName, @PeopleCount, @QRCodeText)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EventID", eventId);
                cmd.Parameters.AddWithValue("@GuestName", guestName);
                cmd.Parameters.AddWithValue("@PeopleCount", peopleCount);
                cmd.Parameters.AddWithValue("@QRCodeText", code);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تمت إضافة البطاقة بنجاح");
                LoadInvitations(eventId);
            }
        
    }
        private void LoadInvitations(int eventId)
        {
            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "SELECT GuestName, PeopleCount, QRCodeText FROM Invitations WHERE EventID = @EventID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EventID", eventId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInvitations.DataSource = dt;
            }
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            
                txtCode.Text = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
 
        }

        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

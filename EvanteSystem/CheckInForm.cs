using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace EvanteSystem
{   
    public partial class CheckInForm : Form
    {
         
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        public CheckInForm()
        {
            InitializeComponent();
        }
        private int invitationID = -1;
        private int allowedCount = 0;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            if (code == "") return;

            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = @"SELECT TOP 1 InvitationID, GuestName, PeopleCount 
                         FROM Invitations WHERE QRCodeText = @Code";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Code", code);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    invitationID = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    allowedCount = reader.GetInt32(2);
                    lblInfo.Text = $"الضيف: {name} - المسموح: {allowedCount}";
                    numGuests.Maximum = allowedCount;
                }
                else
                {
                    lblInfo.Text = "رمز غير صالح";
                }
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (invitationID == -1) return;
            

            int attended = (int)numGuests.Value;

            if (attended <= 0)
            {
                MessageBox.Show("عدد الحضور يجب أن يكون 1 على الأقل");
                return;
            }

            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();

                // تأكد أن الحضور لم يُسجل مسبقًا
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Attendance WHERE InvitationID = @ID", con);
                checkCmd.Parameters.AddWithValue("@ID", invitationID);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("تم تسجيل الحضور سابقًا");
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Attendance (InvitationID, AttendedPeople, CheckInTime) VALUES (@ID, @Count, @Time)", con);
                cmd.Parameters.AddWithValue("@ID", invitationID);
                cmd.Parameters.AddWithValue("@Count", attended);
                cmd.Parameters.AddWithValue("@Time", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم تسجيل الحضور");
            }

            invitationID = -1;
            lblInfo.Text = "";
            txtCode.Text = "";
            numGuests.Value = 1;
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            numGuests.Minimum = 1;
            numGuests.Value = 1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)PictureBox1.Image);
                if (result != null)
                {
                    txtCode.Text = result.Text;
                    timer1.Stop();
                    if (videoSource.IsRunning)
                        videoSource.SignalToStop();

                    // بعد قراءة الكود، ابحث عنه تلقائيًا واملأ بيانات الحضور
                    SearchInvitationByQRCode(result.Text);
                }
            }
        }
        private void SearchInvitationByQRCode(string qrCodeText)
        {
            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT InvitationID, GuestName, PeopleCount FROM Invitations WHERE QRCodeText = @Code", con);
                cmd.Parameters.AddWithValue("@Code", qrCodeText);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    invitationID = reader.GetInt32(0);
                    string guestName = reader.GetString(1);
                    int allowed = reader.GetInt32(2);

                    lblInfo.Text = $"الضيف: {guestName}, المسموح: {allowed}";
                    numGuests.Maximum = allowed;
                    numGuests.Minimum = 1;
                    numGuests.Value = allowed;
                }
                else
                {
                    MessageBox.Show("رمز غير صالح ❌");
                }
            }
        }
        private void btnStartCam_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString); // أول كاميرا

            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
            timer1.Start();
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            PictureBox1.Image = bitmap;
        }
    }
}

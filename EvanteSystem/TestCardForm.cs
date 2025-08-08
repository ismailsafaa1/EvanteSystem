using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvanteSystem
{
    public partial class TestCardForm : Form
    {
        public TestCardForm(string eventName, string guestName, string description,
                                  DateTime start, DateTime end, string organizer, string phone, string codeText ,string Location) 
        {
            InitializeComponent();

            // تعبئة البطاقة
            lblEventName.Text = eventName;
            lblGuestName.Text = $"السيد/ة: {guestName}";
            lblDescription.Text = description;
            lblDateTime.Text = $"الزمان: من {start:dd-MM-yyyy hh:mm tt} إلى {end:dd-MM-yyyy hh:mm tt}";
            lblOrganizer.Text = organizer;
            lblPhone.Text = $"للتواصل: {phone}";

            GenerateQRCode(codeText);
        }
        private void GenerateQRCode(string code)
        {
            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData data = qrGen.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(data);
            Bitmap qrImage = qrCode.GetGraphic(5);
            picQRCode.Image = qrImage;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox11.Text))
            {
                ShowInvitationCard(textBox11.Text.Trim());
            }
        }
        private void ShowInvitationCard(string codeText)
        {
            string conStr = @"Data Source=.;Initial Catalog=Evante;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = @"
            SELECT 
                E.Name AS EventName,
                I.GuestName,
                E.Description,
                E.StartDateTime,
                E.EndDateTime,
                E.ContactPhone,
                E.Name,
                I.QRCodeText
            FROM Invitations I
            INNER JOIN Events E ON I.EventID = E.EventID
            WHERE I.QRCodeText = @Code";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Code", codeText);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string eventName = reader["EventName"].ToString();
                    string guestName = reader["GuestName"].ToString();
                    string description = reader["Description"].ToString();
                    DateTime start = Convert.ToDateTime(reader["StartDateTime"]);
                    DateTime end = Convert.ToDateTime(reader["EndDateTime"]);
                    string phone = reader["ContactPhone"].ToString();
                    string organizer = reader["Name"].ToString(); // تأكد من وجود هذا العمود
                    string code = reader["QRCodeText"].ToString();
                    string Location = reader["LocationEvante"].ToString();

                    // مرر البيانات للفورم
                    TestCardForm f = new TestCardForm(
                        eventName,
                        guestName,
                        description,
                        start,
                        end,
                        organizer,
                        phone,
                        Location,
                        code
                    );
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على البطاقة");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveCardAsImage();
        }
        private void SaveCardAsImage()
        {
            Bitmap bmp = new Bitmap(guna2Panel1.Width, guna2Panel1.Height);
            guna2Panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
                MessageBox.Show("تم حفظ البطاقة بنجاح");
            }
        }

        private void TestCardForm_Load(object sender, EventArgs e)
        {
            // إعدادات عامة للنافذة
            this.Text = "نظام إيفانت - بطاقة الدعوة";
            this.Icon = Properties.Resources.AppIcon; // أضف أيقونة للتطبيق

            // تنسيق Guna2Panel الأساسي
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.ShadowDecoration.BorderRadius = 15;
            guna2Panel1.ShadowDecoration.Depth = 20;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.ShadowDecoration.Shadow = new Padding(0, 0, 5, 5);

            // تنسيق النصوص
            lblEventName.Font = new Font("Tajawal", 14, FontStyle.Bold);
            lblEventName.ForeColor = Color.FromArgb(33, 33, 33);

            lblGuestName.Font = new Font("Tajawal", 11);
            lblGuestName.ForeColor = Color.FromArgb(240, 240, 240);

            // إضافة أيقونات
            AddIcons();

            // تنسيق QR Code
            picQRCode.BackColor = Color.Transparent;
            picQRCode.SizeMode = PictureBoxSizeMode.StretchImage;

            // تنسيق الأزرار
            CustomizeButtons();
        }
        private void AddIcons()
        {
            // أيقونة التاريخ (استخدم FontAwesome أو صور مخصصة)
            var dateIcon = new PictureBox
            {
                Image = Properties.Resources.CalendarIcon, // استبدل بأيقونتك
                Size = new Size(16, 16),
                Location = new Point(lblDateTime.Left - 20, lblDateTime.Top + 3)
            };
            guna2Panel1.Controls.Add(dateIcon);

            // أيقونة الهاتف
            var phoneIcon = new PictureBox
            {
                Image = Properties.Resources.PhoneIcon,
                Size = new Size(16, 16),
                Location = new Point(lblPhone.Left - 20, lblPhone.Top + 3)
            };
            guna2Panel1.Controls.Add(phoneIcon);
        }
        private void CustomizeButtons()
        {
            // زر البحث
            button2.Text = "بحث";
            button2.Font = new Font("Tajawal", 10);
            button2.BackColor = Color.FromArgb(63, 81, 181);
            button2.ForeColor = Color.White;

            // زر الحفظ
            button1.Text = "حفظ البطاقة";
            button1.Font = new Font("Tajawal", 10);
            button1.BackColor = Color.FromArgb(76, 175, 80);
            button1.ForeColor = Color.White;


            // مربع النص
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.BackColor = Color.FromArgb(100,100,100);
            textBox11.Font = new Font("Tajawal", 10);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveCardAsImage();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox11.Text))
            {
                ShowInvitationCard(textBox11.Text.Trim());
            }
        }
    }
}

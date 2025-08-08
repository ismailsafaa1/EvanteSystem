using QRCoder;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace EvanteSystem
{
    public partial class InvitationCardForm : Form
    {
        public InvitationCardForm(string eventName, string guestName, string description,
                                  DateTime start, DateTime end, string organizer, string phone, string codeText , string Location)
        {
            InitializeComponent();
            // تعبئة البطاقة
            lblEventName.Text = eventName;
            lblGuestName.Text = $"السيد/ة: {guestName}";
            lblDescription.Text = description;
            lblDateTime.Text = $"الزمان: من {start:dd-MM-yyyy hh:mm tt} إلى {end:dd-MM-yyyy hh:mm tt}";
            lblOrganizer.Text = organizer;

            lblPhone.Text = $"للتواصل: {phone}";
            label2.Text = $"الموقع: {Location}";

            GenerateQRCode(codeText);

            // ألوان مشابهة للصور المقدمة
            lblEventName.ForeColor = Color.FromArgb(64, 64, 64);
            lblGuestName.ForeColor = Color.FromArgb(100, 100, 100);
            lblDateTime.ForeColor = Color.FromArgb(70, 70, 70);
            lblOrganizer.ForeColor = Color.FromArgb(0, 120, 215); // أزرق
            lblPhone.ForeColor = Color.FromArgb(80, 80, 80);

            // خطوط عربية (تأكد من تثبيت الخط مسبقاً)
            lblEventName.Font = new Font("Dubai", 14, FontStyle.Bold);
            lblGuestName.Font = new Font("Dubai", 11);
            lblDateTime.Font = new Font("Dubai", 10);
        }
        private void GenerateQRCode(string code)
        {
            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData data = qrGen.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(data);
            Bitmap qrImage = qrCode.GetGraphic(5);
            picQRCode.Image = qrImage;
        }
        private void SaveCardAsImage()
        {
            Bitmap bmp = new Bitmap(panelCard.Width, panelCard.Height);
            panelCard.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
                MessageBox.Show("تم حفظ البطاقة بنجاح");
            }
        }

        private void InvitationCardForm_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //SaveCardAsImage();
            SaveCardAsImage1();

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
                E.LocationEvante,
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
                    InvitationCardForm f = new InvitationCardForm(
                        eventName,
                        guestName,
                        description,
                        start,
                        end,
                        organizer,
                        phone,
                        code,
                        Location
                        
                    );
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على البطاقة");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ShowInvitationCard(textBox1.Text.Trim());
            }
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // رسم الخلفية مع زوايا مدورة
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 15;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (var brush = new SolidBrush(Color.White))
                {
                    g.FillPath(brush, path);
                }

                // إضافة ظل خارجي
                using (var shadow = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    shadow.AddPath(path, false);
                    using (var pen = new Pen(Color.FromArgb(50, 0, 0, 0), 5))
                    {
                        g.DrawPath(pen, shadow);
                    }
                }

                // إطار للبطاقة
                using (var pen = new Pen(Color.FromArgb(200, 200, 200), 1))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
        private void DrawCustomSeparator(Graphics g, Panel panel)
        {
            int y = lblDescription.Bottom + 10; // تحت الوصف مباشرة
            using (var pen = new Pen(Color.FromArgb(230, 230, 230), 2))
            {
                g.DrawLine(pen, 15, y, panel.Width - 15, y);
            }
        }

        private void SaveCardAsImage1()
        {
            Bitmap bmp = new Bitmap(panelCard.Width, panelCard.Height);
            panelCard.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            // قص الزوايا المدورة (اختياري)
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 15;
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(bmp.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(bmp.Width - radius, bmp.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, bmp.Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    g.SetClip(path);
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("تم حفظ البطاقة بنجاح");
            }
        }
    }
}

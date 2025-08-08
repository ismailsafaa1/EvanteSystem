using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvanteSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void ShowFormInPanel(Form form)
        {
            CenterPanel.Controls.Clear(); // تنظيف البانل أولاً

            form.TopLevel = false;             // مهم: لجعل الفورم يظهر كعنصر داخل الفورم الحالي
            form.FormBorderStyle = FormBorderStyle.None; // إزالة الإطار
            form.Dock = DockStyle.Fill;        // يملأ البانل بالكامل

            CenterPanel.Controls.Add(form);        // إضافة الفورم إلى البانل
            form.Show();                      // إظهار الفورم
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddEventForm f = new AddEventForm();
            ShowFormInPanel(f);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddInvitationsForm f = new AddInvitationsForm();
            ShowFormInPanel(f);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            // إما تمرر بيانات بطاقة ثابتة لتجربة التصميم
            InvitationCardForm f = new InvitationCardForm(
                "مهرجان الربيع",
                "محمد علي",
                "ندعوكم لحضور فعاليات مهرجان الربيع",
                DateTime.Now,
                DateTime.Now.AddHours(2),
                "لجنة التنظيم",
                "07800000000",
                "INV12345",
                "Iraq"

            );
            ShowFormInPanel(f);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CheckInForm f = new CheckInForm();
            ShowFormInPanel(f);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            StatsForm f = new StatsForm();
            ShowFormInPanel(f); 
            
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

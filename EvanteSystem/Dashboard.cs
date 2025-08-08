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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddEventForm f = new AddEventForm();
            f.ShowDialog(); // أو f.Show() إذا أردته غير معطل
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddInvitationsForm f = new AddInvitationsForm();
            f.ShowDialog();
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
                "Iraq",
                "INV12345"
            );
            f.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CheckInForm f = new CheckInForm();
            f.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            StatsForm f = new StatsForm();
            f.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            // إما تمرر بيانات بطاقة ثابتة لتجربة التصميم
            TestCardForm f = new TestCardForm(
                "مهرجان الربيع",
                "محمد علي",
                "ندعوكم لحضور فعاليات مهرجان الربيع",
                DateTime.Now,
                DateTime.Now.AddHours(2),
                "لجنة التنظيم",
                "07800000000",
                "Iraq",
                "INV12345"
            );
            f.ShowDialog();
        }

       
       

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;
using whw_WPF_EF_.db;

namespace whw_winformEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplicationContext db;
            db = new ApplicationContext();
            db.Users.Load();
            dataGridView1.DataSource = db.Users.Local.ToBindingList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
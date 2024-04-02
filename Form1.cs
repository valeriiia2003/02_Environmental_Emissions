using _02_Environmental_Emissions.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms;

namespace _02_Environmental_Emissions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            MainFormClass mainFormClass = new MainFormClass(this);
            using MyDataBaseContext db = new MyDataBaseContext();

            string usersinputText = searchcompany_window.Text;
            if (usersinputText != null)
            {
                mainFormClass.MainPageMethod(db, usersinputText);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 editForm = new Form2();
            editForm.Show();
        }

        private void filter_data_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 filterForm = new Form3();
            filterForm.Show();
        }
    }
}

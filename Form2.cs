using _02_Environmental_Emissions.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Environmental_Emissions
{
    public partial class Form2 : Form
    {
        private MyDataBaseContext myDataBaseContext;
        private UpdateDataGridView updateGridView;
        public Form2()
        {
            InitializeComponent();
            myDataBaseContext = new MyDataBaseContext();
            updateGridView = new UpdateDataGridView(this);
        }
        private void addNewSourseButton_Click(object sender, EventArgs e)
        {
            SourseEmission newElement = new EditFormClass(this)
                .ReturnNewTableElement(myDataBaseContext);

            myDataBaseContext.SourseEmissions.Add(newElement);
            myDataBaseContext.SaveChanges();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updateGridView.ShowInfoDataGridView(myDataBaseContext);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            updateGridView.UpdateInfo(myDataBaseContext);
        }

        private void mainMenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}

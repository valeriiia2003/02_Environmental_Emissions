using _02_Environmental_Emissions.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            MyDataBaseContext myDataBaseContext = new MyDataBaseContext();
            string usersInputSearch = sourse_search.Text;

            EmissionOperations emissionOperations = new EmissionOperations(this);
            emissionOperations.FilterSourseSearch(usersInputSearch,myDataBaseContext);
        }
    }
}

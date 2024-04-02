using _02_Environmental_Emissions.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Environmental_Emissions
{
    //This class is for adding a new emission case for any sourse
    public class EditFormClass
    {
        private Form2 form;
        public EditFormClass(Form2 f) => this.form = f;
        private int CreateEmissionCase(MyDataBaseContext baseContext)
        {
            string casesTypeFound = form.emission_name.Text;
            int query = 0;

            if (!string.IsNullOrEmpty(casesTypeFound))
            {

                query = baseContext.EmissionTypes
                    .Where(e => e.TypeName == casesTypeFound).Select(i => i.TypeId)
                    .FirstOrDefault();

                if (query < 1)
                    throw new Exception("Can not recognize an input value. No matches in the database");
            }

            return query;
        }
        private int GenerateSourseEmissionsId(MyDataBaseContext baseContext)
        {
            int lastTableElement = baseContext.SourseEmissions
                       .OrderByDescending(e => e.EmissionId)
                       .Select(e => e.EmissionId).FirstOrDefault();

            return lastTableElement + 1;
        }
        public SourseEmission ReturnNewTableElement(MyDataBaseContext baseContext)
        {
            var findCompanyOrSource = baseContext.Sourses
                 .Where(id => id.SourceId == Convert.ToInt32(form.sourse_number.Text)).Count();

            double value;
            if (findCompanyOrSource != 0 && double.TryParse(form.count_ems.Text, out value))
            {

                SourseEmission newUsersIndormation = new SourseEmission()
                {
                    EmissionId = GenerateSourseEmissionsId(baseContext),
                    SourseId = Convert.ToInt32(form.sourse_number.Text),
                    EmissionType = CreateEmissionCase(baseContext),
                    Quantity = Convert.ToDouble(form.count_ems.Text),
                    TextDesc = form.textDescription.Text,
                    SourceDate = DateTime.Now
                };

                return newUsersIndormation;
            }

            throw new Exception("It was some issues with adding values");
        }
    }
}

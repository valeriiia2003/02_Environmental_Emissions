using _02_Environmental_Emissions.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Environmental_Emissions
{
    //This class is a main form class just to see the whole list of 
    //possible emissions
    public class MainFormClass
    {
        private Form1 formToGetValues;

        public MainFormClass(Form1 form)
        {
            this.formToGetValues = form;
        }

        public void MainPageMethod(MyDataBaseContext myDataBaseContext, string companyName)
        {
            int findSourceQuery = myDataBaseContext.Sourses
                .Where(s => s.SourceName == companyName)
                .Count();

            if (findSourceQuery == 0)
                formToGetValues.notFoundMessage.Text = "There is no matching values for your search";

            var emissionTypesForCompany = myDataBaseContext.EmissionTypes
                .Join(
                    myDataBaseContext.SourseEmissions,
                    et => et.TypeId,
                    se => se.EmissionType,
                    (et, se) => new { EmissionType = et, SourceEmission = se }
                )
                .Join(
                    myDataBaseContext.Sourses,
                    joined => joined.SourceEmission.SourseId,
                    s => s.SourceId,
                    (joined, s) => new { EmissionType = joined.EmissionType, Source = s, SourseEmission = joined.SourceEmission }
                )
                .Where(joined => joined.Source.SourceName == companyName)
                .Select(joined => new
                {
                    Types = joined.EmissionType.TypeName,
                    Count = joined.SourseEmission.Quantity
                })
                .Distinct()
                .ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("EmissionType", typeof(string));
            dt.Columns.Add("Emission Quantity", typeof(double));

            foreach (var emissionType in emissionTypesForCompany)
            {
                dt.Rows.Add(emissionType.Types, emissionType.Count);
            }

            formToGetValues.gridViewMain.DataSource = dt;
        }
    }
}

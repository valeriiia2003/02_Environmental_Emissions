using _02_Environmental_Emissions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Environmental_Emissions
{
    //This class is to search for an amount of each source emission
    //and an avarage amount of it
    public class EmissionOperations
    {
        private Form3 form3;
        public EmissionOperations(Form3 f) => form3 = f;

        public void FilterSourseSearch(string search, MyDataBaseContext context)
        {
            string? inputSearch = context.Sourses.Where(s => s.SourceName == search)
                 .Select(n => n.SourceName).FirstOrDefault();

            if (inputSearch != null)
            {
                var numberOfSources = (from s in context.SourseEmissions
                                       join c in context.Sourses on s.SourseId equals c.SourceId
                                       where c.SourceName == "Royal Dutch Shell PLC"
                                       group s by c.SourceName into g
                                       select new
                                       {
                                           SourceName = g.Key,
                                           EmissionsNumber = g.Count()
                                       }).FirstOrDefault();

                var averageEmissionQuery = (from s in context.SourseEmissions
                                            join c in context.Sourses on s.SourseId equals c.SourceId
                                            where c.SourceName == "Royal Dutch Shell PLC"
                                            group s by c.SourceName into g
                                            select new
                                            {
                                                AvgEmissionType = g.Average(x => x.EmissionType)
                                            }).FirstOrDefault();

                var dataTable = new System.Data.DataTable();
                dataTable.Columns.Add("Source Name");
                dataTable.Columns.Add("Emissions Number");
                dataTable.Columns.Add("Avarage Number");

                dataTable.Rows.Add(numberOfSources.SourceName,
                    numberOfSources.EmissionsNumber, averageEmissionQuery.AvgEmissionType);

                form3.dataGridView1.DataSource = dataTable;
            }
        }
    }
}

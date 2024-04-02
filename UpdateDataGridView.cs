using _02_Environmental_Emissions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Environmental_Emissions
{
    //This class is for updatind a datagridview after adding a new case of emission
    public class UpdateDataGridView
    {
        private Form2 form;
        public UpdateDataGridView(Form2 f) => form = f;
        public void ShowInfoDataGridView(MyDataBaseContext context)
        {
            var result = from t in context.SourseEmissions
                         join e in context.EmissionTypes on t.EmissionType equals e.TypeId
                         select new
                         {
                             t.EmissionId,
                             e.TypeName,
                             t.SourseId,
                             t.Quantity,
                             t.TextDesc,
                             t.SourceDate
                         };

            form.dataGridView.DataSource = result.ToList();
        }
        public void UpdateInfo(MyDataBaseContext context)
        {
            ShowInfoDataGridView(context);
        }
        
    }
}

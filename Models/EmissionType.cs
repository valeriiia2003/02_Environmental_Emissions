using System;
using System.Collections.Generic;

namespace _02_Environmental_Emissions.Models;

public partial class EmissionType
{
    public int TypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public string Formula { get; set; } = null!;

    public virtual ICollection<SourseEmission> SourseEmissions { get; set; } = new List<SourseEmission>();
}

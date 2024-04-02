using System;
using System.Collections.Generic;

namespace _02_Environmental_Emissions.Models;

public partial class Sourse
{
    public int SourceId { get; set; }

    public string SourceName { get; set; } = null!;

    public string? FullAddress { get; set; }

    public virtual ICollection<SourseEmission> SourseEmissions { get; set; } = new List<SourseEmission>();
}

using System;
using System.Collections.Generic;

namespace _02_Environmental_Emissions.Models;

public partial class SourseEmission
{
    public int EmissionId { get; set; }

    public int SourseId { get; set; }

    public int EmissionType { get; set; }

    public double Quantity { get; set; }

    public string? TextDesc { get; set; }

    public DateTime SourceDate { get; set; }

    public virtual EmissionType EmissionTypeNavigation { get; set; } = null!;

    public virtual Sourse Sourse { get; set; } = null!;
}

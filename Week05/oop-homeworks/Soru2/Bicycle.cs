using System;

namespace Soru2;

public class Bicycle : Vehicle
{
    public Bicycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }

    public bool HasSidecar { get; set; }
}

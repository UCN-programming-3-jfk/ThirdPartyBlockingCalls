using System;
using System.Collections.Generic;
namespace ThirdPartyBlockingCalls.ThirdPartyAssemblies;
public class Car
{
    private static Random _rnd = new();
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int MilesDriven { get; set; }

    public Car()
    {
        Brand = _brands[_rnd.Next(_brands.Length)];
        Model = _brandModels[Brand][_rnd.Next(_brandModels[Brand].Length)];
        Year = DateTime.Now.AddYears(-_rnd.Next(10)).Year;
        MilesDriven = _rnd.Next(20000);
    }

    private string[] _brands = { "Mazda", "Citroën", "Volvo", "Tesla" };
    Dictionary<string, string[]> _brandModels = new Dictionary<string, string[]>() { 
        { "Mazda", new string[] {"3","6", "MX-5 Miata", "CX-9 Turbo" } },
        { "Citroën", new string[] {"2 CV","C1", "C2", "C3", "Grand C4", "E-Mehari" } },
        { "Volvo", new string[] { "XC 60", "CX 90", "S 60", "S 80", "260 5-D" } },
        { "Tesla", new string[] {"Model S", "Model X", "Model 3", "Model Y"} },
    };

    public override string ToString()
    {
        return $"{Brand} {Model} ({Year})";
    }
}
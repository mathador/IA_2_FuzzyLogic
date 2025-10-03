using FuzzyLogicPCL.FuzzySets;

namespace FuzzyLogicPCL;

public class LinguisticValue
{
    internal FuzzySet Fs { get; set; }
    internal string Name { get; set; }

    public LinguisticValue(string name, FuzzySet fs)
    {
        Name = name;
        Fs = fs;
    }

    internal double DegreeAtValue(double val) => Fs.DegreeAtValue(val);
}

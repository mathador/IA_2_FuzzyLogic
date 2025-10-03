using FuzzyLogicPCL.FuzzySets;
using System.Collections.Generic;
using System.Linq;

namespace FuzzyLogicPCL;

public class LinguisticVariable
{
    internal string Name { get; set; }
    List<LinguisticValue> Values { get; set; }
    internal double MinValue { get; set; }
    internal double MaxValue { get; set; }

    public LinguisticVariable(string name, double Min, double Max)
    {
        Values = [];
        Name = name;
        MinValue = Min;
        MaxValue = Max;
    }

    public void AddValue(LinguisticValue lv)
    {
        Values.Add(lv);
    }

    public void AddValue(string name, FuzzySet fs)
    {
        Values.Add(new LinguisticValue(name, fs));
    }

    public void ClearValues()
    {
        Values.Clear();
    }

    internal LinguisticValue LinguisticValueByName(string name)
    {
        return Values
            .FirstOrDefault(val => val.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
    }
}

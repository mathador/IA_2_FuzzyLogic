
namespace FuzzyLogicPCL;

class FuzzyValue
{
    internal LinguisticVariable Lv;
    internal double Value;

    public FuzzyValue(LinguisticVariable lv, double value)
    {
        Lv = lv;
        Value = value;
    }
}

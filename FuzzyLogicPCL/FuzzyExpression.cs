namespace FuzzyLogicPCL;

public class FuzzyExpression
{
    internal LinguisticVariable Lv { get; set; }
    internal string LinguisticValueName { get; set; }

    public FuzzyExpression(LinguisticVariable _lv, string Value)
    {
        Lv = _lv;
        LinguisticValueName = Value;
    }
}

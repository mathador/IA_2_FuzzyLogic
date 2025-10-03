using FuzzyLogicPCL.FuzzySets;
using System.Collections.Generic;

namespace FuzzyLogicPCL;

public class FuzzySystem
{
    string Name { get; set; }
    List<LinguisticVariable> Inputs;
    LinguisticVariable Output;
    List<FuzzyRule> Rules;
    List<FuzzyValue> Problem;

    public FuzzySystem(string _name)
    {
        Name = _name;
        Inputs = [];
        Rules = [];
        Problem = [];
    }

    public void addInputVariable(LinguisticVariable lv)
    {
        Inputs.Add(lv);
    }

    public void addOutputVariable(LinguisticVariable lv)
    {
        Output = lv;
    }

    public void addFuzzyRule(FuzzyRule fuzzyRule)
    {
        Rules.Add(fuzzyRule);
    }

    public void addFuzzyRule(string ruleStr)
    {
        FuzzyRule rule = new(ruleStr, this);
        Rules.Add(rule);
    }

    public void SetInputVariable(LinguisticVariable inputVar, double value)
    {
        Problem.Add(new FuzzyValue(inputVar, value));
    }

    public void ResetCase()
    {
        Problem.Clear();
    }

    internal LinguisticVariable LinguisticVariableByName(string name)
    {
        foreach (LinguisticVariable input in Inputs)
        {
            if (input.Name.ToUpper().Equals(name))
            {
                return input;
            }
        }
        if (Output.Name.ToUpper().Equals(name))
        {
            return Output;
        }
        return null;
    }

    public double Solve()
    {
        FuzzySet res = new(Output.MinValue, Output.MaxValue);
        res.Add(Output.MinValue, 0);
        res.Add(Output.MaxValue, 0);
        foreach (FuzzyRule rule in Rules)
        {
            FuzzySet resultingSet = rule.Apply(Problem);
            if (!FuzzySet.ReferenceEquals(resultingSet, null))
            {
                res = res | resultingSet;
            }
        }
        return res.Centroid();
    }
}

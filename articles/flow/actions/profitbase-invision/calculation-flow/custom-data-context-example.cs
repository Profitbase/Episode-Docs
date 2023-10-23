// Creating our own DataContext to simulate that the call comes from InVision.
return new Profitbase.Flow.Extensions.Invision.CalculationFlow.CalculationFlowDataContext
{
    ReferenceTableDataContexts = new List<Profitbase.Flow.Extensions.Invision.CalculationFlow.ReferenceTableDataContext>
    {
        new Profitbase.Flow.Extensions.Invision.CalculationFlow.ReferenceTableDataContext("Account", "AccountID", "3"),
        new Profitbase.Flow.Extensions.Invision.CalculationFlow.ReferenceTableDataContext("Account", "AccountID", "4"),
        new Profitbase.Flow.Extensions.Invision.CalculationFlow.ReferenceTableDataContext("Account", "AccountID", "5"),
        new Profitbase.Flow.Extensions.Invision.CalculationFlow.ReferenceTableDataContext("Account", "AccountID", "6"),
        new Profitbase.Flow.Extensions.Invision.CalculationFlow.ReferenceTableDataContext("Account", "AccountID", "7"),
        new Profitbase.Flow.Extensions.Invision.CalculationFlow.ReferenceTableDataContext("Account", "AccountID", "8"),
    },
    Arguments = new List<Profitbase.Flow.Extensions.Invision.CalculationFlow.DataContextArgument>
    {
        new Profitbase.Flow.Extensions.Invision.CalculationFlow.DataContextArgument("OutputName", "CalcTax")
    }
};
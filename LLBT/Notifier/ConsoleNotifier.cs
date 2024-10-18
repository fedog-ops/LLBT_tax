namespace LBTT.Notifier
{
    public class ConsoleNotifier : ITaxNotifier
    {
        public void Notify(decimal salary, decimal tax)
        {
            Console.WriteLine($"Tax calculated for salary: £{salary}. Tax amount: £{tax}");
        }
    }
}

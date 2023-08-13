namespace Dispatcher
{
    public class Mydispatcher
    {
        private static double incometax = 0.20;
        private static double servicetax = 0.40;
        private static double professional = 0.30;

        public double DeductIncomeTax(double amount)
        {
            Console.WriteLine(incometax+"% income tax is deducted from your account");
            amount = amount - (incometax * amount);
            return amount;
        }
        public double DeductServiceTax(double amount)
        {
            Console.WriteLine(servicetax+"% income tax is deducted from your account");
            amount = amount - (servicetax * amount);
            return amount;
        }
        public double DeductProfessionalTax(double amount)
        {
            Console.WriteLine(professional+"% income tax is deducted from your account");
            amount = amount - (professional * amount);
            return amount;
        }
    }
}
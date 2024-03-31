namespace ASSIGNMENT_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Seconds :  ");
            string a = Console.ReadLine();
            float A = (int)Int64.Parse(a);

            float StM = A / 60;
            float MtH = StM / 60;
            float HtD = MtH / 24;
            float DtM = HtD / 30;

            Console.WriteLine("Seconds to Minutes :" + StM + " Minutes");
            Console.WriteLine("Minutes to Hours   :" + MtH + " Hours");
            Console.WriteLine("Hours   to Days    :" + HtD + " Days");
            Console.WriteLine("Days    to Months  :" + DtM + " Months");
        }
    }
}

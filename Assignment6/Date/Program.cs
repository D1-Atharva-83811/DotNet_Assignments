namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(24,5,2024);
            Date d2 = new Date();
            d2.AcceptDate();

            if (d1.isValid() && d2.isValid())
            {
                d1.PrintDate();
                d2.PrintDate();
            }

            int r = d2.SubtractDates(d1);
            Console.WriteLine(r);
            int result=d2 - d1;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }

    #region Date Class
    public class Date
    {
        private int _Day;
        private int _Month;
        private int _Year;

        public Date()
        {

        }

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter day:");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month:");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year:");
            Year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Date: {0}/{1}/{2}", Day, Month, Year);
        }

        public bool isValid()
        {
            if (Year <= 2024 && Year >= 2000)
            {
                if (Month <= 12)
                {
                    if (Day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }

        public override string ToString()
        {
            return "Day=" + Day + ", Month=" + Month + ", " + Year;
        }

        public static int operator -(Date d1, Date d2)
        {
            return Math.Abs(d1.Year - d2.Year);
        }

        public int SubtractDates(Date d1)
        {
            return this - d1;
        }

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }


        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }


        public int Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

    } 
    #endregion
}

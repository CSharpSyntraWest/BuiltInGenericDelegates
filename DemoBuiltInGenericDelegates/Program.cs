using System;

namespace DemoBuiltInGenericDelegates
{
    public enum WeekDag
    { 
        Maandag,
        Dinsdag,
        Woensdag,
        Donderdag,
        Vrijdag,
        Zaterdag,
        Zondag
    }
    class Program
    {
        static void PrintString(string text)
        {
            Console.WriteLine(text);
        }
        static void PrintMax(string welkomText, int getal1, int getal2)
        {
            Console.WriteLine(welkomText + ":" + Math.Max(getal1, getal2));
        }

        static bool IsEven(int getal)
        {
            return (getal % 2 == 0);
        }
        static bool IsGelijk(int getal1, int getal2)
        {
            return getal1 == getal2;
        }
        static bool HeeftLengteGroterDan1(string text)
        {
            if (text == null) return false;
            return text.Length > 1;
        }

        static bool IsWeekend(WeekDag weekdag)
        {
            if (weekdag == WeekDag.Zaterdag || weekdag == WeekDag.Zondag)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Action<string> del_action1 = PrintString;
            del_action1("een tekst");

            Action<string,int, int> del_action2 = PrintMax;
            del_action2("Welkom, het maximum is",5, 6);

            Predicate<int> del_predicate = IsEven;
            Console.WriteLine("Getal 5 is Even? " + del_predicate(5));

            Predicate<string> del_predicate2 = HeeftLengteGroterDan1;
            Console.WriteLine("'Hallo' heeft lengte groter dan 1 ?" + del_predicate2("Hallo"));


            Func<int, int, bool> del_func1 = IsGelijk;
            Console.WriteLine("Getal 5 is gelijk aan getal 6 ?" + del_func1(5,6));

           
            Predicate<WeekDag> del_predicate3 = IsWeekend;
            WeekDag vandaag = WeekDag.Donderdag;
            Console.WriteLine("Vandaag is het weekend? " + del_predicate3(vandaag));

            Func<WeekDag, bool> del_func2 = IsWeekend;
            Console.WriteLine("Vandaag is het weekend? " + del_func2(vandaag));

            Console.WriteLine();
        }
    }
}

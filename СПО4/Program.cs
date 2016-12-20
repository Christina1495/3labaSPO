using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace СПО4
{
    class Program
    {
        public enum Months
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
        }

        public static void Main(string[] args)
        {
            Console.Write("christina@christina:~$ ");
            string command = "";
            Console.Write(command);
            command = Console.ReadLine();
            string[] commands = command.Split(' ');
            //int year = 2016;
            if (commands[0] != "exit")
            {
                rec(commands);
            }
        }


        public static void rec(string[] date)
        {
            if (date.Length > 1)
            {
                if ((date[1] == "-hy") && date.Length == 2) { HY_command(2016); }
                else
                if ((date[1] == "-yh") && date.Length == 2) { HY_command(2016); }
                else
                if ((date[1] == "-y") && date.Length == 2) { Y_command(2016); }
                else if (date[1] == "-h") { H_command(10, 2016); }
                else if ((date.Length == 2) /*&& (date[1] != "-y")*/)
                {
                    Y_command(Convert.ToInt32(date[1]));

                }
                else if ((date[1] == "1") || (date[1] == "2") || (date[1] == "3") ||
                    (date[1] == "4") || (date[1] == "5") || (date[1] == "6") ||
                    (date[1] == "7") || (date[1] == "8") || (date[1] == "9") ||
                    (date[1] == "10") || (date[1] == "11") || (date[1] == "12"))
                {
                    if ((Convert.ToInt32(date[1]) == 10) && (Convert.ToInt32(date[2]) == 2016))
                    Month_Year_command2(Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
                    else Month_Year_command(Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
                }
                else if ((date.Length == 3) && (date[1] == "-y"))
                {
                    Y_command(Convert.ToInt32(date[2]));

                }

            }
            else if (date.Length == 1)
            {
                Month_Year_command2(10, 2016);
            }
            Console.WriteLine();
            Console.Write("christina@christina:~$ ");
            string command = "";
            Console.Write(command);
            command = Console.ReadLine();
            string[] commands = command.Split(' ');
           
            if (commands[0] != "exit")
            {
                rec(commands);
            }
            
        }

        public static void HY_command(int yearnumber)
        {
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            DateTime myDT = new DateTime(yearnumber, 1, 1, myCal);
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine("   " + (Months)i + "  " + yearnumber);
                Console.WriteLine();
                int month = myCal.GetMonth(myDT);
                int j = Convert.ToInt32(myCal.GetDayOfWeek(myDT)) - 1;
                for (int m = 0; m < j; m++) { Console.Write("   "); }
                while (myCal.GetMonth(myDT) == month)
                {
                    if (j % 7 == 0) Console.WriteLine();
                    string space = (myDT.Day.ToString().Length > 1) ? " " : "  ";
                    Console.Write(myDT.Day + space);
                    myDT = myDT.AddDays(1);
                    j++;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static void Y_command(int yearnumber)
        {Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            DateTime myDT = new DateTime(yearnumber, 1, 1, myCal);
            if (yearnumber == 2016)
            {
                 for (int i = 1; i < 13; i++)
                {
                    if (i == 10)
                    {


                        Console.WriteLine("   " + (Months)i + "  " + yearnumber);
                        Console.WriteLine();
                        int month = myCal.GetMonth(myDT);
                        int j = Convert.ToInt32(myCal.GetDayOfWeek(myDT)) - 1;
                        for (int m = 0; m < j; m++) { Console.Write("   "); }
                        while (myCal.GetMonth(myDT) == month)
                        {
                            if (j % 7 == 0) Console.WriteLine();
                            string space = (myDT.Day.ToString().Length > 1) ? " " : "  ";
                            if (myDT.Day == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(myDT.Day + space);
                                Console.ResetColor();
                            }
                            else { Console.Write(myDT.Day + space); }
                            myDT = myDT.AddDays(1);
                            j++;
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("   " + (Months)i + "  " + yearnumber);
                        Console.WriteLine();
                        int month = myCal.GetMonth(myDT);
                        int j = Convert.ToInt32(myCal.GetDayOfWeek(myDT)) - 1;
                        for (int m = 0; m < j; m++) { Console.Write("   "); }
                        while (myCal.GetMonth(myDT) == month)
                        {
                            if (j % 7 == 0) Console.WriteLine();
                            string space = (myDT.Day.ToString().Length > 1) ? " " : "  ";
                            Console.Write(myDT.Day + space);
                            myDT = myDT.AddDays(1);
                            j++;
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                for (int i = 1; i < 13; i++)
                {
                   


                       
                    
                        Console.WriteLine("   " + (Months)i + "  " + yearnumber);
                        Console.WriteLine();
                        int month = myCal.GetMonth(myDT);
                        int j = Convert.ToInt32(myCal.GetDayOfWeek(myDT)) - 1;
                        for (int m = 0; m < j; m++) { Console.Write("   "); }
                        while (myCal.GetMonth(myDT) == month)
                        {
                            if (j % 7 == 0) Console.WriteLine();
                            string space = (myDT.Day.ToString().Length > 1) ? " " : "  ";
                            Console.Write(myDT.Day + space);
                            myDT = myDT.AddDays(1);
                            j++;
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    
                }
            }
        }
    

        public static  void Month_Year_command2(int month_arg, int year) {
            int count_week = 7;
            int current_day = 6;
            int current_month = 10;
            Calendar cal = CultureInfo.InvariantCulture.Calendar;
            DateTime datetime = new DateTime(year, 1, 1, cal);
            for (int i = 1; i < 13; i++)
            {
                if (i == current_month)
                {
                    Console.WriteLine();
                    Console.WriteLine( (Months)i + "  " + year);
                    Console.WriteLine();
                    int month = cal.GetMonth(datetime); 
                    int j = Convert.ToInt32(cal.GetDayOfWeek(datetime)) - 1;
                    for (int m = 0; m < j; m++) { Console.Write("   "); }
                    while (cal.GetMonth(datetime) == month)
                    {
                        if (j % count_week == 0) Console.WriteLine();
                        string space = (datetime.Day.ToString().Length > 1) ? " " : "  ";
                        if (datetime.Day == current_day)
                        {
                            Console.ForegroundColor = ConsoleColor.Green; 
                            Console.Write(datetime.Day + space);
                            Console.ResetColor();
                        }
                        else { Console.Write(datetime.Day + space); }
                        
                        datetime = datetime.AddDays(1);
                        j++;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    int month = cal.GetMonth(datetime);
                    int j = Convert.ToInt32(cal.GetDayOfWeek(datetime)) - 1;
                    for (int m = 0; m < j; m++) { Console.Write("   "); }
                    while (cal.GetMonth(datetime) == month)
                    {
                        
                        string space = (datetime.Day.ToString().Length > 1) ? " " : "  ";
                        datetime = datetime.AddDays(1);
                        j++;
                    }
                }
            }
        }

        public static void Month_Year_command(int month_arg, int year)
        {
            int count_week = 7;
            int current_day = 6;
            int current_month = 10;
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            DateTime myDT = new DateTime(year, 1, 1, myCal);
            for (int i = 1; i < 13; i++)
            {
                if (i == month_arg)
                {
                    Console.WriteLine();
                    Console.WriteLine("   " + (Months)i + "  " + year);
                    Console.WriteLine();
                    int month = myCal.GetMonth(myDT);
                    int j = Convert.ToInt32(myCal.GetDayOfWeek(myDT)) - 1;
                    for (int m = 0; m < j; m++) { Console.Write("   "); }
                    while (myCal.GetMonth(myDT) == month)
                    {
                        if (j % 7 == 0) Console.WriteLine();
                        string space = (myDT.Day.ToString().Length > 1) ? " " : "  ";

                        Console.Write(myDT.Day + space);

                        myDT = myDT.AddDays(1);
                        j++;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    int month = myCal.GetMonth(myDT);
                    int j = Convert.ToInt32(myCal.GetDayOfWeek(myDT)) - 1;
                    for (int m = 0; m < j; m++) { Console.Write("   "); }
                    while (myCal.GetMonth(myDT) == month)
                    {

                        string space = (myDT.Day.ToString().Length > 1) ? " " : "  ";
                        myDT = myDT.AddDays(1);
                        j++;
                    }
                }
            }
        }
        public static void H_command(int month_, int year)
        {
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            DateTime myDT = new DateTime(year, 1, 1, myCal);
            for (int i = 1; i < 13; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("   " + (Months)i + "  " + year);
                    Console.WriteLine();
                    int month = myCal.GetMonth(myDT);
                    int j = Convert.ToInt32(myCal.GetDayOfWeek(myDT)) - 1;
                    for (int m = 0; m < j; m++) { Console.Write("   "); }
                    while (myCal.GetMonth(myDT) == month)
                    {
                        if (j % 7 == 0) Console.WriteLine();
                        string space = (myDT.Day.ToString().Length > 1) ? " " : "  ";
                       
                         Console.Write(myDT.Day + space);
                        
                        myDT = myDT.AddDays(1);
                        j++;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    int month = myCal.GetMonth(myDT);
                    int j = Convert.ToInt32(myCal.GetDayOfWeek(myDT)) - 1;
                    for (int m = 0; m < j; m++) { Console.Write("   "); }
                    while (myCal.GetMonth(myDT) == month)
                    {
                      
                        string space = (myDT.Day.ToString().Length > 1) ? " " : "  ";
                        myDT = myDT.AddDays(1);
                        j++;
                    }
                }
            }
        }

    }
    }


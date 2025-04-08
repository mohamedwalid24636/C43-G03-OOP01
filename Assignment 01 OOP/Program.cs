using System.Linq.Expressions;
using Assignment_01_OOP;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Q1
        //Weekdays wd1 = new Weekdays();

        //for (int i = 0; i < 7; i++)
        //{
        //    wd1 = (Weekdays)i;  
        //    Console.WriteLine(wd1); 
        //}

        #endregion


        #region Q2
        //bool isparsed; 
        //seas_on testinstanse; 


        //Console.WriteLine("please enter your seasson name");
        //if (isparsed = Enum.TryParse(Console.ReadLine(), out testinstanse))

        //{
        //    switch (testinstanse)
        //    {
        //        case seas_on.Spring:
        //            Console.WriteLine("March , April , May");
        //            break;
        //        case seas_on.Summer:
        //            Console.WriteLine("June, July, August");
        //            break;
        //        case seas_on.Autumn:
        //            Console.WriteLine("September , October , November");
        //            break;
        //        case seas_on.Winter:
        //            Console.WriteLine("December , January and February");
        //            break;

        //    };
        //    Console.Write("//" + testinstanse);

        //}

        //else
        //    Console.WriteLine("invalid month_name"); 


        #endregion


        #region Q3
        //bool again = true;
        //Permission perm = new Permission();
        //Permission p1 = new Permission();
        //do
        //{



        //    int x;
        //    bool isparsed;
        //    do
        //    {
        //        Console.WriteLine("choose 1 , 2 or 3 \n 1- ADD , Remove Permission (if exists) {XOR} \n 2- check if specific Permission existed inside variable\r\n 3- exit ");
        //        isparsed = int.TryParse(Console.ReadLine(), out x);
        //    } while (!(x != 1 || x != 2 || x != 3) );


        //    if (isparsed)
        //    {

        //        bool issparsed;
        //        switch (x)
        //        {
        //            case 1:
        //                {
        //                    do
        //                    {
        //                        Console.WriteLine("please enter a permission ");
        //                        issparsed = Enum.TryParse(Console.ReadLine(), out p1);
        //                    } while (!issparsed);
        //                    perm ^= p1;

        //                    Console.WriteLine($"\n Current user Permissions is : {perm}\n ");

        //                }
        //                break;

        //            case 2:
        //                do
        //                {
        //                    Console.WriteLine("please enter a permission ");
        //                    issparsed = Enum.TryParse(Console.ReadLine(), out p1);
        //                } while (!issparsed);
        //                if ((perm &= p1) == p1)
        //                    Console.WriteLine($"\n user has {p1} permession \n ");
        //                else
        //                    Console.WriteLine("\n user dont has this permetion \n");
        //                break;


        //            case 3:
        //                again = false;
        //                break;
        //        }




        //    }
        //} while (again); 
        #endregion

        #region Q4
        //bool isparsed;
        //object obj;
        //Color c1; 
        //do
        //{

        //    Console.WriteLine("please enter  a color name ");
        //    isparsed = Enum.TryParse(typeof(Color), Console.ReadLine(), out obj);
        //    if (!isparsed) Console.WriteLine("u entered normal color");
        //} while (!isparsed);

        //c1 = (Color)obj;

        //if (c1 == Color.Green || c1 == Color.Red || c1 == Color.Blue)
        //    Console.WriteLine("u entered prime color");
       

        #endregion 



    }
}
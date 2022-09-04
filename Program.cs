// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string prog = "1";
string prog1 = "1";
while (prog == "1")
{
    int select = 0;
    Console.WriteLine("functions list");
    for (int i = 1; i < 17; i++)
    {
        Console.WriteLine("Function {0}", i);
    }
    Console.WriteLine("please enter the number for the required function");
    select = Convert.ToInt32(Console.ReadLine());
    if (select == 1)
    {
        Console.WriteLine("Funtion 1");

        Console.WriteLine("Hello World!");


        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";
    }
    if (select == 2)
    {
        Console.WriteLine("Funtion 2");
        string name;
        string family;
        string age;
        Console.WriteLine("Please enter your first name:");
        name = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        family = Console.ReadLine();
        Console.WriteLine("Please enter your age:");
        age = Console.ReadLine();
        Console.WriteLine("first name:" + name );
        Console.WriteLine("Last name:" + family);
        Console.WriteLine("Last name:" + age);

        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 3)
    {
        Console.WriteLine("Funtion 3");

        Console.WriteLine("This is the test for changing the backround and foreground of a text");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("This is the test for changing the backround and foreground of a text");
        Console.ResetColor();

        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 4)
    {
        Console.WriteLine("Funtion 4");

              DateTime today = DateTime.Now;
        Console.WriteLine(today.ToString("D"));

        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 5)
    {
        Console.WriteLine("Funtion 5");

        Console.WriteLine("Enter First Number: ");
        String FirstNumber = Console.ReadLine();
        Console.WriteLine("Enter second Number: ");
        String SecondNumber = Console.ReadLine();
        int A = Convert.ToInt32(FirstNumber);
        int B = Convert.ToInt32(SecondNumber);
        //Console.WriteLine(A + B);
        if (A > B)
            Console.WriteLine("Among the first number and second number,the bigger one is:  " + A);
        else
            Console.WriteLine("Among the first number and second number,the bigger one is:  " + B);


        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 6)
    {
        Console.WriteLine("Funtion 6");

        double a = 0;
        double sq = 0;
        string c = "n";
        Console.WriteLine("Enter the number for calculatig the root: ");
        c = Console.ReadLine();
        a = Convert.ToDouble(c);
        sq = Math.Sqrt(a);
        Console.WriteLine(" The square root of the number:  " + sq + "\n The square root of the number with two desimal:  " + Math.Round(sq, 2) + "\n The square root of the number with 10 desimal:  " + Math.Round(sq, 10));


        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 7)
    {
        Console.WriteLine("Funtion 7");

        string mytext = "This is a test for writing in a file on hard disk";
        string testread = @"C:\Users\Home\Desktop\IT kurs lexikon\projects\text file\writing test.txt";
        Console.WriteLine("writing to File using.WriteAllText()");
        File.WriteAllText(testread, mytext);


        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 8)
    {
        Console.WriteLine("Funtion 8");

        string testread = @"C:\Users\Home\Desktop\IT kurs lexikon\projects\text file\writing test.txt";
        Console.WriteLine("Reading File using File.ReadAllText()");
        string read = File.ReadAllText(testread);
        Console.WriteLine(read);

        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 9)
    {
        Console.WriteLine("Funtion 9");

        double a = 0;
        double sq = 0;
        string c = "n";
        Console.WriteLine("Enter the number for calculatig the root: ");
        c = Console.ReadLine();
        a = Convert.ToDouble(c);
        sq = Math.Sqrt(a);
        Console.WriteLine(" The square root of the number:  " + sq + "\n The square root of the number with two desimal:  " + Math.Round(sq, 2) + "\n The square root of the number with 10 desimal:  " + Math.Round(sq, 10));


        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 10)
    {
        Console.WriteLine("Funtion 10");

        int Number = 10;
        for (int i = 1; i <= Number; i++)
        {
            for (int j = 1; j <= Number; j++)
            {
                int k = i * j;
                string l = k.ToString().PadLeft(3, '0');
                Console.Write(" " + l);
            }
            Console.WriteLine();
        }


        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 11)
    {
        Console.WriteLine("Funtion 11");

        int[] RArray = new int[10];
        Random generator = new Random();
        Console.WriteLine("Random array before sorting:");
        for (int k = 0; k <= 9; k++)
        {
            RArray[k] = generator.Next(9);
            Console.WriteLine(RArray[k]);
        }

        int[] SArray = new int[10];
        SArray = RArray;
        int i, j, Index, t;
        for (i = 0; i < 9; i++)
        {
            Index = i;
            for (j = i + 1; j < 10; j++)
                if (SArray[j] < SArray[Index])
                    Index = j;
            if (Index != i)
            {
                t = SArray[i];
                SArray[i] = SArray[Index];
                SArray[Index] = t;
            }
        }
        Console.WriteLine("Sorted array:");
        for (int l = 0; l < 9; l++)
        {
            Console.WriteLine(SArray[l]);
        }

        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 12)
    {
        Console.WriteLine("Funtion 12");

        Console.WriteLine("enter your word to evaluate palindrome:");
        string inputstring = Console.ReadLine();
        inputstring = inputstring.ToUpper();
        char[] Oletters = inputstring.ToCharArray();
        char[] Rletters = inputstring.ToCharArray();
        Array.Reverse(Rletters);
        //Console.WriteLine(Oletters);
        //Console.WriteLine(Rletters);
        int p = 0;
        for (int i = 0; i < Oletters.Length; i++)
        {
            if (Oletters[i] == Rletters[i])
            {
                p++;
                //Console.WriteLine(p);
                //Console.WriteLine(Rletters[i]);
                //Console.WriteLine(Oletters[i]);
            }
            else
            {
                i = Oletters.Length + 1;
                //Console.WriteLine(i);
            }
        }
        if (p == Oletters.Length)
        {
            Console.WriteLine("It is Palindrome");
        }
        else
        {
            Console.WriteLine("It is not palindrome");
        }

        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 13)
    {
        Console.WriteLine("Funtion 13");

        int first = 0;
        int second = 0;
        int temp = 0;
        int between = 0;
        Console.WriteLine("please enter first number:  ");
        first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please enter second number:  ");
        second = Convert.ToInt32(Console.ReadLine());
        if (first > second)
        {
            temp = first;
            first = second;
            second = temp;
        }
        //Console.WriteLine( first + " " + second );
        Console.WriteLine("The numebers between two entered numbers: ");
        for (int i = 1; between + 1 < second; i++)
        {
            between = first + i;
            Console.WriteLine(between);
        }

        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 14)
    {
        Console.WriteLine("Funtion 14");

        String snumber;
        Double[] dnumber = new Double[20];
        Double[] even = new Double[20];
        double[] odd = new double[20];
        int evi = 0;
        int odi = 0;
        Double buffer = 0;
        Console.WriteLine(" Please enter sveral numbers separated with comma:   ");
        snumber = Console.ReadLine();
        string[] numbers = snumber.Split(',');

        for (int i = 0; i < numbers.Length; i++)
        {
            dnumber[i] = Convert.ToDouble(numbers[i]);
            buffer = dnumber[i] % 2;
            if (buffer == 0)
            {
                even[evi] = dnumber[i];
                evi++;
            }
            else
            {
                odd[odi] = dnumber[i];
                odi++;
            }
        }
        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evi; i++)
            Console.WriteLine(even[i]);


        Console.WriteLine("Odd numbers:");

        for (int i = 0; i < odi; i++)
            Console.WriteLine(odd[i]);


        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 15)
    {
        Console.WriteLine("Funtion 15");

        String snumber;
        Double[] dnumber = new Double[20];
        Double buffer = 0;
        Console.WriteLine(" Please enter sveral numbers separated with comma:   ");
        snumber = Console.ReadLine();
        string[] numbers = snumber.Split(',');

        for (int i = 0; i < numbers.Length; i++)
        {
            dnumber[i] = Convert.ToDouble(numbers[i]);
            buffer = buffer + dnumber[i];
        }
        Console.WriteLine(" sum of the input numbers are equal to:" + buffer);


        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
    if (select == 16)
    {
        Console.WriteLine("Funtion 16");

        Random myrandom = new Random();
        int l = 0;
        int k = 0;
        string myname;
        string aponame;
        string[] sprc = { "health", "streinght", "luck" };
        int[] rank = new int[6];
        Console.WriteLine(" Please enter your name:");
        myname = Console.ReadLine();
        Console.WriteLine("Please enter the name of your opponent:");
        aponame = Console.ReadLine();
        Console.WriteLine("                my name: {0}            Opponant name: {1}", myname, aponame);
        for (int i = 0; i < 6; i++)

        {
            rank[i] = myrandom.Next(1, 10);
            //Console.WriteLine(rank[i]);
        }

        for (int i = 0; i < 3; i++)
        {

            l = 2 * i;
            k = l + 1;
            Console.WriteLine("                    {0}                               {1}                       {2}", rank[k], rank[l], sprc[i]);
        }

        Console.WriteLine("If you want to exit please press 0");
        prog1 = Convert.ToString(Console.ReadLine());
        if (prog1 == "0")
            prog = prog1;
        else
            prog1 = "1";

    }
}
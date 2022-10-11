namespace logbug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> veges = new List<string>();
            veges.Add("CARROT");
            veges.Add("BEET");
            veges.Add("CELERY");
            veges.Add("RADDISH"); 
            veges.Add("RADISH");
            veges.Add("CABBAGE");
            Random randnum = new Random();
            Chosen myobj = new Chosen();
            int i, on = 0, o = 0, k = 0, init = 0, added = 0, vegon = 0, indexer;
            while (k == 0)
            {
                Console.WriteLine("Pick one of the two nums, veges or quit");
            myobj.value = Console.ReadLine();
            if (myobj.value == "nums")
            {
            for (i = 0; i < 25; i++)
            { 
                myobj.nums.Add(randnum.Next(10, 21));
                Console.Write($"{myobj.nums[i]},");
            }
            while (on == 0)
            {
                Console.WriteLine("sort new remove add count largest smallest quit");
            myobj.value = Console.ReadLine().ToLower().Trim();
            if (myobj.value == "sort")
                myobj.nums.Sort();
                for (i = 0; i < myobj.nums.Count; i++)
                {
                        if (i < myobj.nums.Count - 1)
                    Console.Write($"{myobj.nums[i]},");
                }
                    added = 0;
                }
                else if (myobj.value == "new")
                {
                    for (i = 0; i < 26; i++)
                    {
                        myobj.nums[i] = randnum.Next(10, 21);
                        if (i < 25 - 1)
                            Console.Write($"{myobj.nums[i]},");
                        else
                            Console.WriteLine($"{myobj.nums[i]}");
                    }
                }
                else if (myobj.value == "remove")
                {
                    Console.WriteLine("enter a number that is in the list");
                    myobj.value = Console.ReadLine();
                    int golo, jjhj = 0;
                    for (i = 0; i < myobj.nums.Count; i++)
                    {
                        if (myobj.nums.Contains(Convert.ToInt32(myobj.value)))
                        {
                                if (jjhj < myobj.nums.Count)
                            {
                                jjhj = +1;
                                for (int gone = 0; gone < jjhj; gone++)
                                {
                                    golo = Convert.ToInt32(myobj.value);
                                    myobj.nums.Remove(golo);
                                }
                            }
                            init = 1;
                        }
                        else if (init == 0)
                        {
                            Console.WriteLine("this is not in it");
                            i = myobj.nums.Count();
                        }
                        if (init == 1)
                        {
                            for (i = 0; i < myobj.nums.Count; i++)
                            {
                                if (i < myobj.nums.Count - 1)
                                    Console.Write($"{myobj.nums[i]},");
                                else if (i < myobj.nums.Count)
                                    Console.WriteLine(myobj.nums[i]);
                                else;
                            }

                        }
                    }
                }
                else if (myobj.value == "add")
                {
                    Console.WriteLine("Type a number");
                    myobj.value = Console.ReadLine();
                    myobj.lite = Convert.ToInt32(myobj.value);
                    if (myobj.lite == Convert.ToInt32(myobj.value))
                    {
                        myobj.nums.Add(myobj.lite);
                        for (i = 0; i < myobj.nums.Count; i++)
                        {
                            if (i < myobj.nums.Count - 1)
                            {
                                Console.Write($"{myobj.nums[i]},");
        }
                            else if (i < myobj.nums.Count)
        {
                                Console.WriteLine(myobj.nums[i]);
        }
                        }
                    }
                    added = +1;
                }
                else if (myobj.value == "count")
        {
                    Console.WriteLine("specify number");
                    myobj.lite = Convert.ToInt32(myobj.value = Console.ReadLine());
                        for (i = 0; i < myobj.nums.Count; i++)
            {
                        if (myobj.nums[i] == myobj.lite)
                            o++;
                        else;
                    }
                    Console.WriteLine($"{myobj.lite} {o}");
                }
                else if (myobj.value == "largest")
                {
                    if (added == 0)
                        Console.WriteLine(myobj.nums.Last<int>());
                    else if (added > 0)
                        Console.WriteLine(myobj.nums.Last<int>() - added);
                }
                else if (myobj.value == "smallest")
                {
                    Console.WriteLine(myobj.nums[0]);
                }
                else if (myobj.value == "quit")
                    on = 1;
                else
                    Console.WriteLine("Not an option");
                }
            }
        }
    }
}
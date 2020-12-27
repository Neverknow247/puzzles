using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Names();
        }
        public static int[] RandomArray()
        {
            int[] newArr = new int[10];
            Random rand = new Random();
            int i = 0;
            int max = 0;
            int min = 26;
            int sum = 0;
            while(i < 10)
            {
                newArr[i] = rand.Next(5, 26);
                sum += newArr[i];
                i++;
            }
            for(int p = 0; p < newArr.Length; p++)
            {
                if(newArr[p] > max)
                {
                    max = newArr[p];
                }
                if(newArr[p] < min)
                {
                    min = newArr[p];
                }
            }
            Console.WriteLine($"Max: {max} - Min: {min} - Sum: {sum}");
            return newArr;
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            List<string> CoinSide = new List<string>()
            {
                "Heads",
                "Tails"
            };
            Random rand = new Random();
            string resultzz = CoinSide[rand.Next(2)];
            Console.WriteLine(resultzz);
            return resultzz;
        }
        public static double TossMultiCoin(int num)
        {
            int headCount = 0;
            int iteration = 0;
            while (iteration < num)
            {
                if (TossCoin() == "Heads")
                    headCount++;
                iteration++;
            }
            double tossRatio = (double)headCount / (double)num;
            return tossRatio;
        }
        public static List<string> Names()
        {
            Random rand = new Random();
            string pull = "";
            string pop = "";
            int num = 0;
            int count = 1;
            List<int> randList = new List<int>();
            List<string> finalList = new List<string>();
            List<string> nameList = new List<string>();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");
            pop = nameList[0];
            while(count < nameList.Count)
            {
                // temp = nameList[count];
                num = rand.Next(1,nameList.Count);
                if(randList.Contains(num)){}
                else
                {
                    pull = nameList[num];
                    nameList[num] = pop;
                    pop = pull;
                    randList.Add(num);
                    count++;
                }
            }
            nameList[0] = pop;
            for(int i = 0; i<nameList.Count;i++)
            {
                if(nameList[i].Length > 5)
                {
                    finalList.Add(nameList[i]);
                }
            }
            for(int i = 0;i<finalList.Count;i++)
            {
                Console.WriteLine(finalList[i]);
            }
            return finalList;
        }
    }
}

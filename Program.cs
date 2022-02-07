#region SberFight
///*Дан числовой массив. Необходимо найти все числа, которые меньше медианного значения в массиве.

//На входе: 

//nums - числовой массив, 1<length(nums)<=10, 0<nums[i]<2000
//На выходе: 

//Integer[] - числа из массива nums, которые меньше медианного значения
//Пример:

//nums = [1, 3, 5, 6, 7]
//GetResult(nums) = [1, 3]

//Медианное число - 5*/

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace sberfight
//{
//    class Program
//    {
//        static int Main(string[] args)
//        {
//            List<int> fightersStamina = new List<int> { 1, 2, 5, 6 };
//            List<int> copyFightersStamina = new List<int> ();
//            for (int i = 0; i < 4; i++)
//            { copyFightersStamina.Add(fightersStamina[i]); }
//            List<int> result = new List<int> { 0, 0, 0, 0 };
//            List<double> winKing = new List<double> { 0, 0, 0, 0 };
//            List<int> win1 = new List<int>();
//            int king = 5;

//            //Var1 : 0-1 и 2-3
//            Tur1(fightersStamina, 0, 1, win1);
//            Tur1(fightersStamina, 2, 3, win1);
//            if (win1[0] == 10 && win1[1] == 10)
//            { winKing[0] += 0.25; winKing[1] += 0.25; winKing[2] += 0.25; winKing[3] += 0.25; }
//            if ((win1[0] != 10) && (win1[1] != 10))
//            {
//                Tur2(fightersStamina, win1, ref king);
//                if (king != 10) winKing[king] += 1;
//                else { winKing[win1[0]] += 0.5; winKing[win1[1]] += 0.5; }
//            }
//            if (win1[0] == 10 && win1[1] != 10)
//            {
//                king = win1[1];
//                winKing[king] += 1;
//            }
//            if (win1[0] != 10 && win1[1] == 10)
//            {
//                king = win1[0];
//                winKing[king] += 1;
//            }
//            //Var2 : 0-2 и 1-3
//            win1.Clear();
//            for (int i= 0;i<4;i++)
//            {    fightersStamina[i] = copyFightersStamina[i]; }
//            Tur1(fightersStamina, 0, 2, win1);
//            Tur1(fightersStamina, 1, 3, win1);
//            if (win1[0] == 10 && win1[1] == 10)
//            { winKing[0] += 0.25; winKing[1] += 0.25; winKing[2] += 0.25; winKing[3] += 0.25; }
//            if ((win1[0] != 10) && (win1[1] != 10))
//            {
//                Tur2(fightersStamina, win1, ref king);
//                if (king != 10) winKing[king] += 1;
//                else { winKing[win1[0]] += 0.5; winKing[win1[1]] += 0.5; }
//            }
//            if (win1[0] == 10 && win1[1] != 10)
//            {
//                king = win1[1];
//                winKing[king] += 1;
//            }
//            if (win1[0] != 10 && win1[1] == 10)
//            {
//                king = win1[0];
//                winKing[king] += 1;
//            }
//            //Var3 : 0-3 и 1-2
//            for (int i = 0; i < 4; i++)
//            { fightersStamina[i] = copyFightersStamina[i]; }
//            win1.Clear();
//            Tur1(fightersStamina, 0, 3, win1);
//            Tur1(fightersStamina, 1, 2, win1);
//            if (win1[0] == 10 && win1[1] == 10)
//            { winKing[0] += 0.25; winKing[1] += 0.25; winKing[2] += 0.25; winKing[3] += 0.25; }
//            if ((win1[0] != 10) && (win1[1] != 10))
//            {
//                Tur2(fightersStamina, win1, ref king);
//                if (king != 10) winKing[king] += 1;
//                else { winKing[win1[0]] += 0.5; winKing[win1[1]] += 0.5; }
//            }
//            if (win1[0] == 10 && win1[1] != 10)
//            {
//                king = win1[1];
//                winKing[king] += 1;
//            }
//            if (win1[0] != 10 && win1[1] == 10)
//            {
//                king = win1[0];
//                winKing[king] += 1;
//            }
//            //После обработки всех вариантов
//            double sum = 0;
//            foreach (var item in winKing)
//            {  sum += item; }
//            for (int i=0;i<4;i++)
//                result[i] = (int)Math.Round(winKing[i] * 100 / sum);
//            foreach (var item in result)
//                Console.WriteLine(item);
//            return 0;
//        }
//        static void Tur1(List<int> fightersStamina, int uch1, int uch2, List<int> win1)
//        {
//            if (fightersStamina[uch1] != fightersStamina[uch2])
//            {
//                if (fightersStamina[uch1] > fightersStamina[uch2])
//                {
//                    win1.Add(uch1);
//                    fightersStamina[uch1] -= fightersStamina[uch2];
//                }

//                if (fightersStamina[uch2] > fightersStamina[uch1])
//                {
//                    win1.Add(uch2);
//                    fightersStamina[uch2] -= fightersStamina[uch1];
//                }
//            }
//            else { win1.Add(10); fightersStamina[uch2] -= fightersStamina[uch1]; fightersStamina[uch1] = fightersStamina[uch2]; }
//        }
//        static void Tur2(List<int> fightersStamina, List<int> win1, ref int king)
//        {
//            if (fightersStamina[win1[0]] != fightersStamina[win1[1]])
//            {
//                if (fightersStamina[win1[0]] > fightersStamina[win1[1]])
//                {
//                    king = win1[0];
//                }

//                if (fightersStamina[win1[1]] > fightersStamina[win1[0]])
//                {
//                    king = win1[1];
//                }
//            }
//            else { king = 10; }
//        }
//        static void Tur3(List<int> fightersStamina, int uch1, int uch2, ref int king)
//        {

//                if (fightersStamina[uch1] > fightersStamina[uch2])
//                {
//                    king = uch1;
//                }

//                if (fightersStamina[uch2] > fightersStamina[uch1])
//                {
//                    king = uch2;
//                }

//        }
//    }


//    class Solution4
//    {
//        /**
//         * Implement method GetResult
//         */
//        public static int GetResult(List<int> rocketPos, List<int> rocketSpeed)
//        {
//            int t = 0;
//            while ((t<10000)&&(rocketPos.Count>1)) 
//            {
//                for (int i = 0; i < rocketPos.Count&&rocketPos.Count>1; i++)
//                { 
//                    for (int j = i+1; j < rocketPos.Count && rocketPos.Count > 1; j++) 
//                    {
//                        if (rocketPos[i] == rocketPos[j])
//                        {
//                            rocketSpeed[i] += rocketSpeed[j];
//                            rocketPos.RemoveAt(j);
//                            rocketSpeed.RemoveAt(j);
//                            j--;
//                        }
//                    }
//                }

//                ////Отладка 
//                //Console.WriteLine("\n\nПрошло "+t+" единиц времени\n");
//                //Console.WriteLine("Позиция");
//                //foreach (var item in rocketPos)
//                //    Console.Write(item+"\t");
//                //Console.WriteLine("\nСкорость");
//                //foreach (var item in rocketSpeed)
//                //    Console.Write(item + "\t");
//                ////Отладка конец

//                t++;
//                for (int i = 0; i < rocketSpeed.Count; i++)
//                    rocketPos[i] += rocketSpeed[i];


//            }

//            return rocketPos.Count;
//        }

//        public static void RunCode()
//        {
//            // Entrypoint to debug your function
//        }
//    }
//    class Solution3
//    {
//        /**
//         * Implement method GetResult
//         */
//        public static int i = 0;
//        public static bool GetResult(List<int> arr, int w)
//        {
//            int sum = 0;
//            foreach (int value in arr)
//            {
//                sum += value;
//            }
//            if (sum <= w)
//                return true;
//           while (arr.Max() > i)
//            {
//                arr[arr.IndexOf(arr.Max())] = arr.Max() / 2;
//                i++;
//                sum = 0;
//                foreach (int value in arr)
//                {
//                    sum += value;
//                }
//                if (sum <= w)
//                    return true;
//            }
//            return false;
//        }


//        public static void RunCode()
//        {
//            // Entrypoint to debug your function
//        }
//    }
//    class Solution
//    {
//        public static List<int> GetResult(List<int> numb)
//        {
//            List<int> result = numb;
//            result.Sort();
//            IEnumerable<int> distinctAges = result.Distinct();
//            result = distinctAges.ToList();
//            result.RemoveRange(result.Count / 2, result.Count - result.Count / 2);
//            return result;
//        }
//    }
//    class Solution2 
//    {
//        public static bool GetResult(int n, List<string> dislikeList)
//        {
//            GetDislikeList(dislikeList);
//            IEnumerable<string> resultList = dislikeList.Distinct();
//            dislikeList = resultList.ToList();
//            List<int> neighbors = new List<int>();
//            int countOfNeighbors ;
//            int countMin = 0;
//            int countDouble = 0;
//            //заполнение neighbors массив с количеством возможных соседей
//            for (int j=1; neighbors.Count < n;j++)
//            {
//                countOfNeighbors = n-1; 
//                for (int i = 0; i < dislikeList.Count; i++)
//                {
//                   if (dislikeList[i].Contains(j.ToString()+"-"))
//                        countOfNeighbors--;
//                }
//                neighbors.Add(countOfNeighbors);
//            }
//            //Основной подсчет: считаем сколько гостей готовы иметь как минимум одного соседа, как минимум двух
//            for (int i = 0; i < neighbors.Count; i++)
//            {
//                if (neighbors[i] >= 1)
//                    countMin++;
//                if (neighbors[i] >= 2)
//                    countDouble++;
//            }
//            //Основная проверка: если количество гостей всего> количества гостей с как минимум одним соседом, то рассадка невозможна,
//            //если количество гостей минус два (места с краев стола) > количества гостей с как минимум двумя соседями, то рассадка невозможжна
//            if (n > countMin || (n - 2) > countDouble)
//                return false;
//            return true;
//        }

//        private static void GetDislikeList(List<string> dislikeList) 
//        {
//            int countList = dislikeList.Count;
//            for (int i=0; i< countList; i++)
//            {
//                string newItem;
//                while (dislikeList[i].Contains(",") == true)
//                {
//                    if (dislikeList[i].Length >5)
//                        newItem = dislikeList[i].Substring(0, dislikeList[i].Length - dislikeList[i].IndexOf(',')-1);
//                    else newItem = dislikeList[i].Substring(0, dislikeList[i].IndexOf(',') );
//                    dislikeList[i]  = dislikeList[i].Substring(0,dislikeList[i].IndexOf('-')+1)+dislikeList[i].Substring(dislikeList[i].IndexOf(',')+1);
//                    dislikeList.Add(newItem);
//                    // dislikeList.Add(ReverseString(newItem));
//                    //dislikeList.Add(ReverseString(dislikeList[i]));

//                }
//                 //dislikeList.Add(ReverseString(dislikeList[i])); 
//            }
//            int nRevers = dislikeList.Count();
//            for (int i = 0; i < nRevers; i++)
//                dislikeList.Add(ReverseString(dislikeList[i]));

//        }
//        private static string ReverseString(string newItem) {
//            string input = newItem;
//            string output = "";
//            for (int j = input.Length - 1; j >= 0; j--)
//            {
//                output += input[j];
//            }
//            return output;
//        }
//    }
//} 
#endregion

//Дан массив N и число k <= len(N)/ 2
//Опишите словами(без кода и псевдокода) как разбить массив N на k подмассивов так,
//чтобы длина самомого длинного и самого короткого подмассивов отличалась не более чем на 1


//Поиск максимального в дереве
using System;
using System.Collections.Generic;
using System.Linq;
namespace sberfight
{
    public class MaxValue
    {
        public static int maxValue;
        public static int MaxValueInArray(int[] arr)
        {
            int start = 0, interval = arr.Count() - 1, end = arr.Count() / 2;
            int max = -1;
            while (start < end)
            {
                if (arr[start] < arr[end])
                {
                    max = end;
                    start = end;
                    end = interval;
                }
                else { max = start; interval = end; end = start + (end - start) / 2; }
            }
            return arr[max];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5,6,7,8,9 };
            int k = 4;
            int x = arr.Count() / k; //длина массива
            int[][] arrArr = new int[k][]; //создаем массив массивов, количество массивов будет k
            for (int i = 0, count=0; i < k; i++)
            {
                if (i < arr.Count() % k)
                {
                    arrArr[i] = new int[x + 1];
                    for (int j = 0; j < arrArr[i].Count(); j++)
                    { arrArr[i][j] = arr[count]; count++; }
                }
                else 
                { 
                    arrArr[i] = new int[x]; 
                    for (int j = 0; j < arrArr[i].Count(); j++)
                    { arrArr[i][j] = arr[count]; count++; }
                }
                PrintArr(arrArr[i]);
            }
        }
        public static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item+"\t");
            Console.WriteLine();
        }
    }
    
}
using System;
using System.Collections;

namespace Assignment04Adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //List<int> ints= new List<int> { 1, 2, 3, 4, 5,6,4,2,1,1,1,2,2,3 };
            //Hashtable hashtable = new Hashtable();
            //for(int i =0;i<ints.Count;i++)
            //{
            //   if(hashtable.ContainsKey(ints[i]))
            //    {
            //        hashtable[ints[i]] = (int)hashtable[ints[i]] + 1;
            //    }
            //    else
            //    {
            //        hashtable.Add(ints[i], 1);
            //    }
            //}
            //for(int i =0;i<hashtable.Count;i++)
            //{
            //    if(hashtable.ContainsKey(i+1))
            //    {
            //        Console.WriteLine($"number {i+1}, appeared {hashtable[i+1]} times");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"number {i+1}, appeared 0 times");
            //    }
            //} 
            #endregion

            #region Q2
            // Hashtable hashtable = new Hashtable()
            // {
            // { "Ahmed", 1 },
            // { "Omar", 2 },
            // { "Saif", 3 },
            // { "Mostafa", 4 },
            // { "Yehya", 5 }
            //};

            // string maxKey = null;
            // int maxValue = int.MinValue;

            // foreach (DictionaryEntry entry in hashtable)
            // {
            //     int value = (int)entry.Value;
            //     if (value > maxValue)
            //     {
            //         maxValue = value;
            //         maxKey = (string)entry.Key;
            //     }
            // }

            // Console.WriteLine($"{maxKey} has the maximum value: {maxValue}"); 
            #endregion

            #region Q3
            //Hashtable hashtable = new Hashtable()
            //{
            //{ "key1", "apple" }, 
            //{ "key2", "banana" }, 
            // { "key3", "apple" }

            //};
            //string targetValue = "apple";
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    if ((string)entry.Value == targetValue)
            //    {
            //        Console.WriteLine($"Value: {entry.Value}");
            //    }
            //}
            #endregion

            #region Q4
            // ??
            #endregion

            #region Q5
            //List<int> ints = new List<int> { 1, 2,2,3,4,5,6 };
            //Hashtable hashtable = new Hashtable();
            //for (int i = 0; i < ints.Count; i++)
            //{
            //    if (hashtable.ContainsKey(ints[i]))
            //    {
            //        hashtable[ints[i]] = (int)hashtable[ints[i]] + 1;
            //    }
            //    else
            //    {
            //        hashtable.Add(ints[i], 1);
            //    }
            //}
            //bool hasDuplicates = false;
            //for (int i = 0; i < hashtable.Count; i++)
            //{
            //    if (hashtable.ContainsKey(i + 1) && (int)hashtable[i + 1] > 1)
            //    {
            //        hasDuplicates = true;
            //        break;
            //    }
            //}

            //if (hasDuplicates)
            //{
            //    Console.WriteLine("There are duplicates in the list.");
            //}
            //else
            //{
            //    Console.WriteLine("There are no duplicates in the list.");
            //}
            #endregion

            #region Q6
            //SortedDictionary<int, string> SD = new SortedDictionary<int, string>()
            //{

            //{ 101, "Ahmed" },
            //{ 105, "Omar" },
            //{ 103, "Saif" },
            //{ 102, "Mostafa" },
            //{ 104, "Yehya" }

            //};

            //SD.Remove(103); // Remove the entry with key 103
            //SD.Add(108, "hamada");
            //foreach (KeyValuePair<int, string> entry in SD)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}
            #endregion

            #region Q7
            //SortedList<int, string> SL = new SortedList<int, string>()
            //{
            //    {1,"saif" },
            //    {5,"ahmed" },
            //    {3,"omar" },
            //    {0,"hamada" }

            //};
            //foreach (KeyValuePair<int, string> entry in SL)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}
            #endregion

            #region Q8
            //Console.Write("Enter the maximum number N: ");
            //int N;
            //while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            //{
            //    Console.Write("Invalid input. Please enter a positive integer for N: ");
            //}

            //Console.Write("Enter the number of elements you will input (<= N): ");
            //int size;
            //while (!int.TryParse(Console.ReadLine(), out size) || size <= 0 || size > N)
            //{
            //    Console.Write("Invalid input. Please enter a positive integer <= N: ");
            //}

            //HashSet<int> ints = new HashSet<int>();

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    int element;
            //    while (!int.TryParse(Console.ReadLine(), out element) || element < 1 || element > N)
            //    {
            //        Console.Write($"Invalid input. Please enter an integer between 1 and {N}: ");
            //    }
            //    ints.Add(element);
            //}

            //Console.WriteLine("Missing numbers:");
            //for (int i = 1; i <= N; i++)
            //{
            //    if (!ints.Contains(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Q9
            //List<int> ints = new List<int> { 1, 2, 3, 2, 4, 6, 7, 0, 8, 1, 1, 2, 2, 3 };
            //HashSet<int> uniqueInts = new HashSet<int>(ints);
            //for(int i =0;i<ints.Count;i++)
            //{
            //    uniqueInts.Add(ints[i]);
            //}
            //foreach (int num in uniqueInts)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region 10
            //Hashtable hashtable = new Hashtable()
            //{
            //    {1,"a" },
            //    {2,"b" },
            //    {3,"c" },
            //    {4,"d" },
            //    {5,"e" },
            //    {6,"f" }

            //};
            //Hashtable newHash = new Hashtable();
            //for(int i =1 ;i<=hashtable.Count;i++)
            //{
            //    newHash.Add(hashtable[i], i);
            //}
            //foreach (DictionaryEntry entry in newHash)
            //{
            //    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //}
            #endregion

            #region Q11
            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };
            //HashSet<int> union = new HashSet<int>(set1);

            //union.UnionWith(set2);

            //foreach (int num in union)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Q12
            //Hashtable hashtable = new Hashtable()
            //{
            //    {"apple",1},
            //    {"animal",2},
            //    {"airport",3}

            //};
            //char targetChar = 'a';
            //int c = 0;
            //foreach(DictionaryEntry entry in hashtable)
            //{
            //    string key = (string)entry.Key;
            //    if (key.StartsWith(targetChar.ToString()))
            //    {
            //        c++;
            //    }
            //}
            //Console.WriteLine(c);
            #endregion

            #region Q13
            //SortedSet<int> ints = new SortedSet<int>() { 1, 3, 5, 7, 9, 11 };

            //Console.Write("target: ");
            //int target;
            //while (!int.TryParse(Console.ReadLine(), out target))
            //{
            //    Console.Write("Invalid input. Please enter an integer: ");
            //}

            //List<int> ints1 = new List<int>();

            //foreach (int num in ints)
            //{
            //    if (num > target)
            //    {
            //        ints1.Add(num);
            //    }
            //}

            //Console.WriteLine($"Elements greater than {target}:");
            //foreach (int num in ints1)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region Q14
            Hashtable hashtable = new Hashtable()
            {
            {"a", 1},
            {"b", 2},
            {"g", 3},
            {"f", 4},
            {"e", 5},
            {"d", 6},
            };

            foreach (DictionaryEntry entry in hashtable)
            {
                int value = (int)entry.Value;
                if (value % 2 == 0)
                {
                    Console.WriteLine(entry.Key);
                }
            }
            #endregion
        }

    }
}

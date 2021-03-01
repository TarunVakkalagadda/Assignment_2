using System;
using System.Linq;
using System.Collections.Generic;

namespace final_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 0, 0, 1 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                if (n > 0 && (nums.Length / 2) == n)
                {
                    int start = 0, mid = n;//declaration for start and mid element
                    int[] bo = new int[2 * n];//new list to store items
                    for (int i = 0; i < 2 * n; i = i + 2)
                    {
                        bo[i] = nums[start++];//taking the first element
                        bo[i + 1] = nums[mid++];//taking the element starting from mid
                    }

                    Console.WriteLine(string.Join(",", bo));

                }
                else
                {
                    Console.WriteLine("Nums.Length should be same as n");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                if (ar2 != null)
                {
                    for (int i = 0, j = 0; j < ar2.Length; j++)
                        if (ar2[j] != 0)//conditional check
                        {
                            int tmp = ar2[i];//temporary variable and assigning current value
                            ar2[i++] = ar2[j];//switching if number is not equal to zero
                            ar2[j] = tmp;//storing for next variable
                        }
                    Console.WriteLine(string.Join(",", ar2));
                }
                else
                {
                    Console.WriteLine("Array ar2 shouldnt be null");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ////Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length == 0)
                {
                    Console.WriteLine(0);
                }
                Array.Sort(nums);//sorting numbers
                int count = 0;//intialising count
                int i = 0;//checking condition for same number
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count += j - i;//count updation
                    }
                    else
                    {
                        i = j;//changing the value, if condition not met.
                    }
                }
                Console.WriteLine(count);


            }

            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                if (target > 0 && nums != null)
                {
                    int check = 0;
                    var dictionary = new Dictionary<int, int>();//dictionary declaration
                    for (int i = 0; i < nums.Length; i++)
                    {

                        check = target - nums[i];//check value for list
                        if (!dictionary.ContainsKey(check))
                        {
                            dictionary.Add(nums[i], i);//addition into dictionary
                        }
                        else
                        {
                            Console.WriteLine((dictionary[check], i));
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Target and nums array is not as expected");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                if (s.Length != indices.Length)
                {
                    throw new Exception();
                }
                foreach (int a in indices)
                {
                    if (a < 0 || a > indices.Length)
                    {
                        throw new Exception();
                    }
                }

                var dictionary = new Dictionary<int, char>();//dictionary declaration
                for (int i = 0; i < indices.Length; i++)
                {
                    dictionary[indices[i]] = s[i];//adding char as key and indices as values
                }
                var list = dictionary.Keys.ToList();//converting all keys to a list
                list.Sort();//sorting the list to get the final value
                foreach (var key in list)
                {
                    Console.Write(dictionary[key]);//printing the value
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                Dictionary<char, int> map = new Dictionary<char, int>();//dictionary declaration
                for (int i = 0; i < s1.Length; i++)
                {
                    char a = s1[i];//char variable for string 1
                    char b = s2[i];//char variable for string 2
                    if (map.ContainsKey(a))
                    {
                        /*Checking if the dictionary contains the key and equal to char v
                        ariable in string 2 if it is there continue the loop*/
                        if (map[a] == b)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!map.ContainsKey(b))/*if value not present adding it to the dictionary with the 
                            char in string 1 as key and string 2 as value*/
                        {
                            map[a] = b;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                if (items.GetLength(0) > 1000)
                {
                    throw new Exception();
                }

                Dictionary<int, List<int>> mapDict = new Dictionary<int, List<int>>();//dictionary declaration
                for (int i = 0; i < items.GetLength(0); i++)//getting the length of first dimension
                {
                    /*Dictionary key to store the iDi and a list to append all the corresponding values in the list*/
                    if (mapDict.ContainsKey(items[i, 0]))
                    {
                        List<int> lListNew = mapDict[items[i, 0]];
                        if (items[i, 1] > 100)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            lListNew.Add(items[i, 1]);
                            mapDict[items[i, 0]] = lListNew;
                        }
                    }
                    else
                    {
                        List<int> val = new List<int>();
                        if (items[i, 1] > 100)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            val.Add(items[i, 1]);
                            mapDict.Add(items[i, 0], val);
                        }
                    }
                }
                if (mapDict.Count > 100 || mapDict.Count == 1)
                {
                    throw new Exception();
                }
                foreach (KeyValuePair<int, List<int>> entry in mapDict)
                /*displaying the keys along with values in the list to an array and sorting them & getting the first 5 values for average */
                {
                    if (entry.Value.Count < 5)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        var a = entry.Value;
                        a.Sort();
                        a.Reverse();
                        var b = a.GetRange(0, 5);
                        Console.WriteLine((entry.Key, b.Sum() / 5));
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                /*Creating a hashset to store the values of all the unique elements to 
                 understand if a value repeats again and put it in infinite loop*/
                if (n == 1)
                {
                    return true;
                }
                if (n < 1 || n > Math.Pow(2, 31))
                {
                    return false;
                }
                HashSet<int> hset = new HashSet<int>() { n };
                while (n != 1)
                {
                    int sum_n = 0;
                    while (n > 0)
                    /*Getting the divident and adding it to sum and also dividing the value by 10*/
                    {
                        int d = n % 10;
                        sum_n += d * d;
                        n = n / 10;
                    }
                    if (!hset.Add(sum_n))
                        return false;
                    n = sum_n;//updating the sum
                }
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                if (prices.Length == 0 || prices.Length == 1)
                {
                    return 0;
                }


                int min = prices[0];//declaring the minimum value
                int maxProfit = 0;//declaring the profit

                for (int i = 1; i < prices.Length; i++)
                /*updating maxProfit by checking it with maxProfit & the value obtained  after 
                 updating the min value by checking the condition*/
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - min);
                    min = Math.Min(min, prices[i]);
                }

                return maxProfit;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                if (steps <= 0)
                {
                    throw new Exception();
                }
                if (steps == 1)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    if (steps >= 2)
                    {
                        int num1 = 1, num2 = 1, temp;//delcaring num1 and num2 as intial numbers for fibonacci series
                        for (int i = 2; i <= steps; i++)
                        {
                            temp = num1 + num2;//storing addition in temp variable
                            num1 = num2;//swapping the value
                            num2 = temp;//swapping the value
                        }
                        Console.WriteLine(num2);
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

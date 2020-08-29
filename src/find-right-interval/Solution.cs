using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    private int binarySearch(List<int> list, int target)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (list[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return list[left];
    }

    public int[] FindRightInterval(int[][] intervals)
    {
        int n = intervals.Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; i++)
        {
            ans[i] = -1;
        }
        if (n <= 1)
        {
            return ans;
        }

        var keys = new List<int>();
        var map = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            int start = intervals[i][0];
            keys.Add(start);
            map[start] = i;
        }
        keys.Sort();
        for (int i = 0; i < n; i++)
        {
            int end = intervals[i][1];
            int start = binarySearch(keys, end);
            if (end > start)
            {
                ans[i] = -1;
            }
            else
            {
                ans[i] = map[start];
            }
        }

        return ans;
    }
}

public class Driver
{
    public static void Main(String[] args)
    {
        Solution solution = new Solution();
        StreamReader inputfile = new StreamReader("input.txt");
        StreamReader outputfile = new StreamReader("output.txt");
        String line;
        int testno = 1;
        while ((line = inputfile.ReadLine()) != null)
        {
            int[][] arr = stringToInt2dArray(line);
            int[] result = solution.FindRightInterval(arr);

            String output = integerArrayToString(result);
            String expected = outputfile.ReadLine();
            checkAnswer(expected, output, testno);
            testno++;
        }
    }
    public static void checkAnswer(String expected, String output, int testno)
    {
        if (expected.Equals(output))
        {
            Console.WriteLine("TEST {0} SUCCESS EXPECTED: {1} OUTPUT: {2}", testno, expected, output);
        }
        else
        {
            Console.WriteLine("TEST {0} FAILED EXPECTED: {1} OUTPUT: {2}", testno, expected, output);
        }
    }

    public static String integerArrayToString(int[] nums)
    {
        int length = nums.Length;
        if (length == 0)
        {
            return "[]";
        }

        String result = "";
        for (int index = 0; index < length; index++)
        {
            int number = nums[index];
            result += number.ToString() + ",";
        }
        return "[" + result.Substring(0, result.Length - 1) + "]";
    }

    public static int[] stringToIntegerArray(String input)
    {
        input = input.Trim();
        input = input.Substring(1, input.Length - 2);
        if (input.Length == 0)
        {
            return new int[0];
        }

        String[] parts = input.Split(',');
        int[] output = new int[parts.Length];
        for (int index = 0; index < parts.Length; index++)
        {
            String part = parts[index].Trim();
            output[index] = int.Parse(part);
        }
        return output;
    }

    public static int[][] stringToInt2dArray(String input)
    {
        input = input.Trim();
        input = input.Substring(1, input.Length - 2);
        if (input.Length == 0)
        {
            return new int[0][];
        }
        List<int[]> list = new List<int[]>();
        int startIndex = 0, endIndex = 0;
        while (true)
        {
            startIndex = input.IndexOf(
                '[', startIndex,
                input.Length - startIndex);

            if (startIndex < 0)
                break;

            endIndex = input.IndexOf(
                ']', startIndex,
                input.Length - startIndex);

            String[] parts = input.Substring(startIndex + 1, endIndex - startIndex - 1).Split(',');
            int[] arr = new int[parts.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(parts[i].Trim());
            }
            list.Add(arr);
            startIndex = endIndex + 1;
        }

        return list.ToArray();
    }

    public static List<int> stringToIntegerArrayList(String input) {
        input = input.Trim();
        input = input.Substring(1, input.Length - 2);
        String[] parts = input.Split(',');
        var output = new List<int>();
        for(int index = 0; index < parts.Length; index++) {
            String part = parts[index].Trim();
            output.Add(int.Parse(part));
        }
        return output;
    }

    public static String integerArrayListToString(List<int> nums, int length) {
        if (length == 0) {
            return "[]";
        }
    
        String result = "";
        for(int index = 0; index < length; index++) {
            int number = nums[index];
            result += number + ", ";
        }
        return "[" + result.Substring(0, result.Length - 2) + "]";
    }
    
    public static String integerArrayListToString(List<int> nums) {
        return integerArrayListToString(nums, nums.Count);
    }
}
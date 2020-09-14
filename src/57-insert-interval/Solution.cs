using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new List<int[]>();
        int i = 0, n = intervals.Length;
        
        while (i < n && intervals[i][1] < newInterval[0]) {
            result.Add(intervals[i++]);
        }
        
        int[] tmpInterval = newInterval;
        while (i < n && intervals[i][0] <= newInterval[1]) {
            tmpInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            tmpInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            i++;
        }
        result.Add(tmpInterval);
        
        while (i < n) {
            result.Add(intervals[i++]);
        }
        return result.ToArray();
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
            int[][] intervals = StringToInt2dArray(line);
            int[] newIntervals = StringToIntegerArray(inputfile.ReadLine());
            
            String expected = outputfile.ReadLine();
            int[][] result = solution.Insert(intervals, newIntervals);
            String output = Int2dArrayToString(result);
            CheckAnswer(expected, output, testno++);
        }
    }
    public static void CheckAnswer(String expected, String output, int testno)
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

    public static bool StringToBoolean(String input) {
        return input.Equals("true") ? true : false;
    }

    public static String BooleanToString(bool input) {
        return input ? "true" : "false";
    }

    public static int StringToInteger(String input) {
        return int.Parse(input);
    }

    public static String IntegerArrayToString(int[] nums)
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

    public static int[] StringToIntegerArray(String input)
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

    public static int[][] StringToInt2dArray(String input)
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

    public static List<int> StringToIntegerArrayList(String input) {
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

    public static String IntegerArrayListToString(IList<int> nums, int length) {
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
    
    public static String IntegerArrayListToString(IList<int> nums) {
        return IntegerArrayListToString(nums, nums.Count);
    }

    public static String Int2dArrayToString(int[][] array) {
        if (array == null) {
            return "null";
        }
        if (array.Length == 0) {
            return "[]";
        }
    
        StringBuilder sb = new StringBuilder("[");
        foreach (int[] item in array) {

            sb.Append(IntegerArrayToString(item));
            sb.Append(",");
        }
    
        sb[sb.Length - 1] = ']';
        return sb.ToString();
    }
}
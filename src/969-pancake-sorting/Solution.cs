using System;
using System.Collections.Generic;
using System.IO;

public class Solution {
    public IList<int> PancakeSort(int[] A) {
        IList<int> flips = new List<int>();

        for (int i = A.Length; i >= 1; i--) {
            if (A[i - 1] == i) continue;
            int index = IndexOf(A, i);
            Reverse(A, 0, index);
            Reverse(A, 0, i - 1);
            flips.Add(index + 1);
            flips.Add(i);
        }
        return flips;
    }
    private int IndexOf(int[] nums, int key) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == key)
                return i;
        }
        return -1;
    }
    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start++] = nums[end];
            nums[end--] = temp;
        }
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
            int[] input = StringToIntegerArray(line);
            var result = solution.PancakeSort(input);

            String expected = outputfile.ReadLine();
            String output = IntegerArrayListToString(result);
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
}
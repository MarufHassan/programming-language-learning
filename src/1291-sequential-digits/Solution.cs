using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        IList<int> ans = new List<int>();
        Queue<int> queue = new Queue<int>();
        for (int i = 1; i <= 9; i++) {
            queue.Enqueue(i);
        }
        
        while (queue.Count != 0) {
            int num = queue.Dequeue();
            if (num >= low) {
                ans.Add(num);
            }
            int lastdigit = num % 10;
            int next = num * 10 + (lastdigit + 1);
            if (lastdigit < 9 && next <= high) {
                queue.Enqueue(next);
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
            int low = StringToInteger(line);
            int high = StringToInteger(inputfile.ReadLine());
            
            String expected = outputfile.ReadLine();
            IList<int> result = solution.SequentialDigits(low, high);
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Solution {
    public String GetHint(String secret, String guess) {
        int bulls = 0, cows = 0;
        int[] freq = new int[10];
        
        for (int i = 0; i < secret.Length; i++) {
            if (secret[i] == guess[i]) {
                bulls++;
            } else {
                if (freq[secret[i] - '0'] < 0) cows++;
                if (freq[guess[i] - '0'] > 0) cows++;
                freq[secret[i] - '0']++;
                freq[guess[i] - '0']--;
            }
        }
        return bulls + "A" + cows + "B";
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
            String secret = line;
            String guess = inputfile.ReadLine();

            String expected = outputfile.ReadLine();
            String output = solution.GetHint(secret, guess) + "";
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
}
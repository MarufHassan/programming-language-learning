import java.util.*;
import java.io.*;

class Solution {
    public int compareVersion(String version1, String version2) {
        String[] tokens1 = version1.split("\\.");
        String[] tokens2 = version2.split("\\.");
        
        int num1, num2;
        for (int i = 0; i < Math.max(tokens1.length, tokens2.length); i++) {
            num1 = 0; num2 = 0;
            if (i < tokens1.length) {
                num1 = Integer.valueOf(tokens1[i]);
            }
            if (i < tokens2.length) {
                num2 = Integer.valueOf(tokens2[i]);
            }
            if (num1 < num2) {
                return -1;
            } else if (num1 > num2) {
                return 1;
            }
        }
        return 0;
    }
}

public class Driver {
    public static void main(String[] args) throws IOException {
        Scanner inputfile = new Scanner(new File("input.txt"));
        Scanner outputfile = new Scanner(new File("output.txt"));

        Solution solution = new Solution();
        int testno = 1;
        while (inputfile.hasNextLine()) {
            String version1 = inputfile.nextLine();
            String version2 = inputfile.nextLine();
            
            String expected = outputfile.nextLine();
            String output = solution.compareVersion(version1, version2) + "";
            checkAnswer(expected, output, testno++);
        }
        
        inputfile.close();
    }

    public static void checkAnswer(String expected, String output, int testno) {
        if (expected.equals(output)) {
            System.out.printf("TEST %d SUCCESS EXPECTED: %s OUTPUT: %s\n", testno, expected, output);
        } else {
            System.out.printf("TEST %d FAILED EXPECTED: %s OUTPUT: %s\n", testno, expected, output);
        }
    }

    public static int stringToInteger(String input) {
        return Integer.parseInt(input);
    }

    public static boolean stringToBoolean(String input) {
        return input.equals("true") ? true : false;
    }

    public static String booleanToString(boolean input) {
        return input ? "true" : "false";
    }

    public static ArrayList<Integer> stringToIntegerArrayList(String input) {
        input = input.trim();
        input = input.substring(1, input.length() - 1);
        String[] parts = input.split(",");
        ArrayList<Integer> output = new ArrayList<Integer>();
        for(int index = 0; index < parts.length; index++) {
            String part = parts[index].trim();
            output.add(Integer.parseInt(part));
        }
        return output;
    }

    public static String integerArrayListToString(List<Integer> nums, int length) {
        if (length == 0) {
            return "[]";
        }
    
        String result = "";
        for(int index = 0; index < length; index++) {
            Integer number = nums.get(index);
            result += Integer.toString(number) + ", ";
        }
        return "[" + result.substring(0, result.length() - 2) + "]";
    }
    
    public static String integerArrayListToString(List<Integer> nums) {
        return integerArrayListToString(nums, nums.size());
    }

    public static String integerArrayToString(int[] nums) {
        int length = nums.length;
        if (length == 0) {
            return "[]";
        }

        String result = "";
        for (int index = 0; index < length; index++) {
            int number = nums[index];
            result += number + ",";
        }
        return "[" + result.substring(0, result.length() - 1) + "]";
    }

    public static int[] stringToIntegerArray(String input) {
        input = input.trim();
        input = input.substring(1, input.length() - 1);
        if (input.length() == 0) {
            return new int[0];
        }

        String[] parts = input.split(",");
        int[] output = new int[parts.length];
        for (int index = 0; index < parts.length; index++) {
            String part = parts[index].trim();
            output[index] = Integer.parseInt(part);
        }
        return output;
    }

    public static int[][] stringToInt2dArray(String input) {
        input = input.trim();
        input = input.substring(1, input.length() - 1);
        if (input.length() == 0) {
            return new int[0][];
        }
        List<int[]> list = new ArrayList<int[]>();
        int startIndex = 0, endIndex = input.length();
        while (true) {
            startIndex = input.indexOf('[', startIndex);

            if (startIndex < 0)
                break;

            endIndex = input.indexOf(']', startIndex + 1);

            String[] parts = input.substring(startIndex + 1, endIndex).split(",");
            int[] arr = new int[parts.length];
            for (int i = 0; i < arr.length; i++) {
                arr[i] = Integer.parseInt(parts[i].trim());
            }
            list.add(arr);
            startIndex = endIndex + 1;
        }

        return list.toArray(new int[0][]);
    }
}
import java.util.*;
import java.io.*;

class Solution {
    private int ans;
    
    public String largestTimeFromDigits(int[] A) {
        ans = -1;
        
        permute(A, 0);
        if (ans < 0) return "";
        
        return String.format("%02d:%02d", ans / 60, ans % 60);
    }
    
    private void swap(int[] A, int i, int j) {
        int t = A[i];
        A[i] = A[j];
        A[j] = t;
    }
    
    private void permute(int[] A, int index) {
        if (index >= A.length) {
            int h = A[0] * 10 + A[1];
            int m = A[2] * 10 + A[3];
            int minutes = h * 60 + m;
            
            if (h < 24 && m < 60) {
                ans = Math.max(ans, minutes);
            }
            
            return;
        }
        for (int start = index; start < A.length; start++) {
            swap(A, start, index);
            permute(A, index + 1);
            swap(A, start, index);
        }
    }
}

public class Driver {
    public static void main(String[] args) throws IOException {
        Scanner inputfile = new Scanner(new File("input.txt"));
        Scanner outputfile = new Scanner(new File("output.txt"));

        Solution solution = new Solution();
        int testno = 1;
        while (inputfile.hasNextLine()) {
            String line = inputfile.nextLine();
            int[] arr = stringToIntegerArray(line);
            
            String expected = outputfile.nextLine();
            String output = solution.largestTimeFromDigits(arr);
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
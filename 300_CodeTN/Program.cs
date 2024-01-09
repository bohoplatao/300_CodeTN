// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static int[] TwoSum(int[] nums, int target)
    {
        // Tạo một từ điển để lưu trữ các phần tử và chỉ số của chúng
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        // Duyệt qua mảng
        for (int i = 0; i < nums.Length; i++)
        {
            // Tính toán số bù cần thiết để đạt được mục tiêu
            int complement = target - nums[i];

            // Kiểm tra xem số bù đã có trong từ điển chưa
            if (numDict.ContainsKey(complement))
            {
                // Nếu tìm thấy, trả về chỉ số của hai số
                return new int[] { numDict[complement], i };
            }

            // Nếu không, thêm số hiện tại và chỉ số của nó vào từ điển
            if (!numDict.ContainsKey(nums[i]))
            {
                numDict.Add(nums[i], i);
            }
        }

        // Nếu không tìm thấy giải pháp, trả về một mảng rỗng hoặc xử lý tùy ý
        return new int[0];
    }

    static void Main()
    {
        // Example usage:
        int[] nums = { 2, 7, 11, 15 };
        int target = 18;
        int[] result = TwoSum(nums, target);

        // Output the result
        Console.WriteLine("[{0}, {1}]", result[0], result[1]); // Output: [0, 1]
    }
}



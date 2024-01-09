// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static bool IsValid(string s) //Phương thức IsValid nhận vào một chuỗi s và trả về một giá trị boolean, biểu thị xem chuỗi có chứa dấu ngoặc hợp lệ không.
    {

        // Khai báo biến 
       // Stack<char> được sử dụng để theo dõi dấu ngoặc mở trong chuỗi.
       /// Dictionary<char, char> được sử dụng để ánh xạ giữa dấu ngoặc đóng và mở, giúp chúng ta kiểm tra tính đúng đắn của cặp ngoặc.







        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> bracketsDict = new Dictionary<char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        
        foreach (char c in s) //Sử dụng vòng lặp foreach để duyệt qua từng ký tự trong chuỗi s.
        {
            if (bracketsDict.ContainsValue(c)) //Nếu ký tự hiện tại là một dấu ngoặc mở, thêm nó vào ngăn xếp.
            {
                stack.Push(c);
            }
            else if (bracketsDict.ContainsKey(c)) //Nếu ký tự hiện tại là một dấu ngoặc đóng, kiểm tra xem ngăn xếp có trống không (stack.Count == 0).
                                                  //Nếu trống, chuỗi không hợp lệ. Nếu không trống, lấy phần tử đầu ngăn xếp và so sánh với đối ứng của nó. Nếu không khớp, chuỗi không hợp lệ.
            {
                if (stack.Count == 0 || stack.Pop() != bracketsDict[c])
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;//Cuối cùng, kiểm tra xem ngăn xếp có trống không. Nếu có, tất cả dấu ngoặc mở đã được đóng đúng và trả về true. Ngược lại, trả về false.
    }

    static void Main()
    {

        //Trong hàm Main, chúng ta thực hiện một số kiểm tra sử dụng phương thức IsValid với các chuỗi đầu vào khác nhau và in ra kết quả.
        // Ví dụ 1
        string s1 = "()";
        Console.WriteLine(IsValid(s1));  // Output: True

        // Ví dụ 2
        string s2 = "()[]{}";
        Console.WriteLine(IsValid(s2));  // Output: True

        // Ví dụ 3
        string s3 = "(]";
        Console.WriteLine(IsValid(s3));  // Output: False
    }
}


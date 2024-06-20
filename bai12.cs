using System;
namespace BT12_obj04
{
    class Program
    {
    static void Main() {
    // Thiết lập console để hiển thị tiếng Việt
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo số nguyên n 2 byte không dấu
            ushort n;

            // Gọi hàm để nhập giá trị của n
            n = ReadUnsignedShort();

            // In ra màn hình giá trị được nhập
            Console.WriteLine($"Giá trị nhập vào: {n}");

            // Tính tổng bình phương các số từ 1 đến n
            ulong sumOfSquares = CalculateSumOfSquares(n);

            // In ra console giá trị tính được
            Console.WriteLine($"Tổng bình phương các số từ 1 đến {n} là: {sumOfSquares}");
        }

        static ushort ReadUnsignedShort()
        {
            ushort result;
            while (true)
            {
                Console.WriteLine("Nhập vào một số nguyên 2 byte không dấu:");
                string input = Console.ReadLine();

                if (ushort.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }

        static ulong CalculateSumOfSquares(ushort n)
        {
            ulong sum = 0;
            for (ushort i = 1; i <= n; i++)
            {
                sum += (ulong)(i * i);
            }
            return sum;
  }
 }
}

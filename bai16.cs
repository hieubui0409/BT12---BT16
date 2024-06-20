using System;

namespace BT16_obj04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đặt mã hóa cho Console để hiển thị tiếng Việt
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo các biến m và n
            byte m = ReadByteInRange(2, 10);
            byte n = ReadByteInRange(2, 10);

            // Hiển thị giá trị của m và n
            Console.WriteLine($"Giá trị m= {m}");
            Console.WriteLine($"Giá trị n= {n}");

            // Khai báo và cấp phát mảng 2 chiều các số nguyên 4 byte
            int[,] a = new int[m, n];

            // Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím
            Read2DArray(a, m, n);

            // Hiển thị giá trị các phần tử của mảng a
            Print2DArray(a, m, n);

            // Gọi hàm để tính tổng các phần tử của mảng chia hết cho 2024
            int sum = SumDivisibleBy(a, m, n, 2024);
            Console.WriteLine($"Tổng các phần tử của mảng chia hết cho 2024 là: {sum}");
        }

        // Hàm đọc từ bàn phím số nguyên 1 byte không dấu, nằm trong khoảng từ min đến max
        static byte ReadByteInRange(byte min, byte max)
        {
            byte value;
            bool isValid;
            do
            {
                Console.Write($"Nhập số nguyên không dấu trong khoảng từ {min} đến {max}: ");
                isValid = byte.TryParse(Console.ReadLine(), out value) && value >= min && value <= max;
                if (!isValid)
                {
                    Console.WriteLine("Giá trị nỏ hợp lệ. Yêu cầu nhập lại!!");
                }
            } while (!isValid);
            return value;
        }

        // Hàm đọc từ bàn phím số nguyên 4 byte
        static int ReadInt32()
        {
            int value;
            bool isValid;
            do
            {
                Console.Write("Nhập số nguyên (4 byte): ");
                isValid = int.TryParse(Console.ReadLine(), out value);
                if (!isValid)
                {
                    Console.WriteLine("Giá trị nỏ hợp lệ. Yêu cầu nhập lại!!");
                }
            } while (!isValid);
            return value;
        }

        // Hàm nhập vào mảng 2 chiều các số nguyên 4 byte
        static void Read2DArray(int[,] array, byte rows, byte columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Nhập phần tử tại [{i}, {j}]: ");
                    array[i, j] = ReadInt32();
                }
            }
        }

        // Hàm tính tổng các phần tử chia hết cho số nguyên dương p của mảng
        static int SumDivisibleBy(int[,] array, byte rows, byte columns, int p)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % p == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }

        // Hàm hiển thị mảng 2 chiều
        static void Print2DArray(int[,] array, byte rows, byte columns)
        {
            Console.WriteLine("Giá trị các phần tử của mảng:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

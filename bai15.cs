using System;
using System.Globalization;
using System.Text;

namespace BT15_obj04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đảm bảo hiển thị tiếng Việt trong console
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("vi-VN");

            // Khai báo số nguyên n 1 byte không dấu
            byte n = ReadUnsignedByte();
            Console.WriteLine($"Nhập số nguyên thoả mãn: {n}");

            // Khai báo mảng 1 chiều các số thực 4 byte và cấp phát để a gồm n phần tử
            float[] a = new float[n];

            // Gọi hàm để nhập giá trị các phần tử của mảng a từ bàn phím
            ReadFloatArray(a);

            // In ra màn hình giá trị được nhập của mảng a
            Console.WriteLine("Các giá trị của mảng a đã nhập:");
            foreach (float value in a)
            {
                Console.WriteLine(value);
            }
        }

        static byte ReadUnsignedByte()
        {
            byte result;
            while (true)
            {
                Console.WriteLine("Nhập vào số nguyên 1 byte (2-10):");
                string input = Console.ReadLine();
                if (byte.TryParse(input, out result) && result >= 2 && result <= 10)
                {
                    return result;
                }
                Console.WriteLine("Giá trị nỏ hợp lệ tí mô cả. Yêu cầu nhập lại!!");
            }
        }

        static float ReadFloat()
        {
            float result;
            while (true)
            {
                Console.WriteLine("[Nhập vô số thực (4 byte)]:");
                string input = Console.ReadLine();
                if (float.TryParse(input, out result))
                {
                    return result;
                }
                Console.WriteLine("Giá trị nỏ hợp lệ. Vui lòng nhập lại hộ tui cấy!!");
            }
        }

        static void ReadFloatArray(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Nhập vô giá trị phần tử thứ {i + 1}:");
                array[i] = ReadFloat();
            }
        }
    }
}

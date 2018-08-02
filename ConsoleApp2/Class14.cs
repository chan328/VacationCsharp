using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class14
    {
        static void Main()
        {
            string[] array = { "가", "나" };
            Console.WriteLine("숫자를 입력하세여");
            string input = Console.ReadLine();
            /*if(input > array.Length)
            {
                Console.WriteLine("오류ㅠㅠㅠㅠㅠㅠㅠㅠㅠ");
            }
            else
            {
                Console.WriteLine("입력한 위치의 값은" + array[input] + "입니다ㅏㅏㅏㅏㅏㅏ");
            }*/
            try
            {
                int index = int.Parse(input);
                Console.WriteLine("입력숫자" + index);
            }
            catch (Exception exeption)
            {
                Console.WriteLine("예외가 발생했ㅇ");
                Console.WriteLine(exeption.GetType());
            }
            finally
            {
                Console.WriteLine("프로그램이 종료");
            }
        }
    }
}

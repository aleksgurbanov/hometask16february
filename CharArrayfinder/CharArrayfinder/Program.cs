using System;

namespace CharArrayfinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"yoxlama", "bir", "bizon", "redbul"};
            char yoxlayan = 'b';
            foreach (string item in Chararrayfinder(arr,yoxlayan))
            {
                Console.WriteLine(item);
            }
        }
        static string[] Chararrayfinder(string[] arr, char a)
        {
            string[] netice = new string[0];

            foreach (string item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == a)
                    {
                        
                        Array.Resize(ref netice, netice.Length + 1);

                        
                        netice[netice.Length - 1] = item;
                        break;
                    }

                }
            }

            return netice;
        }

    }
}

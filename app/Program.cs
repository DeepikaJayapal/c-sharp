// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace Hello
{
    class Program{
        static void Main(){
            // Average();
            CharacterOccurence();
        }
        static void Average(){
            int number1,number2,number3,average;
            Console.WriteLine("Enter number1");
            number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3");
            number3=Convert.ToInt32(Console.ReadLine());
            average=(number1+number2+number3)/3;
            Console.WriteLine(average);
        }
        static void CharacterOccurence(){
            string str ="Deepika";
            Console.WriteLine("Name:"+str);
            while(str.Length>0){
                Console.Write(str[0]+"=");
                int cal=0;
                for(int i=0;i<str.Length;i++){
                    if(str[0]==str[i]){
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str=str.Replace(str[0].ToString(),string.Empty);
            }
            Console.ReadLine();
        }
    }
}
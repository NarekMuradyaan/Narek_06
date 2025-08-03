using System;

namespace test_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("aaa");
            list.Add("aaa");
            list.Add("aaa");
            list.Add("aaa");
            list.Add("aaa");
            list[5] = "Ss";
            Console.WriteLine(list[5]);
            
        }
        //public class Animal
        //{
        //    public virtual void Sound()
        //    {
        //        Console.WriteLine("aaaaa");
        //    }
        //}
        ////Dogs
        //public class Dog : Animal

        //{
        //    public string name { get; set; }
        //    public Dog(string name)
        //    {
        //        this.name = name;

        //    }
        //    public new void Sound()
        //    {
        //        Console.WriteLine("af");
        //    }
        //}

        ////Cats
        //public class Cat : Animal
        //{
        //    public string name { get; set; }
        //    public Cat(string name)
        //    {
        //        this.name = name;

        //    }
        //    public override void Sound()
        //    {
        //        Console.WriteLine("affffffff");
        //    }
        //}

    }
}

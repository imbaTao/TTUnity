using System;

namespace Clearn
{
    class Program
    {

        static void Main(string[] args)
        {
            var instance = new Father();
             var instace2 = new Father();
            instace2 = new Father();

            var instance3 = new Father(name: "牛逼了1");
            instance3.name("这下可牛逼了");
         
            //instance.name("我名字是hong");
            instance.myFunction();
            //Logger.print("1");
        }


    }
}


class Son: Father
{
   void study()
    {
        Logger.print("我在学习");
    }

   override void move()
    {

    }
}

class Father
{

    public readonly Father myInstance;


    public void move()
    {

    }

    public Father()
    {

    }


    public Father(string name)
    {

    }


    



   public void test()
    {
        Console.WriteLine("Unity3D,I'm Comming!");
    }

    public void name(string str)
    {
        Logger.print("{0}", str);
    }

    public void myFunction(string str = "我是默认参数")
    {
        string b = $@"{str}";
        Logger.print(b);
       
    }
}



class Logger
{
   public static void print(string content)
    {
        Console.WriteLine(content);

    }

    public static void print(object arg0)
    {
        Console.WriteLine(arg0);

    }


    public static void print(string format, object arg0)
    {
        Console.WriteLine("{0}{1}",format, arg0);
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019WCSD3354WEEK05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
        }
    }

    class TestQuestion2
    {
        public int myFavoriteVariable = 0;

        public void PlayingWithForLoops()
        {
            // write a For Loop to Add 10 Numbers
            for (; MyMethod();)
            {
                if (myFavoriteVariable > 10)
                {
                    Console.WriteLine("i am so out of here!");
                    break;
                }
                Console.WriteLine("oh no I have to go through this stupid loop again...");
            }
        }
        public bool MyMethod()
        {
            myFavoriteVariable++;
            return true;
        }

    }

    class dog
    {
        public dog(string name,string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }
        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog previous_dog;
    }
    class birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;
    }
}


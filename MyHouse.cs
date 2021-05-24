using System;

namespace DemoAccessModifiers
{
    public class MyHouse
    {
        public static void KnockOnTheDoor()
        {
            Console.WriteLine("Anyone can knock on the door");
        }

        protected static void UnlockDoorWithKey()
        {
            Console.WriteLine("Only I and trusted friends have the key to the door");
        }

        private void UseToothBrush()
        {
            Console.WriteLine("Only I have access to my toothbrush");
        }
    }
}
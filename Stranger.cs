namespace DemoAccessModifiers
{
    public class Stranger
    {
        public void KnockOnTheDoor()
        {
            //Even though I'm a stranger I can still knock on the door
            MyHouse.KnockOnTheDoor();
        }

        public void UnlockDoorToAPrivateHouse()
        {
            //Since I do not know the owner of the house and have not earned their
            //trust through inheritance, I do not have the key to unlock the door.
            MyHouse.UnlockDoorWithKey();
        }
    }
}
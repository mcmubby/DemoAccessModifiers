namespace DemoAccessModifiers
{
    public class Stranger
    {
        public void KnockOnTheDoor()
        {
            MyHouse houseObject = new MyHouse();

            //A stranger can knock on the door
            houseObject.KnockOnTheDoor();
        }

        public void UnlockDoorToAPrivateHouse()
        {
            MyHouse houseObject = new MyHouse();

            //Since AStranger does not know me and has not earned my
            //trust through inheritance, AStranger does not have the keycard to unlock the door.
            houseObject.UnlockDoorWithKey(); //Error: Can't access due to protection level
        }

        //Since I can't open the door, I can't get to the toothbrush
        //GAME OVER!!!
    }
}
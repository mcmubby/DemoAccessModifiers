namespace DemoAccessModifiers 
{
    public class MySister : MyHouse
    {
        //PS: I granted MySister access to MyHouse through Inheritance since MySister has earned my trust

        public void KnockOnMyBrothersDoor()
        {
            MyHouse houseObject = new MyHouse();
            MySister sisterObject = new MySister();

            //Since MySister is trusted, MySister can simply knock and enter without waiting for a response from me.
            sisterObject.KnockOnTheDoor();

            //OR

            //MySister can simply knock and wait for a response from me.
            houseObject.KnockOnTheDoor();
        }

        //Well I'm not home at the moment 🤷‍♂️

        public void UnlockMyBrothersDoor()
        {
            MyHouse houseObject = new MyHouse();
            MySister sisterObject = new MySister();

            //Since I have given MySister a keycard to the house, MySister can unlock the door with the keycard.
            sisterObject.UnlockDoorWithKey();

            //MySister CANNOT also use my own keycard that I keep under the foot mat.
            houseObject.UnlockDoorWithKey(); // Error: UnlockDoorWithKey can only be accessed by classes derived from MyHouse.
        }

        public void UseMyBrothersBrush()
        {
            MyHouse houseObject = new MyHouse();
            MySister sisterObject = new MySister();

            sisterObject.UseToothBrush(); //Error: Only I can use my toothbrush.
            houseObject.UseToothBrush(); //Error: Only I can use my toothbrush it doesn't matter if you ask for my permission
        }
    }
}
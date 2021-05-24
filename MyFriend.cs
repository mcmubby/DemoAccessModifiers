namespace DemoAccessModifiers 
{
    public class MyFriend : MyHouse
    {
        // I have granted MyFriend access to MyHouse through Inheritance since MyFriend has earned my trust

        public void AccessMyFriendsHouse()
        {
            //Since the owner of the house has given me the key to the house, I can unlock the door with the key
            MyHouse.UnlockDoorWithKey();
        }
    }
}
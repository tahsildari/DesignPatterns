namespace DesignPatternsAsISeeThem.Structural.Facade
{
    public class FriendshipFacade : IFriendshipFacade
    {
        private readonly Person person;
        private readonly Friend friend;

        public FriendshipFacade(Person person, Friend friend)
        {
            this.person = person;
            this.friend = friend;
        }
        public string ShowFriendshipInBrief() => person.GetFullNameTitled() + " is friends with " + friend.GetNameAndHistory();
    }
}

using DesignPatternsAsISeeThem.Structural.Facade;
using System;

namespace Tester.Testers
{
    /// <summary>
    /// The purpose of the FACADE pattern is to provide a single and short interface to multiple wokers.
    /// In some cases the facade class masks a giant worker class with lots of methods.
    /// </summary>
    class FacadeTester : Tester, ITester
    {
        protected override string GetName() => this.GetType().Name;

        public void Run()
        {
            IntroduceTester();

            var mahdi = new Person(Age: 33, FirstName: "Mahdi", LastName: "Tahsildari");
            var rosie = new Friend(Type: FriendType.Dog, Name: "Rosie", Since: DateTime.Now.AddYears(-1));
            var hamid = new Friend(Type: FriendType.Human, Name: "Hamid", Since: new DateTime(2001, 1, 1));
            
            IFriendshipFacade bestFriends = new FriendshipFacade(mahdi, rosie);
            Console.WriteLine(bestFriends.ShowFriendshipInBrief());

            IFriendshipFacade oldFriends = new FriendshipFacade(mahdi, hamid);
            Console.WriteLine(oldFriends.ShowFriendshipInBrief());
        }

    }
}

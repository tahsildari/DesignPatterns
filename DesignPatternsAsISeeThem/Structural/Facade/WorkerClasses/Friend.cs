using System;

namespace DesignPatternsAsISeeThem.Structural.Facade
{
    public record Friend(FriendType Type, string Name, DateTime? Since = null)
    {
        public int GetFriendshipAgeInYears() => Since != null ? DateTime.Now.Year - Since.Value.Year : 0;
        public string GetYearsFormatted() => GetFriendshipAgeInYears() + (GetFriendshipAgeInYears() == 1 ? " year" : " years");
        public string GetNameAndHistory() => $"{Name}, the \"{Type}\" friend for {GetYearsFormatted()}";
    }

    public enum FriendType
    {
        Dog, Human
    }
}

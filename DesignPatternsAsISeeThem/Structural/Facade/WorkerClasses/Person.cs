namespace DesignPatternsAsISeeThem.Structural.Facade
{
    public record Person(string FirstName, string LastName, int? Age = null, string Title = "")
    {
        public string GetFullName() => $"{FirstName} {LastName}";
        public string GetFullNameFormal() => $"{LastName}, {FirstName}";
        public string GetFullNameTitled() => Title.Equals(string.Empty) ? GetFullName() : $"{Title} {GetFullName()}";
        public string GetFullNameTitledAndFormal() => Title.Equals(string.Empty) ? GetFullNameFormal() : $"{Title} {GetFullNameFormal()}";
        public string GetHeadline() => $"{GetFullNameTitled}, {Age} years old";

    }
}

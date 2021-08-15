namespace WindowsFormsApp
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNum { get; set; }

        public string FullInfo => $"{FirstName} {LastName} ({EmailAddress})";
    }
}
class Personne
{
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public Personne(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }
}
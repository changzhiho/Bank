class CurrentAccount
{
    public string Number { get; set; }
    public double Balance { get; private set; }
    public double CreditLine { get; set; }
    public Personne Owner { get; set; }

    public CurrentAccount(string number, double balance, double creditline, Personne owner)
    {
        Number = number;
        Balance = balance;
        CreditLine = creditline;
        Owner = owner;

    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Vous ne pouvez pas retirer un montant négatif");
        }

        if (Balance + CreditLine >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Retrait de  {amount} euros effectué");
        }
        else
        {
            Console.WriteLine("Le retrait n'a pas pu s'effectuer");
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Dépôt de {amount} effectué");
        }
        else
        {
            Console.WriteLine("Le montant déposé doit être positif");
        }
    }
}
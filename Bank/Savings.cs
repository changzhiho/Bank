class Savings
{
    public string Number { get; set; }
    public double Balance { get; private set; }
    public DateTime DateLastWithdraw { get; private set; }
    public Personne Owner { get; set; }

    public Savings(string number, double balance, Personne owner)
    {
        Number = number;
        Balance = balance;
        Owner = owner;
        DateLastWithdraw = DateTime.MinValue;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant du retrait doit être positif.");
            return;
        }

        if (Balance >= amount)
        {
            Balance -= amount;
            DateLastWithdraw = DateTime.Now;
            Console.WriteLine($"Retrait de {amount} effectué. Nouveau solde : {Balance}.");
        }
        else
        {
            Console.WriteLine("Fonds insuffisants pour ce retrait.");
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Dépôt de {amount} effectué. Nouveau solde : {Balance}.");
        }
        else
        {
            Console.WriteLine("Le montant du dépôt doit être positif.");
        }
    }
}
class Bank
{
    public Dictionary<string, CurrentAccount> Accounts { get; }
    public string Name { get; }

    public Bank(string name)
    {
        Name = name;
        Accounts = new Dictionary<string, CurrentAccount >();
        
    }

    public void AddAccount(CurrentAccount account)
    {
        if (Accounts.TryAdd(account.Number, account))
        {
            Console.WriteLine("Le compte existe déjà");
        }
        else
        {
            Accounts.Add(account.Number, account);
            Console.WriteLine($"Le compte {account.Number} a été ajouté");
        }
    }

    public void DeleteAccount(string number)
    {
        if (Accounts.Remove(number))
        {
            Console.WriteLine($"Le compte {number} a été supprimé");
        }
        else
        {
            Console.WriteLine("Compte non trouvé");
        }
    }

    public double GetTotalBalance(Personne Owner)
    {
        double totalBalance = 0;
        foreach (var account in Accounts.Values)
        {
            totalBalance += account.GetBalance();
        }
        return totalBalance;
    }
}
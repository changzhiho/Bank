using System;
using System.Collections.Generic;

public class Bank
{
    public Dictionary<string, Account> Accounts { get; } // Travaille avec la classe de base "Account"
    public string Name { get; }

    public Bank(string name)
    {
        Name = name;
        Accounts = new Dictionary<string, Account>();
    }

    // Ajouter un compte à la banque
    public void AddAccount(Account account)
    {
        if (Accounts.ContainsKey(account.Number))
        {
            Console.WriteLine("Le compte existe déjà.");
        }
        else
        {
            Accounts.Add(account.Number, account);
            Console.WriteLine($"Le compte {account.Number} a été ajouté à la banque {Name}.");
        }
    }

    // Supprimer un compte de la banque
    public void DeleteAccount(string accountNumber)
    {
        if (Accounts.Remove(accountNumber))
        {
            Console.WriteLine($"Le compte {accountNumber} a été supprimé.");
        }
        else
        {
            Console.WriteLine("Compte non trouvé.");
        }
    }

    // Obtenir la somme totale des soldes pour tous les comptes d'une personne
    public double GetTotalBalance(Person owner)
    {
        double totalBalance = 0;

        foreach (var account in Accounts.Values)
        {
            if (account.Owner == owner)
            {
                totalBalance += account.Balance;
            }
        }

        return totalBalance;
    }

    // Afficher les informations de tous les comptes
    public void ShowAllAccounts()
    {
        foreach (var account in Accounts.Values)
        {
            account.ShowAccountInfo();
        }
    }
}
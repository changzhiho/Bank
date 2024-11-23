using System;

class Program
{
    static void Main()
    {
        // Création d'une personne
        Person p = new Person("Anthony", "Chang", new DateTime(1997, 5, 5));

        // Création d'une banque
        Bank bank = new Bank("ING");

        // Création de comptes
        CurrentAccount currentAccount = new CurrentAccount("123456", 1000, 500, p);
        Savings savingsAccount = new Savings("S123456", 2000, p);

        // Ajout des comptes à la banque
        bank.AddAccount(currentAccount);
        bank.AddAccount(savingsAccount);

        // Affichage des informations de tous les comptes
        Console.WriteLine("Informations des comptes dans la banque:");
        bank.ShowAllAccounts();

        // Calcul de la somme totale des soldes pour la personne
        double totalBalance = bank.GetTotalBalance(p);
        Console.WriteLine($"Solde total pour {p.FirstName} {p.LastName}: {totalBalance} euros.");

        // Suppression d'un compte
        bank.DeleteAccount("123456");

        // Affichage des informations restantes
        Console.WriteLine("Informations après suppression:");
        bank.ShowAllAccounts();
    }
}
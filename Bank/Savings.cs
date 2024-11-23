using System;

public class Savings : Account
{
    public DateTime DateLastWithdraw { get; private set; }

    public Savings(string number, double balance, Person owner)
        : base(number, balance, owner)
    {
        DateLastWithdraw = DateTime.MinValue; // Initialement, aucune date de retrait
    }

    // Redéfinition de la méthode Withdraw
    public override void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant du retrait doit être positif.");
            return;
        }

        if (Balance >= amount)
        {
            Console.WriteLine($"Retrait de {amount} effectué. Nouveau solde : {Balance - amount}");
            DateLastWithdraw = DateTime.Now; // Mise à jour de la date du dernier retrait
        }
        else
        {
            Console.WriteLine("Fonds insuffisants.");
        }
    }
    
    //Implémentation de la méthode CalculInterests (4,5%)
    protected override double CalculInterests()
    {
        double interest = Balance * 0.045;
        return interest;
    }

    // Méthode pour afficher la date du dernier retrait
    public void ShowLastWithdrawDate()
    {
        if (DateLastWithdraw != DateTime.MinValue)
        {
            Console.WriteLine($"Dernier retrait effectué le : {DateLastWithdraw}");
        }
        else
        {
            Console.WriteLine("Aucun retrait effectué.");
        }
    }
}
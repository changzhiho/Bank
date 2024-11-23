using System;

public class CurrentAccount : Account
{
    public double CreditLine { get; set; }

    public CurrentAccount(string number, double balance, double creditLine, Person owner)
        : base(number, balance, owner)
    {
        CreditLine = creditLine;
    }

    // Redéfinition de la méthode Withdraw
    public override void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant du retrait doit être positif.");
            return;
        }

        if (Balance + CreditLine >= amount)
        {
            Console.WriteLine($"Retrait de {amount} effectué. Nouveau solde : {Balance - amount}");
        }
        else
        {
            Console.WriteLine("Fonds insuffisants.");
        }
    }
    
    //Implémentation de la méthode CalculInterest (3% si balance positif, sinon 9,75%)
    protected override double CalculInterests()
    {
        double interest;
        if (Balance > 0)
        {
            interest = Balance * 0.03;
        }
        else
        {
            interest = Balance * 0.0975;
        }
        return interest;
    }
}

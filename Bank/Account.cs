using System;

public abstract class Account // Veuillez vous assurer que 'Account' est 'public'
{
    private double balance; // Le solde (encapsulation avec accès privé)

    public Account(string number, double balance, Person owner)
    {
        Number = number;
        this.balance = balance;
        Owner = owner;
    }

    public string Number { get; set; }
    public Person Owner { get; set; }

    public double Balance
    {
        get { return balance; }
    }

    // Méthode pour effectuer un dépôt
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Dépôt de {amount} effectué. Nouveau solde : {balance}.");
        }
        else
        {
            Console.WriteLine("Le montant du dépôt doit être positif.");
        }
    }

    // Méthode abstraite de retrait, à redéfinir dans les classes dérivées
    public abstract void Withdraw(double amount);
    
    //Méthode abstraite pour le calcul des intérêts

    protected abstract double CalculInterests();
    
    //Méthode publique pour appliquer les intérêts
    public void ApplyInterest()
    {
        double interest  = CalculInterests();
        balance += interest;
        Console.WriteLine($"Intérêts appliqués: {interest}. Nouveau solde: {balance}.");
    }
    
    // Affichage des informations du compte
    public void ShowAccountInfo()
    {
        Console.WriteLine($"Numéro de compte: {Number}, Solde: {balance}, Propriétaire: {Owner.FirstName} {Owner.LastName}");
    }

   
    
}
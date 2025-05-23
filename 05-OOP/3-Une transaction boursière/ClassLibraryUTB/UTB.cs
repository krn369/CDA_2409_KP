using System;
using System.Collections.Generic;
namespace ClassLibraryUTB;

// Represents a stock or action with a symbol and price
public class Action
{
    // Properties to store the symbol and price of the action
    public string Symbole { get; private set; }
    public decimal Prix { get; private set; }

    // Constructor to initialize the action with a symbol and price
    public Action(string symbole, decimal prix)
    {
        Symbole = symbole;
        Prix = prix;
    }

    // Method to get the symbol of the action
    public string GetSymbole()
    {
        return Symbole;
    }

    // Method to get the price of the action
    public decimal GetPrix()
    {
        return Prix;
    }
}

// Represents a transaction with details like ID, date, type, quantity, and amount
public class Transaction
{
    // Properties to store transaction details
    public int Id { get; private set; }
    public DateTime Date { get; private set; }
    public string Type { get; private set; }
    public int Quantite { get; private set; }
    public decimal Montant { get; private set; }

    // Constructor to initialize a transaction
    public Transaction(int id, DateTime date, string type, int quantite, decimal montant)
    {
        Id = id;
        Date = date;
        Type = type;
        Quantite = quantite;
        Montant = montant;
    }

    // Method to execute the transaction
    public void Executer()
    {
        // Logic to execute the transaction
        Console.WriteLine($"Transaction {Id} executed: {Type} {Quantite} shares at {Montant} total.");
    }
}

// Represents an investor with an ID, name, and a portfolio of actions
public class Investisseur
{
    // Properties to store investor details and their portfolio
    public int Id { get; private set; }
    public string Nom { get; private set; }
    public List<Action> Portefeuille { get; private set; }

    // Constructor to initialize an investor
    public Investisseur(int id, string nom)
    {
        Id = id;
        Nom = nom;
        Portefeuille = new List<Action>(); // Initialize an empty portfolio
    }

    // Method to buy a specified quantity of an action
    public void Acheter(int quantite, Action action)
    {
        // Add the action to the portfolio for the specified quantity
        for (int i = 0; i < quantite; i++)
        {
            Portefeuille.Add(action);
        }
        // Calculate the total amount for the transaction
        decimal montant = quantite * action.GetPrix();
        // Create a new transaction and execute it
        Transaction transaction = new Transaction(GenerateTransactionId(), DateTime.Now, "achat", quantite, montant);
        transaction.Executer();
    }

    // Method to sell a specified quantity of an action
    public void Vendre(int quantite, Action action)
    {
        // Remove the action from the portfolio for the specified quantity
        for (int i = 0; i < quantite; i++)
        {
            Portefeuille.Remove(action);
        }
        // Calculate the total amount for the transaction
        decimal montant = quantite * action.GetPrix();
        // Create a new transaction and execute it
        Transaction transaction = new Transaction(GenerateTransactionId(), DateTime.Now, "vente", quantite, montant);
        transaction.Executer();
    }

    // Helper method to generate a unique transaction ID
    private int GenerateTransactionId()
    {
        // Simple ID generation for demonstration purposes
        return new Random().Next(1000, 9999);
    }
}
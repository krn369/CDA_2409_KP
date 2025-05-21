# 🏦 Bank Account (CompteBancaire) Class in C#

## 🎯 Objective
Create a `CompteBancaire` class that handles:  
💰 Basic banking operations  
🛡️ With overdraft protection  

### Core Requirements
- 🔢 Store account details (number, owner, balance, overdraft)
- ⬆️⬇️ Support deposits/withdrawals
- 🔄 Transfers between accounts
- 📊 Balance comparisons

## 🛠️ Implementation

### 1️⃣ Class Structure
```csharp
public class Compte
{
    private int numero;          // 🔐 Account ID
    private string nom;         // 👤 Owner
    private int solde;           // 💰 Balance
    private int decouvertAutorise; // ➖ Overdraft

    Constructors : 💡 Pro Tip: Chain constructors using this() to avoid duplicate code!
    
    public Compte() : this(0, "", 0, 0) { }  // 🏗️ Default
    
    public Compte(int num, string name, int balance, int overdraft) 
    {
        // ✅ Initialization
    }
}


## 🔑 Key Methods

| Method | Description | Emoji | Returns |
|--------|-------------|-------|---------|
| `ToString()` | Returns formatted account info | 📝 | `string` |
| `Crediter(int montant)` | Deposits amount to balance | 💹 | `void` |
| `Debiter(int montant)` | Withdraws amount (with overdraft check) | 💸 | `bool` (success/fail) |
| `Transferer(int montant, Compte dest)` | Transfers to another account | 🔄 | `bool` (success/fail) |
| `Superieur(Compte autre)` | Compares balances | ⚖️ | `bool` (true if current > other) |

### 💡 Method Details:
```csharp
// 📝 Display account info
public override string ToString() 
{
    return $"Account [No:{numero}, Name:{nom}, Balance:{solde}€, Overdraft:{decouvertAutorise}€]";
}

// 💹 Deposit money (with validation)
public void Crediter(int montant)
{
    if (montant <= 0) throw new ArgumentException("Amount must be positive!");
    solde += montant;
}

// 💸 Withdraw with overdraft protection
public bool Debiter(int montant)
{
    if (montant <= 0 || (solde - montant) < decouvertAutorise) 
        return false;
    solde -= montant;
    return true;
}


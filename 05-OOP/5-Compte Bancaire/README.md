# Bank Account (`Compte`) Class - Overview 🏦  

## 🚀 **Objective**  
Create a simple **Bank Account** class (`Compte`) in C# to simulate basic banking operations while learning **object-oriented programming (OOP)** concepts.  

### **Key Operations**  
- Depositing funds 💰  
- Withdrawing money 💸  
- Transferring between accounts 🔄  
- Comparing account balances 📊  

---

## 🔑 **Key Features**  

### 📝 **Account Information**  
- Account number 🆔  
- Holder’s name 👤  
- Current balance 💵 (read-only)  
- Authorized overdraft limit 💳  

### 💰 **Bank Operations**  
| Method            | Description                                                  |  
|-------------------|--------------------------------------------------------------|  
| `Crediter()`      | Deposit money into the account. Throws error if amount ≤ 0.  |  
| `Debiter()`       | Withdraw money if balance + overdraft allows. Returns `true` if successful, `false` otherwise. Throws error if amount ≤ 0. |  
| `Transferer()`    | Transfer funds to another account. Validates amount and destination account. |  

### ⚖️ **Balance Comparison**  
- Implements `IComparable<Compte>` to compare accounts by their balances.  
- Provides `Superieur()` method to check if this account has a higher balance than another.  

---

## ⚠️ **Error Handling**  
- Validates that transaction amounts are positive.  
- Prevents overdrafts beyond the authorized limit.  
- Throws exceptions for invalid inputs (null account names, null destination accounts, negative amounts).  
- Ensures sufficient funds before withdrawals or transfers.  

---

## 🎯 **Learning Goals**  
✔ Understand **C# classes**, **properties**, and **methods**.  
✔ Implement **interfaces** (`IComparable<Compte>`) for object comparison.  
✔ Practice **exception handling** for robust code.  
✔ Apply real-world banking logic such as overdraft limits and balance checks.  

---


# Bank Account (`Compte`) Class - Overview 🏦  

## 🚀 **Objective**  
Create a simple **Bank Account** class (`Compte`) in C# to simulate basic banking operations while learning **object-oriented programming (OOP)** concepts.  

### **Key Operations**  
- Depositing funds  
- Withdrawing money  
- Transferring between accounts  
- Comparing account balances  

---

## 🔑 **Key Features**  

### 📝 **Account Information**  
- Account number  
- Holder’s name  
- Current balance  
- Overdraft limit  

### 💰 **Bank Operations**  
| Method            | Description |  
|-------------------|-------------|  
| `Crediter()`      | Deposit money into the account. |  
| `Debiter()`       | Withdraw money (checks overdraft limit). |  
| `Transferer()`    | Transfer funds between accounts. |  

### ⚖️ **Balance Comparison**  
- Implements `IComparable` to compare balances between accounts.  

---

## ⚠️ **Error Handling**  
- Validates transaction amounts (must be positive).  
- Prevents overdrafts beyond the limit.  
- Checks for sufficient funds before withdrawals/transfers.  

---

## 🎯 **Learning Goals**  
✔ Understand **C# classes** and **methods**.  
✔ Learn **interfaces** (`IComparable`) and **error handling**.  
✔ Implement real-world banking logic in code.  
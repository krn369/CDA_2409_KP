using AccountManagementSystem.PackageDomaine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManagementSystem
{
    public partial class FormGestionComptes : Form
    {
        public FormGestionComptes()
        {
            InitializeComponent();
        }

        private void btnTestReference_Click(object sender, EventArgs e)
        {
          
            using (ListeDeComptes portefeuille = new ListeDeComptes())
            {
                Compte compte1 = new Compte
                {
                    Num = 1,
                    DecouvertAutorise = 500,
                    Solde = 1000
                };

                portefeuille.AjouterCompte(compte1);

                MessageBox.Show(
                    $"Account {compte1.Num} belongs to a portefeuille with {portefeuille.SesComptes.Count} accounts.\n" +
                    $"The portefeuille of account {compte1.Num} is: {(compte1.SonPortefeuille != null ? "Set" : "Not set")}"
                );
            }
        }

        private void btnTestPersistence_Click(object sender, EventArgs e)
        {
            // Test SQL Server Persistence
            var sqlPersistence = new AccountManagementSystem.PackagePersistanceSQLServer.PersistenceCompte();
            Compte compteSQL = new Compte { Num = 1, Solde = 1000, DecouvertAutorise = 500 };
            sqlPersistence.Create(compteSQL);
            sqlPersistence.Update(compteSQL);
            sqlPersistence.Delete(compteSQL);
            Compte selectedCompteSQL = sqlPersistence.Select(1);

            // Test MySQL Persistence
            var mysqlPersistence = new AccountManagementSystem.PackagePersistanceMySQL.PersistenceCompte();
            Compte compteMySQL = new Compte { Num = 2, Solde = 2000, DecouvertAutorise = 1000 };
            mysqlPersistence.Create(compteMySQL);
            mysqlPersistence.Update(compteMySQL);
            mysqlPersistence.Delete(compteMySQL);
            Compte selectedCompteMySQL = mysqlPersistence.Select(2);

            // Show a success message
            MessageBox.Show(
                $"SQL Server: Les opérations de persistance ont été testées pour le compte {selectedCompteSQL.Num}.\n" +
                $"MySQL: Les opérations de persistance ont été testées pour le compte {selectedCompteMySQL.Num}."
            );
        }
    }
}



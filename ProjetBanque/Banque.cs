using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBanque
{
	public class Banque
	{
		private string nom;

		void afficherMenu ()
		{
			int choixUtilisateur = 0;
			do
			{
				Console.WriteLine("0 Ajouter un compte");
				Console.WriteLine("1 Supprimer un compte");
				Console.WriteLine("2 Obtenir un compte");
				Console.WriteLine("3 Afficher un compte");
				Console.WriteLine("4 Effectuer un virement");
				do
				{
					choixUtilisateur = read.readInt();
				}while(0 < choixUtilisateur || choixUtilisateur > 0 );

				switch(choixUtilisateur)
				{
				case 0:
					GestionCompte.Afficher;
					Console.WriteLine("Indiquez le compte à ajouter: ");
					int libelle = read.readInt();
					GestionCompte.Ajouter(libelle);
				break;
				}
			}while(choixUtilisateur != 0);
				
		}
	}
}


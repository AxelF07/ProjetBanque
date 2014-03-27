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
				Console.WriteLine("0 Supprimer un compte");
				Console.WriteLine("0 Obtenir un compte");
				Console.WriteLine("0 Afficher un compte");
				Console.WriteLine("0 Effectuer un virement");
				do
				{
					choixUtilisateur = read.readInt();
				}while(0 < choixUtilisateur || choixUtilisateur > 0 );
			}while(choixUtilisateur != 0);
				
		}
	}
}


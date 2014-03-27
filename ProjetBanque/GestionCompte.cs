using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
	public class GestionCompte
	{

		private List<Compte> ListeComptes = new List<Compte>();

		public void Ajouter(Compte compte)
		{
			ListeComptes.Add (compte);
		}

		public void Supprimer (Compte compte)
		{
			ListeComptes.Remove (compte);
		}

		public Compte Obtenir (int numero)
		{
			return null;
		}

		public int Afficher ()
		{

		}

		public int Virement ()
		{

		}
	}
}


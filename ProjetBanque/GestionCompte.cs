using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
	public class GestionCompte
	{

		List<Compte> ListeComptes = new List<Compte>();

		public int Ajouter()
		{
			ListeComptes.Add (new Compte ());
		}

		public int Supprimer ()
		{
			ListeComptes.Remove (Compte ());
		}

		public int Obtenir ()
		{
		}

		public int Afficher ()
		{
		}

		public int Virement ()
		{
		}
	}
}


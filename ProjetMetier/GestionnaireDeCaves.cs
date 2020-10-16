using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            LesCaves.Add(unNomDeCave,lesBouteillesDeLaCave);
           
        }

        public int NbBouteilles(string unNomDeCave)
        {
            int NbBouteilles = 0;
            foreach (Bouteille bou in LesCaves)
            {
                NbBouteilles = NbBouteilles + bou.QuantiteBouteille;
            };

            return NbBouteilles;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            int NbBouteillesRouge = 0;
            foreach (Bouteille bou in LesCaves)
            {
                foreach(Vin vin in bou.LeVin)
                {
                    foreach(Couleur cou in vin.LaCouleur)
                    {
                        if(cou.NomCouleur.CompareTo("Rouge")==0)
                        {
                            NbBouteillesDeRouges++;
                        }
                    }
                }

            }
            return NbBouteillesDeRouges;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            double valeur = 0;
            return 0;
        }
    }
}

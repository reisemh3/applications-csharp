using System;
using System.Collections.Generic;
using System.Linq;

namespace Annuaire // Note: actual namespace depends on the project name.
{
    public class Gestion : Candidats //Formulaire de gestion des candidats
    {
        private List<Candidats> CandidatsCollections;
        public CandidatsService() { get; set; }
        public void Ajouter(Candidats candidats)
        {
            this.CandidatsCollections.Add(candidats);
        }
        public List<Candidats> TousCandidats()
        {
            return this.CandidatsCollections;
        }
    }
}
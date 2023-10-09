using System;
using System.Collections.Generic;
using System.Text;

namespace dm_cinema_aiman
{
    class Acteur
    {
        private string anneeNaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur()
        {

        }
        public Acteur(string anneeNaissance, int id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public string AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Acteur getInstance(string Anee,int id, string nom,string prenom)
        {
            Acteur a1bis=new Acteur(Anee,id,nom,prenom);
            return a1bis;
        }
        public override string ToString()
        {
            return "Nom : "+this.nom+ " Prénom : "+this.prenom +" année de naissance : "+this.anneeNaissance;
        }
    }
}

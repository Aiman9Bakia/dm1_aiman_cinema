using System;
using System.Collections.Generic;
using System.Text;

namespace dm_cinema_aiman
{
    class Film
    {
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film(int annee, string genre, int idFilm, string resume, string titre,Acteur acteurprincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurprincipal;
        }

        public int Annee { get => annee; set => annee = value; }
        public string Genre { get => genre; set => genre = value; }
        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Titre { get => titre; set => titre = value; }

        public Acteur ActeurPrincipal { get => acteurPrincipal; set => acteurPrincipal = value; }

        public Film getInstance(int annee,string genre,int idFilm,string resume,string titre,Acteur ap)
        {
             Film filmbis = new Film(annee, genre, idFilm, resume, titre, ap);
            return filmbis;
        }

        public override string  ToString()
        {
            return "Titre: " + this.titre +
                "\n Année: " + this.annee +
                "\n Genre: " + this.genre+
                "\n Résumé: "+this.resume+
                "\n Acteur Principal : "+this.acteurPrincipal;
        }
    }
}

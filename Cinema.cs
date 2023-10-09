using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace dm_cinema_aiman
{
    class Cinema
    {
        private Cinema cine;
        private List<Film> lesFilms;
        private List<Acteur> lesActeurs;


        public Cinema()
        {
            this.cine = cine;
            this.lesFilms = new List<Film>();
            this.lesActeurs = new List<Acteur>();
        }

        

        public Cinema(Cinema cine)
        {
            this.cine = cine;
            this.lesFilms = new List<Film>();
            this.lesActeurs = new List<Acteur>();
        }

        public Cinema Cine { get => cine; set => cine = value; }
        public List<Film> LesFilms { get => lesFilms; set => lesFilms = value; }
        public List<Acteur> LesActeurs { get => lesActeurs; set => lesActeurs = value; }

        public Acteur GetActeur(int id)
        {
            int i = 0; int j = 0;
            foreach( Acteur unActeur in lesActeurs)
            {
                if (id == unActeur.Id)
                {
                    
                    j = i;
                }
                i++;
            }

            return lesActeurs[j];
            //possible de faire un foreach avec un nouvel objet à qui on va donner
            //les valeurs de l'objet qui a le même id et de donner au nouvel objet les attributs
            //de celui déja crée et le retourner
        }

        public Film GetFilm(int id)
        {
            int i = 0; int j = 0;
            foreach (Film unfilm in lesFilms)
            {
                if (id == unfilm.IdFilm)
                {

                    j = i;
                }
                i++;
            }

            return lesFilms[j];
        }

        public int nbActeur(List<Acteur> list)
        {
            return list.Count;
        }

        public void SetFilm(int annee,string genre, int idFilm,string resume,string titre, Acteur acteurPrincipal) 
        {
            Film filmauPif = new Film (annee, genre, idFilm,resume, titre,acteurPrincipal);
            this.LesFilms.Add(filmauPif);
            //this.LesFilms.Add(new Film(annee,genre,idFilm,resume,titre,acteurPrincipal));
        }
        public void SetActeur(string anneeNaissance,int id, string nom, string prenom)
        {
            Acteur abdkdslsd = new Acteur(anneeNaissance, id, nom, prenom);
            this.lesActeurs.Add(abdkdslsd);
            //this.lesActeurs.Add(new Acteur(anneeNaissance, id, nom, prenom)) aussi possible d'écrire comme ça mais les objets n'auront pas de nom
        }


        public override string ToString()
        {
            string str = "";
            foreach(Film unfilm in lesFilms)
            {
                str += unfilm.ToString() + "\n";
            }

            foreach(Acteur unacteur in lesActeurs)
            {
                str += unacteur.ToString() + "\n";
            }

            return str;
        }


    }
}

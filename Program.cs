﻿using System;

namespace dm_cinema_aiman
{
    class Program
    {
        static void Main(string[] args)
        {
            Acteur monActeur = new Acteur("13/06/1942", 1, "Ford", "Harrison");
            
            Film monFilm = new Film(1982, "Science-Fiction", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner",monActeur);
            
            Acteur a2 = new Acteur("09/07/1956", 2, "Hanks", "Tom");
            Film f2 = new Film(1992, "Aimation", 2, 
            "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux."
            , "Toy Story", a2);
            Cinema monCinema = new Cinema();
            monCinema.LesActeurs.Add(monActeur);
            monCinema.LesActeurs.Add(a2 );
            monCinema.LesFilms.Add(monFilm);
            monCinema.LesFilms.Add (f2);
            //Console.WriteLine(c1.ToString());
            Console.WriteLine(monCinema.GetActeur(2));
            Console.WriteLine(monCinema.ToString());
        }
    }
}

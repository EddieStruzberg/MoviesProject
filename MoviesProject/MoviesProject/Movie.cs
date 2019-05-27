using System;
using System.Collections.Generic;

namespace MoviesProject
{
    internal class Movie
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Seasons { get; set; }
        public int Views { get; set; }
        public string Details { get; set; }

        public Movie(int _Id, string _ImageName, string _Title, string _Seasons, int _Views, string _Details)
        {
            Image = "Images//" + _ImageName;
            Title = _Title;
            Seasons = _Seasons;
            Views = _Views;
            Details = _Details;
            ID = _Id;
        }
    }
    internal static class MovieGenerator
    {
        public static List<Movie> Movies
        {
            get {
                return movies;
            }
            set
            {
                movies = value ;
            }
        }
        private static List<Movie> movies = new List<Movie>() {
                new Movie(0,"Apollo11.jpg", "APOLLO 11", "2019", 5500,
                "Critics Consensus: Edifying and inspiring in equal measure, Apollo 11 uses artfully repurposed archival footage to send audiences soaring back to a pivotal time in American history.\nSynopsis: Apollo 11 is a cinematic space event film fifty years in the making.Featuring never-before-seen large-format film footage of one...\nStarring:\nDirected By: Todd Douglas Miller\n"),
                new Movie(1,"WOMAN_AT_WAR.jpg", "WOMAN AT WAR", "2018", 6100,
                "Critics Consensus: Treating its timely themes with a deceptively light touch, Woman at War is easy to enjoy in the moment, yet its impact lingers long after the closing credits roll.\nSynopsis: Halla is a fifty-year-old independent woman. But behind the scenes of a quiet routine, she leads a double life\nStarring: Halldóra Geirharðsdóttir, Jóhann Sigurðarson, David Thor Jonsson, Magnus Trygvason Eliasen\nDirected By: Benedikt Erlingsson\n"),
                new Movie(2,"ThreeFACES.jpg", "3 FACES", "2017", 7350,
                "Critics Consensus: Observational, insightful, and ultimately powerful, 3 Faces adds another quietly thought-provoking chapter to writer-director Jafar Panahi's filmography.\nSynopsis: Well-known actress Behnaz Jafari is distraught by a provincial girl's video plea for help--oppressed by her family to not pursue...\nStarring: Behnaz Jafari, Jafar Panahi, Marziyeh Rezaei, Maedeh Erteghaei\nDirected By: Jafar Panahi\n"),
                new Movie(3,"AMAZING_GRACE.jpg", "AMAZING GRACE", "2019", 8420,
                "Critics Consensus: Brilliantly capturing a remarkable performer near the peak of her prodigious power, Amazing Grace is a thrilling must-watch documentary for Aretha Franklin fans.\nSynopsis: Concert footage from 1972 of Aretha Franklin performing songs from the best-selling gospel album at the New Temple Missionary Baptist...\nStarring: Aretha Franklin, C.L. Franklin, Rev. James Cleveland, Bernard Pretty Purdie\n"),
                new Movie(4,"RODENTS OF UNUSUAL SIZE.jpg", "RODENTS OF UNUSUAL SIZE", "2019", 3540,
                "Critics Consensus: Rodents of Unusual Size approaches a variety of timely and thought-provoking subjects from fresh angles -- and a lot of surprisingly large creatures in the bargain.\nSynopsis: Hard headed Louisiana fisherman Thomas Gonzales doesn't know what will hit him next. After decades of hurricanes and oil spills...\nStarring: Wendell Pierce\nDirected By: Quinn Costello, Chris Metzler, Jeff Springer\n"),
                new Movie(5,"THE HEIRESSES.jpg", "THE HEIRESSES", "2015", 6541,
                "Critics Consensus: Led by a standout performance from Ana Brun, The Heiresses takes a thoroughly compelling look at lives little explored by mainstream cinema.\nSynopsis: Chela and Chiquita, both descended from wealthy families in Asunción, Paraguay, have been together for over 30 years. But recently... [More]\nStarring: Ana Brun, Ana Ivanova, Margarita Irún, Nilda Gonzalez\nDirected By: Marcelo Martinessi\n")
                };

    }
}
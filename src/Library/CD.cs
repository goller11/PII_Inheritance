using System;

namespace Herencia {

    public class CD {
        private String name;

        private String genre;

        private Int32 year;
        private String interprete;
        private String[] songs;

        public String Genre {
            get{
                return this.genre;
            }
        }

        public CD (String name, String genre, Int32 year, String interprete, String[] songs) {
            this.name = name;
            this.genre = genre;
            this.year = year;
            this.interprete = interprete;
            this.songs = songs;
        }

    }
}
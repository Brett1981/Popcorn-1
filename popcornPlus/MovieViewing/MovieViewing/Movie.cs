using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieViewing
{
    class Movie
    {
        private string movieId;
        private string title;
        private string genre;
        private string runTime;
        private Image poster;
        private double ticketPrice;
        private string director;
        private string cast;

        /// <summary>
        /// Test Update
        /// </summary>
        /// <param name="movieIn"></param>
        /// <param name="titleIn"></param>
        /// <param name="genreIn"></param>
        /// <param name="runTimeIn"></param>
        /// <param name="posterIn"></param>
        /// <param name="ticketPriceIn"></param>
        /// <param name="directorIn"></param>
        /// <param name="castIn"></param>
        public Movie(string movieIn, string titleIn, string genreIn, string runTimeIn, Image posterIn, double ticketPriceIn
            , string directorIn, string castIn)
        {
            movieId = movieIn;
            title = titleIn;
            genre = genreIn;
            runTime = runTimeIn;
            poster = posterIn;
            ticketPrice = ticketPriceIn;
            director = directorIn;
            cast = castIn;
        }

        public string getMovieId()
        {
            return movieId;
        }
        public void setMovieId(string movieIdIn)
        {
            movieId = movieIdIn;
        }
        public string getTitle()
        {
            return title;
        }
        public void setTitle(string titleIn)
        {
            title = titleIn;
        }
        public string getGenre()
        {
            return genre;
        }
        public void setGenre(string genreIn)
        {
            genre = genreIn;
        }
        public string getRunTime()
        {
            return runTime;
        }
        public void setRunTime(string runTimeIn)
        {
            runTime = runTimeIn;
        }
        public Image getPoster()
        {
            return poster;
        }
        public void setPoster(Image posterIn)
        {
            poster = posterIn;
        }
        public double getTicketPrice()
        {
            return ticketPrice;
        }
        public void setTicketPrice(double ticketPriceIn)
        {
            ticketPrice = ticketPriceIn;
        }
        public string getDirector()
        {
            return director;
        }
        public void setDirector(string directorIn)
        {
            director = directorIn;
        }

        public string getCast()
        {
            return cast;
        }
        public void setCast(string castIn)
        {
            cast = castIn;
        }
    }
}

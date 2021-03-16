using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        //We will use the same _contentDirectory from StreamingContentRepository.cs

        //Read --> Show
        public Show GetShowByTitle(string title)
        {
            //To find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() ==title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }

        //Read --> Movie
        public Movie GetMovieByTitle(string title)
        {
            //To find a specific movie
            foreach(StreamingContent content in _contentDirectory)
            {
                                                        // can use (is) instead of content.GetType() == typeof
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        //Read --> get all
        public List<Show> GetAllShows()
        {
            //use this to add our shows --. starts empty (we will return this list)
            List<Show> AllShows = new List<Show>();

            foreach(StreamingContent content in _contentDirectory)
            {
                //if the content that we find is of type show..
                if(content is Show)
                {
                    //add the show to the AllShows list
                    AllShows.Add((Show)content);
                }
            }
            return AllShows;
        }

        //Read get all movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> AllMovies = new List<Movie>();

            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Movie)
                {
                    AllMovies.Add(content as Movie);
                }
            }
            return AllMovies;
        }

        
        //get by RunTime/AverageRunTime
        
        //get shows with over x episodes
        //get shows/movie by rating
    }
}

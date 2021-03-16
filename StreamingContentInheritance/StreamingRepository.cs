using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContentInheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        //We can use the same _contentDirector from StreamingContentRepository.cs since we inherited it.

        //Read method
        public Show GetShowByTitle(string title)
        {
            //To find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() ==typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }

        //Read -> Movie

        public Movie GetMovieByTitle(string title)
        {
            //Find a specific movie
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower()==title.ToLower() && content is Movie) // 'is' is the same as '==typeof()'
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        //Read get all Shows
        public List<Show> GetAllShows()
        {
            //Use this to hold list of shows -> Starts empty... Empty != null
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        //Read get all Movies
        public List<Movie> GetAllMovies()
        {
            //Use this to hold list of shows -> Starts empty... Empty != null
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }
            }
            return allMovies;
        }

        //Get all shows with more then X episodes
        //public List<Show> GetShowsWithMoreEpisodes(int episodeCount)
        //{
            //                      #####This challenge was cancelled#####
        //}

    }
}

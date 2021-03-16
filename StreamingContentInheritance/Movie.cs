using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContentInheritance
{
    public class Movie:StreamingContent
    {
        //We also get all the properties of StreamingContent since this class inherits from it. So it "is a" StreamingContent
        public double RunTime { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string description, MediaMaturityRating maturityRating, GenreType genreType, double starRating)
            :base(title,description,maturityRating,genreType,starRating)
        {
            RunTime = RunTime;
        }
    }
}

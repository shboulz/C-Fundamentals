using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    //we are inheriting everything from :streamingcontent to movie (inheritance means "IS A" relationship)
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string description, MaturityRating maturityRating, GenreType genreType, double starRating, double runTime)
            :base(title, description, maturityRating, genreType, starRating)
        {
            RunTime = runTime;
        }
    }
}

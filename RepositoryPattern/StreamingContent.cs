using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public enum MediaMaturityRating { G, PG, PG_13, R, TV_Y, TV_G, TV_PG, TV_14, TV_MA}
    public enum GenreType {Horror = 1, RomCom, SciFi, Documentary, Bromance, Drama, Action}
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MediaMaturityRating MaturityRating { get; set; }
        public GenreType GenreType { get; set; }
        public bool IsFamilyFriendly 
        {
            get
            {
                switch (MaturityRating)
                {
                    case MediaMaturityRating.G:
                    case MediaMaturityRating.PG:
                    case MediaMaturityRating.TV_Y:
                    case MediaMaturityRating.TV_G:
                    case MediaMaturityRating.TV_PG:
                        return true;
                    case MediaMaturityRating.TV_14:
                    case MediaMaturityRating.PG_13:
                    case MediaMaturityRating.R:
                    case MediaMaturityRating.TV_MA:
                    default:
                        return false;
                }
                //if ((int)MaturityRating > 4)
                //{
                //    return false;
                //}
                //else
                //{
                //    return true;
                //}

            }
            
        }
        public StreamingContent(){}

        public StreamingContent(string title, string description, MediaMaturityRating maturityRating, GenreType genreType, double starRating)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            GenreType = genreType;           
            StarRating = starRating;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        //Get by star rating
        public List<StreamingContent> GetByStarRating(double starRating)
        {
            List<StreamingContent> matchingContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (starRating == content.StarRating)
                {
                    matchingContent.Add(content);
                }
            }
            return matchingContent;
        }
        //Get by family friendly
        public List<StreamingContent> GetFamilyFriendly(bool familyFriendly)
        {
            List<StreamingContent> matchingContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (familyFriendly == content.IsFamilyFriendly)
                {
                    matchingContent.Add(content);
                }
            }
            return matchingContent;
        }

        //Filter by maturity rating
        public List<StreamingContent> GetMaturityRating(MediaMaturityRating maturityRating)
        {
            List<StreamingContent> matchingContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (maturityRating == content.MaturityRating)
                {
                    matchingContent.Add(content);
                }
            }
            return matchingContent;
        }

        //Filter by genre
        public List<StreamingContent> GetGenre(GenreType genreType)
        {
            List<StreamingContent> matchingContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (genreType == content.GenreType)
                {
                    matchingContent.Add(content);
                }
            }
            return matchingContent;
        }

        //Filter by description
        public List<StreamingContent> FilterByDescription(string description)
        {
            List<StreamingContent> matchingContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Description.Contains(description))
                {
                    matchingContent.Add(content);
                }
            }
            return matchingContent;
        }
        ////Get by non family friendly
        //public List<StreamingContent> GetNotFamilyFriendly(bool familyFriendly)
        //{
        //    List<StreamingContent> matchingContent = new List<StreamingContent>();
        //    foreach (StreamingContent content in _contentDirectory)
        //    {
        //        if (familyFriendly != true)
        //        {
        //            matchingContent.Add(content);
        //        }
        //    }
        //    return matchingContent;
        //}


    }
}

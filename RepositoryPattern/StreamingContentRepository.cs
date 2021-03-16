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
        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            // Initiating the count
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            // is the contentDirectory.count greater than starting count?
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Read
        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }

        // getting specific titles
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            //NOT BEST PRACTICE SHOULD NOT DO THIS!
            return null;
        }

        public List<StreamingContent> GetContentByMaturityRating(MaturityRating maturityRating)
        {
            List<StreamingContent> maturityRatingResults = new List<StreamingContent>();

            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.MaturityRating == maturityRating)
                {
                    maturityRatingResults.Add(content);
                    
                }
            }
            return maturityRatingResults;
        }

        public List<StreamingContent> GetContentByFamilyFriendly(bool isFamilyFriendly)
        {
            List<StreamingContent> familyFriendly = new List<StreamingContent>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly == isFamilyFriendly)
                {
                    familyFriendly.Add(content);
                }
            }
            return familyFriendly;
        }
        public List<StreamingContent> GetContentByGenre(GenreType genreType)
        {
            List<StreamingContent> genreTypeResults = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GenreType == genreType)
                {
                    genreTypeResults.Add(content);
                }
            }
            return genreTypeResults;

        }
        public List<StreamingContent> GetContentByStarRating(double starRating)
        {
            List<StreamingContent> starRatingResults = new List<StreamingContent>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.StarRating == starRating)
                {
                    starRatingResults.Add(content);
                }
            }
            return starRatingResults;
        }
        //Update
        public bool UpdateExistingContent(string OriginalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(OriginalTitle);

            if(oldContent != null)
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
        // To remove
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        //Get by other parameters
        //Get By Rating
        //Get by Family Friendly
    }
}

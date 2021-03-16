using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {


        //We want to test the add method in the repo
        [TestMethod]
        public void AddToDirectoryShouldGetCorrectBoolean()
        {
            //Follow the 3 A's -> Arrange, Act, Assert

            //Arrange -> Overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act -> Get/Run the code to test
            bool addResult = repository.AddContentToDirectory(content);


            //Assert -> Used to get the expected outcome of a test
            Assert.IsTrue(addResult);

            //Console.WriteLine(addResult);
        }

        //Testing the Read Method GetContents
        [TestMethod]
        public void GetDirectoryShouldReturnCorrectCollection()
        {
            //Follow the 3 A's -> Arrange, Act, Assert

            //Arrange -> Overall setup
            //create the content
            StreamingContent movie = new StreamingContent();
            //Create the repository
            StreamingContentRepository listOfMovies = new StreamingContentRepository();
            //add to the repository
            listOfMovies.AddContentToDirectory(movie);


            //Act -> Get/Run the code to test
            //Our plan is to store a list of StreamingContent in a variable
            List<StreamingContent> contents = listOfMovies.GetContents();

            bool directoryHasContent = contents.Contains(movie);

            //Assert -> Used to get the expected outcome of a test
            Assert.IsTrue(directoryHasContent);

        }

        //We will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        private StreamingContent _content2;

        //This is the Arrange Part
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            //We make a movie here ....finally....
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode",
                                            MediaMaturityRating.R, GenreType.Drama, 5.8d);
            _content2 = new StreamingContent("Rubber-Duck", "A car tire comes to life with the power to make people explode",
                                            MediaMaturityRating.R, GenreType.Drama, 5.8d);

            //Now the movie is in our 'database' (list)
            _repo.AddContentToDirectory(_content);
            _repo.AddContentToDirectory(_content2);
        }

        //retrieve content by title
        [TestMethod]
        public void GetByTitleShouldReturnCorrectContent()
        {
            //Arrange -> done above

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            Assert.AreEqual(searchResult, _content);

        }


        //Test the Update Method
        [TestMethod]
        public void UpdateExistingContentShouldReturnTrue()
        {
            //Arrange -> Updated version of our movie
            StreamingContent newContent = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode",
                                            MediaMaturityRating.R, GenreType.Drama, 9.8d);
            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);
            //Assert
            Assert.IsTrue(updateResult);
        }


        //Test the Delete Method
        [TestMethod]
        public void DeleteExistingContentShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);
        }

        //Search by description
        //This isn't working correctly
        [TestMethod]
        public void FilterByDescriptionShouldReturnCorrectContent()
        {
            //Arrange -> done above

            //Act
            List<StreamingContent> searchResults = _repo.FilterByDescription("to life");
            StreamingContent searchResult = searchResults[0];
            Assert.IsNotNull(searchResult);
            Console.WriteLine(searchResult.Description);
            
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        // We want to test the Add Method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA -> Arrange, Act, Assert

            //Arrange-> Overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act-> Get / Run the code to test
            bool addResult = repository.AddContentToDirectory(content);

            //Assert-> Used to get the expected outcome of a test
            Assert.IsTrue(addResult);

        }

        //Testing the Read Method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA RULES APPLY!

            //Arrange-> Initial setup 
            //Creating the Content
            StreamingContent content = new StreamingContent();

            //Creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();

            //Adding to the repo
            repo.AddContentToDirectory(content);

            //Act
            //our plan is to store the list of streaming content in a variable
            List<StreamingContent> contents = repo.GetContent();

            //looks through our entire list and returns true if there is content
            bool directoryHasContent = contents.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);

        }

        //We will start with private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;


        //This is the Arrange part!
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();

            //We make a new movie here..........Finally.......
            _content = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode", MaturityRating.R, GenreType.Drama, 5.8d);

            //now the movie in our 'database' (list)
            _repo.AddContentToDirectory(_content);

        }

        //retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange.....Already done above

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }

        //Test the update mathod
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange -. Updated version of our movie
            StreamingContent newContent = new StreamingContent("Rubber part 2", "A car tyre comes to life with the power to make people explode", MaturityRating.R, GenreType.Drama, 9.8d);

            //Act
            bool updatedResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updatedResult);
            //Console.WriteLine(GiveMeInfo(_content));

        }

        //Testing theory
        //public string GiveMeInfo(StreamingContent content)
        //{
        //    var result = $"{content.Title}\n" + $"{content.StarRating}";
        //    return result;
        //}

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}

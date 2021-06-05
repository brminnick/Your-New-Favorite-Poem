using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Your_New_Favorite_Poem;
using Your_New_Favorite_Poem.Constants;
using Your_New_Favorite_Poem.Pages;

namespace YourNewFavoritePoem.UnitTests.Tests
{
    class AddPoetModelTests : BaseTest
    {
        [Test]
        public async Task OnPostSubmit_AddPoetModel_AddsNewPoetToDatabase()
        {
            //Arrange
            var emptyLogger = new NullLogger<AddPoetModel>();
            var addPoetPage = new AddPoetModel(emptyLogger, AuthorsDbContext);
            string authorName = "😀😀";
            string poemUrl = PoemsConstants.AuthorList[0].Poems.First().URL?.ToString() ?? throw new NullReferenceException();
            string poemName = PoemsConstants.AuthorList[0].Poems.First().Title;
            string bio = PoemsConstants.AuthorList[0].Bio;
            string pictureUrl = PoemsConstants.AuthorList[0].PictureURL?.ToString() ?? throw new NullReferenceException();
            string pictureAltText = PoemsConstants.AuthorList[0].PictureAltText;
            int authorsCount_initial = AuthorsDbContext.Authors.Count();
            int authorsCount_final;

            //Act
            await addPoetPage.OnPostSubmit(authorName, poemUrl, poemName, bio, pictureUrl, pictureAltText);
            authorsCount_final = AuthorsDbContext.Authors.Count();

            //Assert
            Assert.AreEqual(authorsCount_initial + 1, authorsCount_final);

            var newestAuthor = AuthorsDbContext.Authors.Last();
            Assert.AreEqual(authorName, newestAuthor.Name);
            Assert.AreEqual(poemUrl, newestAuthor.Poems.First().URL?.ToString());
            Assert.AreEqual(poemName, newestAuthor.Poems.First().Title);
            Assert.AreEqual(bio, newestAuthor.Bio);
            Assert.AreEqual(pictureUrl, newestAuthor.PictureURL?.ToString());
            Assert.AreEqual(pictureAltText, newestAuthor.PictureAltText);
        }
    }
}
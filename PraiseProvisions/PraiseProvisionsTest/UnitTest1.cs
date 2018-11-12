using System;
using Xunit;
using PraiseProvisions;
using PraiseProvisions.Models;
using PraiseProvisions.Data;
using PraiseProvisions.Controllers;

namespace PraiseProvisionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetChefNameViaChefResultsModel()
        {
            ChefResults chef = new ChefResults();
            chef.firstName = "Colonel";

            Assert.Equal("Colonel", chef.firstName);
        }

        [Fact]
        public void CanGetChefLastNameViaChefResultsModel()
        {
            ChefResults chef = new ChefResults();
            chef.lastName = "Sanders";

            Assert.Equal("Sanders", chef.lastName);
        }

        [Fact]
        public void CanGetRestaurantViaChefResultsModel()
        {
            ChefResults restaurant = new ChefResults();
            restaurant.restaurantName = "KFC";

            Assert.Equal("KFC", restaurant.restaurantName);
        }

        [Fact]
        public void CanGetAddressViaChefResultsModel()
        {
            ChefResults addresses = new ChefResults();
            addresses.address = "1900 Colonel Sanders Lane, Louiville, KY 40213";

            Assert.Equal("1900 Colonel Sanders Lane, Louiville, KY 40213", addresses.address);
        }

        [Fact]
        public void CanGetDescriptionViaChefResultsModel()
        {
            ChefResults descriptions = new ChefResults();
            descriptions.description = "Finger lickin' good!";

            Assert.Equal("Finger lickin' good!", descriptions.description);
        }

        [Fact]
        public void CanGetCityViaChefResultsModel()
        {
            ChefResults location = new ChefResults();
            location.city = "Louiville";

            Assert.Equal("Louiville", location.city);
        }

        [Fact]
        public void CanGetChefReviewsViaChefResultsModel()
        {
            ChefResults reviews = new ChefResults();
            reviews.review = "This is a raving review";

            Assert.Equal("This is a raving review", reviews.review);
        }

        [Fact]
        public void CanGetFirstNameViaCelelbrityChefModel()
        {
            CelebrityChef chef = new CelebrityChef();
            chef.firstName = "Marcus";

            Assert.Equal("Marcus", chef.firstName);
        }

        [Fact]
        public void CanGetLastNameViaCelebrityChefModel()
        {
            CelebrityChef chef = new CelebrityChef();
            chef.lastName = "Samuelsson";

            Assert.Equal("Samuelsson", chef.lastName);
        }

        [Fact]
        public void CanGetCityViaCelebrityChefModel()
        {
            CelebrityChef chef = new CelebrityChef();
            chef.city = "Addis Ababa";

            Assert.Equal("Addis Ababa", chef.city);
        }

        [Fact]
        public void CanGetFavoritesViaCelebrityChefModel()
        {
            CelebrityChef chef = new CelebrityChef();
            chef.favorites = "Estela Restaurant";

            Assert.Equal("Estela Restaurant", chef.favorites);
        }

    }
}

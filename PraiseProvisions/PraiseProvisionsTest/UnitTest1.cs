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

        [Fact]
        public void CanGetRestaurantNameViaRestaurantModel()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Name = "Some Random Bar";

            Assert.Equal("Some Random Bar", restaurant.Name);
        }

        [Fact]
        public void CanGetRestaurantAddressViaRestaurantModel()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Address = "2604 1st Ave, Seattle, WA 98121";

            Assert.Equal("2604 1st Ave, Seattle, WA 98121", restaurant.Address);
        }

        [Fact]
        public void CanGetDescriptionViaRestaurantModel()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Description = "Local New American eats and craft cocktails served in brick-walled gastropub with Mason jar lighting.";

            Assert.Equal("Local New American eats and craft cocktails served in brick-walled gastropub with Mason jar lighting.", restaurant.Description);
        }

        [Fact]
        public void CanGetUserProfileFullNameViaUserProfileModel()
        {
            UserProfile userProfile = new UserProfile();
            userProfile.fullName = "Best Restaurant App Ever";

            Assert.Equal("Best Restaurant App Ever", userProfile.fullName);
        }

        [Fact]
        public void CanGetCategoryAliasViaYelpResultsModel()
        {
            Category category = new Category();
            category.alias = "test category alias";

            Assert.Equal("test category alias", category.alias);
        }

        [Fact]
        public void CanGetCategoryTitleViaYelpResultsModel()
        {
            Category category = new Category();
            category.title = "test category title";

            Assert.Equal("test category title", category.title);
        }

        [Fact]
        public void CanGetLocationAddress1ViaYelpResultsModel()
        {
            Location location = new Location();
            location.address1 = "Test Location Address 1";

            Assert.Equal("Test Location Address 1", location.address1);
        }

        [Fact]
        public void CanGetLocationAddress2ViaYelpResultsModel()
        {
            Location location = new Location();
            location.address2 = "Test Location Address 2";

            Assert.Equal("Test Location Address 2", location.address2);
        }

        [Fact]
        public void CanGetLocationAddress3ViaYelpResultsModel()
        {
            Location location = new Location();
            location.address3 = "Test Location Address 3";

            Assert.Equal("Test Location Address 3", location.address3);
        }

        [Fact]
        public void CanGetLocationCityViaYelpResultsModel()
        {
            Location location = new Location();
            location.city = "Test Location City";

            Assert.Equal("Test Location City", location.city);
        }

        [Fact]
        public void CanGetLocationZipCodeViaYelpResultsModel()
        {
            Location location = new Location();
            location.zip_code = "Test Location Zip Code";

            Assert.Equal("Test Location Zip Code",location.zip_code);
        }

        [Fact]
        public void CanGetLocationCountryViaYelpResultsModel()
        {
            Location location = new Location();
            location.country = "Test Location Country";

            Assert.Equal("Test Location Country", location.country);
        }

        [Fact]
        public void CanGetLocationStateViaYelpResultsModel()
        {
            Location location = new Location();
            location.state = "Test Location State";

            Assert.Equal("Test Location State", location.state);
        }
    }
}

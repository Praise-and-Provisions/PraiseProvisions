using System;
using Xunit;
using PraiseProvisions;
using PraiseProvisions.Models;
using PraiseProvisions.Data;
using PraiseProvisions.Controllers;
using Microsoft.EntityFrameworkCore;

namespace PraiseProvisionsTest
{
    public class UnitTest1
    {/// <summary>
    /// Tests getting Chef's first name from Chef Results Model
    /// </summary>
        [Fact]
        public void CanGetChefNameViaChefResultsModel()
        {
            ChefResults chef = new ChefResults();
            chef.firstName = "Colonel";

            Assert.Equal("Colonel", chef.firstName);
        }

        /// <summary>
        /// Tests getting Chef's last name from Chef Results Model
        /// </summary>
        [Fact]
        public void CanGetChefLastNameViaChefResultsModel()
        {
            ChefResults chef = new ChefResults();
            chef.lastName = "Sanders";

            Assert.Equal("Sanders", chef.lastName);
        }

        /// <summary>
        /// Tests getting restaurant name from Chef Results Model
        /// </summary>
        [Fact]
        public void CanGetRestaurantViaChefResultsModel()
        {
            ChefResults restaurant = new ChefResults();
            restaurant.restaurantName = "KFC";

            Assert.Equal("KFC", restaurant.restaurantName);
        }

        /// <summary>
        /// Tests getting address of Chef recommended restaurant from Chef Results Model
        /// </summary>
        [Fact]
        public void CanGetAddressViaChefResultsModel()
        {
            ChefResults addresses = new ChefResults();
            addresses.address = "1900 Colonel Sanders Lane, Louiville, KY 40213";

            Assert.Equal("1900 Colonel Sanders Lane, Louiville, KY 40213", addresses.address);
        }

        /// <summary>
        /// Tests getting description of recommended restaurant from Chef Results Model
        /// </summary>
        [Fact]
        public void CanGetDescriptionViaChefResultsModel()
        {
            ChefResults descriptions = new ChefResults();
            descriptions.description = "Finger lickin' good!";

            Assert.Equal("Finger lickin' good!", descriptions.description);
        }

        /// <summary>
        /// Tests getting city name from Chef Results Model
        /// </summary>
        [Fact]
        public void CanGetCityViaChefResultsModel()
        {
            ChefResults location = new ChefResults();
            location.city = "Louiville";

            Assert.Equal("Louiville", location.city);
        }

        /// <summary>
        /// Tests getting Chef restaurant recommendation review from Chef Results Model
        /// </summary>
        [Fact]
        public void CanGetChefReviewsViaChefResultsModel()
        {
            ChefResults reviews = new ChefResults();
            reviews.review = "This is a raving review";

            Assert.Equal("This is a raving review", reviews.review);
        }

        /// <summary>
        /// Tests getting first name from Celebrity Chef Model
        /// </summary>
        [Fact]
        public void CanGetFirstNameViaCelelbrityChefModel()
        {
            CelebrityChef chef = new CelebrityChef();
            chef.firstName = "Marcus";

            Assert.Equal("Marcus", chef.firstName);
        }

        /// <summary>
        /// Tests getting last name from Celebrity Chef Model
        /// </summary>
        [Fact]
        public void CanGetLastNameViaCelebrityChefModel()
        {
            CelebrityChef chef = new CelebrityChef();
            chef.lastName = "Samuelsson";

            Assert.Equal("Samuelsson", chef.lastName);
        }

        /// <summary>
        /// Tests getting city from Celebrity Chef Model
        /// </summary>
        [Fact]
        public void CanGetCityViaCelebrityChefModel()
        {
            CelebrityChef chef = new CelebrityChef();
            chef.city = "Addis Ababa";

            Assert.Equal("Addis Ababa", chef.city);
        }

        /// <summary>
        /// Tests getting favorite from Celebrity Chef Model
        /// </summary>
        [Fact]
        public void CanGetFavoritesViaCelebrityChefModel()
        {
            CelebrityChef chef = new CelebrityChef();
            chef.favorites = "Estela Restaurant";

            Assert.Equal("Estela Restaurant", chef.favorites);
        }

        /// <summary>
        /// Tests getting restaurant name from Restaurant Model
        /// </summary>
        [Fact]
        public void CanGetRestaurantNameViaRestaurantModel()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Name = "Some Random Bar";

            Assert.Equal("Some Random Bar", restaurant.Name);
        }

        /// <summary>
        /// Tests getting address from Restaurant Model
        /// </summary>
        [Fact]
        public void CanGetRestaurantAddressViaRestaurantModel()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Address = "2604 1st Ave, Seattle, WA 98121";

            Assert.Equal("2604 1st Ave, Seattle, WA 98121", restaurant.Address);
        }

        /// <summary>
        /// Tests getting restuarant description from Restaurant Model
        /// </summary>
        [Fact]
        public void CanGetDescriptionViaRestaurantModel()
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Description = "Local New American eats and craft cocktails served in brick-walled gastropub with Mason jar lighting.";

            Assert.Equal("Local New American eats and craft cocktails served in brick-walled gastropub with Mason jar lighting.", restaurant.Description);
        }

        /// <summary>
        /// Tests getting full user name from User Profile
        /// </summary>
        [Fact]
        public void CanGetUserProfileFullNameViaUserProfileModel()
        {
            UserProfile userProfile = new UserProfile();
            userProfile.fullName = "Best Restaurant App Ever";

            Assert.Equal("Best Restaurant App Ever", userProfile.fullName);
        }

        /// <summary>
        /// Tests getting alias from category of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetCategoryAliasViaYelpResultsModel()
        {
            Category category = new Category();
            category.alias = "test category alias";

            Assert.Equal("test category alias", category.alias);
        }

        /// <summary>
        /// Tests geting title from category of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetCategoryTitleViaYelpResultsModel()
        {
            Category category = new Category();
            category.title = "test category title";

            Assert.Equal("test category title", category.title);
        }

        /// <summary>
        /// Tests getting address line 1 from location of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetLocationAddress1ViaYelpResultsModel()
        {
            Location location = new Location();
            location.address1 = "Test Location Address 1";

            Assert.Equal("Test Location Address 1", location.address1);
        }

        /// <summary>
        /// Tests getting address line 2 from location of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetLocationAddress2ViaYelpResultsModel()
        {
            Location location = new Location();
            location.address2 = "Test Location Address 2";

            Assert.Equal("Test Location Address 2", location.address2);
        }

        /// <summary>
        /// Tests getting address line 3 from location of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetLocationAddress3ViaYelpResultsModel()
        {
            Location location = new Location();
            location.address3 = "Test Location Address 3";

            Assert.Equal("Test Location Address 3", location.address3);
        }

        /// <summary>
        /// Tets getting city from location of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetLocationCityViaYelpResultsModel()
        {
            Location location = new Location();
            location.city = "Test Location City";

            Assert.Equal("Test Location City", location.city);
        }

        /// <summary>
        /// Tests getting zip code from location of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetLocationZipCodeViaYelpResultsModel()
        {
            Location location = new Location();
            location.zip_code = "Test Location Zip Code";

            Assert.Equal("Test Location Zip Code",location.zip_code);
        }

        /// <summary>
        /// Tests getting country from location of of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetLocationCountryViaYelpResultsModel()
        {
            Location location = new Location();
            location.country = "Test Location Country";

            Assert.Equal("Test Location Country", location.country);
        }

        /// <summary>
        /// Tests getting state from location of Yelp Results Model 
        /// </summary>
        [Fact]
        public void CanGetLocationStateViaYelpResultsModel()
        {
            Location location = new Location();
            location.state = "Test Location State";

            Assert.Equal("Test Location State", location.state);
        }

        /// <summary>
        /// Tests getting business alias from Business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetBusinessAliasViaYelpResultsModel()
        {
            Business business = new Business();
            business.alias = "Test Business Alias";

            Assert.Equal("Test Business Alias", business.alias);
        }

        /// <summary>
        /// Tests getting name of business from business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetBusinessNameViaYelpResultsModel()
        {
            Business business = new Business();
            business.name = "Test Business Name";

            Assert.Equal("Test Business Name", business.name);
        }

        /// <summary>
        /// Tests count of reviews from business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetBusinessReviewCountViaYelpResultsModel()
        {
            Business business = new Business();
            business.review_count = 4500;

            Assert.Equal(4500, business.review_count);
        }

        /// <summary>
        /// Tests bool if business is closed/open from business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanTestBusinessIsClosedFalseViaYelpResultsModel()
        {
            Business business = new Business();
            business.is_closed = true;
            business.is_closed = false;

            Assert.False(business.is_closed);
        }

        /// <summary>
        /// Tests can get restaurant rating from business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetBusinessRatingViaYelpResultsModel()
        {
            Business business = new Business();
            business.rating = 4;

            Assert.Equal(4, business.rating);
        }

        /// <summary>
        /// Tests price range as a string from business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetBusinessPriceViaYelpResultsModel()
        {
            Business business = new Business();
            business.price = "Test Business Price String";

            Assert.Equal("Test Business Price String", business.price);
        }

        /// <summary>
        /// Tests can get business phone number as a string from business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetBusinessPhoneViaYelpResultsModel()
        {
            Business business = new Business();
            business.phone = "Test Business Phone";

            Assert.Equal("Test Business Phone", business.phone);
        }

        /// <summary>
        /// Tests can display phone number from business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetBusinessDisplayPhoneViaYelpResultsModel()
        {
            Business business = new Business();
            business.display_phone = "Test Business Display Phone";

            Assert.Equal("Test Business Display Phone", business.display_phone);
        }

        /// <summary>
        /// Tests distance of restaurant from business of Yelp Results Model
        /// </summary>
        [Fact]
        public void CanGetBusinessDistanceViaYelpResultsModel()
        {
            Business business = new Business();
            business.distance = 8.2;

            Assert.Equal(8.2, business.distance);
        }
    }
}

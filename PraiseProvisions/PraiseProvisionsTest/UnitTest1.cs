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
        public void CanGetChefReviewsViaChefResultsModel()
        {
            ChefResults reviews = new ChefResults
            {
                review = "This is a raving review"
            };
        }
    }
}

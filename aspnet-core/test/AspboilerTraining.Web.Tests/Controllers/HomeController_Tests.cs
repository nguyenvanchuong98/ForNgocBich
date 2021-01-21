using System.Threading.Tasks;
using AspboilerTraining.Models.TokenAuth;
using AspboilerTraining.Web.Controllers;
using Shouldly;
using Xunit;

namespace AspboilerTraining.Web.Tests.Controllers
{
    public class HomeController_Tests: AspboilerTrainingWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
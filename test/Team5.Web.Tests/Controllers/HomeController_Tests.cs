using System.Threading.Tasks;
using Team5.Models.TokenAuth;
using Team5.Web.Controllers;
using Shouldly;
using Xunit;

namespace Team5.Web.Tests.Controllers
{
    public class HomeController_Tests: Team5WebTestBase
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
using Aura.Web.Controllers;
using Aura.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Aura.Web.Tests.Models
{
    public class ErrorViewModelTests
    {
        [Fact]
        public void ShowRequestId_WhenRequestIdIsNonEmpty_ReturnsTrue()
        {
            var model = new ErrorViewModel
            {
                RequestId = "123"
            };

            Assert.True(model.ShowRequestId);
        }

        [Fact]
        public void ShowRequestId_WhenRequestIdIsEmpty_ReturnsFalse()
        {
            var model = new ErrorViewModel();
            Assert.False(model.ShowRequestId);

            model.RequestId = string.Empty;
            Assert.False(model.ShowRequestId);
        }
    }
}

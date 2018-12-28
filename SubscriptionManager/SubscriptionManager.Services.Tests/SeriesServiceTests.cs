using SubscriptionManager.Core.DTO;
using SubscriptionManager.DAL.Interfaces;
using SubscriptionManager.Services.Implementations;
using SubscriptionManager.Services.Interfaces;
using SubscriptionManager.Services.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SubscriptionManager.Services.Tests
{
    
    public class SeriesServiceTests
    {
        [Fact]
        public void EmptyTest()
        {
            Assert.True(true);
        }

        [Fact]
        public async Task GetAllComicBookSeries()
        {
            ISeriesService service = new SeriesService();
            ISeriesDataAccess dataAccess = new MockSeriesDataAccess();

            IEnumerable<ComicBookSeries> issues = service.GetIssues();
        }
    }
}

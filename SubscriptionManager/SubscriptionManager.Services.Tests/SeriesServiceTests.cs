using SubscriptionManager.Core.DTO;
using SubscriptionManager.Services.Implementations;
using SubscriptionManager.Services.Interfaces;
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

            IEnumerable<ComicBookSeries> issues = service.GetIssues();
        }
    }
}

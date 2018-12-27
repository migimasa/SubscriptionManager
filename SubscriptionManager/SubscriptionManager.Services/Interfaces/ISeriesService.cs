using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionManager.Services.Interfaces
{
    public interface ISeriesService
    {
        IEnumerable<Core.DTO.ComicBookSeries> GetIssues();
    }
}

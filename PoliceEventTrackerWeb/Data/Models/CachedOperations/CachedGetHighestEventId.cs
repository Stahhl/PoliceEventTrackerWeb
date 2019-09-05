using PoliceEventTrackerWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliceEventTrackerWeb.Data.Models.CachedOperations
{
    internal static class CachedGetHighestEventId
    {
        private static int lastUpdateId;
        private static int highestEventId;

        internal static async Task<int> MyFunction(DbAccess dbAccess, Update update)
        {
            if(update == null || update.Id != lastUpdateId)
            {
                lastUpdateId = update != null ? update.Id : 0;

                var events = await dbAccess.GetAllEvents();

                highestEventId = events != null ? events.Max(e => e.EventId) : 0;
            }

            return highestEventId;
        }
    }
}

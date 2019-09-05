using PoliceEventTrackerWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliceEventTrackerWeb.Data.Models.CachedOperations
{
    internal static class CachedGetLatestEvents
    {
        private static int lastUpdateId;
        private static int lastAmount;
        private static List<Event> events;

        internal static async Task<List<Event>> MyFunction(DbAccess dbAccess, Update update, int amount)
        {
            if (events == null || update == null || update.Id != lastUpdateId || amount != lastAmount)
            {
                lastUpdateId = update != null ? update.Id : 0;
                lastAmount = amount;

                var list = await dbAccess.GetAllEvents();
                events = list.OrderByDescending(x => x.DateTime).Take(amount).ToList();
            }

            return events;
        }
    }
}

using PoliceEventTrackerWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliceEventTrackerWeb.Data.Models.CachedOperations
{
    internal static class CachedGetTopLocations
    {
        private static int lastUpdateId;
        private static List<Location> locations;

        internal static async Task<List<Location>> MyFunction(DbAccess dbAccess, Update update)
        {
            if (locations == null || update == null || update.Id != lastUpdateId)
            {
                lastUpdateId = update != null ? update.Id : 0;

                var list = await dbAccess.GetAllLocations();

                locations = list.OrderByDescending(x => x.Events.Count).ToList();
            }

            return locations;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BH_FileShare.Services
{
    public class HomeService
    {
        internal static bool SaveDownloadInformation(Download d)
        {
            using(var entities = new BH_FileShareEntities())
            {
                try
                {
                    entities.Downloads.Add(d);
                    entities.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewApplication.CORE.Infrastructure;

namespace ReviewApplication.API.TEST
{
    [TestClass]
    public class EntityFrameworkTests
    {
        [TestMethod]
        public void GenerateDatabaseText()
        {
            using (var db = new ReviewApplicationDbContext())
            {
                //   var firstProperty = db.Properties.FirstOrDefault();

                // Assert.IsNull(firstProperty);
            }
        }
    }
}

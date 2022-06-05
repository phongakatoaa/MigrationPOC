using System;
using System.Collections.Generic;
using MyNetEF;
using System.Linq;

namespace MyNetStandard
{
    public class CarService
    {
        private readonly MigrationPOCContext db;

        public CarService(MigrationPOCContext db)
        {
            this.db = db;
        }

        public List<Car> List()
        {
            return (from c in db.Car select c).ToList();
        }
    }
}

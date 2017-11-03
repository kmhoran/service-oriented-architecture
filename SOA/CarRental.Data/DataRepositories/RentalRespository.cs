using CarRental.Business.Entities;
using CarRental.Data.Contracts.DTOs;
using CarRental.Data.Contracts.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.DataRepositories
{
    class RentalRespository : DataRepositoryBase<Rental>, IRentalRepository
    {
        protected override Rental AddEntity(CarRentalContext entityContext, Rental entity)
        {
            return entityContext.RentalSet.Add(entity);
        }

        protected override IEnumerable<Rental> GetEntities(CarRentalContext entityContext)
        {
            return (from e in entityContext.RentalSet
                    select e);
        }

        protected override Rental GetEntity(CarRentalContext entityContext, int id)
        {
            var query = (from e in entityContext.RentalSet
                         where e.RentalId == id
                         select e);

            var results = query.FirstOrDefault();

            return results;
        }

        protected override Rental UpdateEntity(CarRentalContext entityContext, Rental entity)
        {
            return (from e in entityContext.RentalSet
                    where e.RentalId == entity.RentalId
                    select e).FirstOrDefault();
        }


        public IEnumerable<Rental> GetRentalHistoryByCar(int carId)
        {
            using (CarRentalContext entityContext = new CarRentalContext())
            {
                var query = from e in entityContext.RentalSet
                            where e.CarId == carId
                            select e;

                return query.ToList().ToArray();
            }
        }


        public Rental GetCurrentRentalByCarId(int carId)
        {
            using(CarRentalContext entityContext = new CarRentalContext())
            {
                var query = from e in entityContext.RentalSet
                            where e.CarId == carId && e.DateReturned == null
                            select e;

                return query.FirstOrDefault();
            }
        }


        public IEnumerable<CustomerRentalInfo> GetCurrentCustomerRentalInfo()
        {
            using(CarRentalContext entityContext = new CarRentalContext())
            {
                var query = from r in entityContext.RentalSet
                            where r.DateRented == null
                            join a in entityContext.AccountSet on r.AccountId equals a.AccountId
                            join c in entityContext.CarSet on r.CarId equals c.CarId
                            select new CustomerRentalInfo()
                            {
                                Customer = a,
                                Car = c,
                                Rental = r
                            };
                return query.ToArray().ToList();
            }
        }
    }
}

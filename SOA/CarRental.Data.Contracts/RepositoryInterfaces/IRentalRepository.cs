using CarRental.Business.Entities;
using Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Contracts.RepositoryInterfaces
{
    public interface IRentalRepository: IDataRepository<Rental>
    {
        // This interface exposes public members of the Rental Repository for DI

        IEnumerable<Rental> GetRentalHistoryByCar(int carId);

        Rental GetCurrentRentalByCarId(int carId);
    }
}

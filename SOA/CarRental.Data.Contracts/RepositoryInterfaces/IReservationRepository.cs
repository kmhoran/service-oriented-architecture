﻿using CarRental.Business.Entities;
using Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Contracts.RepositoryInterfaces
{
    public interface IReservationRepository : IDataRepository<Reservation>
    {
        // This interface exposes public members of the Reservation Repository for DI
    }
}

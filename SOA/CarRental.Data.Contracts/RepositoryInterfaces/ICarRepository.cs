﻿using CarRental.Business.Entities;
using Core.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Contracts.RepositoryInterfaces
{
    public interface ICarRepository: IDataRepository<Car>
    {
        // This interface exposes public members of the Car Repository for DI
    }
}

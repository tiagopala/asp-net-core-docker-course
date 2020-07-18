using GeneratorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorApi.Contracts
{
    public interface IGeneratorManager
    {
        NamesModel GetRandomNames();
        NumbersModel GetRandomNumbers();
    }
}

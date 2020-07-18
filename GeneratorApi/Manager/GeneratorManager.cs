using GeneratorApi.Contracts;
using GeneratorApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorApi.Manager
{
    public class GeneratorManager : IGeneratorManager
    {
        private static readonly string[] arrayNames = new[]
        {
            "Alberto", "Paulo", "Alfredo", "Juliano", "Giovana", "Deusa", "Roberta"
        };

        private readonly Random rng;

        public GeneratorManager()
        {
            rng = new Random();
        }

        public NamesModel GetRandomNames()
        {
            // intencionally hard coded quantity
            var names = GenerateRandomNamesList(3);

            return new NamesModel
            {
                Names = names
            };
        }

        public NumbersModel GetRandomNumbers()
        {
            // intencionally hard coded quantity
            var numbers = GenerateRandomNumbersList(3);

            return new NumbersModel
            {
                Numbers = numbers
            };
        }

        private List<string> GenerateRandomNamesList(int quantity)
        {
            var temporaryList = new List<string>();

            // stay in the looping while the temporaryList if not filled
            while (temporaryList.Count < quantity)
            {
                var name = arrayNames[rng.Next(arrayNames.Length)];
                if (!temporaryList.Contains(name)) temporaryList.Add(name);
            }

            return temporaryList;
        }

        private List<int> GenerateRandomNumbersList(int quantity)
        {
            var temporaryList = new List<int>();

            // stay in the looping while the temporaryList if not filled
            while (temporaryList.Count < quantity)
            {
                var number = rng.Next(0, 10);
                if (!temporaryList.Contains(number)) temporaryList.Add(number);
            }

            return temporaryList;
        }
    }
}

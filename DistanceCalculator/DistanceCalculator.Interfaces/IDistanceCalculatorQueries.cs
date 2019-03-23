using DistanceCalculator.Dto;

namespace DistanceCalculator.Interfaces
{
    public interface IDistanceCalculatorQueries
    {
        FilterDistancesResponce FilterDistances(FilterDistancesRequest request);
    }
}
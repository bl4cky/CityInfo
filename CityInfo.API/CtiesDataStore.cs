using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current => new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Descripton = "Most visited Park"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Descripton = "Most visited Building"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Vienna",
                    Description = "City of Danube",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Danube Tower",
                            Descripton = "Most visited Tower"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Stephans Dome",
                            Descripton = "Most visited Dome"
                        }
                    }

                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Antwerp",
                    Description = "Cathedral that was never really finished",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Cathedral",
                            Descripton = "Most visited Cathedral"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Unknown House",
                            Descripton = "Mistery House"
                        }
                    }
                }
            };
        }

    }
}

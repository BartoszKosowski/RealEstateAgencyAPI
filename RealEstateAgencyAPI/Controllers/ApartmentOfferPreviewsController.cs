using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateAgencyAPI.Models;
using RealEstateAgencyAPI.Models.FuzzyLogic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentOfferPreviewsController : ControllerBase
    {
        private readonly estate_agency_dbContext _context;

        public ApartmentOfferPreviewsController(estate_agency_dbContext context)
        {
            _context = context;
        }

        //GET: api/ApartmentOfferPreviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApartmentOfferPreview>>> GetApartmentOfferPreviews()
        {
            return await _context.ApartmentOfferPreviews.ToListAsync();
        }

        //GET: api/ApartmentOfferPreviews/params
        [HttpGet("{query}")]
        public async Task<ActionResult<IEnumerable<ApartmentOfferPreview>>> GetSpecificApartmentOfferPreviews(string query)
        {
            var apartments = await _context.ApartmentOffers.FromSqlRaw(GetSqlExpression(query)).ToListAsync();

            var idApartments = apartments.Select(a => a.IdOffers).ToList();
            return await _context.ApartmentOfferPreviews.Where(a => idApartments.Contains(a.IdOffer)).ToListAsync();
        }

        [HttpGet("fuzzy/{query}")]
        public async Task<ActionResult<IEnumerable<ApartmentOfferPreview>>> GetFuzzyOfferPreviews(string query)
        {
            var apartments = await _context.ApartmentOfferPreviews.ToListAsync();

            if (!query.Contains("empty"))
            {
                FuzzyQueryApartments fuzzyQueryApartments = new FuzzyQueryApartments(apartments, query.Split("~"));
                return fuzzyQueryApartments.GetRecords();
            }
            else
            {
                return apartments;
            }
        }

        private string GetSqlExpression(string query)
        {
            if (query.Contains("empty"))
            {
                return @"SELECT * FROM apartment_offer_view";
            }
            else
            {
                var queryParams = query.Split("~");
                string sqlExpression = @"SELECT * FROM apartment_offer_view";

                int remainArrayLength = queryParams.Length;
                sqlExpression += " WHERE";
                foreach (var param in queryParams)
                {
                    var paramArray = param.Split("-");

                    if (remainArrayLength != queryParams.Length)
                    {
                        sqlExpression += " AND";
                    }

                    switch (paramArray[0])
                    {
                        case "offerType":
                            {
                                sqlExpression += $" offer_type LIKE \"{paramArray[1]}\"";
                                break;
                            };
                        case "city":
                            {
                                sqlExpression += $" city LIKE \"{paramArray[1]}\"";
                                break;
                            };
                        case "market":
                            {
                                sqlExpression += $" market LIKE \"{paramArray[1]}\"";
                                break;
                            };
                        case "priceFrom":
                            {
                                sqlExpression += $" price > {paramArray[1]}";
                                break;
                            };
                        case "priceTo":
                            {
                                sqlExpression += $" price < {paramArray[1]}";
                                break;
                            };
                        case "priceForMeterFrom":
                            {
                                sqlExpression += $" price_for_meter > {paramArray[1]}";
                                break;
                            };
                        case "priceForMeterTo":
                            {
                                sqlExpression += $" price_for_meter < {paramArray[1]}";
                                break;
                            };
                        case "numberOfRoomsFrom":
                            {
                                sqlExpression += $" number_of_rooms > {paramArray[1]}";
                                break;
                            };
                        case "numberOfRoomsTo":
                            {
                                sqlExpression += $" number_of_rooms < {paramArray[1]}";
                                break;
                            };
                        case "numberOfFloorsFrom":
                            {
                                sqlExpression += $" number_of_floors > {paramArray[1]}";
                                break;
                            }
                        case "numberOfFloorsTo":
                            {
                                sqlExpression += $" number_of_floors < {paramArray[1]}";
                                break;
                            }
                        case "areaFrom":
                            {
                                sqlExpression += $" property_area > {paramArray[1]}";
                                break;
                            };
                        case "areaTo":
                            {
                                sqlExpression += $" property_area < {paramArray[1]}";
                                break;
                            }
                        case "agents":
                            {
                                sqlExpression += " (";
                                var agentsNumbers = paramArray[1].Split("-");
                                int agentsLength = agentsNumbers.Length;
                                foreach (var agent in agentsNumbers)
                                {
                                    if (agentsLength != agentsNumbers.Length)
                                    {
                                        sqlExpression += " OR";
                                    }
                                    sqlExpression += $" agent = {agent}";
                                    agentsLength--;
                                }
                                sqlExpression += ")";
                                break;
                            }
                        case "state":
                            {
                                sqlExpression += $" property_state LIKE {paramArray[1]}";
                                break;
                            }
                        case "distForest":
                            {
                                sqlExpression += $" distance_to_forest IS NOT NULL";
                                break;
                            }
                        case "distMountains":
                            {
                                sqlExpression += $" distance_to_mountains IS NOT NULL";
                                break;
                            }
                        case "distRiver":
                            {
                                sqlExpression += $" distance_to_river IS NOT NULL";
                                break;
                            }
                        case "distHighway":
                            {
                                sqlExpression += $" distance_to_highway IS NOT NULL";
                                break;
                            }
                        case "distCenter":
                            {
                                sqlExpression += $" distance_to_center IS NOT NULL";
                                break;
                            }
                        case "distMall":
                            {
                                sqlExpression += $" distance_to_mall IS NOT NULL";
                                break;
                            }
                        case "distLake":
                            {
                                sqlExpression += $" distance_to_lake IS NOT NULL";
                                break;
                            }
                        case "distCoast":
                            {
                                sqlExpression += $" distance_to_coast IS NOT NULL";
                                break;
                            }
                    }
                    remainArrayLength--;
                }
                return sqlExpression;
            }
        }
    }
}

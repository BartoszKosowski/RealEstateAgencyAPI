using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _15_CreateApartmentOfferView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW apartment_offer_view AS
                SELECT o.id_offers, o.agent, o.publishing_date, o.area, o.price, o.details, o.offer_name, o.price_for_meter,
                    o.offer_type, o.has_rent, o.rent_value,
                    ap.property_state, ap.property_area, ap.furnishings, ap.has_balcony, ap.floor_number, ap.number_of_rooms, ap.has_bathroom,
                    ap.parking_space, ap.heating, ap.inside_design, ap.kitchen_equipment, ap.bathroom_equipment, ap.building_name, ap.build_year,
                    ap.building_type, ap.number_of_floors, ap.distance_to_forest, ap.distance_to_river, ap.distance_to_mountains, ap.distance_to_highway, 
                    ap.distance_to_center, ap.distance_to_mall, ap.distance_to_lake, ap.distance_to_coast, ap.other_details,
                    ad.street, ad.estate_number, ad.apartment_number, ad.city, ad.zip_code, ad.google_maps_url
                    FROM offers o
                    LEFT JOIN apartments ap ON o.apartment = ap.id_apartment
                    LEFT JOIN addresses ad ON ap.address = ad.id_address
                    WHERE o.is_estate = 0;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [apartment_offer_view];");
        }
    }
}

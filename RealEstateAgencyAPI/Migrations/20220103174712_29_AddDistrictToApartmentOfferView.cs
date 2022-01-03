using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _29_AddDistrictToApartmentOfferView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW apartment_offer_view AS
                SELECT o.id_offers, o.agent, o.publishing_date, o.area, o.price, o.details, o.offer_name, o.price_for_meter,
                    o.offer_type, o.has_rent, o.rent_value, o.market,
                    ap.property_area, ap.furnishings, ap.has_balcony, ap.floor_number, ap.number_of_rooms, ap.has_bathroom,
                    ap.parking_space, ap.heating, ap.inside_design, ap.kitchen_equipment, ap.bathroom_equipment, ap.building_name, ap.build_year,
                    ap.building_type, ap.number_of_floors, ap.near_forest, ap.near_river, ap.near_mountains, ap.near_highway, 
                    ap.near_center, ap.near_mall, ap.near_lake, ap.near_coast, ap.other_details,
                    ad.street, ad.estate_number, ad.apartment_number, ad.city, ad.zip_code, ad.google_maps_url, ad.district,
                    s.name AS property_state
                    FROM offers o
                    LEFT JOIN apartments ap ON o.apartment = ap.id_apartment
                    LEFT JOIN addresses ad ON ap.address = ad.id_address
                    LEFT JOIN statuses s ON ap.property_state = s.id_status
                    WHERE o.is_estate = 0;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW apartment_offer_view AS
                SELECT o.id_offers, o.agent, o.publishing_date, o.area, o.price, o.details, o.offer_name, o.price_for_meter,
                    o.offer_type, o.has_rent, o.rent_value, o.market,
                    ap.property_area, ap.furnishings, ap.has_balcony, ap.floor_number, ap.number_of_rooms, ap.has_bathroom,
                    ap.parking_space, ap.heating, ap.inside_design, ap.kitchen_equipment, ap.bathroom_equipment, ap.building_name, ap.build_year,
                    ap.building_type, ap.number_of_floors, ap.near_forest, ap.near_river, ap.near_mountains, ap.near_highway, 
                    ap.near_center, ap.near_mall, ap.near_lake, ap.near_coast, ap.other_details,
                    ad.street, ad.estate_number, ad.apartment_number, ad.city, ad.zip_code, ad.google_maps_url,
                    s.name AS property_state
                    FROM offers o
                    LEFT JOIN apartments ap ON o.apartment = ap.id_apartment
                    LEFT JOIN addresses ad ON ap.address = ad.id_address
                    LEFT JOIN statuses s ON ap.property_state = s.id_status
                    WHERE o.is_estate = 0;");
        }
    }
}

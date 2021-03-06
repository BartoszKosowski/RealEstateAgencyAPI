using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _17_AddAgentToOfferPreview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW apartment_offer_preview_view AS
                SELECT o.id_offers, o.agent, o.offer_name, o.has_rent, o.rent_value, o.price, o.price_for_meter, o.offer_type, o.offer_status, 
                ap.property_area, ap.inside_design, ap.number_of_rooms, ap.main_photo_url, 
                ad.city, ad.street
                FROM offers o 
                LEFT JOIN apartments ap ON o.apartment = ap.id_apartment 
                LEFT JOIN addresses ad ON ap.address = ad.id_address
                WHERE o.is_estate = 0;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW apartment_offer_preview_view AS
                SELECT o.id_offers, o.offer_name, o.has_rent, o.rent_value, o.price, o.price_for_meter, o.offer_type, o.offer_status, 
                ap.property_area, ap.inside_design, ap.number_of_rooms, ap.main_photo_url, 
                ad.city, ad.street
                FROM offers o 
                LEFT JOIN apartments ap ON o.apartment = ap.id_apartment 
                LEFT JOIN addresses ad ON ap.address = ad.id_address
                WHERE o.is_estate = 0;");
        }
    }
}

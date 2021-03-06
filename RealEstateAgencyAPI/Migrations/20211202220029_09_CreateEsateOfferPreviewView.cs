using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _09_CreateEsateOfferPreviewView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR REPLACE VIEW etsate_offer_preview_view AS
                SELECT o.id_offers, o.offer_name, o.price, o.price_for_meter, o.offer_type, o.offer_status, 
                e.property_area, e.number_of_rooms, e.main_photo_url, 
                a.city, a.street, 
                t.name
                FROM offers o 
                LEFT JOIN estates e ON o.estate = e.id_estate 
                LEFT JOIN addresses a ON e.address = a.id_address 
                LEFT JOIN trade_info t ON e.property_type = t.id_info;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW estate_offer_preview_view");
        }
    }
}

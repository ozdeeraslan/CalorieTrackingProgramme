using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoungFit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Yedi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 120, "SuBardagi", "Kefir" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 130, "SuBardagi", "Yoğurt" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 100, "Ayran" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 110, "Cacık" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 70, "Adet", "Haşlanmış Yumurta" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 120, "Porsiyon", "Omlet" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 130, "Porsiyon", "Peynirli Omlet" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 140, "Mantarlı Omlet" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 150, "Menemen" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 160, "Sucuklu Yumurta" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 170, "Kuymak - Mıhlama" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 180, "Sucuk" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 190, "Sosis" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200, "Dana Salam" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 210, "Hindi Salam" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 220, "Dana Jambon" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 230, "Hindi Jambon" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 240, "Piliç Jambon" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "Hindi Füme" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 260, "Piliç Füme" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 270, "Pastırma" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 50, "Siyah Zeytin" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 60, "Yeşil Zeytin" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "OlcuBirimi", "YemekAdi" },
                values: new object[] { "TatliKasigi", "Bal" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "OlcuBirimi", "YemekAdi" },
                values: new object[] { "TatliKasigi", "Kaymak" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 70, "SuBardagi", "Keçi Sütü" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 80, "Porsiyon", "Cevizli Yaz Helvası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 90, "TatliKasigi", "Tahin" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 100, "TatliKasigi", "Pekmez" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 110, "Tahin Pekmez" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 120, "Nutella" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 130, "Kakaolu Fındık Kreması" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 140, "Fındık Ezmesi" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 150, "Fıstık Ezmesi" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 220, "Porsiyon", "Haşlanmış Makarna" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 230, "Porsiyon", "Domatesli Makarna" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 240, "Spagetti Bolonez" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "Penne Arabiata" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 260, "Fettucini Alfredo" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 270, "Lazanya" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 280, "Fırında Makarna" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 290, "Makarna Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 10, "YemekKasigi", "Ketçap" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 20, "YemekKasigi", "Mayonez" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 15, "Hardal" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 25, "Barbekü Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 30, "Ranch Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 35, "Buffalo Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 40, "Pesto Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 15, "Nar Ekşisi" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 25, "Köri Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 20, "Soya Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 200, "Porsiyon", "Çıtır Tavuk" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 300, "Porsiyon", "Tavuk Burger" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 350, "Cheeseburger" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 280, "Etli Ekmek" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 200, "Adet", "Lahmacun" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Et Döner Dürüm" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 350, "Porsiyon", "Kumpir" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 400, "Adana Dürüm" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 450, "Urfa Dürüm" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "Patates Kızartması" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Soğan Halkası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 350, "Kıymalı Pide" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 400, "Kaşarlı Pide" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 450, "Kuşbaşılı Pide" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200, "Dana Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "Kuzu Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Etli Sebzeli Pizza" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 280, "Kızarmış Hindi Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 320, "Kaz Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 290, "Keçi Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 350, "Kurutulmuş Sığır Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 230, "Etli Nohut" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Et Döner" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 350, "Et Kavurma" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 320, "Et Sote" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 400, "Dana Etli Burrito" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 280, "Etli Kuru Fasulye" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 20, "Adet", "Domates" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 15, "Adet", "Çeri Domates" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 25, "Salatalık" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 10, "Marul" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 15, "Çarliston Biber" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 20, "Kırmızı Biber" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 10, "Turp" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 180, "Tabak", "Ezogelin Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 250, "Tabak", "İşkembe Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200, "Kırmızı Mercimek Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 190, "Yeşil Mercimek Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 150, "Sebze Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 180, "Tarhana Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 160, "Yayla Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 140, "Tavuk Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 120, "Balkabağı Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 170, "Mantar Çorbası" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 180, "Porsiyon", "Beyaz Peynir" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 190, "Porsiyon", "Beyaz Peynir" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 120, "Kefir" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 130, "Yoğurt" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 100, "SuBardagi", "Ayran" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 110, "SuBardagi", "Cacık" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 70, "Adet", "Haşlanmış Yumurta" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 120, "Omlet" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 130, "Peynirli Omlet" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 140, "Mantarlı Omlet" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 150, "Menemen" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 160, "Sucuklu Yumurta" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 170, "Kuymak - Mıhlama" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 180, "Sucuk" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 190, "Sosis" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200, "Dana Salam" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 210, "Hindi Salam" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 220, "Dana Jambon" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 230, "Hindi Jambon" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 240, "Piliç Jambon" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "Hindi Füme" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 260, "Piliç Füme" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 270, "Pastırma" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "OlcuBirimi", "YemekAdi" },
                values: new object[] { "Porsiyon", "Siyah Zeytin" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "OlcuBirimi", "YemekAdi" },
                values: new object[] { "Porsiyon", "Yeşil Zeytin" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 50, "TatliKasigi", "Bal" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 60, "TatliKasigi", "Kaymak" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 70, "SuBardagi", "Keçi Sütü" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 80, "Porsiyon", "Cevizli Yaz Helvası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 90, "Tahin" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 100, "Pekmez" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 110, "Tahin Pekmez" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 120, "Nutella" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 130, "Kakaolu Fındık Kreması" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 140, "TatliKasigi", "Fındık Ezmesi" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 150, "TatliKasigi", "Fıstık Ezmesi" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 220, "Haşlanmış Makarna" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 230, "Domatesli Makarna" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 240, "Spagetti Bolonez" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "Penne Arabiata" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 260, "Fettucini Alfredo" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 270, "Lazanya" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 280, "Porsiyon", "Fırında Makarna" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 290, "Porsiyon", "Makarna Salatası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 10, "Ketçap" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 20, "Mayonez" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 15, "Hardal" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 25, "Barbekü Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 30, "Ranch Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 35, "Buffalo Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 40, "Pesto Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 15, "Nar Ekşisi" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 25, "YemekKasigi", "Köri Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 20, "YemekKasigi", "Soya Sos" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200, "Çıtır Tavuk" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Tavuk Burger" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 350, "Porsiyon", "Cheeseburger" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 280, "Etli Ekmek" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 200, "Adet", "Lahmacun" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Et Döner Dürüm" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 350, "Kumpir" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 400, "Adana Dürüm" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 450, "Urfa Dürüm" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "Patates Kızartması" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Soğan Halkası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 350, "Kıymalı Pide" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 400, "Kaşarlı Pide" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 450, "Kuşbaşılı Pide" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200, "Dana Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "Kuzu Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Etli Sebzeli Pizza" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 280, "Kızarmış Hindi Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 320, "Kaz Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 290, "Keçi Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 350, "Kurutulmuş Sığır Eti" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 230, "Etli Nohut" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 300, "Et Döner" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 350, "Et Kavurma" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 320, "Et Sote" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 400, "Porsiyon", "Dana Etli Burrito" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 280, "Porsiyon", "Etli Kuru Fasulye" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 20, "Domates" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 15, "Çeri Domates" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 25, "Salatalık" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 10, "Marul" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 15, "Çarliston Biber" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 20, "Adet", "Kırmızı Biber" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Kalori", "OlcuBirimi", "YemekAdi" },
                values: new object[] { 10, "Adet", "Turp" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 180, "Ezogelin Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 250, "İşkembe Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 200, "Kırmızı Mercimek Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 190, "Yeşil Mercimek Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 150, "Sebze Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 180, "Tarhana Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 160, "Yayla Çorbası" });

            migrationBuilder.UpdateData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Kalori", "YemekAdi" },
                values: new object[] { 140, "Tavuk Çorbası" });

            migrationBuilder.InsertData(
                table: "Yemekler",
                columns: new[] { "Id", "Kalori", "OlcuBirimi", "Resim", "Tarih", "ToplamKalori", "YemekAdi", "YemekZamani" },
                values: new object[,]
                {
                    { 194, 120, "Tabak", null, null, null, "Balkabağı Çorbası", null },
                    { 195, 170, "Tabak", null, null, null, "Mantar Çorbası", null }
                });
        }
    }
}

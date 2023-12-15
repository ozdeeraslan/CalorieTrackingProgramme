using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoungFit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Alti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Yemekler",
                columns: new[] { "Id", "Kalori", "OlcuBirimi", "Resim", "Tarih", "ToplamKalori", "YemekAdi", "YemekZamani" },
                values: new object[,]
                {
                    { 1, 200, "Gram", null, null, null, "Somon", null },
                    { 2, 150, "Adet", null, null, null, "Ahtapot", null },
                    { 3, 180, "Gram", null, null, null, "Alabalık", null },
                    { 4, 160, "Gram", null, null, null, "Barbun", null },
                    { 5, 170, "Gram", null, null, null, "Çipura", null },
                    { 6, 140, "Gram", null, null, null, "Dil Balığı", null },
                    { 7, 120, "Gram", null, null, null, "Izgara Hamsi", null },
                    { 8, 130, "Gram", null, null, null, "Kızartma Hamsi", null },
                    { 9, 250, "Gram", null, null, null, "Havyar", null },
                    { 10, 220, "Adet", null, null, null, "Istakoz", null },
                    { 11, 180, "Gram", null, null, null, "İstavrit", null },
                    { 12, 200, "Adet", null, null, null, "İstiridye", null },
                    { 13, 150, "Gram", null, null, null, "İzmarit", null },
                    { 14, 190, "Gram", null, null, null, "Kalkan Balığı", null },
                    { 15, 160, "Gram", null, null, null, "Karides Güveç", null },
                    { 16, 170, "Gram", null, null, null, "Tereyağda Karides", null },
                    { 17, 160, "Gram", null, null, null, "Kefal Balığı", null },
                    { 18, 180, "Gram", null, null, null, "Kılıç Balığı", null },
                    { 19, 150, "Gram", null, null, null, "İzmarit", null },
                    { 20, 170, "Gram", null, null, null, "Lüfer", null },
                    { 21, 160, "Gram", null, null, null, "Mezgit", null },
                    { 22, 130, "Adet", null, null, null, "Midye Dolma", null },
                    { 23, 140, "Gram", null, null, null, "Midye Tava", null },
                    { 24, 180, "Gram", null, null, null, "Palamut", null },
                    { 25, 160, "Gram", null, null, null, "Sardalya", null },
                    { 26, 170, "Gram", null, null, null, "Sazan", null },
                    { 27, 210, "Adet", null, null, null, "Deniz Tarağı", null },
                    { 28, 140, "Gram", null, null, null, "Tekir", null },
                    { 29, 200, "Gram", null, null, null, "Ton Balığı", null },
                    { 30, 250, "Adet", null, null, null, "Sushi", null },
                    { 31, 150, "Gram", null, null, null, "Haşlanmış Tavuk Göğsü", null },
                    { 32, 200, "Gram", null, null, null, "Pişmiş Tavuk Eti", null },
                    { 33, 180, "Gram", null, null, null, "Kızarmış Tavuk Kanadı", null },
                    { 34, 220, "Gram", null, null, null, "Kızarmış Tavuk But", null },
                    { 35, 200, "Gram", null, null, null, "Haşlanmış Tavuk But", null },
                    { 36, 150, "Gram", null, null, null, "Tavuk Köftesi", null },
                    { 37, 190, "Gram", null, null, null, "Tavuk Ciğeri", null },
                    { 38, 50, "Gram", null, null, null, "Ahududu", null },
                    { 39, 40, "Gram", null, null, null, "Böğürtlen", null },
                    { 40, 30, "Adet", null, null, null, "Yeşil Erik", null },
                    { 41, 25, "Adet", null, null, null, "İncir", null },
                    { 42, 20, "Gram", null, null, null, "Dut", null },
                    { 43, 35, "Gram", null, null, null, "Üzüm", null },
                    { 44, 40, "Adet", null, null, null, "Nar", null },
                    { 45, 30, "Adet", null, null, null, "Şeftali", null },
                    { 46, 15, "Adet", null, null, null, "Limon", null },
                    { 47, 30, "Adet", null, null, null, "Kırmızı Erik", null },
                    { 48, 200, "Tabak", null, null, null, "Sütlaç", null },
                    { 49, 220, "Tabak", null, null, null, "Kazandibi", null },
                    { 50, 180, "Tabak", null, null, null, "Magnolia", null },
                    { 51, 250, "Tabak", null, null, null, "Tiramisu", null },
                    { 52, 280, "Tabak", null, null, null, "Cheesecake", null },
                    { 53, 190, "Tabak", null, null, null, "Güllaç", null },
                    { 54, 180, "Tabak", null, null, null, "Tavuk Göğsü Tatlısı", null },
                    { 55, 200, "Tabak", null, null, null, "Muhallebi", null },
                    { 56, 160, "Tabak", null, null, null, "Puding", null },
                    { 57, 220, "Tabak", null, null, null, "Supangle", null },
                    { 58, 240, "Tabak", null, null, null, "Trileçe", null },
                    { 59, 180, "Tabak", null, null, null, "Höşmerim", null },
                    { 60, 210, "Tabak", null, null, null, "Keşkül", null },
                    { 61, 250, "Tabak", null, null, null, "Aşure", null },
                    { 62, 200, "Tabak", null, null, null, "Profiterol", null },
                    { 63, 170, "Tabak", null, null, null, "Meyveli Dondurma", null },
                    { 64, 160, "Tabak", null, null, null, "Sütlü Dondurma", null },
                    { 65, 180, "Tabak", null, null, null, "Çikolatalı Dondurma", null },
                    { 66, 190, "Tabak", null, null, null, "Sütlü İrmik Tatlısı", null },
                    { 67, 250, "Tabak", null, null, null, "İrmik Helvası", null },
                    { 68, 280, "Tabak", null, null, null, "Un Helvası", null },
                    { 69, 320, "Adet", null, null, null, "Baklava", null },
                    { 70, 280, "Tabak", null, null, null, "Kadayıf", null },
                    { 71, 300, "Adet", null, null, null, "Soğuk Baklava", null },
                    { 72, 270, "Adet", null, null, null, "Tulumba", null },
                    { 73, 240, "Adet", null, null, null, "Kemalpaşa", null },
                    { 74, 280, "Adet", null, null, null, "Halka Tatlısı", null },
                    { 75, 290, "Adet", null, null, null, "Şam Tatlısı", null },
                    { 76, 300, "Porsiyon", null, null, null, "Şöbiyet", null },
                    { 77, 310, "Porsiyon", null, null, null, "Künefe", null },
                    { 78, 260, "Porsiyon", null, null, null, "Şekerpare", null },
                    { 79, 270, "Porsiyon", null, null, null, "Revani", null },
                    { 80, 280, "Porsiyon", null, null, null, "Lokma Tatlısı", null },
                    { 81, 290, "Porsiyon", null, null, null, "Kalburabastı", null },
                    { 82, 310, "Porsiyon", null, null, null, "Fıstıklı Sarma Tatlısı", null },
                    { 83, 260, "Porsiyon", null, null, null, "Un Helvası", null },
                    { 84, 280, "Porsiyon", null, null, null, "San Sebastian", null },
                    { 85, 150, "SuBardagi", null, null, null, "Tam Yağlı İnek Sütü", null },
                    { 86, 120, "SuBardagi", null, null, null, "Yarım Yağlı İnek Sütü", null },
                    { 87, 140, "SuBardagi", null, null, null, "Keçi Sütü", null },
                    { 88, 100, "SuBardagi", null, null, null, "Soya Sütü", null },
                    { 89, 130, "SuBardagi", null, null, null, "Badem Sütü", null },
                    { 90, 100, "Porsiyon", null, null, null, "Beyaz Peynir", null },
                    { 91, 110, "Porsiyon", null, null, null, "Süzme Peynir", null },
                    { 92, 120, "Porsiyon", null, null, null, "Lor Peyniri", null },
                    { 93, 130, "Porsiyon", null, null, null, "Kaşar Peyniri", null },
                    { 94, 140, "Porsiyon", null, null, null, "Labne", null },
                    { 95, 150, "Porsiyon", null, null, null, "Örgü Peynir", null },
                    { 96, 160, "Porsiyon", null, null, null, "Dil Peyniri", null },
                    { 97, 170, "Porsiyon", null, null, null, "Hellim Peyniri", null },
                    { 98, 180, "Porsiyon", null, null, null, "Beyaz Peynir", null },
                    { 99, 190, "Porsiyon", null, null, null, "Beyaz Peynir", null },
                    { 100, 120, "SuBardagi", null, null, null, "Kefir", null },
                    { 101, 130, "SuBardagi", null, null, null, "Yoğurt", null },
                    { 102, 100, "SuBardagi", null, null, null, "Ayran", null },
                    { 103, 110, "SuBardagi", null, null, null, "Cacık", null },
                    { 104, 70, "Adet", null, null, null, "Haşlanmış Yumurta", null },
                    { 105, 120, "Porsiyon", null, null, null, "Omlet", null },
                    { 106, 130, "Porsiyon", null, null, null, "Peynirli Omlet", null },
                    { 107, 140, "Porsiyon", null, null, null, "Mantarlı Omlet", null },
                    { 108, 150, "Porsiyon", null, null, null, "Menemen", null },
                    { 109, 160, "Porsiyon", null, null, null, "Sucuklu Yumurta", null },
                    { 110, 170, "Porsiyon", null, null, null, "Kuymak - Mıhlama", null },
                    { 111, 180, "Porsiyon", null, null, null, "Sucuk", null },
                    { 112, 190, "Porsiyon", null, null, null, "Sosis", null },
                    { 113, 200, "Porsiyon", null, null, null, "Dana Salam", null },
                    { 114, 210, "Porsiyon", null, null, null, "Hindi Salam", null },
                    { 115, 220, "Porsiyon", null, null, null, "Dana Jambon", null },
                    { 116, 230, "Porsiyon", null, null, null, "Hindi Jambon", null },
                    { 117, 240, "Porsiyon", null, null, null, "Piliç Jambon", null },
                    { 118, 250, "Porsiyon", null, null, null, "Hindi Füme", null },
                    { 119, 260, "Porsiyon", null, null, null, "Piliç Füme", null },
                    { 120, 270, "Porsiyon", null, null, null, "Pastırma", null },
                    { 121, 50, "Porsiyon", null, null, null, "Siyah Zeytin", null },
                    { 122, 60, "Porsiyon", null, null, null, "Yeşil Zeytin", null },
                    { 123, 50, "TatliKasigi", null, null, null, "Bal", null },
                    { 124, 60, "TatliKasigi", null, null, null, "Kaymak", null },
                    { 125, 70, "SuBardagi", null, null, null, "Keçi Sütü", null },
                    { 126, 80, "Porsiyon", null, null, null, "Cevizli Yaz Helvası", null },
                    { 127, 90, "TatliKasigi", null, null, null, "Tahin", null },
                    { 128, 100, "TatliKasigi", null, null, null, "Pekmez", null },
                    { 129, 110, "TatliKasigi", null, null, null, "Tahin Pekmez", null },
                    { 130, 120, "TatliKasigi", null, null, null, "Nutella", null },
                    { 131, 130, "TatliKasigi", null, null, null, "Kakaolu Fındık Kreması", null },
                    { 132, 140, "TatliKasigi", null, null, null, "Fındık Ezmesi", null },
                    { 133, 150, "TatliKasigi", null, null, null, "Fıstık Ezmesi", null },
                    { 134, 220, "Porsiyon", null, null, null, "Haşlanmış Makarna", null },
                    { 135, 230, "Porsiyon", null, null, null, "Domatesli Makarna", null },
                    { 136, 240, "Porsiyon", null, null, null, "Spagetti Bolonez", null },
                    { 137, 250, "Porsiyon", null, null, null, "Penne Arabiata", null },
                    { 138, 260, "Porsiyon", null, null, null, "Fettucini Alfredo", null },
                    { 139, 270, "Porsiyon", null, null, null, "Lazanya", null },
                    { 140, 280, "Porsiyon", null, null, null, "Fırında Makarna", null },
                    { 141, 290, "Porsiyon", null, null, null, "Makarna Salatası", null },
                    { 142, 10, "YemekKasigi", null, null, null, "Ketçap", null },
                    { 143, 20, "YemekKasigi", null, null, null, "Mayonez", null },
                    { 144, 15, "YemekKasigi", null, null, null, "Hardal", null },
                    { 145, 25, "YemekKasigi", null, null, null, "Barbekü Sos", null },
                    { 146, 30, "YemekKasigi", null, null, null, "Ranch Sos", null },
                    { 147, 35, "YemekKasigi", null, null, null, "Buffalo Sos", null },
                    { 148, 40, "YemekKasigi", null, null, null, "Pesto Sos", null },
                    { 149, 15, "YemekKasigi", null, null, null, "Nar Ekşisi", null },
                    { 150, 25, "YemekKasigi", null, null, null, "Köri Sos", null },
                    { 151, 20, "YemekKasigi", null, null, null, "Soya Sos", null },
                    { 152, 200, "Porsiyon", null, null, null, "Çıtır Tavuk", null },
                    { 153, 300, "Porsiyon", null, null, null, "Tavuk Burger", null },
                    { 154, 350, "Porsiyon", null, null, null, "Cheeseburger", null },
                    { 155, 280, "Porsiyon", null, null, null, "Etli Ekmek", null },
                    { 156, 200, "Adet", null, null, null, "Lahmacun", null },
                    { 157, 300, "Porsiyon", null, null, null, "Et Döner Dürüm", null },
                    { 158, 350, "Porsiyon", null, null, null, "Kumpir", null },
                    { 159, 400, "Porsiyon", null, null, null, "Adana Dürüm", null },
                    { 160, 450, "Porsiyon", null, null, null, "Urfa Dürüm", null },
                    { 161, 250, "Porsiyon", null, null, null, "Patates Kızartması", null },
                    { 162, 300, "Porsiyon", null, null, null, "Soğan Halkası", null },
                    { 163, 350, "Porsiyon", null, null, null, "Kıymalı Pide", null },
                    { 164, 400, "Porsiyon", null, null, null, "Kaşarlı Pide", null },
                    { 165, 450, "Porsiyon", null, null, null, "Kuşbaşılı Pide", null },
                    { 166, 200, "Porsiyon", null, null, null, "Dana Eti", null },
                    { 167, 250, "Porsiyon", null, null, null, "Kuzu Eti", null },
                    { 168, 300, "Porsiyon", null, null, null, "Etli Sebzeli Pizza", null },
                    { 169, 280, "Porsiyon", null, null, null, "Kızarmış Hindi Eti", null },
                    { 170, 320, "Porsiyon", null, null, null, "Kaz Eti", null },
                    { 171, 290, "Porsiyon", null, null, null, "Keçi Eti", null },
                    { 172, 350, "Porsiyon", null, null, null, "Kurutulmuş Sığır Eti", null },
                    { 173, 230, "Porsiyon", null, null, null, "Etli Nohut", null },
                    { 174, 300, "Porsiyon", null, null, null, "Et Döner", null },
                    { 175, 350, "Porsiyon", null, null, null, "Et Kavurma", null },
                    { 176, 320, "Porsiyon", null, null, null, "Et Sote", null },
                    { 177, 400, "Porsiyon", null, null, null, "Dana Etli Burrito", null },
                    { 178, 280, "Porsiyon", null, null, null, "Etli Kuru Fasulye", null },
                    { 179, 20, "Adet", null, null, null, "Domates", null },
                    { 180, 15, "Adet", null, null, null, "Çeri Domates", null },
                    { 181, 25, "Adet", null, null, null, "Salatalık", null },
                    { 182, 10, "Adet", null, null, null, "Marul", null },
                    { 183, 15, "Adet", null, null, null, "Çarliston Biber", null },
                    { 184, 20, "Adet", null, null, null, "Kırmızı Biber", null },
                    { 185, 10, "Adet", null, null, null, "Turp", null },
                    { 186, 180, "Tabak", null, null, null, "Ezogelin Çorbası", null },
                    { 187, 250, "Tabak", null, null, null, "İşkembe Çorbası", null },
                    { 188, 200, "Tabak", null, null, null, "Kırmızı Mercimek Çorbası", null },
                    { 189, 190, "Tabak", null, null, null, "Yeşil Mercimek Çorbası", null },
                    { 190, 150, "Tabak", null, null, null, "Sebze Çorbası", null },
                    { 191, 180, "Tabak", null, null, null, "Tarhana Çorbası", null },
                    { 192, 160, "Tabak", null, null, null, "Yayla Çorbası", null },
                    { 193, 140, "Tabak", null, null, null, "Tavuk Çorbası", null },
                    { 194, 120, "Tabak", null, null, null, "Balkabağı Çorbası", null },
                    { 195, 170, "Tabak", null, null, null, "Mantar Çorbası", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Yemekler",
                keyColumn: "Id",
                keyValue: 195);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using InterviewTest.Extensions;

namespace InterviewTest.Models
{
    public static class EntityGenerator
    {
        public static splitsText GenerateS() => new splitsText
        {
            layoutString = "TTHHTT",
            seperate = "checked",
            Id = "00000",
        };

        public static Layoutsplits GenerateL() => new Layoutsplits
        {
            layoutOf = new List<List<string>>(),
            Id = "00000",
        };

        public static Host GenerateHost() => new Host
        {
            Name = $"{FirstNames.GetRandom()} {LastNames.GetRandom()}",
            Job = $"{Jobs1.GetRandom()} {Jobs2.GetRandom()}",
            ImageUrl = ImageUrls.GetRandom(),
            used = 0,
            addclass = "",
        };

        public static Trip GenerateTrip(string hostId) => new Trip
        {
            Name = $"{Activities.GetRandom()} {TripTypes.GetRandom()}",
            Country = Countries.GetRandom(),
            HostId = hostId,
            ImageUrl = ImageUrls.GetRandom(),
            used = 0,
            addclass = "",
        };

        private static string[] Countries => new[] { "France", "Italy", "Portugal", "Spain", "USA" };
        private static string[] Activities => new[] { "Surf", "Cookery", "Painting", "Knitting" };
        private static string[] TripTypes => new[] { "Holiday", "Trip", "Retreat", "Experience" };

        private static string[] FirstNames => new[] { "Gita", "Bob", "Alice", "Donald" };
        private static string[] LastNames => new[] { "Smith", "Jones", "Trump", "Kapoor" };
        private static string[] Jobs1 => new[] { "Dream", "Experience", "Holiday", "Skill" };
        private static string[] Jobs2 => new[] { "Ideator", "Creator", "Wrangler", "Wizard" };

        private static string[] ImageUrls
            =>
                new[]
                {
                    "https://media.vidados.com/images/vd-p-68/680fdcf2-9fbf-4048-9466-e523842fe194.JPG",
                    "https://media.vidados.com/images/vd-p-3f/3f9894f2-8dcc-4faf-ae36-29ea04451d3e.jpg",
                    "https://media.vidados.com/images/vd-p-49/49187b64-4b86-4f11-8c5f-d54cc6d46e3f.jpg",
                    "https://media.vidados.com/images/vd-p-52/5235ecc4-17d9-47a9-8b70-0b7db40362b6.jpg",
                    "https://media.vidados.com/images/vd-p-b0/b0d198d3-91f9-49ba-8c3b-60b9af30a347.jpg",
                    "https://media.vidados.com/images/vd-p-68/680fdcf2-9fbf-4048-9466-e523842fe194.JPG",
                    "https://media.vidados.com/images/vd-p-cd/cd4547f9-7b25-405d-aadf-19997ad98835.jpg",
                    "https://media.vidados.com/images/vd-p-3c/3cdc6996-96b7-4bf4-bc06-ee309be28046.jpg",
                    "https://media.vidados.com/images/vd-p-32/32da6058-4f47-4067-96ab-715224e2aff2.jpg",
                    "https://media.vidados.com/images/vd-p-71/71ba204c-aba2-4b10-a730-224eb4bd6ba0.jpg",
                    "https://media.vidados.com/images/vd-p-0e/0ec4ec42-728e-49db-b21e-8bdff5e2c519.jpg",
                    "https://media.vidados.com/images/vd-p-cd/cd4547f9-7b25-405d-aadf-19997ad98835.jpg",
                    "https://media.vidados.com/images/vd-p-3c/3cdc6996-96b7-4bf4-bc06-ee309be28046.jpg",
                    "https://media.vidados.com/images/vd-p-b0/b0d198d3-91f9-49ba-8c3b-60b9af30a347.jpg",
                    "https://media.vidados.com/images/vd-p-76/76ee0770-56b3-41d5-a69e-6699652ef143.jpg",
                    "https://media.vidados.com/images/vd-p-3f/3f9894f2-8dcc-4faf-ae36-29ea04451d3e.jpg",
                    "https://media.vidados.com/images/vd-p-76/766239f8-9552-4376-a72e-3faddd4908d0.jpg",
                    "https://media.vidados.com/images/vd-p-76/767e857d-fb7c-4f3d-93ac-68d1d60a5f40.jpg",
                    "https://media.vidados.com/images/vd-p-b0/b0d198d3-91f9-49ba-8c3b-60b9af30a347.jpg",
                    "https://media.vidados.com/images/vd-p-76/76ee0770-56b3-41d5-a69e-6699652ef143.jpg",
                    "https://media.vidados.com/images/vd-p-0d/0d04e0f7-1fcb-49ca-83af-fbbdd7017bf6.jpg",
                    "https://media.vidados.com/images/vd-p-45/45ff93be-7d6e-427b-bd16-5efa55edd032.jpg",
                    "https://media.vidados.com/images/vd-p-9a/9a540c0b-9f29-4565-af3a-23de0e23a4ba.jpg",
                    "https://media.vidados.com/images/vd-p-e9/e951041e-a36e-446d-b86a-5e59245e5c64.jpg",
                    "https://media.vidados.com/images/vd-p-0d/0d04e0f7-1fcb-49ca-83af-fbbdd7017bf6.jpg",
                    "https://media.vidados.com/images/vd-p-d1/d1ed83a2-94bd-44a2-8189-2f2d09e1d437.JPG",
                    "https://media.vidados.com/images/vd-p-9b/9bc59305-4b17-4da4-af6d-4becf0890f4c.JPG",
                    "https://media.vidados.com/images/vd-p-97/978dbbab-7c64-481a-8bdf-3a8bb4031da1.JPG",
                    "https://media.vidados.com/images/vd-p-c2/c2b970ac-4d68-4496-8cd6-8556497446fc.jpg",
                    "https://media.vidados.com/images/vd-p-d1/d1ed83a2-94bd-44a2-8189-2f2d09e1d437.JPG",
                    "https://media.vidados.com/images/vd-p-9b/9bc59305-4b17-4da4-af6d-4becf0890f4c.JPG",
                    "https://media.vidados.com/images/vd-p-2e/2e5d9ca1-841c-42cc-b976-e37101d5d9df.jpg",
                }.Select(
                    u => u + "?width=100&height=100&mode=crop").ToArray();

    }
}
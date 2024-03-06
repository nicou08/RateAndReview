namespace RateAndReview.Utilities
{
    public class ShowInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public string EndDate { get; set; }
        public string Image { get; set; }
    }
    public static class Constants
    {
        public static List<ShowInfo> Shows = new List<ShowInfo>
        {
            new ShowInfo 
            { 
                Id = "tt0903747", 
                Name = "Breaking Bad", 
                Type = "TV Series",
                Description = "A chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine with a former student in order to secure his family's future.",
                ReleaseDate = "2008",
                EndDate = "2013",
                Image = "https://m.media-amazon.com/images/M/MV5BYmQ4YWMxYjUtNjZmYi00MDQ1LWFjMjMtNjA5ZDdiYjdiODU5XkEyXkFqcGdeQXVyMTMzNDExODE5._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt0944947", 
                Name = "Game of Thrones",
                Type = "TV Series",
                Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                ReleaseDate = "2011",
                EndDate = "2019",
                Image = "https://m.media-amazon.com/images/M/MV5BN2IzYzBiOTQtNGZmMi00NDI5LTgxMzMtN2EzZjA1NjhlOGMxXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt4574334", 
                Name = "Stranger Things",
                Type = "TV Series",
                Description = "When a young boy vanishes, a small town uncovers a mystery involving secret experiments, terrifying supernatural forces and one strange little girl.",
                ReleaseDate = "2016",
                EndDate = "2025",
                Image = "https://m.media-amazon.com/images/M/MV5BN2ZmYjg1YmItNWQ4OC00YWM0LWE0ZDktYThjOTZiZjhhN2Q2XkEyXkFqcGdeQXVyNjgxNTQ3Mjk@._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt7660850", 
                Name = "Succession",
                Type = "TV Series",
                Description = "The Roy family is known for controlling the biggest media and entertainment company in the world. However, their world changes when their father steps down from the company.",
                ReleaseDate = "2018",
                EndDate = "2023",
                Image = "https://m.media-amazon.com/images/M/MV5BODY5YjA3ZDgtM2EwYy00ZGVmLWFhNWItMTMxMWRkMWFiOTlkXkEyXkFqcGdeQXVyMTMzNDExODE5._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt1190634", 
                Name = "The Boys",
                Type = "TV Series",
                Description = "A group of vigilantes set out to take down corrupt superheroes who abuse their superpowers.",
                ReleaseDate = "2019",
                EndDate = null,
                Image = "https://m.media-amazon.com/images/M/MV5BZWViOWJmNTctNjBjMC00ODA1LWIxZjItZTQxNGZiMDIxZTIwXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt10919420", 
                Name = "Squid Game",
                Type = "TV Series",
                Description = "Hundreds of cash-strapped players accept a strange invitation to compete in children's games. Inside, a tempting prize awaits with deadly high stakes: a survival game that has a whopping 45.6 billion-won prize at stake.",
                ReleaseDate = "2021",
                EndDate = null,
                Image = "https://m.media-amazon.com/images/M/MV5BYWE3MDVkN2EtNjQ5MS00ZDQ4LTliNzYtMjc2YWMzMDEwMTA3XkEyXkFqcGdeQXVyMTEzMTI1Mjk3._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt10986410", 
                Name = "Ted Lasso",
                Type = "TV Series",
                Description = "American college football coach Ted Lasso heads to London to manage AFC Richmond, a struggling English Premier League soccer team.",
                ReleaseDate = "2020",
                EndDate = "2023",
                Image = "https://m.media-amazon.com/images/M/MV5BOTE1MzIwOGItODAwNS00ODE4LWE3OTYtNTM4NThmODU2MGFiXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt8111088", 
                Name = "The Mandalorian",
                Type = "TV Series",
                Description = "The travels of a lone bounty hunter in the outer reaches of the galaxy, far from the authority of the New Republic.",
                ReleaseDate = "2019",
                EndDate = null,
                Image = "https://m.media-amazon.com/images/M/MV5BN2M5YWFjN2YtYzU2YS00NzBlLTgwZWUtYWQzNWFhNDkyYjg3XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt4786824", 
                Name = "The Crown",
                Type = "TV Series",
                Description = "Follows the political rivalries and romances of Queen Elizabeth II's reign and the events that shaped Britain for the second half of the 20th century.",
                ReleaseDate = "2016",
                EndDate = "2023",
                Image = "https://m.media-amazon.com/images/M/MV5BODYxYjZkODQtYTMyZS00NTMwLTkzNmItZDZjZDJjMmIzMjk0XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" 
            },
            new ShowInfo 
            { 
                Id = "tt3581920", 
                Name = "The Last of Us",
                Type = "TV Series",
                Description = "After a global pandemic destroys civilization, a hardened survivor takes charge of a 14-year-old girl who may be humanity's last hope.",
                ReleaseDate = "2023",
                EndDate = null,
                Image = "https://m.media-amazon.com/images/M/MV5BZGUzYTI3M2EtZmM0Yy00NGUyLWI4ODEtN2Q3ZGJlYzhhZjU3XkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_.jpg" 
            }
        };

        public static List<ShowInfo> NetflixTopShows = new List<ShowInfo>
        {
            new ShowInfo { Id = "tt4574334", Name="Stranger Things", Image= "https://m.media-amazon.com/images/M/MV5BN2ZmYjg1YmItNWQ4OC00YWM0LWE0ZDktYThjOTZiZjhhN2Q2XkEyXkFqcGdeQXVyNjgxNTQ3Mjk@._V1_.jpg" },
            new ShowInfo { Id = "tt10919420", Name="Squid Game", Image= "https://m.media-amazon.com/images/M/MV5BYWE3MDVkN2EtNjQ5MS00ZDQ4LTliNzYtMjc2YWMzMDEwMTA3XkEyXkFqcGdeQXVyMTEzMTI1Mjk3._V1_.jpg" },
            new ShowInfo { Id = "tt13443470", Name="Wednesday", Image= "https://m.media-amazon.com/images/M/MV5BM2ZmMjEyZmYtOGM4YS00YTNhLWE3ZDMtNzQxM2RhNjBlODIyXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg" },
            new ShowInfo { Id = "tt5180504", Name="The Witcher", Image= "https://m.media-amazon.com/images/M/MV5BN2FiOWU4YzYtMzZiOS00MzcyLTlkOGEtOTgwZmEwMzAxMzA3XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt4786824", Name = "The Crown", Image = "https://m.media-amazon.com/images/M/MV5BODYxYjZkODQtYTMyZS00NTMwLTkzNmItZDZjZDJjMmIzMjk0XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt8740790", Name="Bridgerton", Image= "https://m.media-amazon.com/images/M/MV5BMjZjNTMxOTUtN2RkYy00ZTFkLTg0OWEtZGEyM2NkZjQxNWY1XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt5611024", Name="Fool Me Once", Image= "https://m.media-amazon.com/images/M/MV5BMDVjYjgwYjMtZTAyNS00NmVhLTk4MTctMTIwY2VlZGRkOGFlXkEyXkFqcGdeQXVyMTYxMzc5MjQx._V1_.jpg" },
            new ShowInfo { Id = "tt10048342", Name="The Queen's Gambit", Image= "https://m.media-amazon.com/images/M/MV5BM2EwMmRhMmUtMzBmMS00ZDQ3LTg4OGEtNjlkODk3ZTMxMmJlXkEyXkFqcGdeQXVyMjM5ODk1NDU@._V1_.jpg" },
            new ShowInfo { Id = "tt13207736", Name="Dahmer – Monster: The Jeffrey Dahmer Story", Image= "https://m.media-amazon.com/images/M/MV5BM2IwNWY2YWEtNTU4Ni00MmE2LTljZjItNWQ0NzBlNjJiMzBiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "https://m.media-amazon.com/images/M/MV5BNzhkZDcxMzctNzJlOC00MjAwLWJhNzgtY2MzNjdkNDE5NGMxXkEyXkFqcGdeQXVyNTQ4ODA2NzQ@._V1_.jpg" },
            new ShowInfo { Id = "tt6468322", Name = "Money Heist", Image = "https://m.media-amazon.com/images/M/MV5BODI0ZTljYTMtODQ1NC00NmI0LTk1YWUtN2FlNDM1MDExMDlhXkEyXkFqcGdeQXVyMTM0NTUzNDIy._V1_.jpg" },
            new ShowInfo { Id = "tt14169960", Name = "All of Us Are Dead", Image = "https://m.media-amazon.com/images/M/MV5BOTY1ZGM2YzQtMTBjZC00NjE2LWJlNzUtYjA0YjYxNzBjMmRjXkEyXkFqcGdeQXVyMTEzMTI1Mjk3._V1_.jpg" },
            new ShowInfo { Id = "tt4052886", Name = "Lucifer", Image = "https://m.media-amazon.com/images/M/MV5BNDJjMzc4NGYtZmFmNS00YWY3LThjMzQtYzJlNGFkZGRiOWI1XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt11126994", Name = "Arcane", Image = "https://m.media-amazon.com/images/M/MV5BYmRiNzY5MjEtZWI1OC00M2Y4LWIwOWMtYzliMTYwOGE3MjkyXkEyXkFqcGdeQXVyODc0OTEyNDU@._V1_.jpg" },
            new ShowInfo { Id = "tt13918776", Name = "The Night Agent", Image = "https://m.media-amazon.com/images/M/MV5BODgzYmFkZjAtYjhmNC00NDdkLTk4NGYtNDdiODVlNmE3ODkyXkEyXkFqcGdeQXVyNTE1NjY5Mg@@._V1_.jpg" },
            new ShowInfo { Id = "tt14403178", Name = "Beef", Image = "https://m.media-amazon.com/images/M/MV5BOTNjOGVkYTctYjE1ZS00MTBhLTlkOTAtMGUzODZlNjAxMGM3XkEyXkFqcGdeQXVyNDk3MzMwMTI@._V1_.jpg" },
            new ShowInfo { Id = "tt5753856", Name = "Dark", Image = "https://m.media-amazon.com/images/M/MV5BOTk2NzUyOTctZDdlMS00MDJlLTgzNTEtNzQzYjFhNjA0YjBjXkEyXkFqcGdeQXVyMjg1NDcxNDE@._V1_.jpg" },
            new ShowInfo { Id = "tt6763664", Name = "The Haunting of Hill House", Image = "https://m.media-amazon.com/images/M/MV5BMTU4NzA4MDEwNF5BMl5BanBnXkFtZTgwMTQxODYzNjM@._V1_.jpg" },
            new ShowInfo { Id = "tt2085059", Name = "Black Mirror", Image = "https://m.media-amazon.com/images/M/MV5BZTgyNTBkNzctN2I3NC00NTA1LWJiMDMtYzA2MmYyZjc1NWQzXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg" },
            new ShowInfo { Id = "tt1837492", Name = "13 Reasons Why", Image = "https://m.media-amazon.com/images/M/MV5BYmRhZjkyMjEtNjRkMS00MDQ0LTg2NGMtMTQ3ZjE0NjJmMjM2L2ltYWdlXkEyXkFqcGdeQXVyNTY0MTkxMTg@._V1_.jpg" },
        };

        public static List<ShowInfo> DisneyTopShows = new List<ShowInfo>
        {
            new ShowInfo { Id = "tt8111088", Name = "The Mandalorian", Image = "https://m.media-amazon.com/images/M/MV5BN2M5YWFjN2YtYzU2YS00NzBlLTgwZWUtYWQzNWFhNDkyYjg3XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt9140560", Name="WandaVision", Image= "https://m.media-amazon.com/images/M/MV5BZGEwYmMwZmMtMTQ3MS00YWNhLWEwMmQtZTU5YTIwZmJjZGQ0XkEyXkFqcGdeQXVyMTI5MzA5MjA1._V1_.jpg" },
            new ShowInfo { Id = "tt9208876", Name="The Falcon and the Winter Soldier", Image= "https://m.media-amazon.com/images/M/MV5BODNiODVmYjItM2MyMC00ZWQyLTgyMGYtNzJjMmVmZTY2OTJjXkEyXkFqcGdeQXVyNzk3NDUzNTc@._V1_.jpg" },
            new ShowInfo { Id = "tt12324366", Name="Percy Jackson and the Olympians", Image= "https://m.media-amazon.com/images/M/MV5BMTYyNGUyNWMtMWFlMy00NThiLTk3YjItMWE2MzMzNmQwZTU3XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt9140554", Name="Loki", Image= "https://m.media-amazon.com/images/M/MV5BNTY1ZDQzNzQtZGM1Yy00YjRhLTliYmMtOGM2OWFlYTRjOTc2XkEyXkFqcGdeQXVyMTY3MDE5MDY1._V1_.jpg" },
            new ShowInfo { Id = "tt13622776", Name="Ahsoka", Image= "https://m.media-amazon.com/images/M/MV5BMWM1NjU1MDgtYjhjYS00Mjg5LWE1MWEtNzUwNWMxNTU2ZWY3XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt10168312", Name="What If...?", Image= "https://m.media-amazon.com/images/M/MV5BMDVjNGMzZWUtZGQzOS00ZGRhLTg3MjQtOTlkMzlkNDI1NzFhXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt13966962", Name="Echo", Image= "https://m.media-amazon.com/images/M/MV5BMTBjYTAzMWEtM2YyOS00NGMzLWExMmMtNmQ1Y2VkMDIxYmFiXkEyXkFqcGdeQXVyMTEyMjM2NDc2._V1_.jpg" },
            new ShowInfo { Id = "tt10234724", Name="Moon Knight", Image= "https://m.media-amazon.com/images/M/MV5BYTc5OWNhYjktMThlOS00ODUxLTgwNDQtZjdjYjkyM2IwZTZlXkEyXkFqcGdeQXVyNTA3MTU2MjE@._V1_.jpg" },
            new ShowInfo { Id = "tt8466564", Name="Obi-Wan Kenobi", Image= "https://m.media-amazon.com/images/M/MV5BOTAxOTlmOTAtMjA0Yy00YjVjLWE3OTQtYjAzMWMxOTAwZTY1XkEyXkFqcGdeQXVyMTM1MTE1NDMx._V1_.jpg" },
            new ShowInfo { Id = "tt2357547", Name="Jessica Jones", Image= "https://m.media-amazon.com/images/M/MV5BMTkxMDk5NTQ3MF5BMl5BanBnXkFtZTgwNzg3ODU3NDM@._V1_.jpg" },
            new ShowInfo { Id = "tt12708542", Name="Star Wars: The Bad Batch", Image= "https://m.media-amazon.com/images/M/MV5BZWU5Mjg5ZDctOWZmMi00ZjQ4LTkzYzYtY2FkY2E4YWIxMGNkXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_.jpg" },
            new ShowInfo { Id = "tt9253284", Name="Andor", Image= "https://m.media-amazon.com/images/M/MV5BNDgxNTIyZTMtMzYxNi00NmRjLWFiMTEtM2U4MTFmODkzNzM1XkEyXkFqcGdeQXVyMTM1MTE1NDMx._V1_.jpg" },
            new ShowInfo { Id = "tt3475734", Name="Agent Carter", Image= "https://m.media-amazon.com/images/M/MV5BOTJiNjUxZTUtNGE1ZS00MGFiLWIzMGEtZWI2OTMyMjAwZjM0XkEyXkFqcGdeQXVyNzQwMzAwNTI@._V1_.jpg" },
            new ShowInfo { Id = "tt13668894", Name="The Book of Boba Fett", Image= "https://m.media-amazon.com/images/M/MV5BZjllZjE1MWEtYTJhZC00MWIyLTliMjEtYzM3ODc4YzQ2MjFlXkEyXkFqcGdeQXVyODIyOTEyMzY@._V1_.jpg" },
            new ShowInfo { Id = "tt2364582", Name="Agents of S.H.I.E.L.D.", Image= "https://m.media-amazon.com/images/M/MV5BMTkwODYyMjgzOV5BMl5BanBnXkFtZTgwODAzMTE5MjE@._V1_.jpg" },
            new ShowInfo { Id = "tt0458290", Name="Star Wars: The Clone Wars", Image= "https://m.media-amazon.com/images/M/MV5BZWFlNzRmOTItZjY1Ni00ZjZkLTk5MDgtOGFhOTYzNWFhYzhmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt10160804", Name="Hawkeye", Image= "https://m.media-amazon.com/images/M/MV5BMGQ1OWNlY2QtMGY1NC00ZDkxLWJhZTktMzg5Mzk5YWY1YzA1XkEyXkFqcGdeQXVyMTU5OTc2NTk@._V1_.jpg" },
            new ShowInfo { Id = "tt13157618", Name="Secret Invasion", Image= "https://m.media-amazon.com/images/M/MV5BM2FlYzVmNWQtNzE4ZS00OTMwLTlhYTUtZDY0YTEyZTRlZDlkXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg" },
            new ShowInfo { Id = "tt13622958", Name="Baymax!", Image= "https://m.media-amazon.com/images/M/MV5BMGZiZmNkZWMtMjE0OS00NzBmLWIwNjMtZmZjMWE1MjE1MTM2XkEyXkFqcGdeQXVyMTQzNTA5MzYz._V1_.jpg" },
        };

        public static List<ShowInfo> MaxTopShows = new List<ShowInfo>
        {
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" }
        };

        public static List<ShowInfo> PrimeTopShows = new List<ShowInfo>
        {
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" }
        };

        public static List<ShowInfo> AppleTopShows = new List<ShowInfo>
        {
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" },
            new ShowInfo { Id = "tt7335184", Name="You", Image= "" }
        };
    }
}

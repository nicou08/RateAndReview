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

        public static List<ShowInfo> TopMovies = new List<ShowInfo>
        {
            new ShowInfo { Id = "tt1630029", Name = "Avatar: The Way of Water", Image = "https://m.media-amazon.com/images/M/MV5BYjhiNjBlODctY2ZiOC00YjVlLWFlNzAtNTVhNzM1YjI1NzMxXkEyXkFqcGdeQXVyMjQxNTE1MDA@._V1_.jpg"},
            new ShowInfo { Id = "tt15398776", Name = "Oppenheimer", Image = "https://m.media-amazon.com/images/M/MV5BMDBmYTZjNjUtN2M1MS00MTQ2LTk2ODgtNzc2M2QyZGE5NTVjXkEyXkFqcGdeQXVyNzAwMjU2MTY@._V1_.jpg"},
            new ShowInfo { Id = "tt0816692", Name = "Interstellar", Image = "https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg"},
            new ShowInfo { Id = "tt0381707", Name = "White Chicks", Image = "https://m.media-amazon.com/images/M/MV5BMTY3OTg2OTM3OV5BMl5BanBnXkFtZTYwNzY5OTA3._V1_.jpg"},
            new ShowInfo { Id = "tt15239678", Name = "Dune: Part Two", Image = "https://m.media-amazon.com/images/M/MV5BN2QyZGU4ZDctOWMzMy00NTc5LThlOGQtODhmNDI1NmY5YzAwXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg"},
            new ShowInfo { Id = "tt1745960", Name = "Top Gun: Maverick", Image = "https://m.media-amazon.com/images/M/MV5BZWYzOGEwNTgtNWU3NS00ZTQ0LWJkODUtMmVhMjIwMjA1ZmQwXkEyXkFqcGdeQXVyMjkwOTAyMDU@._V1_.jpg"},
            new ShowInfo { Id = "tt0298148", Name = "Shrek 2", Image = "https://m.media-amazon.com/images/M/MV5BMDJhMGRjN2QtNDUxYy00NGM3LThjNGQtMmZiZTRhNjM4YzUxL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg"},
            new ShowInfo { Id = "tt0468569", Name = "The Dark Knight", Image = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
            new ShowInfo { Id = "tt1411697", Name = "The Hangover Part II", Image = "https://m.media-amazon.com/images/M/MV5BMTM2MTM4MzY2OV5BMl5BanBnXkFtZTcwNjQ3NzI4NA@@._V1_.jpg"},
            new ShowInfo { Id = "tt2582802", Name = "Whiplash", Image = "https://m.media-amazon.com/images/M/MV5BOTA5NDZlZGUtMjAxOS00YTRkLTkwYmMtYWQ0NWEwZDZiNjEzXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg"},
            new ShowInfo { Id = "tt2322441", Name = "Fifty Shades of Grey", Image = "https://m.media-amazon.com/images/M/MV5BMjE1MTM4NDAzOF5BMl5BanBnXkFtZTgwNTMwNjI0MzE@._V1_.jpg"},
            new ShowInfo { Id = "tt0107290", Name = "Jurassic Park", Image = "https://m.media-amazon.com/images/M/MV5BMjM2MDgxMDg0Nl5BMl5BanBnXkFtZTgwNTM2OTM5NDE@._V1_.jpg"},
            new ShowInfo { Id = "tt9362722", Name = "Spider-Man: Across the Spider-Verse", Image = "https://m.media-amazon.com/images/M/MV5BMzI0NmVkMjEtYmY4MS00ZDMxLTlkZmEtMzU4MDQxYTMzMjU2XkEyXkFqcGdeQXVyMzQ0MzA0NTM@._V1_.jpg"},
            new ShowInfo { Id = "tt6751668", Name = "Parasite", Image = "https://m.media-amazon.com/images/M/MV5BYWZjMjk3ZTItODQ2ZC00NTY5LWE0ZDYtZTI3MjcwN2Q5NTVkXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_.jpg"},
            new ShowInfo { Id = "tt0463985", Name = "The Fast and the Furious: Tokyo Drift", Image = "https://m.media-amazon.com/images/M/MV5BMTQ2NTMxODEyNV5BMl5BanBnXkFtZTcwMDgxMjA0MQ@@._V1_.jpg"},
            new ShowInfo { Id = "tt8579674", Name = "1917", Image = "https://m.media-amazon.com/images/M/MV5BOTdmNTFjNDEtNzg0My00ZjkxLTg1ZDAtZTdkMDc2ZmFiNWQ1XkEyXkFqcGdeQXVyNTAzNzgwNTg@._V1_.jpg"},
            new ShowInfo { Id = "tt1074638", Name = "Skyfall", Image = "https://m.media-amazon.com/images/M/MV5BMWZiNjE2OWItMTkwNy00ZWQzLWI0NTgtMWE0NjNiYTljN2Q1XkEyXkFqcGdeQXVyNzAwMjYxMzA@._V1_.jpg"},
            new ShowInfo { Id = "tt0470752", Name = "Ex Machina", Image = "https://m.media-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_.jpg"},
            new ShowInfo { Id = "tt2194499", Name = "About Time", Image = "https://m.media-amazon.com/images/M/MV5BMTA1ODUzMDA3NzFeQTJeQWpwZ15BbWU3MDgxMTYxNTk@._V1_.jpg"},
            new ShowInfo { Id = "tt0405159", Name = "Million Dollar Baby", Image = "https://m.media-amazon.com/images/M/MV5BMTkxNzA1NDQxOV5BMl5BanBnXkFtZTcwNTkyMTIzMw@@._V1_.jpg"},
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
            new ShowInfo { Id = "tt7660850", Name="Succession", Image= "https://m.media-amazon.com/images/M/MV5BODY5YjA3ZDgtM2EwYy00ZGVmLWFhNWItMTMxMWRkMWFiOTlkXkEyXkFqcGdeQXVyMTMzNDExODE5._V1_.jpg" },
            new ShowInfo { Id = "tt11198330", Name="House of the Dragon", Image= "https://m.media-amazon.com/images/M/MV5BMjk2NjgzMTEtYWViZS00NTMyLWFjMzctODczYmQzNzk2NjIwXkEyXkFqcGdeQXVyMTEyMjM2NDc2._V1_.jpg" },
            new ShowInfo { Id = "tt2356777", Name="True Detective", Image= "https://m.media-amazon.com/images/M/MV5BMTUwMGM2ZmYtZGEyZC00OWQyLWI2Y2QtMTdjYzMxZGJmNjhjXkEyXkFqcGdeQXVyNjU2ODM5MjU@._V1_.jpg" },
            new ShowInfo { Id = "tt8772296", Name="Euphoria", Image= "https://m.media-amazon.com/images/M/MV5BMDMzZDkyNzEtYTY5Ni00NzlhLWI4MzUtY2UzNjNmMjI1YzIzXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt3581920", Name="The Last of Us", Image= "https://m.media-amazon.com/images/M/MV5BZGUzYTI3M2EtZmM0Yy00NGUyLWI4ODEtN2Q3ZGJlYzhhZjU3XkEyXkFqcGdeQXVyNTM0OTY1OQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt5348176", Name="Barry", Image= "https://m.media-amazon.com/images/M/MV5BMmY1NTk5N2QtYWQyOS00NjhiLWFhZmYtYWZmZGFlMjEzY2E2XkEyXkFqcGdeQXVyMzQ2MDI5NjU@._V1_.jpg" },
            new ShowInfo { Id = "tt0306414", Name="The Wire", Image= "https://m.media-amazon.com/images/M/MV5BNTllYzFhMjAtZjExNS00MjM4LWE5YmMtOGFiZGRlOTU5YzJiXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg" },
            new ShowInfo { Id = "tt7671070", Name="Industry", Image= "https://m.media-amazon.com/images/M/MV5BOTQ5ZjllMDgtZWQxZS00YjcwLWEwOTAtMGUxZTNhMGMzMGQzXkEyXkFqcGdeQXVyNjEwNTM2Mzc@._V1_.jpg" },
            new ShowInfo { Id = "tt13406094", Name="The White Lotus", Image= "https://m.media-amazon.com/images/M/MV5BNTcyMDdhNmUtM2JmOS00MWY4LThjZDMtMWRiZmI3ZDg4OWJiXkEyXkFqcGdeQXVyMTU2Mjg2NjE2._V1_.jpg" },
            new ShowInfo { Id = "tt10155688", Name="Mare of Easttown", Image= "https://m.media-amazon.com/images/M/MV5BYjIyOGU1NzAtODZmYi00NGMzLWJiMjItNGNjNTFjOTM5ZDJhXkEyXkFqcGdeQXVyMTEyMjM2NDc2._V1_.jpg" },
            new ShowInfo { Id = "tt3920596", Name="Big Little Lies", Image= "https://m.media-amazon.com/images/M/MV5BZmNjYzdjN2ItOTBlNy00Mjc0LWE4YmMtYTQ4ZjQzNTMyNDc4XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt0944947", Name="Game of Thrones", Image= "https://m.media-amazon.com/images/M/MV5BN2IzYzBiOTQtNGZmMi00NDI5LTgxMzMtN2EzZjA1NjhlOGMxXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_.jpg" },
            new ShowInfo { Id = "tt7049682", Name="Watchmen", Image= "https://m.media-amazon.com/images/M/MV5BYjhhZDE3NjgtMjkzNC00NzI3LWJhOTItMWQ5ZjljODA5NWNkXkEyXkFqcGdeQXVyMzQ2MDI5NjU@._V1_.jpg" },
            new ShowInfo { Id = "tt0141842", Name="The Sopranos", Image= "https://m.media-amazon.com/images/M/MV5BZGJjYzhjYTYtMDBjYy00OWU1LTg5OTYtNmYwOTZmZjE3ZDdhXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt7366338", Name="Chernobyl", Image= "https://m.media-amazon.com/images/M/MV5BNTdkN2QwMDItMDVhNS00ZjFiLWEzNTctMzY5ODQzYWNkMDllXkEyXkFqcGdeQXVyMTMzNDExODE5._V1_.jpg" },
            new ShowInfo { Id = "tt2887954", Name="Tokyo Vice", Image= "https://m.media-amazon.com/images/M/MV5BYWVhN2Q2MDEtMzIzYS00M2EwLTlmZDItMzk5YTUzZWE0MjkwXkEyXkFqcGdeQXVyMTEzMTI1Mjk3._V1_.jpg" },
            new ShowInfo { Id = "tt11204260", Name="I May Destroy You", Image= "https://m.media-amazon.com/images/M/MV5BMmI0Mjc4ZTgtZmU0My00ODliLWE0MzYtYzBiODMxZWJkZmE4XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt0475784", Name="Westworld", Image= "https://m.media-amazon.com/images/M/MV5BMTRmYzNmOTctZjMwOS00ODZlLWJiZGQtNDg5NDY5NjE3MTczXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt14586350", Name="Love & Death", Image= "https://m.media-amazon.com/images/M/MV5BOGRhYmU2YWEtNThlMi00ZmQ4LWFiYTQtYjM0NDM3YTRlZmUxXkEyXkFqcGdeQXVyMTEyMjM2NDc2._V1_.jpg" },
            new ShowInfo { Id = "tt10814438", Name="Betty", Image= "https://m.media-amazon.com/images/M/MV5BYmY3Y2UwOTgtMDZiZC00ODI3LWFmZTQtNWVlZDVkYTE4N2NkXkEyXkFqcGdeQXVyMTAyMjQ3NzQ1._V1_.jpg" },
        };

        public static List<ShowInfo> DramaMovies = new List<ShowInfo>
        {
            new ShowInfo { Id = "tt7286456", Name="Joker", Image= "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" },
            new ShowInfo { Id = "tt5013056", Name="Dunkirk", Image= "https://m.media-amazon.com/images/M/MV5BN2YyZjQ0NTEtNzU5MS00NGZkLTg0MTEtYzJmMWY3MWRhZjM2XkEyXkFqcGdeQXVyMDA4NzMyOA@@._V1_.jpg" },
            new ShowInfo { Id = "tt2543164", Name="Arrival", Image= "https://m.media-amazon.com/images/M/MV5BMTExMzU0ODcxNDheQTJeQWpwZ15BbWU4MDE1OTI4MzAy._V1_.jpg" },
            new ShowInfo { Id = "tt7131622", Name="Once Upon a Time in... Hollywood", Image= "https://m.media-amazon.com/images/M/MV5BOTg4ZTNkZmUtMzNlZi00YmFjLTk1MmUtNWQwNTM0YjcyNTNkXkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_.jpg" },
            new ShowInfo { Id = "tt0993846", Name="The Wolf of Wall Street", Image= "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_.jpg" },
            new ShowInfo { Id = "tt3704428", Name="Elvis", Image= "https://m.media-amazon.com/images/M/MV5BYzMzNTJjYmMtZTkxNS00MjI4LWI3YmQtOTQ4MDZjZDJlZjQyXkEyXkFqcGdeQXVyNjc0NzQzNTM@._V1_.jpg" },
            new ShowInfo { Id = "tt1302006", Name="The Irishman", Image= "https://m.media-amazon.com/images/M/MV5BMGUyM2ZiZmUtMWY0OC00NTQ4LThkOGUtNjY2NjkzMDJiMWMwXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_.jpg" },
            new ShowInfo { Id = "tt0405159", Name = "Million Dollar Baby", Image = "https://m.media-amazon.com/images/M/MV5BMTkxNzA1NDQxOV5BMl5BanBnXkFtZTcwNTkyMTIzMw@@._V1_.jpg"},
            new ShowInfo { Id = "tt1291584", Name="Warrior", Image= "https://m.media-amazon.com/images/M/MV5BMTk4ODk5MTMyNV5BMl5BanBnXkFtZTcwMDMyNTg0Ng@@._V1_.jpg" },
            new ShowInfo { Id = "tt13880104", Name="Happening", Image= "https://m.media-amazon.com/images/M/MV5BZDU4NTE3YTQtMzczMC00YzRkLWI5MjItNGE3NjQ0NTY4MzExXkEyXkFqcGdeQXVyODA0MjgyNzM@._V1_.jpg" },
            new ShowInfo { Id = "tt1517451", Name="A Star Is Born", Image= "https://m.media-amazon.com/images/M/MV5BNmE5ZmE3OGItNTdlNC00YmMxLWEzNjctYzAwOGQ5ODg0OTI0XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg" },
            new ShowInfo { Id = "tt0068646", Name="The Godfather", Image= "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg" },
            new ShowInfo { Id = "tt2179136", Name="American Sniper", Image= "https://m.media-amazon.com/images/M/MV5BMTkxNzI3ODI4Nl5BMl5BanBnXkFtZTgwMjkwMjY4MjE@._V1_.jpg" },
            new ShowInfo { Id = "tt3741834", Name="Lion", Image= "https://m.media-amazon.com/images/M/MV5BMjA3NjkzNjg2MF5BMl5BanBnXkFtZTgwMDkyMzgzMDI@._V1_.jpg" },
            new ShowInfo { Id = "tt7653254", Name="Marriage Story", Image= "https://m.media-amazon.com/images/M/MV5BZGVmY2RjNDgtMTc3Yy00YmY0LTgwODItYzBjNWJhNTRlYjdkXkEyXkFqcGdeQXVyMjM4NTM5NDY@._V1_.jpg" },
            new ShowInfo { Id = "tt0120338", Name="Titanic", Image= "https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_.jpg" },
            new ShowInfo { Id = "tt0172495", Name="Gladiator", Image= "https://m.media-amazon.com/images/M/MV5BMDliMmNhNDEtODUyOS00MjNlLTgxODEtN2U3NzIxMGVkZTA1L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg" },
            new ShowInfo { Id = "tt0414387", Name="Pride & Prejudice", Image= "https://m.media-amazon.com/images/M/MV5BMTA1NDQ3NTcyOTNeQTJeQWpwZ15BbWU3MDA0MzA4MzE@._V1_.jpg" },
            new ShowInfo { Id = "tt10731256", Name="Don't Worry Darling", Image= "https://m.media-amazon.com/images/M/MV5BZWUyZmJiMTgtZWQ5ZS00ZmRjLTg0NWItNmQxNmM5ZjQ2MmFiXkEyXkFqcGdeQXVyMTUzMTQ0NzQz._V1_.jpg" },
            new ShowInfo { Id = "tt1285016", Name="The Social Network", Image= "https://m.media-amazon.com/images/M/MV5BOGUyZDUxZjEtMmIzMC00MzlmLTg4MGItZWJmMzBhZjE0Mjc1XkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg" },
        };
    }
}

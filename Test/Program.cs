using AnimeLists;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var downloader = new Downloader("anime-list.xml");
            var animelist = downloader.Download().Result;

            var mapper = new Mapper(animelist);

            var fateZero = new AnidbEpisode
            {
                Series = "8160",
                Season = 1,
                Index = 7
            };

            var tvdb = mapper.ToTvdb(fateZero);
            var anidb = mapper.ToAnidb(tvdb);

            var fateZeroS2 = new AnidbEpisode
            {
                Series = "8880",
                Season = 1,
                Index = 11
            };

            tvdb = mapper.ToTvdb(fateZeroS2);
            anidb = mapper.ToAnidb(tvdb);

            var fateZeroSpecial = new AnidbEpisode
            {
                Series = "8880",
                Season = 0,
                Index = 1
            };

            tvdb = mapper.ToTvdb(fateZeroSpecial);
            anidb = mapper.ToAnidb(tvdb);

            var naruto = new AnidbEpisode
            {
                Series = "4880",
                Season = 1,
                Index = 212
            };

            tvdb = mapper.ToTvdb(naruto);
            anidb = mapper.ToAnidb(tvdb);

            var narutoMovie = new AnidbEpisode
            {
                Series = "6503",
                Season = 1,
                Index = 1
            };

            tvdb = mapper.ToTvdb(narutoMovie);
            anidb = mapper.ToAnidb(tvdb);
        }
    }
}
using GameIndustry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustry.Data.Repository
{
    public class MockGamesRepository: IRepository
    {
        List<GameModel> _GameModels;

        public MockGamesRepository()
        {
            _GameModels = new List<GameModel>()
            {
                new GameModel()
                {
                    Name = "Farming Simulator 2019",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018,11,19),
                    Image = "https://cdn2.unrealengine.com/Diesel%2Fproductv2%2Ffarming-simulator-19%2Fhome%2FEGS-GIANTS-FS19-1360x766_Standard-1360x766-3ff704f0c5b6993465dbbeb797b181e9acf313e3.jpg?h=270&resize=1&w=480"
                },

                new GameModel()
                {
                    Name = "The Wincher 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2015,11,19),
                    Image = "https://cdn2.unrealengine.com/Diesel%2Fproductv2%2Ffarming-simulator-19%2Fhome%2FEGS-GIANTS-FS19-1360x766_Standard-1360x766-3ff704f0c5b6993465dbbeb797b181e9acf313e3.jpg?h=270&resize=1&w=480"
                },

                 new GameModel()
                {
                    Name = "The Wincher 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2015,11,19),
                    Image = "https://cdn2.unrealengine.com/Diesel%2Fproductv2%2Ffarming-simulator-19%2Fhome%2FEGS-GIANTS-FS19-1360x766_Standard-1360x766-3ff704f0c5b6993465dbbeb797b181e9acf313e3.jpg?h=270&resize=1&w=480"
                }
            };
        }


        public List<GameModel> GetAllGames()
        {
            return _GameModels;
        }
    }
}

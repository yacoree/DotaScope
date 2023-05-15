using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Utilities;

namespace DotaScope.Data
{
    public class DotaAPI
    {
        private SteamWebInterfaceFactory webApi;
        private DOTA2Match dotaMatch;

        public DotaAPI(string webApiKey)
        {
            this.webApi = new SteamWebInterfaceFactory(webApiKey);
            dotaMatch = webApi.CreateSteamWebInterface<DOTA2Match>();
        }

        public DOTA2Match GetDOTA2 { get => dotaMatch; }

        public async Task<IReadOnlyCollection<Steam.Models.DOTA2.LiveLeagueGameModel>> GetLiveLigueDataAsync()
        {
            var liveGames = await dotaMatch.GetLiveLeagueGamesAsync();
            return liveGames.Data;
        }

        public async Task<ISteamWebResponse<IReadOnlyCollection<Steam.Models.DOTA2.TeamInfo>>> GetTeams()
        {
            return await dotaMatch.GetTeamInfoByTeamIdAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueProject
{
    internal class Summoner
    {
        public string Name { get; set; }
        public string TagLine { get; set; }
        public string PUUID { get; set; }
        public string Rank_SD { get; set; } = "Unranked";
        public string Rank_Flex { get; set; } = "Unranked";

        public string Status { get; set; }
        public double WR_SD { get; set; }
        public double WR_FLEX { get; set; }
        public long Level { get; set; }
        public override string ToString()
        {
            return $"Summoner name: {this.Name}\nSummoner Tagline: #{this.TagLine}\nSummoner Rank: S/D -> {this.Rank_SD}\tFlex -> {this.Rank_Flex}\nSummoner WR: S/D -> {this.WR_SD}%\tFlex -> {this.WR_FLEX}%\nSummoner Level: {this.Level}\nSummoner Status: {this.Status}";
        }
    }
    
}

using Camille.Enums;
using Camille.RiotGames;
using Camille.RiotGames.LeagueExpV4;
using Camille.RiotGames.LeagueV4;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace LeagueProject
{

    public partial class HomePage : Form
    {

        private readonly RiotGamesApi api = RiotGamesApi.NewInstance("RGAPI-4db2555e-d6a0-47c8-afe8-c45da70e518e");
        Summoner player;
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public HomePage()
        {
            InitializeComponent();
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            AllocConsole();

        }


        private void getDataButton_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(getData) { IsBackground = true };
           // thread.Start();
            getData();
            updateHomePage(false);
        }

        void getData()
        {
            player = new Summoner();
            try
            {
                if (nameTextbox.Text.Contains('#') && nameTextbox.Text.Length  > 0)
                {
                    var nameAndtag = nameTextbox.Text.Split("#");

                        player.Name = nameAndtag[0]; player.TagLine= nameAndtag[1];
                        var Account = api.AccountV1().GetByRiotId(RegionalRoute.EUROPE, player.Name, player.TagLine);
                        if (Account is not null)
                        {
                            player.PUUID = Account.Puuid;
                            var summonerInfo = api.SummonerV4().GetByPUUID(PlatformRoute.EUN1, player.PUUID);
                            player.Level = summonerInfo.SummonerLevel;

                            var currentGameType = api.SpectatorV4().GetCurrentGameInfoBySummoner(PlatformRoute.EUN1, summonerInfo.Id);
                            if (currentGameType is null)
                            {
                                player.Status = "Not in game";
                            }
                            else
                            {
                                player.Status = currentGameType.GameType.ToString();
                            }


                            var ranked = api.LeagueV4().GetLeagueEntriesForSummoner(PlatformRoute.EUN1, summonerInfo.Id);
                            Console.WriteLine(ranked.Length);
                            foreach (var rank in ranked)
                            {
                                if (rank.QueueType == QueueType.RANKED_SOLO_5x5)
                                {

                                    player.Rank_SD = rank.Tier.Value.ToString() + " " + rank.Rank.Value.ToString();
                                    player.WR_SD = Math.Round(((double)rank.Wins / (double)(rank.Losses + rank.Wins) * 100), 2);
                                }
                                else if (rank.QueueType == QueueType.RANKED_FLEX_SR)
                                {
                                    player.Rank_Flex = rank.Tier.Value.ToString() + " " + rank.Rank.Value.ToString();
                                    player.WR_FLEX = Math.Round(((double)rank.Wins / (double)(rank.Losses + rank.Wins) * 100), 2);
                                }
                            }
                            Console.WriteLine(player);
                        }
                        else
                        {
                            MessageBox.Show("Invalid name..");
                        }
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void updateHomePage(bool isFlex)
        {

            LevelBox.Text = player.Level.ToString();
            RankBox.Text = (isFlex) ? player.Rank_Flex : player.Rank_SD;
            WinRateBox.Text = (isFlex) ? player.WR_FLEX.ToString() + "%" : player.WR_SD.ToString() + "%";
            statusBox.Text = player.Status;
    

        }
        string getTier(int compTier)
        {
            switch (compTier)
            {
                case 3:
                    return "iron 1";
                case 4:
                    return "iron 2";
                case 5:
                    return "iron 3";
                case 6:
                    return "bronze 1";
                case 7:
                    return "bronze 2";
                case 8:
                    return "bronze 3";
                case 9:
                    return "Silver 1";
                case 10:
                    return "Silver 2";
                case 11:
                    return "Silver 3";
                case 12:
                    return "Gold 1";
                case 13:
                    return "Gold 2";
                case 14:
                    return "Gold 3";
                case 15:
                    return "Plat 1";
                case 16:
                    return "Plat 2";
                case 17:
                    return "Plat 3";
                case 18:
                    return "Diamond 1";
                case 19:
                    return "Diamond 2";
                case 20:
                    return "Diamond 3";
                case 21:
                    return "Ascendant 1";
                case 22:
                    return "Ascendant 2";
                case 23:
                    return "Ascendant 3";
                case 24:
                    return "Immortal 1";
                case 25:
                    return "Immortal 2";
                case 26:
                    return "Immortal 3";
                case 27:
                    return "Radiant";
                default:
                    return "No valid tier";
            }
        }

        private void flexToggleButton_Click(object sender, EventArgs e)
        {
            updateHomePage(true);
        }

        private void sdToggleButton_Click(object sender, EventArgs e)
        {
            updateHomePage(false);
        }
    }
}
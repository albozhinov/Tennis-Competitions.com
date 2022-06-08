namespace Tennis_Competitions.Services.Models
{
    using Tennis_Competitions.Data.Common;
    using Tennis_Competitions.Data.Models;

    public class MatchServiceModel
    {
        public MatchServiceModel()
        {

        }

        public MatchServiceModel(Match match)
        {
            this.Id = match.Id;
            this.Name = match.Name;
            this.FirstPlayerId = match.FirstPlayerId;
            this.SecondPlayerId = match.SecondPlayerId;
            this.FirstPlayerName = match.FirstPlayerName;
            this.SecondPlayerName = match.SecondPlayerName;
            this.Round = match.Round;
            this.AcesFirstPlayer = match.AcesFirstPlayer;
            this.AcesSecondPlayer = match.AcesSecondPlayer;
            this.DoubleFoultsFirstPlayer = match.DoubleFoultsFirstPlayer;
            this.DoubleFoultsSecondPlayer = match.DoubleFoultsSecondPlayer;
            this.WinnersFirstPlayer = match.WinnersFirstPlayer;
            this.WinnersSecondPlayer = match.WinnersSecondPlayer;
            this.UnforcesErrorsFirstPlayer = match.UnforcesErrorsFirstPlayer;
            this.UnforcesErrorsSecondPlayer = match.UnforcesErrorsSecondPlayer;

            if(match.Players is not null)
            this.Players = match.Players
                                        .Select(p => new PlayerServiceModel(p.Player))
                                        .ToList();
        }

        public Guid Id { get; init; }

        public string Name { get; set; }

        public Guid FirstPlayerId { get; set; }

        public Guid SecondPlayerId { get; set; }

        public string FirstPlayerName { get; set; }

        public string SecondPlayerName { get; set; }

        public Round Round { get; set; }

        public int AcesFirstPlayer { get; set; }

        public int AcesSecondPlayer { get; set; }

        public int DoubleFoultsFirstPlayer { get; set; }

        public int DoubleFoultsSecondPlayer { get; set; }

        public int WinnersFirstPlayer { get; set; }

        public int WinnersSecondPlayer { get; set; }

        public int UnforcesErrorsFirstPlayer { get; set; }

        public int UnforcesErrorsSecondPlayer { get; set; }

        public ICollection<PlayerServiceModel> Players { get; set; }
    }
}

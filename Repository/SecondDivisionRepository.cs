using server_brazilian_second_division.Repository.interfaces;

namespace server_brazilian_second_division.Repository
{
    public class SecondDivisionRepository : ISecondDivisionRepository
    {
        public List<string> GetAllTeams()
        {
            return GetTeams();
        }

        private List<String> GetTeams()
        {
            string[] mockTeam = 
            { 
                    "Guarani",
                    "Avaí",
                    "Vila Nova",
                    "Novorizontino",
                    "Criciúma",
                    "Tombense",
                    "Ituano",
                    "Ceará",
                    "Mirassol",
                    "Chapecoense",
                    "Vitória",
                    "Ponte Preta",
                    "Sampaio Corrêa",
                    "Atlético-GO",
                    "Juventude",
                    "Botafogo-SP",
                    "Londrina",
                    "ABC",
                    "CRB",
                    "Sport"  
            };

            var teamList = new List<String>();
            teamList.AddRange(mockTeam);
            return teamList; 
        }
    }
}
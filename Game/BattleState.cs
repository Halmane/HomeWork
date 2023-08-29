using Game.Warrior;

namespace Game;

public class BattleState
{
    private int _aliveWarriorsFirstTeam;
    private int _hpFirstTeam;
    private int _aliveWarriorsSecondTeam;
    private int _hpSecondTeam;
    

    public bool FirstTeamWin { get; private set; }
    public bool SecondTeamWin { get; private set; }

    private void CommandsStateInfo(Team teamOne, Team teamTwo)
    {
        _aliveWarriorsFirstTeam = 0;
        _hpFirstTeam = 0;
        _aliveWarriorsSecondTeam = 0;
        _hpSecondTeam = 0;

        for (int i = 0; i < teamOne.Warriors.Count; i++)
        {
            _hpFirstTeam += teamOne.Warriors[i].HP;
            if (!teamOne.Warriors[i].IsKilled)
                _aliveWarriorsFirstTeam++;
        }
        for (int i = 0; i < teamTwo.Warriors.Count; i++)
        {
            _hpSecondTeam += teamTwo.Warriors[i].HP;
            if (!teamTwo.Warriors[i].IsKilled)
                _aliveWarriorsSecondTeam++;
        }
    }

    public void PrintCommandsStateInfo(Team teamOne, Team teamTwo)
    {
        CommandsStateInfo(teamOne, teamTwo);

        Console.WriteLine(
            $"""
            Team one info:
            Team hp: {_hpFirstTeam}
            Team alive warriors: {_aliveWarriorsFirstTeam} 


            """
        );
        Console.WriteLine(
            $"""
            Team two info:
            Team hp: {_hpSecondTeam}
            Team alive warriors: {_aliveWarriorsSecondTeam}
            

            """
        );
    }

    public bool WinTeam(Team teamOne, Team teamTwo)
    {
        CommandsStateInfo(teamOne, teamTwo);

        if (_aliveWarriorsSecondTeam == 0)
        {
            FirstTeamWin = true;
            Console.WriteLine("Team one win!");
            return true;
        }
        if (_aliveWarriorsFirstTeam == 0)
        {
            SecondTeamWin = true;
            Console.WriteLine("Team two win!");
            return true;
        }
        return false;
    }
}

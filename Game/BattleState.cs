using Game.Warrior;

namespace Game;

public class BattleState
{
    private int _aliveWarriorsTeamOne;
    private int _hpTeamOne;
    private int _aliveWarriorsTeamTwo;
    private int _hpTeamTwo;

    private void CommandsState(Team teamOne, Team teamTwo)
    {
        _aliveWarriorsTeamOne = 0;
        _hpTeamOne = 0;
        _aliveWarriorsTeamTwo = 0;
        _hpTeamTwo = 0;

        for (int i = 0; i < teamOne.Warriors.Count; i++)
        {
            _hpTeamOne += teamOne.Warriors[i]._hP;
            if (!teamOne.Warriors[i].IsKilled)
                _aliveWarriorsTeamOne++;
        }
        for (int i = 0; i < teamTwo.Warriors.Count; i++)
        {
            _hpTeamTwo += teamTwo.Warriors[i]._hP;
            if (!teamTwo.Warriors[i].IsKilled)
                _aliveWarriorsTeamTwo++;
        }
    }

    public void CommandsStateInfo(Team teamOne, Team teamTwo)
    {
        CommandsState(teamOne, teamTwo);

        Console.WriteLine(
            $"""
            Team one info:
            Team hp: {_hpTeamOne}
            Team alive warriors: {_aliveWarriorsTeamOne} 


            """
        );
        Console.WriteLine(
            $"""
            Team two info:
            Team hp: {_hpTeamTwo}
            Team alive warriors: {_aliveWarriorsTeamTwo}
            

            """
        );
    }

    public bool WinTeam(Team teamOne, Team teamTwo)
    {
        CommandsState(teamOne, teamTwo);

        if (_aliveWarriorsTeamTwo == 0)
        {
            Console.WriteLine("Team one win!");
            return true;
        }
        if (_aliveWarriorsTeamOne == 0)
        {
            Console.WriteLine("Team two win!");
            return true;
        }
        return false;
    }
}

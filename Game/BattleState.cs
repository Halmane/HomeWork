using Game.Warrior;

namespace Game;

public class BattleState
{
    private int _aliveWarriorsFirstTeam;
    private int _hpFirstTeam;
    private int _aliveWarriorsSecondTeam;
    private int _hpSecondTeam;
    private Team _firstTeam;
    private Team _secondTeam;
    private const int NumberOfTurnsForDraw = 15;

    public bool FirstTeamWin { get; private set; }
    public bool SecondTeamWin { get; private set; }
    public bool Draw { get; private set; }
    public string FirstTeamInfo { get; private set; }
    public string SecondTeamInfo { get; private set; }
    public int NumberOfTurns { get; set; } = 0;

    public BattleState(Team firstTeam, Team secondTeam)
    {
        FirstTeamWin = false;
        SecondTeamWin = false;
        Draw = false;
        _firstTeam = firstTeam;
        _secondTeam = secondTeam;
    }

    public void UpdateCommandsStateInfo()
    {
        _aliveWarriorsFirstTeam = 0;
        _hpFirstTeam = 0;
        _aliveWarriorsSecondTeam = 0;
        _hpSecondTeam = 0;

        for (int i = 0; i < _firstTeam.Warriors.Count; i++)
        {
            _hpFirstTeam += _firstTeam.Warriors[i].HP;
            if (!_firstTeam.Warriors[i].IsKilled)
                _aliveWarriorsFirstTeam++;
        }
        for (int i = 0; i < _secondTeam.Warriors.Count; i++)
        {
            _hpSecondTeam += _secondTeam.Warriors[i].HP;
            if (!_secondTeam.Warriors[i].IsKilled)
                _aliveWarriorsSecondTeam++;
        }
        FirstTeamInfo = $"""
            Team one info:
            Team hp: {_hpFirstTeam}
            Team alive warriors: {_aliveWarriorsFirstTeam} 


            """;
        SecondTeamInfo = $"""
            Team two info:
            Team hp: {_hpSecondTeam}
            Team alive warriors: {_aliveWarriorsSecondTeam}
            

            """;
        IsGameOver();
    }

    public void PrintCommandsStateInfo()
    {
        UpdateCommandsStateInfo();

        Console.WriteLine(FirstTeamInfo);
        Console.WriteLine(SecondTeamInfo);
    }

    public bool IsGameOver()
    {
        if (
            NumberOfTurns == NumberOfTurnsForDraw
            && _aliveWarriorsFirstTeam > 0
            && _aliveWarriorsSecondTeam == _aliveWarriorsFirstTeam
        ) 
        {
            Draw = true;
            Console.WriteLine("Draw!");
            return true;
        }
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

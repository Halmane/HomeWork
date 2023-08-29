using Game.Warrior;

namespace Game;

public class Battle
{
    private Team _teamOne;
    private Team _teamTwo;
    private bool _isGameEnd;
    private BattleState _battleState = new BattleState();

    public Battle()
    {
        _teamOne = new Team();
        _teamTwo = new Team();
        _isGameEnd = false;
        PrintBattleInfo();
    }

    public void PrintBattleInfo()
    {
        if (!_isGameEnd)
            _battleState.PrintCommandsStateInfo(_teamOne, _teamTwo);
    }

    private void Fight(Team firstWarriors, Team secondWarriors)
    {
        for (int i = 0; i < firstWarriors.Warriors.Count; i++)
        {
            int randomEnemyIndex = Random.Shared.Next(0, secondWarriors.Warriors.Count);
            var rendomEnemy = secondWarriors.Warriors[randomEnemyIndex];
            firstWarriors.Warriors[i].Attack(rendomEnemy);
            if (rendomEnemy.IsKilled)
                secondWarriors.RemoveWarrior(rendomEnemy);
            if (_battleState.WinTeam(_teamOne, _teamTwo))
            {
                _isGameEnd = true;
                return;
            }
        }
    }

    public void StartBattle()
    {
        _teamOne.ShuffleTeam();
        _teamTwo.ShuffleTeam();
        while (!_isGameEnd)
        {
            Fight(_teamOne, _teamTwo);
            Fight(_teamTwo, _teamOne);
            
            PrintBattleInfo();
            Thread.Sleep(500);
        }
    }
}

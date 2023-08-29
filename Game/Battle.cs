using Game.Warrior;

namespace Game;

public class Battle
{
    private Team _teamOne;
    private Team _teamTwo;
    private bool _isGameEnd;
    private BattleState _battleState;

    public Battle()
    {
        _teamOne = new Team();
        _teamTwo = new Team();
        _battleState = new BattleState(_teamOne, _teamTwo);
        _isGameEnd = false;
        PrintBattleInfo();
    }

    public void PrintBattleInfo()
    {
        if (!_isGameEnd)
            _battleState.PrintCommandsStateInfo();
    }

    private void Fight(Team firstWarriors, Team secondWarriors)
    {
        for (int i = 0; i < firstWarriors.Warriors.Count; i++)
        {
            int randomEnemyIndex = Random.Shared.Next(0, secondWarriors.Warriors.Count);
            var randomEnemy = secondWarriors.Warriors[randomEnemyIndex];
            firstWarriors.Warriors[i].Attack(randomEnemy);
            if (randomEnemy.IsKilled)
                secondWarriors.RemoveWarrior(randomEnemy);
            _battleState.UpdateCommandsStateInfo();
            if (_battleState.IsGameOver())
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
            _battleState.NumberOfTurns++;
            Fight(_teamOne, _teamTwo);
            Fight(_teamTwo, _teamOne);

            PrintBattleInfo();
            Thread.Sleep(500);
        }
    }
}

namespace Game;

public class Battle
{
    private Team _teamOne;
    private Team _teamTwo;
    private bool _endGame;
    private BattleState _battleState = new BattleState();

    public Battle()
    {
        _teamOne = new Team();
        _teamTwo = new Team();
        _endGame = false;
        BattleInfo();
    }

    public void BattleInfo()
    {
        if (!_endGame)
            _battleState.PrintCommandsStateInfo(_teamOne, _teamTwo);
    }

    public void War()
    {
        while (!_endGame) 
        {
            _teamOne.ShuffleTeam();
            _teamTwo.ShuffleTeam();
            for (int i = 0; i < _teamOne.Warriors.Count; i++) 
            {
                int randomEnemy = Random.Shared.Next(0, _teamTwo.Warriors.Count - 1);
                _teamOne.Warriors[i].Attack(_teamTwo.Warriors[randomEnemy]);
                _teamTwo.WarriorIsDead(_teamTwo.Warriors[randomEnemy]);
                _endGame = _battleState.WinTeam(_teamOne, _teamTwo);
                if (_endGame) return;
            }
            for (int i = 0; i < _teamTwo.Warriors.Count; i++)
            {
                int randomEnemy = Random.Shared.Next(0, _teamOne.Warriors.Count - 1);
                _teamTwo.Warriors[i].Attack(_teamOne.Warriors[randomEnemy]);
                _teamOne.WarriorIsDead(_teamOne.Warriors[randomEnemy]);
                _endGame = _battleState.WinTeam(_teamOne, _teamTwo);
                if (_endGame) return;
            }
            BattleInfo();
            Thread.Sleep(500);
        }
    }
}

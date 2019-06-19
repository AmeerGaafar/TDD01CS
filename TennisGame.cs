using System;

namespace UglyTennis
{
  public class TennisGame
  {
    private readonly  string _player1Name;
    private readonly string _player2Name;
    private int _p1Point = 0;
    private int _p2Point = 0;

    private string _p1Res = "";
    private string _p2Res = "";

    public TennisGame(string player1Name, string player2Name)
    {
      this._player1Name = player1Name;
      this._player2Name = player2Name;
    }

    public void PlayerOneScores()
    {
      _p1Point++;
    }

    public void PlayerTwoScores()
    {
      _p2Point++;
    }

    public string ComputeScore()
    {
      string score = "";
      if (IsEqualScore())
      {
        score = DrawScore(score);
      }
      if (_p1Point == _p2Point && _p1Point >= 3)
        score = "Deuce";

      if (_p1Point > 0 && _p2Point == 0)
      {
        if (_p1Point == 1)
          _p1Res = "Fifteen";
        if (_p1Point == 2)
          _p1Res = "Thirty";
        if (_p1Point == 3)
          _p1Res = "Forty";

        _p2Res = "Love";
        score = _p1Res + "," + _p2Res;
      }
      if (_p2Point > 0 && _p1Point == 0)
      {
        if (_p2Point == 1)
          _p2Res = "Fifteen";
        if (_p2Point == 2)
          _p2Res = "Thirty";
        if (_p2Point == 3)
          _p2Res = "Forty";

        _p1Res = "Love";
        score = _p1Res + "," + _p2Res;
      }

      if (_p1Point > _p2Point && _p1Point < 4)
      {
        if (_p1Point == 2)
          _p1Res = "Thirty";
        if (_p1Point == 3)
          _p1Res = "Forty";
        if (_p2Point == 1)
          _p2Res = "Fifteen";
        if (_p2Point == 2)
          _p2Res = "Thirty";
        score = _p1Res + "," + _p2Res;
      }
      if (_p2Point > _p1Point && _p2Point < 4)
      {
        if (_p2Point == 2)
          _p2Res = "Thirty";
        if (_p2Point == 3)
          _p2Res = "Forty";
        if (_p1Point == 1)
          _p1Res = "Fifteen";
        if (_p1Point == 2)
          _p1Res = "Thirty";
        score = _p1Res + "," + _p2Res;
      }

      if (_p1Point > _p2Point && _p2Point >= 3)
      {
        score = "Advantage " + _player1Name;
      }

      if (_p2Point > _p1Point && _p1Point >= 3)
      {
        score = "Advantage " + _player2Name;
      }

      if (_p1Point >= 4 && _p2Point >= 0 && (_p1Point - _p2Point) >= 2)
      {
        score = this._player1Name + " wins";
      }
      if (_p2Point >= 4 && _p1Point >= 0 && (_p2Point - _p1Point) >= 2)
      {
        score = this._player2Name + " wins";
      }
      return score;
    }

      private bool IsEqualScore()
      {
          return _p1Point == _p2Point && _p1Point < 4;
      }

      private string DrawScore(string score)
      {
          if (_p1Point == 0)
              score = "Love";
          if (_p1Point == 1)
              score = "Fifteen";
          if (_p1Point == 2)
              score = "Thirty";
          score += " all";
          return score;
      }

      public void blah()
      {
          int a = 1;

          int b = a + 1;
          int c = b + 1;
          int d = b + c;
      }
  }


}

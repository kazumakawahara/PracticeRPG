using UnityEngine;

public class PlayerModel
{
    int maxHp;
    int hp;
    int at;
    int currenStage;

    public int MaxHP
    {
        get { return maxHp; }
    }

    public int HP
    {
        get { return hp; }
    }

    public int AT
    {
        get { return at; }
    }

    public int CurrenStage
    {
        get { return currenStage; }
    }

    public PlayerModel()
    {
        maxHp = 100;
        hp = maxHp;
        at = 6;
        currenStage = 0;
    }

    public void NextStage()
    {
        currenStage++;
    }

    public void BackToTown()
    {
        currenStage = 0;
    }
}

using UnityEngine;

public class MonsterModel
{
    int maxHp;
    int hp;
    int at;

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

    public MonsterModel()
    {
        maxHp = 100;
        hp = maxHp;
        at = 6;
    }
}

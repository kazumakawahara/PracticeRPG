using UnityEngine;

public class StegeModel
{
    MonsterModel monsterModel = null;

    public MonsterModel Monster
    {
        get { return monsterModel; }
        set { monsterModel = value; }
    }

    public bool HasMonster()
    {
        if (monsterModel == null)
        {
            return false;
        }
        return true;
    }
}

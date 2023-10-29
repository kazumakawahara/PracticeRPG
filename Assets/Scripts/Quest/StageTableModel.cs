using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTableModel
{
    int MaxStageCount = 10;
    List<bool> enemyPoint;

    public StageTableModel()
    {
        enemyPoint = new List<bool>();

        for (int i = 0; i < MaxStageCount; i++)
        {
            enemyPoint.Add(false);
        }

        enemyPoint[3] = true;
        enemyPoint[5] = true;
        enemyPoint[8] = true;
    }

    public bool IsEnemyPointAt(int currenStage)
    {
        return enemyPoint[currenStage];
    }

    public bool HasGameCleared(int currenStage)
    {
        if (enemyPoint.Count <= currenStage)
        {
            return true;
        }
        return false;
    }
}

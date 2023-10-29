using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTableModel
{
    int MaxStageCount = 10;
    List<StegeModel> stageModelList;

    public StageTableModel()
    {
        stageModelList = new List<StegeModel>();

        for (int i = 0; i < MaxStageCount; i++)
        {
            stageModelList.Add(new StegeModel());
        }

        stageModelList[3].Monster = new MonsterModel();
        stageModelList[5].Monster = new MonsterModel();
        stageModelList[8].Monster = new MonsterModel();
    }

    public bool IsEnemyPointAt(int currenStage)
    {
        return stageModelList[currenStage].HasMonster();
    }

    public bool HasGameCleared(int currenStage)
    {
        if (stageModelList.Count <= currenStage)
        {
            return true;
        }
        return false;
    }

    public MonsterModel GetMonster(int currenStage)
    {
        return stageModelList[currenStage].Monster;
    }
}

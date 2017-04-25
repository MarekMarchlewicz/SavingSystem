using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class MonsterData 
{
    public List<Monster> monsterData = new List<Monster>();

    public MonsterData()
    {
        monsterData = new List<Monster>();
    }

    public void AddMonster(Monster monster)
    {
        monsterData.Add(monster);
    }

    public void RemoveMonster(Monster monster)
    {
        if (monsterData.Contains(monster))
        {
            monsterData.Remove(monster);
        }
    }

    public List<Monster> GetMonsters()
    {
        return monsterData;
    }
}

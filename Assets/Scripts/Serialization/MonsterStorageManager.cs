using UnityEngine;
using System.Diagnostics;

public class MonsterStorageManager : MonoBehaviour
{
    [SerializeField] private int numberOfObjectsToStore;

    [SerializeField] private StorageMethod method;
   
    private MonsterData monsterData;

    private void Start()
    {
        monsterData = new MonsterData();

        for (int i = 0; i < numberOfObjectsToStore; i++)
        {
            Monster monster = new Monster();
            monster.Name = "Monster" + i.ToString();
            monster.Health = i * 10;
            monster.Power = i / 10f;

            monsterData.AddMonster(monster);                
        }
            
        UnityEngine.Debug.Log("Write time: " + CheckWritePerformance().ToString());

        UnityEngine.Debug.Log("Read time: " + CheckReadPerformance().ToString());

        UnityEngine.Debug.Log(monsterData.GetMonsters()[numberOfObjectsToStore - 1].Name);
        
    }

    private float CheckWritePerformance()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        DataStorage.SaveToFile<MonsterData>(monsterData, method);

        stopwatch.Stop();

        return stopwatch.ElapsedMilliseconds;
    }

    private float CheckReadPerformance()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        monsterData = DataStorage.LoadFromFIle<MonsterData>(method);

        stopwatch.Stop();

        return stopwatch.ElapsedMilliseconds;
    }
}

using UnityEngine;

[System.Serializable]
public class Monster  
{
    [SerializeField] private string name;
    [SerializeField] private int health;
    [SerializeField] private float power;

    public Monster()
    {

    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public float Power
    {
        get { return power; }
        set { power = value; }
    }
}

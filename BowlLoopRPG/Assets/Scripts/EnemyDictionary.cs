using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemyDictionary : MonoBehaviour
{
    public List<Enemy> enemyPrefabs;
    private Dictionary<int, GameObject> enemyDictionary;

    void Awake()
    {
        enemyDictionary = new Dictionary<int, GameObject>();
        for (int i = 0; i < enemyPrefabs.Count; i++)
        {
            if (enemyPrefabs[i] != null)
            {
                enemyPrefabs[i].ID = i + 1;
            }
        }

        foreach (Enemy enemy in enemyPrefabs)
        {
            enemyDictionary[enemy.ID] = enemy.gameObject;
        }
    }
}

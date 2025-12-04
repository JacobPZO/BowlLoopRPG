using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int ID;

    private QuestController questController;

    private void Awake()
    {
        questController = FindObjectOfType<QuestController>();
    }

    public void OnKill()
    {
        questController.CheckKillForQuests(ID);
    }
}

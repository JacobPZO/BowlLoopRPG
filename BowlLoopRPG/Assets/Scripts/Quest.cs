using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(menuName ="Quests/Quest")]
public class Quest : ScriptableObject 
{
    public string questID;
    public string questName;
    public string description;
    public List<QuestObjective> objectives;

    private void OnEnable()
    {
        if (string.IsNullOrEmpty(questID))
        {
            questID = questName + Guid.NewGuid().ToString();
        }
    }

    [System.Serializable]
    public class QuestObjective
    {
        public string objectiveID;
        public string description;
        public ObjectiveType type;
        public int requiredAmount;
        public int currentAmount;

        public bool isCompleted => currentAmount >= requiredAmount;
    }

    public enum ObjectiveType { CollectItem, TalkNPC, Custom}

    [System.Serializable]
    public class QuestProgress
    {
        public Quest quest;
        public List <QuestObjective> objectives;

        public QuestProgress(Quest quest)
        {
            this.quest = quest;
            objectives = new List<QuestObjective>();
        }
    }
}

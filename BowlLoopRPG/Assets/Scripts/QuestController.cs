using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    public static QuestController Instance {  get; private set; }
    public List<QuestProgress> activeQuests = new();
    private QuestUI questUI;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        questUI = FindObjectOfType<QuestUI>();
        InventoryController.Instance.OnInventoryChanged += CheckInventoryForQuests;
    }

    public void AcceptQuest(Quest quest)
    {
        if (IsQuestActive(quest.questID)) return;

        activeQuests.Add(new QuestProgress(quest));
        CheckInventoryForQuests();
        questUI.UpdateQuestUI();
    }

    public bool IsQuestActive(string questID) => activeQuests.Exists(q => q.QuestID == questID);   

    public void CheckInventoryForQuests()
    {
        Dictionary<int, int> itemCounts = InventoryController.Instance.GetItemCounts();

        foreach(QuestProgress quest in activeQuests)
        {
            foreach (QuestObjective questObjective in quest.objectives)
            {
                if(questObjective.type != ObjectiveType.CollectItem) continue;
                if (!int.TryParse(questObjective.objectiveID, out int itemID)) continue;

                int newAmount = itemCounts.TryGetValue(itemID, out int count) ? Mathf.Min(count, questObjective.requiredAmount) : 0;

                if ( questObjective.currentAmount != newAmount)
                {
                    questObjective.currentAmount = newAmount;
                }
            }
        }
        questUI.UpdateQuestUI();
    }
}

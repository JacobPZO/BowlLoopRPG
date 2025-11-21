using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewNPCDialogue", menuName = "NPC Dialogue")]

public class NPCDialogue : ScriptableObject
{
    public string[] npcName;
    public Sprite[] npcPortrait;
    public string[] dialogueLines;
    public float[] typingSpeed;
    public AudioClip[] voiceSound;
    public float[] voicePitch;
    public bool[] autoProgressLines;
    public bool[] endDialogueLines;
    public float autoProgressDelay;

    public DialogueChoice[] choices;

    public int questInProgressIndex;
    public int questCompletedIndex;
    public Quest quest;
}

[System.Serializable]
public class DialogueChoice
{
    public int dialogueIndex;
    public string[] choices;
    public int[] nextDialogueIndexes;
    public bool[] givesQuest;
}
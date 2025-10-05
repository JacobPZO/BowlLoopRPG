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
    public float autoProgressDelay;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int ID;

    private Transform Player;
    public int MoveSpeed = 3;
    public int Range = 8;

    private QuestController questController;
    private PlayerController playerController;

    private void Awake()
    {
        questController = FindObjectOfType<QuestController>();
        playerController = FindObjectOfType<PlayerController>();
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnKill();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        Player = playerController.transform;

        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) <= Range)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
    }

    public void OnKill()
    {
        questController.CheckKillForQuests(ID);
    }
}

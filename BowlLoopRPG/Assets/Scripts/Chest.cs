using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public bool IsOpened {  get; private set; }
    public string ChestID { get; private set; }
    public GameObject itemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        ChestID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenChest();
    }

    private void OpenChest()
    {
        SetOpened(true);
        if (itemPrefab != null)
        {
            GameObject droppedItem = Instantiate(itemPrefab, transform.position + Vector3.back, Quaternion.identity);
        }
    }

    public void SetOpened(bool opened)
    {
        IsOpened = opened;
    }
}

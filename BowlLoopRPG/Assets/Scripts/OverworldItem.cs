using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldItem : MonoBehaviour, IInteractable
{
    public GameObject UIItem;
    private InventoryController inventoryController;

    // Start is called before the first frame update
    void Start()
    {
        inventoryController = FindObjectOfType<InventoryController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CanInteract()
    {
        return true;
    }

    public void Interact()
    {
        if (!CanInteract()) return;
        bool itemAdded = inventoryController.AddItem(UIItem);
        if (itemAdded)
        {
            Destroy(gameObject);
        }
    }
}

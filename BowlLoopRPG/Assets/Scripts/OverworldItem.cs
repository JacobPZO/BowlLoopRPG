using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldItem : MonoBehaviour
{
    public GameObject UIItem;
    private InventoryController inventoryController;
    private InteractionDetector interactionDetector;

    private bool Obtained;

    // Start is called before the first frame update
    void Start()
    {
        Obtained = false;
        inventoryController = FindObjectOfType<InventoryController>();
        interactionDetector = FindObjectOfType<InteractionDetector>();
}

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CanPickup()
    {
        return !Obtained;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!CanPickup()) return;
            bool itemAdded = inventoryController.AddItem(UIItem);
            if (itemAdded)
            {
                Obtained = true;
                Destroy(gameObject);
            }
        }
    }
}

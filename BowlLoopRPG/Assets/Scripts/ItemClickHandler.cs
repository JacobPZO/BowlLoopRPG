using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClickHandler : MonoBehaviour, IPointerDownHandler
{
    public InventoryTextController inventoryTextController;
    public string itemName;
    public string itemDescription;

    // Start is called before the first frame update
    void Start()
    {
        inventoryTextController = FindObjectOfType<InventoryTextController>();
    }

    public void OnPointerDown(PointerEventData eventData)
    { 

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryTextController : MonoBehaviour
{
    public TMP_Text itemName;
    public TMP_Text itemDescription;

    public void SetNameText(string nameString)
    {
        itemName.text = nameString;
    }

    public void SetDescriptionText(string descriptionString)
    {
        itemDescription.text = descriptionString;
    }
}

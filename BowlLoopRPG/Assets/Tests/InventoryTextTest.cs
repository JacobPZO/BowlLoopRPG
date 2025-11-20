using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestTextController : MonoBehaviour
{
    public string itemName;
    public string itemDescription;

    public void SetNameText(string nameString)
    {
        itemName = nameString;
    }

    public void SetDescriptionText(string descriptionString)
    {
        itemDescription = descriptionString;
    }
}

public class InventoryTextTest
{
    private TestTextController testTextController;
    // A Test behaves as an ordinary method
    [Test]
    [TestCase("Hello")]
    [TestCase("Awesome item name")]
    public void SetNameTest(string nameString)
    {
        testTextController.SetNameText(nameString);

        // Use the Assert class to test conditions
        Assert.IsTrue(testTextController.itemName == nameString);
    }

    [Test]
    [TestCase("Longish desription text very cool and interesting it is a lot more text than the other test would have.")]
    [TestCase("Awesome item description")]
    public void SetDescriptionTest(string descriptionString)
    {
        testTextController.SetDescriptionText(descriptionString);

        // Use the Assert class to test conditions
        Assert.IsTrue(testTextController.itemDescription == descriptionString);
    }
}

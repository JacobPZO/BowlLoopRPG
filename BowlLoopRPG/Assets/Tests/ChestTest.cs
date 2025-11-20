using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestChest
{
    public bool IsOpened;
    public bool CanInteract()
    {
        return !IsOpened;
    }

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenChest();
    }

    public void OpenChest()
    {
        IsOpened = true;
    }
}


public class ChestTest
{
    private TestChest testChest;

    // A Test behaves as an ordinary method
    [Test]
    public void ChestInteractTest()
    {
        testChest.Interact();

        Assert.IsTrue(testChest.CanInteract() == false);
        Assert.IsTrue(testChest.IsOpened == true);
    }

    public void Test()
    {

    }
}

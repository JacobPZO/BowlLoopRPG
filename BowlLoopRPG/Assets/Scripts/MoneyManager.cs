using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int Tonkus;

    public void GetMoney(int amount)
    {
        Tonkus += amount;
    }

    public bool SpendMoney(int amount)
    {
        if (amount > Tonkus) return false;

        Tonkus -= amount;
        return true;
    }
}

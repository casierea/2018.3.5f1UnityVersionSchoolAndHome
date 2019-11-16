using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PaymentObj : ScriptableObject
{//need value to be able to put coin.value

    public UnityAction<int> CostAction;
    public int value = 1;
   
    public void UseIt()
    {
        CostAction?.Invoke(value);
    }
}

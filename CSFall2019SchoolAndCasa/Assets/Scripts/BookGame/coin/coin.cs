using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Coin : ScriptableObject
{//need value to be able to put coin.value

    public UnityAction<int> coinAction;
    public int value = 10;
   
    public void Spend()
    {
        coinAction?.Invoke(value);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Flower : ScriptableObject
{//need value to be able to put coin.value

    public UnityAction<int> flowerAction;
    public int value = 50;
   
    public void Spend()
    {
        flowerAction?.Invoke(value);
    }
}
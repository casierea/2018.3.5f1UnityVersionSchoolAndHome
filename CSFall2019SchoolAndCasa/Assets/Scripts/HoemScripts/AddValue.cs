using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class AddValue : ScriptableObject
{


    public FloatData ValueObj;
    public FloatData MaxValue;
    public FloatData MinValue;
	
    public UnityEvent EventMax;
    public UnityEvent EventMin;
	
    public void AddValueToObj(FloatData data)
    {
        ValueObj.value += data.value;
		
        if (ValueObj.value <= MaxValue.value)
        {
            EventMax.Invoke();
        }

        if (MaxValue.value <= MinValue.value)
        {
            EventMin.Invoke();
        }
    }
}
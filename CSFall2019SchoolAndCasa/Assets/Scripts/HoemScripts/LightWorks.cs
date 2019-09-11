using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWorks : MonoBehaviour
{
    public Light lightlight;
    
    private float[] smoothing = new float[20];
        // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < smoothing.Length ; i++)
        {
            smoothing[i] = .0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float sum = .0f;
        
        for(int i = 1; i < smoothing.Length ; i++)
        {
            smoothing[i - 1] = smoothing[i];
            sum+= smoothing[i- 1];
        }

        smoothing[smoothing.Length - 1] = Random.value;
        sum += smoothing[smoothing.Length - 1];
        //light.intensity = sum / smoothing.Length;
    }
}

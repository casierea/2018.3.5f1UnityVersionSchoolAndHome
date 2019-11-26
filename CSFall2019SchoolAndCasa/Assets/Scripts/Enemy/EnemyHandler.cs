using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public FloatData healthBase;
    private FloatData health;
    
    void Start()
    {
        health = Instantiate(healthBase);
        print(health.value);
    }

    private void OnTriggerEnter(Collider other)
    {
        health.UpdateValue(0.1f);
    }
}

using UnityEngine;
[CreateAssetMenu]
public class DeBugger : ScriptableObject
{
    public void OnDeBug(string message)
    {
        Debug.Log(message);
    }

    public void OnDebug(int number)
    {
        Debug.Log(number);
    }
}

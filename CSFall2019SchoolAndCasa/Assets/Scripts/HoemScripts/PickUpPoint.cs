using System.Collections;
using System.Collections.Generic;
using BansheeGz.BGSpline.Curve;
using UnityEngine;

public class PickUpPoint : MonoBehaviour
{
    public int ScorePoints = 0;
    public Sprite CollectEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PickUpPoints")
            Destroy(gameObject);
        ScorePoints += 1;

        if (gameObject.tag == "PickUpPoints" && CollectEffect != null)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = CollectEffect;
            var newZ = gameObject.transform.position;
            newZ.z = -3.0f;
            gameObject.transform.position = newZ;
            StartCoroutine("Remove Sprite");
        }
    }
    IEnumerator RemoveSprite()
    {
        yield return new WaitForSeconds(.50f);
        Destroy(gameObject);
    }
    
}

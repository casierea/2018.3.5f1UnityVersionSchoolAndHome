using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MarqueeText : MonoBehaviour {

    public TextMeshProUGUI theText;
    public float marqueeSpeed = 5f;

    private TextMeshProUGUI copyText;
    private RectTransform textRectTransform;
    private string sourceText;
    private string tempText;

    // Use this for initialization
    void Awake () {
        textRectTransform = theText.GetComponent<RectTransform>();
        
        copyText = Instantiate(theText) as TextMeshProUGUI;
        RectTransform cloneRectTransform = copyText.GetComponent<RectTransform>();
        cloneRectTransform.SetParent(textRectTransform);
        cloneRectTransform.anchorMin = new Vector2(1, 0);
        cloneRectTransform.localPosition = new Vector3(theText.preferredWidth, 0, cloneRectTransform.position.z);
        cloneRectTransform.localScale = new Vector3(1, 1, 1);
        copyText.text = theText.text;  

    }

    private IEnumerator Start()
    {
  
        float width = theText.preferredWidth;      
        Vector3 startPosition = textRectTransform.localPosition;

        float scrollingPosition = 0;

        while (true)
        {
            textRectTransform.localPosition = new Vector3(-scrollingPosition % width, startPosition.y, startPosition.z);
            scrollingPosition += marqueeSpeed * 10 * Time.deltaTime;         
            yield return null;
        }      
    }
}
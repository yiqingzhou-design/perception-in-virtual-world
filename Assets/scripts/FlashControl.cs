using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashControl : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    public float timeLast;
    public Image img;
    
    // Start is called before the first frame update
    void Start()
    {
        // gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false){
            StartCoroutine(Flickering());
        }
    }

    IEnumerator Flickering(){
        isFlickering = true;
        img.enabled = false;
        yield return new WaitForSeconds(timeDelay);
        // Debug.Log("y1");
        img.enabled = true;
        yield return new WaitForSeconds(timeLast);
        isFlickering = false;
        // Debug.Log("y2");
    }
}

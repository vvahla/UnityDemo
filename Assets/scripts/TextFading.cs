using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFading : MonoBehaviour
{

    public Text text1;
    //public Text text2;

    public bool showText1 = true;
    public bool showText2 = false;

    // Start is called before the first frame update
    void Start()
    {
        if (showText1)
            StartCoroutine(FadeTextToFullAlpha(1f, text1));
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!showText1)
            StartCoroutine(FadeTextToZeroAlpha(1f, text1));

    }

    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        showText1 = false;
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
        i.text = "";
    }

}

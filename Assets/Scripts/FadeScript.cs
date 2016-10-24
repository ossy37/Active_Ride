using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {


    public float fade_speed = 1.0f;
    float alpha;
    float red, blue, green;

    private bool isFadein;
    private bool isFadeout;

    public GameObject canvas;
    public GameObject background;

    // Use this for initialization
    void Start () {
        isFadein = true;
        isFadeout = false;

        canvas.SetActive(false);
        background.SetActive(false);

        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
        alpha = GetComponent<Image>().color.a;
       
    }

    // Update is called once per frame
    void Update() {
        GetComponent<Image>().color = new Color(red, green, blue, alpha);
        
        if (isFadein)
        {
            alpha = alpha + 0.01f;
            Debug.Log(alpha);
            if (alpha >= 1.0)
            {
                isFadein = false;
                isFadeout = true;
            }
        }
        if (isFadeout)
        {
            alpha = alpha - 0.01f;
            Debug.Log(alpha);
            if (alpha <= 0)
            {
                wait();
                canvas.SetActive(true);
                background.SetActive(true);

                isFadein = false;
                isFadeout = false;
            }
        }

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
    }
}

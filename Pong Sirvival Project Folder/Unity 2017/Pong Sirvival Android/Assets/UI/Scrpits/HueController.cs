using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HueController : MonoBehaviour {
    public Image bgImage;

    public float fadeSpeed = 15;

    float mHue;
    float mSaturation;
    float mValue;

    // Use this for initialization
    void Start () {
        //bgImage.GetComponent<Image>();
        fadeSpeed = 15;
        mHue = 0.1f;
        mSaturation = 0.36f;
        mValue = 1;
    }

    // Update is called once per frame
    void Update () {
        mHue += (Time.deltaTime/fadeSpeed);
        bgImage.color = Color.HSVToRGB(mHue, mSaturation, mValue );

        if (mHue >=1)
        {
            mHue = 0;
        }
	}
}

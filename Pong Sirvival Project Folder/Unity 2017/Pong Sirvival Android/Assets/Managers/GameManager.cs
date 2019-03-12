using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject platform;
    public GameObject ball;

    Sprite platformSkin;
    Sprite ballSkin;

    
    private void Awake()
    {
        platformSkin = platform.GetComponentInChildren<SpriteRenderer>().sprite;
        ballSkin = ball.GetComponentInChildren<SpriteRenderer>().sprite;

        //DontDestroyOnLoad(this.gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

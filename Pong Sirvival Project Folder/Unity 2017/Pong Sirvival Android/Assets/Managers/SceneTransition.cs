using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

    //Scene currentScene;
    //Scene newScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNewScene(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
        //SceneManager.
    }

}

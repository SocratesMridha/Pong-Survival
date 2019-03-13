using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersDDOL : MonoBehaviour {

    public static ManagersDDOL instance = null;

    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

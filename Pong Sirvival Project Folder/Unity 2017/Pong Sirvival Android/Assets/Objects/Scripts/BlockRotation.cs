using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRotation : MonoBehaviour {

    [Range(1, 100)] public float rotationSpeed;
    public int minTime;
    public int maxTime;

    int randSide;
    int randTime;

    float timer;

    Animator anim;

    // Use this for initialization
    void Start () {
        randSide = RandomNumber(0,2);
        randTime = RandomNumber(minTime,maxTime);

        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (randSide == 0)
        {
            transform.Rotate(Vector3.forward * (rotationSpeed * Time.deltaTime));

        }
        else
        {
            transform.Rotate(Vector3.forward * (-rotationSpeed * Time.deltaTime));

        }
        if (timer >= randTime)
        {
            DeSpawn();
        }
        
    }
    void DeSpawn()
    {
        anim.SetBool("Dead", true);
        Destroy(this.gameObject,2);
    }
    int RandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
}

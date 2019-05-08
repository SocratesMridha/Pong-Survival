using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {

    public GameObject block;

    public Transform[] spawnPoint;

    Queue <int> sp = new Queue <int>();

    float timer;
    public int minTime;
    public int maxTime;

    float listTImer;

	// Use this for initialization
	void Start () {
        timer = 0;
        //CreateList();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (sp.Count >0)
        {
            listTImer += Time.deltaTime;
            if (listTImer >= maxTime)
            {
                sp.Dequeue();
            }
        }
        if (timer >= 5)
        {
            SpawnABlock();
            timer = 0;
        }
	}

    void SpawnABlock()
    {
        bool pass = true;
        int rand = 0;
        do 
        {
            rand = RandomNumber(0, spawnPoint.Length);
            pass = true;

            if (sp.Contains(rand))
            {
                pass = false;
            }

        }while(pass == false);

        sp.Enqueue(rand);
        GameObject blockClone = Instantiate(block, spawnPoint[rand].position, spawnPoint[rand].rotation);
        //Destroy(blockClone, RandomNumber(minTime,maxTime));
    }
    void AddToList()
    {

    }

    int RandomNumber(int min, int max)
    {
        return Random.Range(min,max);
    }
}

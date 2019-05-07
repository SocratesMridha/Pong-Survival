using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFallingObjects : MonoBehaviour {


    public Transform followPlayerTarget;
    public Transform[] spawnPoint;

    [Range(1, 100)] public float objectSpawnRate;
    public GameObject[] fallingObject;

    [Range(1, 100)] public float explosiveSpawnRate;
    public GameObject[] explosives;
    


    float spawnTimer;
    float rateOfSpawn;

    float explosiveTimer;
    float rateOfExplosive;

    float ballYTarget;

    GameObject ball;


    //bool debug = false;

    // Use this for initialization
    private void Awake()
    {
        ballYTarget = followPlayerTarget.position.y;
    }

    void Start () {
        spawnTimer = 0;
        ball = GameObject.FindGameObjectWithTag("Ball");
        
	}
	
	// Update is called once per frame
	void Update () {
        spawnTimer += Time.deltaTime;
        rateOfSpawn = 60 / objectSpawnRate;
        if (spawnTimer >= rateOfSpawn)
        {
            SpawnObject();
            spawnTimer = 0;
        }

        explosiveTimer += Time.deltaTime;
        rateOfExplosive = 60 / explosiveSpawnRate;
        if (explosiveTimer >= rateOfExplosive)
        {
            SpawnExplosive();
            explosiveTimer = 0;
        }

        FollowBall();
        //Debug.Log(spawnTimer);
	}

    void SpawnObject()
    {
        int randTargert = RandomNumber(spawnPoint.Length);
        GameObject clone = Instantiate(fallingObject[RandomNumber(fallingObject.Length)], spawnPoint[randTargert].position, spawnPoint[randTargert].rotation);
        Destroy(clone,10); // temp until i creat object scripts
    }
    void SpawnExplosive()
    {
        int randTargert = RandomNumber(spawnPoint.Length);
        GameObject cloneExplosive = Instantiate(explosives[RandomNumber(explosives.Length)], spawnPoint[randTargert].position, spawnPoint[randTargert].rotation);
        Destroy(cloneExplosive, 10);// temp until i creat object scripts
    }
    void SpwanBombOnPlayer()
    {
        
    }

    int RandomNumber(int max)
    {
        return Random.Range(0,max);
    }

    public void ReportDebugNum()
    {

    }
    void FollowBall()
    {
        followPlayerTarget.position = new Vector2(ball.transform.position.x,ballYTarget);
    }
}

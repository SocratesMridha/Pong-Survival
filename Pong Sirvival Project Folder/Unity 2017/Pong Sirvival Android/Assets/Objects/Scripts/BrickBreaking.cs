using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreaking : MonoBehaviour {

    public float radius = 5.0F;
    public float power = 100.0F;

    public bool fullBlock;
    public GameObject[] piece;
    public Transform[] point;

    bool doOnce;

    public GameObject explosion;
    

    // Use this for initialization
    void Start() {
        doOnce = false;
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathBox")
        {
            Destroy(gameObject);
        }
        else
        {
            if (doOnce == false)
            {
                SpawnBlocks();
                doOnce = true;
            }
        }
        
        

    }
    
    void SpawnBlocks()
    {
        int num = 0;
        GameObject firstClone = Instantiate(piece[1], point[num].transform.position, point[num].transform.rotation);
        //Rigidbody2D rb2d = firstClone.GetComponent<Rigidbody2D>();
        //rb2d.AddForce(transform.up * power);
        //firstClone.GetComponent<Rigidbody2D>().AddForce(transform.up * power);
        num++;
        for (int i = 0; i < 2; i++)
        {
                GameObject secondClone = Instantiate(piece[0], point[num].transform.position, point[num].transform.rotation);
            //secondClone.GetComponent<Rigidbody2D>().AddForce(transform.up * power);
            num++;
        }
        GameObject thirdClone = Instantiate(piece[1], point[num].transform.position, point[num].transform.rotation);
        //thirdClone.GetComponent<Rigidbody2D>().AddForce(transform.up * power);
        num++;
        if (fullBlock)
        {
            GameObject pieceClone = Instantiate(piece[2], point[num].transform.position, point[num].transform.rotation);
            
        }
        Explode();
        Destroy(this.gameObject);
    }
    
    void Explode()
    {
        GameObject explosionClone = Instantiate(explosion,transform.position,transform.rotation);
        Destroy(explosionClone,0.1f);
    }
    
}

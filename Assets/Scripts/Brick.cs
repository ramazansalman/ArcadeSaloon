using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int points;
    //public int brickPoint;
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("ball"))
        {

            Destroy(gameObject);
        }

        /*
        if (collision.transform.CompareTag("ball"))
        {
            Transform newExplosion = Instantiate(explosion, collision.transform.position, collision.transform.rotation); // Instantiate is  using for the object creating
            Destroy(newExplosion.gameObject, 1f);

            gameManager.UpdateScore(collision.gameObject.GetComponent<Brick>().points); // I tried to use singleton here but bricks are disappear after using singleton
            gameManager.BrickCounter();
            Destroy(collision.gameObject);
        }*/
        
    }
    

}

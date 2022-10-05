using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            Debug.Log("Coin Collected! +10");
            ScoreManager.instance.ChangeScore(10);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

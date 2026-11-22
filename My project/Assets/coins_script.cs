using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins_script : MonoBehaviour
{

    public AudioClip coin1;
    public AudioClip coin2;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerStats score = other.GetComponent<PlayerStats>();
            score.score++;
            Debug.Log("Score: " + score.score.ToString());
            Destroy(gameObject);
            AudioManager.Instance.PlayRandomSFX(coin1, coin2);
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

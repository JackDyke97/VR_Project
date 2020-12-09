using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour
{

    //keeps track of total treasure in the level
    public static int TreasureCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Treasure created, increment the treasure count
        ++Treasure.TreasureCount;

    }

    void OnTriggerEnter(Collider Col)
    {
        //if player collected treasure, destroy treasure
        if (Col.CompareTag("Player"))
            Destroy(gameObject);
    }

    // called when object is destroyed
    void onDestroy()
    {
        //Decrement treasure count
        --Treasure.TreasureCount;

        //check remaining coins
        if (Treasure.TreasureCount <= 0) ;
        {
            //We win
        }
        
    }
}

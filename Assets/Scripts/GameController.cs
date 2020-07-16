using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int TotalScore;
    
    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

}

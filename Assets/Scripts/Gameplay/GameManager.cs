using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField][Range(0, 6)] private float timeStep = 1;

    // Update is called once per frame
    void Update()
    {
        
        Time.timeScale = timeStep;

    }
}

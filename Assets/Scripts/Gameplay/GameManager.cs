using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

   [SerializeField] [Range (0,6)] private float timeStep = 1;
   

    private void Update()
    {

        Time.timeScale = timeStep;





    }

    






}

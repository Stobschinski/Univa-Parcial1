using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverUI : MonoBehaviour
{
    [SerializeField] private RectTransform _gameOverPanel;
   
    public void OnGameOver()

    {
        _gameOverPanel.gameObject.SetActive(true);
        GameManager.Instance.ChangeSpeed(0);
    }

    public void OnRestart()



    
    {
        GameManager.Instance.ChangeSpeed(1);

    }
}

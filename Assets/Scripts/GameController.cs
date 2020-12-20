using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance; 
    private int _remainedCollectors = 3;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }


    public void Collected()
    {
        _remainedCollectors--;
        if (_remainedCollectors == 0)
        {
            OpenGate();
        }
    }

    private void OpenGate()
    {
        Debug.Log("COLLECTED ALL DIAMONDS");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    // Start is called before the fiframe upda
    void Start()
    {
        
    }
    // Update is called once per
    void Update()
    {
        
    }
public void Play()
{
	SceneManager.LoadScene("GameSetUp");
}
}


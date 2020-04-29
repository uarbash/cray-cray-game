using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdManager : MonoBehaviour
{
    public static UnityAdManager instance;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(instance == null)
        {

            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame updat
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowAd()
    {
        if (Advertisement.IsReady("video")) ;
        {
            Advertisement.Show("video");
        }
    }
}

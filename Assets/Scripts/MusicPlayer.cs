using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioSource m_audioSource;

    void Awake()
    {
        if (FindObjectsOfType<MusicPlayer>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            if (m_audioSource)
                DontDestroyOnLoad(gameObject);
        }

    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}

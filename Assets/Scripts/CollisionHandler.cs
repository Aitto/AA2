using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    [Tooltip("In seconds")][SerializeField] ParticleSystem m_particle;
    [Tooltip("FX for player ship explosion")][SerializeField][Range(1,5)] private float m_loadLevelDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleParticles()
    {
        m_particle.gameObject.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        HandleParticles();
    }

    /// <summary>
    /// Start Death Sequence
    /// Load level, Freeze Control, Music...
    /// </summary>
    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
        Invoke("ReloadScene",m_loadLevelDelay);
        
    }

    private void ReloadScene()  //string referenced
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }
}

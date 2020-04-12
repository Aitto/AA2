using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private Collider m_NonTriggerCollider;
    [SerializeField] GameObject m_DeathFX;
    [SerializeField] Transform parent;
    [SerializeField]
    private int m_hitScore = 100;
    [SerializeField]
    private int hitPoint = 5;

    private ScoreBoard m_score;
    private bool m_destroyed;


    // Start is called before the first frame update
    void Start()
    {
        AddNonTriggerCollider();
        m_score = FindObjectOfType<ScoreBoard>();
        m_destroyed = false;
    }

    private void AddNonTriggerCollider()
    {
        if (GetComponent<BoxCollider>() == null)
        {
            m_NonTriggerCollider = gameObject.AddComponent<BoxCollider>();
        }else
        {
            m_NonTriggerCollider = GetComponent<BoxCollider>();
        }
        m_NonTriggerCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }

    private void OnParticleCollision(GameObject other)
    {
        if (!m_destroyed)
        {
            m_score.HitScore(m_hitScore);
            if( hitPoint <=0)
            {
                
                KillEnemy();
            }
            hitPoint--;
            
        }
        
    }

    private void KillEnemy()
    {
        GameObject fx = Instantiate(m_DeathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;
        Destroy(gameObject);
        m_destroyed = true;
        
    }
}

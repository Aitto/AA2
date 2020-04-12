using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
     [SerializeField][Range(1,10.0f)]   private float m_timer = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_timer);
    }

}

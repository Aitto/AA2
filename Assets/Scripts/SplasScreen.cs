using UnityEngine;
using UnityEngine.SceneManagement;

public class SplasScreen : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene(1);
           // Debug.Log("Hello from update");
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    
    private int m_score;
    private Text m_textScore;
    // Start is called before the first frame update
    void Start()
    {
        m_score = 0;
        m_textScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        m_textScore.text = "Score: " + m_score.ToString();
    }

    public void HitScore(int m_hitScore) //String referenced
    {
        m_score+= m_hitScore;
    }

}

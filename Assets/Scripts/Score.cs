using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    [SerializeField] scoreUI _ui;
    // public static Score instance;
    public void ChangeScore(int addToScore) {
        score += addToScore;
        _ui.setScore(score);
    }

    public int GetScore() {
        return score;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}

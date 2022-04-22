using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreUI : MonoBehaviour
{
    //[SerializeField] Text textComponent2;
    [SerializeField] TextMeshProUGUI textComponent;

    public void setScore(int newScore)
    {
        textComponent.text = " Score: "+newScore;
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

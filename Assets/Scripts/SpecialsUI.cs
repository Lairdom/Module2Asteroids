using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpecialsUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;

    public void viewSpecials(int specials) {
        textComponent.text = " Power Shots: "+specials;
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

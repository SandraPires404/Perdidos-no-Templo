using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getCharacterName : MonoBehaviour
{
    private string input;
    public Text newName;
    void Start()
    {
       newName.text = "Novo jogador";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput (string name)
    {
        input = name;
        newName.text = input;
        Debug.Log(input);
    }
}

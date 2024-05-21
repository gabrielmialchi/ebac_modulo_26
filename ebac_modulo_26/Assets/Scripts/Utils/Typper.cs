using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float typeTimer;
    public string phrase;

    private void Awake()
    {
        textMesh.text = "";
    }

    [NaughtyAttributes.Button]
    public void StartType()
    {
        StartCoroutine(Type(phrase));
    }

    IEnumerator Type(string s)
    {
        textMesh.text = "";
        
        foreach(char l in s.ToCharArray())
        {
            textMesh.text += l;
            yield return new WaitForSeconds(typeTimer);
        }

    }

}

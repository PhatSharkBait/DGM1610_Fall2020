using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string value;

    public void displayText(TextMeshPro txt)
    {
        txt.text = value;
    }
}

using UnityEngine;
using TMPro;
public class scorecounter : MonoBehaviour
{
TextMeshProUGUI textmesh;

public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textmesh.text = score.ToString();
    }
}

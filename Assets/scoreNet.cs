using Unity.VisualScripting;
using UnityEngine;

public class scoreNet : MonoBehaviour
{
[SerializeField]scorecounter scoreCounter;
[SerializeField] ballmovement ball;


private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreCounter.score++;
        ball.transform.position = ball.startPos;
        ball.launch();
    }
}

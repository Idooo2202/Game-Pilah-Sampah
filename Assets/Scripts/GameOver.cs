using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            Data.score = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
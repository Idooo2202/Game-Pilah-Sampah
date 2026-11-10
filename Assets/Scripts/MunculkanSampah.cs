using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{
    public float jeda = 0.8f;
    public GameObject[] obyekSampah;

    private float timer;

    private void Update()
    {
        if (obyekSampah == null || obyekSampah.Length == 0)
        {
            return;
        }

        timer += Time.deltaTime;
        if (timer >= jeda)
        {
            int index = Random.Range(0, obyekSampah.Length);
            Instantiate(obyekSampah[index], transform.position, transform.rotation);
            timer = 0f;
        }
    }
}
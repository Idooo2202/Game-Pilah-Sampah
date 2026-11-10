using UnityEngine;
using TMPro;

public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    public TMP_Text textScore;

    private AudioSource mediaPlayerBenar;
    private AudioSource mediaPlayerSalah;

    private void Start()
    {
        mediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        mediaPlayerBenar.clip = audioBenar;

        mediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        mediaPlayerSalah.clip = audioSalah;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool benar = collision.gameObject.tag == nameTag;
        Data.score += benar ? 25 : -5;
        textScore.text = Data.score.ToString();

        Destroy(collision.gameObject);

        if (benar)
        {
            mediaPlayerBenar.Play();
        }
        else
        {
            mediaPlayerSalah.Play();
        }
    }
}
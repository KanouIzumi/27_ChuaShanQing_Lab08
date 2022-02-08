using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{

    private AudioSource m_AudioSource;
    [SerializeField] private AudioClip m_GetScore;           // the sound played when character touches the coin.


    public Text scoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void PlayGetScoresound()
    {
        m_AudioSource.clip = m_GetScore;
        m_AudioSource.Play();
    }

    void OnTriggerEnter(Collider collision)
    {


        if (collision.gameObject.tag == "Obstacle")
        {
            score++;
            PlayGetScoresound();
            scoreText.text = "Score: " + score;
            Destroy(collision.gameObject);
        }

    }
}

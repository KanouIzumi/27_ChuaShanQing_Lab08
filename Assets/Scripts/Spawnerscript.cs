using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{

    private AudioSource m_AudioSource;
    [SerializeField] private AudioClip m_ObstacleSpawn;           // the sound played something is spawn


    public GameObject[] SpawnObject;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();

        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        


    }


    private void PlayObstacleSpawn()
    {
        m_AudioSource.clip = m_ObstacleSpawn;
        m_AudioSource.Play();
    }

    void SpawnObjects()
    {
        int randomIndex = Random.Range(0, SpawnObject.Length);

        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        PlayObstacleSpawn();
        Instantiate(SpawnObject[randomIndex], transform.position, transform.rotation);
    }
}

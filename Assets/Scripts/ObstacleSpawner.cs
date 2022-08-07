using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] float spawnDistance;
    int lastFrame = -1;

    [SerializeField] float _minY;
    [SerializeField] float _maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && lastFrame != Time.frameCount)
        {
            float distanceY = Random.Range(_minY, _maxY);

            

            Vector3 spawnPosition = new Vector3(collision.gameObject.transform.position.x + spawnDistance, distanceY, 0);
            
            collision.gameObject.transform.position = spawnPosition;
            
            lastFrame = Time.frameCount;
        }
    }
}

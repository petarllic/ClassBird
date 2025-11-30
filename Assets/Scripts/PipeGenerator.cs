using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    [SerializeField]
    private float spawnDelay; //Time between spawning
    private float timeLeft; //Time left to next spawning

    [SerializeField]
    private GameObject pipePrefab;

    private float maxHeight=1.68f;
    private float minHeight=-1.4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = timeLeft - Time.deltaTime;
        if(timeLeft<=0){
            //Instance of new pipe
            GameObject newPipe = Instantiate(pipePrefab);

            float newY = Random.Range(minHeight, maxHeight);
            newPipe.transform.position = new Vector2(transform.position.x, newY);
            newPipe.transform.parent=transform;

            //Reset timer
            timeLeft = spawnDelay;
        }
    }
}

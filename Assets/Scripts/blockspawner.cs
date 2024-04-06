using UnityEngine;

public class blockspawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject Blockprefab;
    private float timetospawn = 4f;
    public float timebetweenwaves = 4f;
    void Update()
    {
        if(Time.time >= timetospawn)
        {

            Something();
            Spawn();
            timetospawn = Time.time + timebetweenwaves;
        }
    }
    public void Spawn()
    {
        
        int random = Random.Range(0, spawnpoints.Length);
        for (int i = 0; i < spawnpoints.Length; i++)
        {
            if (random != i)
            {
                Instantiate(Blockprefab, spawnpoints[i].position, Quaternion.identity);
            }
        }
    }
    public void Something()
    {
        
        int random1 = Random.Range(0, spawnpoints.Length);
        int random2 = Random.Range(0, spawnpoints.Length);
        for (int i = 0;i < spawnpoints.Length;i++)
        {   
            if(random1 == i)
            {
                Transform targetTransform = spawnpoints[i].transform;
                Vector3 newPosition = targetTransform.position;
                newPosition.y += random2;
                targetTransform.position = newPosition;
            }
            
        }
    }
    
}

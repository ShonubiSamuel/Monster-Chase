using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] Enemies;
    private GameObject spwanedEnemies;
    private int RandEnemies;

    [SerializeField] private Transform left, right;

    private int randomIndex;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
                RandEnemies = Random.Range(0, Enemies.Length);
                randomIndex = Random.Range(0, 2);
                spwanedEnemies = Instantiate(Enemies[RandEnemies]);
            
                if (randomIndex == 0)
                {spwanedEnemies.transform.position = left.position;
                    spwanedEnemies.GetComponent<Monster>().speed = Random.Range(4, 7);  
                }
                else
                {
                    spwanedEnemies.transform.position = right.position;
                    spwanedEnemies.GetComponent<Monster>().speed = -Random.Range(4, 7);
                    spwanedEnemies.transform.localScale = new Vector3(-1f, 1f, 1f);
                }
        }
        
    }
}
    






































    
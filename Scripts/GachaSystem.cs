using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    public Transform spawnpoint;

    public GameObject[] characters;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RollGacha()
    {
        int t_rollval = Random.Range(0, characters.Length);

        Instantiate(characters[t_rollval], new Vector3(534, 232, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        characters[t_rollval].transform.position = spawnpoint.transform.position;
    }
}

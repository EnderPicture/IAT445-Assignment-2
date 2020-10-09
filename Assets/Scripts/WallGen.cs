using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGen : MonoBehaviour
{

    
    public GameObject walltile;
    public GameObject player;


    // Start is called before the first frame update
    List<GameObject> tiles = new List<GameObject>();
    void Start()
    {
        for (int x = 0; x < 50; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                float num = y * (Mathf.PI*2/10) + x * 0.1f;
                float instanceZ = (Mathf.Sin(num) * 10);
                float instanceY = (Mathf.Cos(num) * 10);

                GameObject newTile = Instantiate(walltile, transform.position + new Vector3(x, instanceY, instanceZ), Quaternion.Euler(0, 0, 0));
                newTile.GetComponent<LookAt>().target = player.transform;
                newTile.GetComponent<LookAt>().center = transform.position + new Vector3(x, 0, 0);
                tiles.Add(newTile);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggleOutside : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lightSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Player") {
            lightSource.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.transform.tag == "Player") {
            lightSource.SetActive(false);
        }
    }
}

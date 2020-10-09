using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    Vector3 initPosition;
    public Vector3 center;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        float mag = (initPosition - new Vector3((Time.realtimeSinceStartup*20%150-40)+target.position.x, center.y, center.z)).magnitude / 20;
        float delta = Mathf.Lerp(20, 8, mag);
        transform.position = new Vector3(0, initPosition.y, initPosition.z).normalized * delta + new Vector3(initPosition.x, 0, 0);
    }
}

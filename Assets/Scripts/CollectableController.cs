using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;
    private Vector3 offset1;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player one");
        offset = transform.position - player.transform.position;
        offset1 = transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 moving = new Vector3(90.0f, 0.0f, 0.0f);
        transform.Rotate(Vector3.up * Time.deltaTime*speed);
        

    }
}

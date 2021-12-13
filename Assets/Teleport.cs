using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Teleport : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void back_to_start() {
        player.transform.SetPositionAndRotation(new Vector3(23.39f, 0.353f, 44.611f), new Quaternion(0f,0f,0f,0f));
    }
}

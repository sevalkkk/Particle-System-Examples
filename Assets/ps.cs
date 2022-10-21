using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ps : MonoBehaviour
{
    [SerializeField] GameObject fire;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
            GameObject explosion = Instantiate(fire, transform.position, transform.rotation);
            Destroy(explosion, 0.75f);
         
        }
    }
}

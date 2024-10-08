using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time = 2.0f;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (time >=2f))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            time = 0f;
        }
    }
}

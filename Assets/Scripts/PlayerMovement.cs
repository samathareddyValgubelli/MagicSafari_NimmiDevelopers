using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera camera;
    public bool isStopped = false;
    Ray ray;
    RaycastHit hit;

    string playerTag = "Player";

    // Update is called once per frame
    void Update()
    {
        if (!isStopped)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }


        if (Input.GetMouseButtonDown(0))
        {
            ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 1000))
            {
                Debug.Log("Rayast clicked " + hit.collider.gameObject.name);
                /// Name Comparison
                if (hit.collider.tag.Equals(playerTag))
                {
                    isStopped = !isStopped;
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClickCube : MonoBehaviour
{
    public UnityEvent anEvent;

    private void OnMouseDown()
    {
        anEvent.Invoke();
    }

    Vector3 targetPosition = new Vector3(0, 1.5f, 20);
    public void EventClick(GameObject obj)
    {
        Debug.Log("object name............" + obj.name);

        if (GameUI.Instance.selectedType == GameUI.enSelectedType.Gravity)
        {
            if (obj.transform.position.x < 1f)
            {
                obj.GetComponent<Rigidbody>().useGravity = false;

                //obj.transform.position = new Vector3(obj.transform.position.x, 1f, obj.transform.position.z);

                obj.transform.position = Vector3.Lerp(transform.position, targetPosition, 0.5f * Time.deltaTime);

            }
        }
    }
}

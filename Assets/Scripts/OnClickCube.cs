using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class OnClickCube : MonoBehaviour
{
    public UnityEvent anEvent;

    private void OnMouseDown()
    {
        anEvent.Invoke();
    }

    public void EventClick(GameObject obj)
    {
        Debug.Log("object name............" + obj.name);

        switch (GameUI.Instance.selectedType)
        {
            case GameUI.enSelectedType.Gravity:
                    if (obj.transform.position.y < 1f)
                    {
                        obj.GetComponent<Rigidbody>().useGravity = false;

                        obj.transform.DOMoveY(1.7f, 1f).OnComplete(()=>
                        {
                            obj.GetComponent<Rigidbody>().isKinematic = true;
                        });
                    }
                break;
            case GameUI.enSelectedType.Destroy:

                obj.SetActive(false);

                GameObject cubeObj = obj.transform.parent.gameObject;

                Destroy(obj);

                if (cubeObj != null)
                {
                    cubeObj.transform.DOMoveY(1.7f, 1f).OnComplete(() => {

                        cubeObj.GetComponent<Rigidbody>().isKinematic = true;

                    });
                }
                break;
            case GameUI.enSelectedType.Shape:
                break;
            case GameUI.enSelectedType.Magic:
                break;
            case GameUI.enSelectedType.None:
                Debug.Log("Please select action");
                break;
        }        
    }
}

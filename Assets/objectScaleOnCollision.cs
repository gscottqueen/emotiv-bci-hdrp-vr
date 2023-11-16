using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectScaleOnCollision : MonoBehaviour
{

  public GameObject parentObj, socketWrapper, socket;
  public float targetScale;
  public float timeToLerp = 0.25f;
  float scaleModifier = 1;
  private GameObject otherObj;
  private bool isTouching = false;
  private float angle;
  public Vector3 positionToMoveTo;

  IEnumerator LerpFunction(float endValue, float duration,  GameObject obj)
  {
    float time = 0;
    float startValue = scaleModifier;
    Vector3 startScale = transform.localScale;
    while (time < duration)
    {
      scaleModifier = Mathf.Lerp(startValue, endValue, time / duration);
      obj.transform.localScale = startScale * scaleModifier;
      time += Time.deltaTime;
      yield return null;
    }

    obj.transform.localScale = startScale * endValue;
    scaleModifier = endValue;
  }

  IEnumerator LerpPosition(Vector3 targetPosition, float duration, GameObject obj)
  {
    float time = 0;
    Vector3 startPosition = obj.transform.position;
    while (time < duration)
    {
      obj.transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
      time += Time.deltaTime;
      yield return null;
    }
    obj.transform.position = targetPosition;
  }

  void Update()
  {

    if (isTouching == true)
    {
      // and rotate
      angle = 10 * Time.deltaTime;
      otherObj.transform.Rotate(angle, angle, angle, Space.Self);
    }
  }


  void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Interactable"))
    {
      other.attachedRigidbody.isKinematic = true;
      StartCoroutine(LerpFunction(0.4f, timeToLerp, other.gameObject));
      other.gameObject.transform.parent = socketWrapper.transform;
      // position
      Vector3 center = new Vector3();
      center = socket.GetComponent<Renderer>().bounds.center;
      otherObj.transform.position = Vector3.Lerp(otherObj.transform.position, center, timeToLerp);
    }
  }

  void OnTriggerStay(Collider other)
  {
    if (other.gameObject.CompareTag("Interactable"))
    {
      otherObj = other.gameObject;
      isTouching = true;
    }
  }

  void OnTriggerExit(Collider other)
  {
    if (other.gameObject.CompareTag("Interactable"))
    {
      other.attachedRigidbody.isKinematic = false;
      StartCoroutine(LerpFunction(1, timeToLerp, other.gameObject));
      other.gameObject.transform.parent = parentObj.transform;
      isTouching = false;
    }
  }
}

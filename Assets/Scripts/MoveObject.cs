using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public IEnumerator moveOverSpeedCor(Transform objectToMove, Vector3 end, float speed)
    {
        // speed should be 1 unit per second
        while (objectToMove.position != end)
        {
            objectToMove.position = Vector3.MoveTowards(objectToMove.position, end, speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        objectToMove.position = end;
        //TODO: прерывание при повторном вызове корутины без завершения движения
    }

    public IEnumerator moveOverSecondsCor(Transform objectToMove, Vector3 end, float seconds)
    {
        float elapsedTime = 0;
        Vector3 startingPos = objectToMove.position;
        while (elapsedTime < seconds)
        {
            objectToMove.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        objectToMove.position = end;
    }
}

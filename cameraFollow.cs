using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  
    public GameObject PlayerPrefab;
    private Vector3 set = new Vector3(-1.16f, 1.32f, -10.5f);
     void LateUpdate()
    {
        transform.position = PlayerPrefab.transform.position+set;
    }
}

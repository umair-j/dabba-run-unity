using UnityEngine;

public class followPlayer : MonoBehaviour
{

    public Transform playerr;
    public Vector3 offset;

    void Update()
    {
        transform.position = playerr.position + offset;
    }
}

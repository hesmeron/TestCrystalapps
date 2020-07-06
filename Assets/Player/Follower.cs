using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    float smooth;
    Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }
    // Start is called before the first frame updatee
    void Update()
    {
        float y = this.transform.position.y;
        Vector3 newPosition = Vector3.Lerp(this.transform.position, target.position + startPosition, smooth);
        this.transform.position = new Vector3(newPosition.x, y, newPosition.z);
    }
}

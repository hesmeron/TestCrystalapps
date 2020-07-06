using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovment : MonoBehaviour
{
    [Range(0,3)]
    public int direction = 0;
    [SerializeField]
    float speed = 1f;
    Rigidbody rgb;
    [SerializeField]
    public static Vector3 lastPostion = Vector3.zero;
    [SerializeField]
    SceneGenerator generator;
    [SerializeField]
    TrackLeaver trackLeaver;
    [SerializeField]
    float acceleration = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        rgb = this.gameObject.GetComponent<Rigidbody>();
        SwipeDetector.OnSwipe += ChangeDirectionOnSwipe;
        lastPostion = Vector3.zero;
    }

    private void ChangeDirectionOnSwipe(SwipeDetector.SwipeData obj)
    {
        Debug.Log("Swipe!");
        if(obj.Direction == SwipeDetector.SwipeDirection.Up)
        {
            direction = 0;
        }
        if (obj.Direction == SwipeDetector.SwipeDirection.Right)
        {
            direction = 1;
        }
        if (obj.Direction == SwipeDetector.SwipeDirection.Down)
        {
            direction = 2;
        }
        if (obj.Direction == SwipeDetector.SwipeDirection.Left)
        {
            direction = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        PrepareObstacles();
    }

    private void Move()
    {
        PlayerInput.CheckDirection(ref direction);
        this.transform.rotation = Quaternion.Euler(0, 90 * direction, 0);
        rgb.velocity = this.transform.forward * (speed + (Points.points * acceleration));
    }
    void PrepareObstacles()
    {
        float distance = CheckDistance();
        if (distance >= 1)
        {
            //trackLeaver.LeaveTrack();
            lastPostion = this.transform.position;
            generator.GenerateObstacles(distance);
        }
    }

    float CheckDistance()
    {
        float distance = 0;
        switch (direction)
        {
            case 0:
                distance = (lastPostion.z - transform.position.z) * (-1);
                break;
            case 1:
                distance = (lastPostion.x - transform.position.x) * (-1);
                break;
            case 2:
                distance = lastPostion.z - transform.position.z ;
                break;
            case 3:
                distance = lastPostion.x - transform.position.x ;
                break;
        }
        return distance;           
    }
    private void OnDestroy()
    {
        rgb.velocity = Vector3.zero;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{
    [SerializeField] private float recordTime = 4f;
    private List<PointInTime> pointsInTime;
    private Rigidbody2D rb;
    private bool isRewinding;

    private void Start()
    {
        pointsInTime = new List<PointInTime>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            StartRewind();
        if (Input.GetKeyDown(KeyCode.P))
            StopRewind();
    }

    private void FixedUpdate()
    {
        if (isRewinding)
            Rewind();
        else
            Record();
    }

    private void Rewind()
    {
        if(pointsInTime.Count > 1)
        {
            PointInTime pointInTime2 = pointsInTime[0];
            transform.position = pointInTime2.position;
            transform.rotation = pointInTime2.rotation;
            pointsInTime.RemoveAt(0);
        }
        else
        {
            PointInTime pointInTime2 = pointsInTime[0];
            transform.position = pointInTime2.position;
            transform.rotation = pointInTime2.rotation;
            StopRewind();
        }
    }

    private void Record()
    {
        if (pointsInTime.Count > Mathf.Round(recordTime / Time.fixedDeltaTime))
            pointsInTime.RemoveAt(pointsInTime.Count - 1);
        pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation, rb.velocity, rb.angularVelocity));
    }

    private void StartRewind()
    {
        isRewinding = true;
        rb.isKinematic = true;
    }

    private void StopRewind()
    {
        isRewinding = false;
        rb.isKinematic = false;
        rb.velocity = pointsInTime[0].velocity;
        rb.angularVelocity = pointsInTime[0].angularVelocity;
    }
}

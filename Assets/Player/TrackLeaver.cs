using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackLeaver : MonoBehaviour
{
    [SerializeField]
    GameObject trackPrefab;
    private void Start()
    {
       
    }
    public void LeaveTrack()
    {
        if(Vector3.Distance(PlayerMovment.lastPostion, this.transform.position) > 1)
        {
            GameObject newTrack = Instantiate(trackPrefab, this.transform);
            newTrack.transform.localPosition -= new Vector3(0, 0, 1.1f);
            newTrack.transform.parent = null;

        }
    }
}

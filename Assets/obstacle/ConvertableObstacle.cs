using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertableObstacle : MonoBehaviour
{
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        int choice = Random.Range(0, 4);
        this.transform.rotation = Quaternion.Euler(0, choice * 90 , 0);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.childCount);

        ContactPoint contact = collision.contacts[0];
        float rotation = Vector3.Angle(this.transform.right, contact.normal);
        Debug.Log(rotation);
        if (rotation == 0 && collision.transform.childCount < 3)
        {
            Debug.Log("Add");
            this.transform.parent = collision.gameObject.transform;
            this.transform.localPosition = new Vector3(0, -0.41417f, 1);
            this.GetComponent<MeshRenderer>().material = mat;
            Destroy(this);
        }
        else
        {
            if (collision.transform.childCount > 1)
            {
                GameObject child = collision.transform.GetChild(1).gameObject;
                Destroy(child);
                Destroy(this.gameObject);
                return;
            }
            Points.Lose();
        }
    }
}

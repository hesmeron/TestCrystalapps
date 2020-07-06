using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGenerator : MonoBehaviour
{
    [SerializeField]
    List<GameObject> prefabs = new List<GameObject>();
    [SerializeField]
    List<int> chances = new List<int>();
    [SerializeField]
    int eventStrength = 0;
    [SerializeField]
    int generationDistance = 1;
    [SerializeField]
    int generationLength = 48;
    [SerializeField]
    float generationHeight = 0f;


    // Start is called before the first frame update
    private void Start()
    {
        foreach(var c in chances)
        {
            eventStrength += c;
        }
        for(int j = 3; j >= 0; j--)
        {
            this.transform.rotation = Quaternion.Euler(0, 90 * j, 0);
            int oldDistance = generationDistance;
            for (int i = 3; i <= oldDistance; i++)
            {
                generationDistance = i;
                GenerateObstacles(0);
            }
        }

    }
    // Update is called once per frame
    public void GenerateObstacles(float distance)
    {
        for(int i=0; i<generationDistance * 2; i++)
        {
            int choice = ChooseRandomObstacle();
            if(choice == prefabs.Count)
            {
                continue;
            }
            else
            {
                PlaceObstacle(i, choice, distance);
            }
        }
    }

    int ChooseRandomObstacle()
    {
        int choice = Random.Range(0, eventStrength);
        int currentStrength = 0;
        for (int i = 0; i <= prefabs.Count; i++)
        {
            currentStrength += chances[i];
            if(choice <= currentStrength)
            {
                return i;
            }
        }
        return prefabs.Count;
    }
    void PlaceObstacle(int i, int random, float distance)
    {
        GameObject obstacle =  Instantiate(prefabs[random], this.transform);
        obstacle.transform.localPosition = new Vector3(
            i - (generationLength/2), 
            obstacle.transform.localPosition.y, 
            generationDistance);

        obstacle.transform.parent = null;
        obstacle.transform.position = new Vector3(
            Mathf.Round(obstacle.transform.position.x),
            generationHeight, 
            Mathf.Round(obstacle.transform.position.z));
    }

}

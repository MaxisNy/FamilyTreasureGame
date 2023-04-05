using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{

    List<Vector3> clockPositions = new List<Vector3>() {new Vector3(-3.12f, 36, 0), new Vector3(0.05f, 36, 0), new Vector3(3.13f, 36, 0)};

    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> clocks = new List<GameObject>() {};
        clocks.Add(transform.GetChild(0).gameObject);
        clocks.Add(transform.GetChild(1).gameObject);
        clocks.Add(transform.GetChild(2).gameObject);

        reshuffle(clockPositions, clocks);
    }

    void reshuffle(List<Vector3> positions, List<GameObject> objs) {

        List<Vector3> pos = new List<Vector3>(positions);

        for (int i = 0; i < objs.Count; i++) {
            int num  = Random.Range(0, pos.Count);
            objs[i].transform.position = pos[num];
            pos.RemoveAt(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

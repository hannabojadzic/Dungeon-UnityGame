using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInstantiateObjectClick : MonoBehaviour {
    bool t = false;
    Material material;
    Material material2;
    // Use this for initialization
    void Start () {
         material = (Material)Resources.Load("Assets/Materials/skull");
        material2 = (Material)Resources.Load("Assets/Materials/bonetex4");
    }
	
	// Update is called once per frame
	void Update () {
        /*if(t)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(GameObject.Find("skull"), transform.position + new Vector3(4, 0, 0), Quaternion.identity);
            }

        }*/
		
	}
    void OnMouseDown()
    {
        t = true;
        for (int i = 0; i < 6; i++)
        {
            GameObject go = Instantiate(GameObject.Find("skull"), transform.position + new Vector3(5 + i*7, -30 , -10 - i * 5 * Random.value), Quaternion.identity);
            if (i%2==0) go.transform.Rotate(new Vector3( 1 + Random.value*10, 180,  Random.value*20));
            else go.transform.Rotate(new Vector3(1 + Random.value * 10, 180, Random.value * 20 * (-1)));
            go.GetComponent<MeshRenderer>().materials[0] = material;
            go.GetComponent<MeshRenderer>().materials[1] = material;
            //  go.GetComponent<MeshRenderer>().material = material2;
        }
        

    }
}

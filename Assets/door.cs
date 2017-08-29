using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter(Collider other)
    {
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 5f)
        {
            SceneManager.LoadScene("Demo Scene");
        }

    }
}

using UnityEngine;
using System.Collections;

public class playergun2 : MonoBehaviour {

    // Use this for initialization
    public getgun pg;
    public AudioClip clip;
    public GameObject gun2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        pg.HasGunII = true;
        GetComponent<AudioSource>().PlayOneShot(clip);
        gun2.SetActive(false);

    }
}

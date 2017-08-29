using UnityEngine;
using System.Collections;

public class playergun1 : MonoBehaviour {

    public getgun pg;
    public AudioClip clip;
    public GameObject gun1;
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
        pg.HasGunI = true;
        GetComponent<AudioSource>().PlayOneShot(clip);
        gun1.SetActive(false);

    }
}

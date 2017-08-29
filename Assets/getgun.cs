using UnityEngine;
using System.Collections;

public class getgun : MonoBehaviour {

    public bool HasGunI = true;
    public bool HasGunII = false;
    public GameObject imageObjectI;
    public GameObject imageObjectII;
    public GameObject gunI;
    public GameObject gunII;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HasGunI && Input.GetKeyDown(KeyCode.Alpha1))
        {
            imageObjectI.SetActive(true);
            gunI.SetActive(true);
            gunII.SetActive(false);

        }
        else if (HasGunII && Input.GetKeyDown(KeyCode.Alpha2))
        {

            imageObjectII.SetActive(true);
            gunI.SetActive(false);
            gunII.SetActive(true);

        }
       
    }
}

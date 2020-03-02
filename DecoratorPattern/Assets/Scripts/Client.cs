using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Client : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            IRifle rifle = new BasicRifle();
            Instantiate(rifle.LoadPart());
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Instantiate(rifle.LoadPart());
            Debug.Log("WithScope accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithStabilizer(new WithScope(rifle));
            Instantiate(rifle.LoadPart());
            Debug.Log("Stabilizer+Scope accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithSilencer(new WithStabilizer(new WithScope(rifle)));
            Instantiate(rifle.LoadPart());
            Debug.Log("Stabilizer+Scope+Silencer accuracy: "
                + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            IRifle rifle = new BasicRifle();
            rifle = new InPink(new WithStabilizer
                (new WithSilencer(new WithScope(rifle))));
            Instantiate(rifle.LoadPart());
            Debug.Log("Stabilizer+Scope+Silencer in Pink! accuracy: "
                + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

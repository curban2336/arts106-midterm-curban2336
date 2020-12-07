using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMANAGER : MonoBehaviour
{

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("MidtermProject");
    }

    public void Composition()
    {
        SceneManager.LoadScene("Composition");
    }
}

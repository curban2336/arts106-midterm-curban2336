using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMANAGER : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void FinalScene()
    {
        SceneManager.LoadScene("MidtermProject");
    }

    public void CompositionScene()
    {
        SceneManager.LoadScene("Composition");
    }
}

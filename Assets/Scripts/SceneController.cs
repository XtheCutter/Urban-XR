using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private const string _mappingApp = "MappingApp";
    private const string _contentPlacement = "ContentPlacementSample";

    public void LoadMappingApp()
    {
        SceneManager.LoadSceneAsync(_mappingApp);
    }

    public void LoadContentPlacement()
    {
        SceneManager.LoadSceneAsync(_contentPlacement);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

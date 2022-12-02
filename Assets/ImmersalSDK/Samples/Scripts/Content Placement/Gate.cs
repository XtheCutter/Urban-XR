using Immersal.AR;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField]
    private ARMap _arMap;
    [SerializeField]
    private GameObject _gateObject;

    private void Awake()
    {
        _arMap.OnFirstLocalization.AddListener(EnableItself);
    }

    private void OnDestroy()
    {
        _arMap.OnFirstLocalization.RemoveListener(EnableItself);
    }

    private void EnableItself(int value)
    {
        _gateObject.SetActive(true);
    }
}

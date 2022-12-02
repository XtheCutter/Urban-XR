using Immersal.AR;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField]
    private ARMap _arMap;

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
        gameObject.SetActive(true);
    }
}

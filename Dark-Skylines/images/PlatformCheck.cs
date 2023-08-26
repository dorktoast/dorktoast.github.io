using UdonSharp;
using UnityEngine;
using UnityEngine.UI;

public class PlatformCheck : UdonSharpBehaviour
{
#if UNITY_ANDROID
    public bool isAndroid = true;
#else
    public bool isAndroid = false;
#endif

    public Toggle CheckToggle;
    
    private void Start()
    {
        if (isAndroid) Debug.Log("UNITY_ANDROID preprocessor reads as TRUE");
        else Debug.Log("UNITY_ANDROID preprocessor reads as FALSE");

        CheckToggle.SetIsOnWithoutNotify(isAndroid);
    }
}

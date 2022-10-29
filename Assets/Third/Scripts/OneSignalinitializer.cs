using OneSignalSDK;
using UnityEngine;

public class OneSignalinitializer : MonoBehaviour
{
    private static OneSignalinitializer instance;
    [SerializeField] string YOUR_ONESIGNAL_APP_ID;

    private void Start()
    {
        if(transform.parent != null)
        {
            transform.SetParent(null);
        }

        if(instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            OneSignal.Default.Initialize(YOUR_ONESIGNAL_APP_ID);
        }

        DontDestroyOnLoad(gameObject);
    }
}

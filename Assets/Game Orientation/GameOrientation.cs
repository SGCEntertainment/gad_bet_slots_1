using UnityEngine;

public class GameOrientation : MonoBehaviour
{
    [SerializeField] ScreenOrientation screenOrientation;

    private void Start() => Screen.orientation = screenOrientation;
}

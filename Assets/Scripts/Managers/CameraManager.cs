using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject mainCamera;
    public Transform player;

    private void Awake()
    {
        mainCamera.transform.SetParent(player, true);
    }
}

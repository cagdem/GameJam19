// 25.05.2024 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using UnityEngine;
using UnityEngine.InputSystem;
// 25.05.2024 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{// 25.05.2024 AI-Tag
 // This was created with assistance from Muse, a Unity Artificial Intelligence product

    public CinemachineVirtualCamera TimmyVirtualCamera;
    public CinemachineVirtualCamera TimmyOldVirtualCamera;

    private void Start()
    {
        // Ensure only TimmyCamera is enabled at start
        TimmyVirtualCamera.enabled = true;
        TimmyOldVirtualCamera.enabled = false;
    }

    private void Update()
    {
        // 25.05.2024 AI-Tag
        // This was created with assistance from Muse, a Unity Artificial Intelligence product

        // 25.05.2024 AI-Tag
        // This was created with assistance from Muse, a Unity Artificial Intelligence product

        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            // Switch cameras by swapping priorities
            int tempPriority = TimmyVirtualCamera.Priority;
            TimmyVirtualCamera.Priority = TimmyOldVirtualCamera.Priority;
            TimmyOldVirtualCamera.Priority = tempPriority;
        }
    }
}
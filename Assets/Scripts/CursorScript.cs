using UnityEngine;
using UnityEngine.UI;

public class CursorScript : MonoBehaviour
{
    
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
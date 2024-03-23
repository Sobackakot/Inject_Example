using System; 
using UnityEngine;

public class CylinderMessage : MonoBehaviour, ITypeObject
{
    public event Action<string> onMessageReceived;

    private void OnTriggerEnter(Collider other)
    {
        onMessageReceived?.Invoke(other.gameObject.name);
    }
}

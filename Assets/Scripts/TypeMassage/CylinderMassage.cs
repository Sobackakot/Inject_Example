using System; 
using UnityEngine;

public class CylinderMassage : MonoBehaviour, IMassages
{
    public event Action<string> massage;

    public void OnTriggerEnter(Collider other)
    {
        massage?.Invoke(other.gameObject.name);
    }
}

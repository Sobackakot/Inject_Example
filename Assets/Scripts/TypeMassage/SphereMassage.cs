using System; 
using UnityEngine;

public class SphereMassage : MonoBehaviour, IMassages
{
    public event Action<string> massage;
    public void OnTriggerEnter(Collider other)
    {
        massage?.Invoke(other.gameObject.name);
    }
}

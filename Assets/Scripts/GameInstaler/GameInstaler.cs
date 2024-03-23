using UnityEngine;

public class GameInstaler: MonoBehaviour
{
    [SerializeField] private CubeMessage cubMessage;
    [SerializeField] private SphereMessage sphereMessage;
    [SerializeField] private CylinderMessage cylinderMessage;
    [SerializeField] private CupsuleMessage cupsuleMessage;
    private ITypeObject _currentType;
   
    private void Awake()
    {
        _currentType = cupsuleMessage;
        ShowMessage showText = new ShowMessage(_currentType);
        showText.ShowText(); 
    }
}
    


 
using UnityEngine; 

public class ShowMessage 
{
    public ITypeObject currentType;
     
    public ShowMessage(ITypeObject newType)
    {
        currentType = newType; 
    } 
    private void HandleMessageReceived(string newText)
    {
        Debug.Log(newText);
        currentType.onMessageReceived -= HandleMessageReceived;
    }

    public void ShowText()
    {
        currentType.onMessageReceived += HandleMessageReceived;
    }
}

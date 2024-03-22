 
using UnityEngine;
using Zenject;

public class ShowMassage : MonoBehaviour
{
    public IMassages _massage;

    [Inject]
    public void Construct(IMassages massage)
    {
        Debug.Log("constr");
        _massage = massage;
    }
     
    private void OnEnable()
    { 
        _massage.massage += Massage_massage;
    }
    private void OnDisable()
    { 
        _massage.massage -= Massage_massage;
    }

    private void Massage_massage(string text)
    {
        Debug.Log(text);
    }
}

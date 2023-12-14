using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private IKitchenObjectParent kitchenObjectParent;


    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }

    //After triggering function to clear parent for object it check if there is one
    public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent) 
    {
        //Whole problem was missing "this."
        if (this.kitchenObjectParent != null)
        {
            //If there is one we clear parent
            this.kitchenObjectParent.ClearKitchenObject();
        }
            //And set new one after
        this.kitchenObjectParent = kitchenObjectParent;

        if (kitchenObjectParent.HasKitchenObject())
        {
            Debug.LogError("Counter already has KitchenObject!!");
        }

        kitchenObjectParent.SetKitchenObject(this);

        transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }
    
    public IKitchenObjectParent GetKitchenObjectParent() 
    { 
        return kitchenObjectParent; 
    }
}

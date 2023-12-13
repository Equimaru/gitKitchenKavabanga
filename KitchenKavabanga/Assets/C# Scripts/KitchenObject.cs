using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private ClearCounter clearCounter;


    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }

    //After triggering function to clear parent for object it check if there is one
    //public void SetClearCounter(ClearCounter clearCounter) 
    //{
        //if (clearCounter != null)
        //{
            //If there is one we clear parent
            //this.clearCounter.ClearKitchenObject();
        //}
            //And set new one after
        //this.clearCounter = clearCounter;

        //if (clearCounter.HasKitchenObject())
        //{
            //Debug.LogError("Counter already has KitchenObject!!");
        //}

        //clearCounter.SetKitchenObject(this);

        //transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        //transform.localPosition = Vector3.zero;
    //}
    
    //public ClearCounter GetClearCounter() 
    //{ 
        //return clearCounter; 
    //}
}

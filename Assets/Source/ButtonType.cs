using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonType : MonoBehaviour
{ 
    [SerializeField] private ResourceType _resourceType;
    public ResourceType ResourceType => _resourceType;
}

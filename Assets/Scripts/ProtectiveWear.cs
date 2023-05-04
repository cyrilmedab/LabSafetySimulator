using System.Collections;
using System.Collections.Generic;
using Meta.WitAi;
using UnityEngine;

public class ProtectiveWear : MonoBehaviour
{
    [SerializeField] private GameObject oculusRig;
    [SerializeField] private Material gloveMat;

    private PlayerManager _playerManager;
    
    private GameObject _leftHand;
    private GameObject _rightHand;
    private GameObject _glassesCanvas;
    
    private GameObject _leftSleeve;
    private GameObject _rightSleeve;

    private void Start()
    {
        _playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        
        _leftHand = oculusRig.transform.GetChild(1).GetChild(2).GetChild(0).GetChild(1).gameObject;
        _rightHand = oculusRig.transform.GetChild(1).GetChild(2).GetChild(1).GetChild(1).gameObject;

        var trackingSpace = oculusRig.transform.GetChild(0).GetChild(0);
        _glassesCanvas = trackingSpace.GetChild(1).GetChild(0).gameObject;
        _leftSleeve = trackingSpace.GetChild(4).GetChild(2).gameObject;
        _rightSleeve = trackingSpace.GetChild(5).GetChild(2).gameObject;


    }

    public void PutOnGear()
    {
        switch (gameObject.tag)
        {
            case "LabCoat":
                WearCoat();
                break;
            case "Glasses": 
                WearGlasses();
                break;
            case "Gloves": 
                WearGloves();
                break;
        }
        gameObject.DestroySafely();
    }

    private void WearCoat()
    {
        _leftSleeve.SetActive(true);
        _rightSleeve.SetActive(true);

        _playerManager.hasCoat = true;
    }
    
    private void WearGlasses()
    {
        _glassesCanvas.SetActive(true);
        _playerManager.hasGlasses = true;
    }
    
    private void WearGloves()
    {
        _leftHand.GetComponentInChildren<SkinnedMeshRenderer>(false).material = gloveMat;
        _rightHand.GetComponentInChildren<SkinnedMeshRenderer>(false).material = gloveMat;
        _playerManager.hasGloves = true;
    }
}

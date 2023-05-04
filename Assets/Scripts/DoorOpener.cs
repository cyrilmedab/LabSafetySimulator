using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private PlayerManager _playerManager;
    private Animator _animator;
    
    private void Start()
    {
        _playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerManager>();
        _animator = GetComponent<Animator>();
    }

    private bool HasProtectiveWear()
    {
        return _playerManager.hasGloves && _playerManager.hasCoat && _playerManager.hasGlasses;
    }

    public void OpenDoor()
    {
        if (!HasProtectiveWear()) return;
        
        _animator.Play("LocationDoorOpen");
    }
}

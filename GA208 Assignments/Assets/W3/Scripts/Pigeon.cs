using UnityEngine;


public class Pigeon : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] PigeonState _state;
    [SerializeField] string flyingAnimBool = "isFlying";

    // (1) add a member variable to represent the Pigeon's state
    public enum PigeonState
    {
        Idle,
        Flying
    }
    

    void Update()
    {
        PollState();
        PollAppearance();
    }

    // (2) fill in this method to update the pigeon's state based on input
    // if the player is pressing the 'A' key, the state should be set to Flying
    // - otherwise, it should be Idle
    void PollState () => _state = Input.GetKey(KeyCode.A) ? PigeonState.Flying : PigeonState.Idle;

    // (3) fill in this method to update the pigeon's animation based on its state
    // based on whether the player is Flying or Idling, use the given methods PlayFlyAnimation and PlayIdleAnimation
    // to play the correct animation
    // use a Switch statement!
    void PollAppearance()
    {
        switch (_state)
        {
            case PigeonState.Flying: PlayFlyAnimation(); break;
            case PigeonState.Idle: PlayIdleAnimation(); break;
        }
    }

     
    void PlayFlyAnimation () => _animator.SetBool(flyingAnimBool, true);
    void PlayIdleAnimation () => _animator.SetBool(flyingAnimBool, false);
}

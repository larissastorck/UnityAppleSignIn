using UnityEngine;
using UnityEngine.SignInWithApple;

public class SignInWithAppleTest : MonoBehaviour
{
    public void Start()
    {
        gameObject.AddComponent<SignInWithApple>();
        Open();
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void ButtonPress()
    {
        var siwa = gameObject.GetComponent<SignInWithApple>();
        siwa.Login(OnLogin);
    }

    public void CredentialButton()
    {
        // User id that was obtained from the user signed into your app for the first time.
        var siwa = gameObject.GetComponent<SignInWithApple>();
        siwa.GetCredentialState("<userid>", OnCredentialState);
    }

    private void OnCredentialState(SignInWithApple.CallbackArgs args)
    {
        Debug.Log("User credential state is: " + args.credentialState);
        Debug.Log("User userInfo.idToken is: " + args.userInfo.idToken);
        Debug.Log("User userInfo.userId is: " + args.userInfo.userId);
        Debug.Log("User credentialState is: " + args.credentialState);
    }

    private void OnLogin(SignInWithApple.CallbackArgs args)
    {
        Debug.Log("Sign in with Apple login has completed.");
    }
}

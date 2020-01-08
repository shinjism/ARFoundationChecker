using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARSession))]
[RequireComponent(typeof(Text))]
[RequireComponent(typeof(Sprite))]

public class DeviceSupportChecker : MonoBehaviour
{
    [SerializeField] ARSession m_Session = null;
    [SerializeField] Text m_Text = null;
    [SerializeField] Image m_Image = null;
    [SerializeField] Sprite m_Sprite_x = null;
    [SerializeField] Sprite m_Sprite_exclamation = null;
    [SerializeField] Sprite m_Sprite_check = null;

    void Awake()
    {
        if (m_Session != null)
        {
            m_Session.enabled = false;
        }
        if (m_Text != null)
        {
            m_Text.text = "";
        }
        if (m_Image != null)
        {
            m_Image.sprite = null;
        }
    }

    IEnumerator Start() {
        if ((ARSession.state == ARSessionState.None) ||
            (ARSession.state == ARSessionState.CheckingAvailability))
        {
            yield return ARSession.CheckAvailability();
        }

        if (ARSession.state == ARSessionState.Unsupported)
        {
            // Start some fallback experience for unsupported devices
        }
        else
        {
            // Start the AR session
            m_Session.enabled = true;
        }
    }

    void Update()
    {
        if (m_Session == null) return;
        if (m_Text == null) return;

        Sprite sprite = null;

        switch (ARSession.state)
        {
            case ARSessionState.None:
                m_Text.text = "The AR System has not been initialized and availability is unknown.";
                sprite = m_Sprite_x;
                break;
            case ARSessionState.Unsupported:
                m_Text.text = "AR is not supported on the current device.";
                sprite = m_Sprite_x;
                break;
            case ARSessionState.CheckingAvailability:
                m_Text.text = "The system is checking the availability of AR on the current device.";
                sprite = m_Sprite_exclamation;
                break;
            case ARSessionState.NeedsInstall:
                m_Text.text = "AR is supported on the current device, but requires an additional install.";
                sprite = m_Sprite_exclamation;
                break;
            case ARSessionState.Installing:
                m_Text.text = "AR software is being installed";
                sprite = m_Sprite_exclamation;
                break;
            case ARSessionState.Ready:
                m_Text.text = "AR is supported and ready";
                sprite = m_Sprite_check;
                break;
            case ARSessionState.SessionInitializing:
                m_Text.text = "An AR session is initializing (i.e., starting up). This usually means AR is working but has not gathered enough information about the environment";
                sprite = m_Sprite_check;
                break;
            case ARSessionState.SessionTracking:
                m_Text.text = "An AR session is running and is tracking (i.e., the device is able to determine its position and orientation in the world).";
                sprite = m_Sprite_check;
                break;
        }

        if (m_Image != null && sprite != null)
        {
            m_Image.sprite = sprite;
        }
    }
}

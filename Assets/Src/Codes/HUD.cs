using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum InfoType { DeviceId, Time }
    public InfoType type;

    private Text myText;

    private void Awake() {
        myText = GetComponent<Text>();
    }

    private void LateUpdate() {
        switch(type) {
            case InfoType.DeviceId:
                myText.text = string.Format("{0}", GameManager.instance.deviceId);
                break;
            case InfoType.Time:
                int min = Mathf.FloorToInt(GameManager.instance.gameTime / 60);
                int sec = Mathf.FloorToInt(GameManager.instance.gameTime % 60);
                myText.text = string.Format("{0:D2}:{1:D2}", min, sec);
                break;
        }
    }
}

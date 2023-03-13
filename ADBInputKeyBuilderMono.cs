using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ADBInputKeyBuilderMono : MonoBehaviour
{

}

public class ADBInputKeyBuilder
{


    public static void GetInputKey(int keyEvent, out string commandLine)
    {
        commandLine = string.Format("adb shell input keyevent " + keyEvent);
    }
    public static void GetInputKey(AndroidKeyInputRaw0To123 keyEvent, out string commandLine) => GetInputKey((int)keyEvent, out commandLine);
    public static void GetInputKey(AndroidKeyInput0To123 keyEvent, out string commandLine) => GetInputKey((int)keyEvent, out commandLine);

    public static void Home(out string commandLine) => commandLine = "adb shell input keyevent 3oradb shell am start -W -c android.intent.category.HOME -a android.intent.action.MAIN";


    public enum AndroidKeyInputRaw0To123 : int  {BACK=4,CALL=5,ENDCALL=6,TOGGLEONOFF=26,LAUNCHCAMERA=27,LAUNCHBROWSER=64,ENTER=66,DELETE=67,BACKSPACE=67,LAUNCHCONTACTS=207,BRIGHTNESSDOWN=220,BRIGHTNESSUP=221,CUT=277,COPY=278,PASTE=279,KEY_MenuSoftLeft=1,KEY_SoftRight=2,KEY_HOME=3,KEY_BACK=4,KEY_CALL=5,KEY_ENDCALL=6,KEY_0=7,KEY_1=8,KEY_2=9,KEY_3=10,KEY_4=11,KEY_5=12,KEY_6=13,KEY_7=14,KEY_8=15,KEY_9=16,KEY_STAR=17,KEY_POUND=18,KEY_DPADUP=19,KEY_DPADDOWN=20,KEY_DPADLEFT=21,KEY_DPADRIGHT=22,KEY_DPADCENTER=23,KEY_VOLUMEUP=24,KEY_VOLUMEDOWN=25,KEY_POWER=26,KEY_CAMERA=27,KEY_CLEAR=28,KEY_A=29,KEY_B=30,KEY_C=31,KEY_D=32,KEY_E=33,KEY_F=34,KEY_G=35,KEY_H=36,KEY_I=37,KEY_J=38,KEY_K=39,KEY_L=40,KEY_M=41,KEY_N=42,KEY_O=43,KEY_P=44,KEY_Q=45,KEY_R=46,KEY_S=47,KEY_T=48,KEY_U=49,KEY_V=50,KEY_W=51,KEY_X=52,KEY_Y=53,KEY_Z=54,KEY_COMMA=55,KEY_PERIOD=56,KEY_ALTLEFT=57,KEY_ALTRIGHT=58,KEY_SHIFTLEFT=59,KEY_SHIFTRIGHT=60,KEY_TAB=61,KEY_SPACE=62,KEY_SYM=63,KEY_SelectKeyboard=63,KEY_EXPLORER=64,KEY_ENVELOPE=65,KEY_ENTER=66,KEY_Delete=67,KEY_GRAVE=68,KEY_MINUS=69,KEY_EQUALS=70,KEY_LEFTBRACKET=71,KEY_RIGHTBRACKET=72,KEY_BACKSLASH=73,KEY_SEMICOLON=74,KEY_APOSTROPHE=75,KEY_SLASH=76,KEY_AT=77,KEY_NUM=78,KEY_HEADSETHOOK=79,KEY_FOCUS=80,KEY_PLUS=81,KEY_MENU=82,KEY_NOTIFICATION=83,KEY_SEARCH=84,KEY_MEDIASWITCHPLAY=85,KEY_MEDIASTOP=86,KEY_NEXT=87,KEY_PREVIOUS=88,KEY_MEDIA_REWIND=89,KEY_MEDIA_FAST_FORWARD=90,KEY_MUTE=91,KEY_PAGEUP=92,KEY_PAGEDOWN=93,KEY_PICTSYMBOLS=94,KEY_MOVEHOME=122,KEY_MOVEEND=123}
    public enum AndroidKeyInput0To123 : int{ Back=4,Call=5,EndCall=6,ToggleOnOff=26,LaunchCamera=27,LaunchBrowser=64,Enter=66,Delete=67,Backspace=67,LaunchContacts=207,BrightnessDown=220,BrightnessUp=221,Cut=277,Copy=278,Paste=279,KeyMenuSoftLeft=1,KeySoftRight=2,KeyHome=3,KeyBack=4,KeyCall=5,KeyEndCall=6,Key0=7,Key1=8,Key2=9,Key3=10,Key4=11,Key5=12,Key6=13,Key7=14,Key8=15,Key9=16,KeyStar=17,KeyPound=18,KeyDpadUp=19,KeyDpadDown=20,KeyDpadLeft=21,KeyDpadRight=22,KeyDpadCenter=23,KeyVolumeUp=24,KeyVolumeDown=25,KeyPower=26,KeyCamera=27,KeyClear=28,KeyA=29,KeyB=30,KeyC=31,KeyD=32,KeyE=33,KeyF=34,KeyG=35,KeyH=36,KeyI=37,KeyJ=38,KeyK=39,KeyL=40,KeyM=41,KeyN=42,KeyO=43,KeyP=44,KeyQ=45,KeyR=46,KeyS=47,KeyT=48,KeyU=49,KeyV=50,KeyW=51,KeyX=52,KeyY=53,KeyZ=54,KeyComma=55,KeyPeriod=56,KeyAltLeft=57,KeyAltRight=58,KeyShiftLeft=59,KeyShiftRight=60,KeyTab=61,KeySpace=62,KeySym=63,KeySelectKeyboard=63,KeyExplorer=64,KeyEnvelope=65,KeyEnter=66,KeyDelete=67,KeyGrave=68,KeyMinus=69,KeyEquals=70,KeyLeftBracket=71,KeyRightBracket=72,KeyBackslash=73,KeySemicolon=74,KeyApostrophe=75,KeySlash=76,KeyAt=77,KeyNum=78,KeyHeadsetHook=79,KeyFocus=80,KeyPlus=81,KeyMenu=82,KeyNotification=83,KeySearch=84,KeyMediaSwitchPlay=85,KeyMediaStop=86,KeyNext=87,KeyPrevious=88,KeyMediaRewind=89,KeyMediaFastForward=90,KeyMute=91,KeyPageUp=92,KeyPageDown=93,KeyPictsymbols=94,KeyMoveHome=122,KeyMoveEnd=123}



  

}
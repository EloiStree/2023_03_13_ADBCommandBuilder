using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Threading;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.tvOS;
using UnityEngine.WSA;

public class ADBUnstoreMethodeMono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class ADBShellCommandBuilder {

    //    Using ADB, users can only perform 1 operation at a time on device storage but shell gives an advantage
    //    here to move inside any directory and then perform any operations on the same folder.
    //    Here are some important directories which are really useful.

    //Use Command

    //    To start remote shell console adb shell
    //To change directory to /system adb shell<enter> cd /system
    //To delete file from device  adb shell<enter>rm -f /sdcard/<apkname.apk>
    //To delete folder from device adb shell<enter> rm -d /sdcard/test
    //    To create folder in device adb shell<enter> mkdir /sdcard/test
    //    To check network statistic of android device    adb shell<enter>netstat
    //    To get IP address information of device’s WIFI  adb shell<enter>ip -f inet addr show wlan0
    //To get the list and monitor all process running on android device adb shell<enter> top
    //To get the properties of android build.prop configuration   adb shell<enter>getprop ro.build.version.sdk
    //To Set/replace the properties of android build.prop configuration   adb shell<enter>setprop net.dns1 4.4.4.0


//    To copy files inside device storage from one folder to another folder.adb shell<enter> cp /sdcard/<filename.extension> /sdcard/foldername
//To move files inside device storage from one folder to another folder.adb shell<enter>mv /sdcard/<filename.extension> /sdcard/foldername
//    To move file inside the device storage and rename the file in destination folder    adb shell<enter>mv /sdcard/<filename.extension> /sdcard/apps/<newfilename.extension>

}

public class ADBUnstoreWhatIsThat {

    //   To list JDWP(Java Debug Wire Protocol) processes of android device adb jdwp

    //adb get-state

    /*
     
        
To list all devices connected via USB or To restart adb device in USB mode	adb usb
To list all forward socket connections	adb forward –list
To set up port forwarding (sets up forwarding of computer port 6123 to Android device port 7123)	adb forward tcp:6123 tcp:7123
     
     
     
To list directory content	adb shell lss
To print size of each file in selected directory	adb shell ls -s
To print list of subdirectories recursively	adb shell ls -R


To print information of application activity by package and activity name	adb shell dumpsys activity <package>/<activity>
To print process status	adb shell ps

To print activity of current opened application	dumpsys window windows | grep -E ‘mCurrentFocus|mFocusedApp’
To list the information of all opened apps	adb shell dumpsys package packages
To get the information of particular application	adb shell dump <name>
To get the path of application by package name	adb shell path <package>
     
     */

}

public class ADBUnstoreAPKBuild {


    //    To copy or transfer a file from a device’s storage to a computer.adb pull /system/app/<apkname.apk>
    public static void GetFileWithPullPath(string filePath, out string commandLine)
    => commandLine = "adb pull "+ filePath;

    //    To transmit or push a file from a computer to a device  adb push /local/path/<apkname.apk> /sdcard/apps/
    public static void GetPullApk(string apkNameWithExtension, out string commandLine)
 => commandLine = "adb pull /system/app/"+apkNameWithExtension;

    /*
     Use	Command
To push a single application to the device and install.	adb install <apk_name.apk>
To push multiple applications to the device and install.	adb install-multiple <apkname.apk> <apkname2.apk>
To push multiple applications to the device and install it automatically.	adb install-multi-package <apkname.apk> <apkname2.apk>
To replace existing application by keeping its data.	adb install -r <apkname.apk>
To install apk in external storage	adb install -s <apkname.apk>
To allow test packages	adb install -t <apkname.apk>
To uninstall apk by package name	adb uninstall <package_name_of_apk>
To uninstall apk by package name while keeping cache and app data	adb uninstall -k <package_name_of_apk>
To clear application data by package name	adb shell pm clear <package_name_of_apk>
To uninstall system application by package name	adb shell pm uninstall -k –user 0 <package_name_of_apk>
To disable application by package name	adb shell pm disable <package_name_of_apk>
To disable application by package name for system user	adb shell pm disable-user –user 0 <package_name_of_apk>
To disable re-enable disabled application by package name	adb shell pm enable <package_name_of_apk>
To hide application by package name	adb shell pm hide <package_name_of_apk>
To unhide application by package name	adb shell pm unhide <package_name_of_apk>
To suspend any application by package name	adb shell pm suspend <package_name_of_apk>
To re-enable suspended application by package name	adb shell pm unsuspend <package_name_of_apk>
     */


}

public class ADBUnstoreBackupBuild
{

    /*
     To take full backup of android device to computer	adb backup //
To restore backup from computer to device	adb restore //
To take backup of apps and settings	adb backup -apk -all -f backup.ab
To take backup of applications and application settings and shared storage	adb backup -apk -shared -all -f backup.ab
To take backup of only third party applications.	adb backup -apk -nosystem -all -f backup.ab
To connect to device using its ip address	adb connect ip_address_of_device
To restore previously created backup	adb restore backup.ab

    To reboot device in bootloader or fastboot mode	adb reboot bootloader
To reboot device in recovery mode	adb reboot recovery
To restart ADB device with root permission	adb root
To restart ADB device without root permission	adb unroot
To manually install OTA package using recovery mode	adb sideload ota-updatefile.zip
     */



}


public class ADBUnstoreMethodeBuilder
{

    public static void GetStartADBServer(out string commandLine)
=> commandLine = "adb start-server";

    public static void GetStartTCPIPConnection(int port, out string commandLine)
  => commandLine = "adb tcpip " + port;
    public static void GetADBConnection(string ipAddress, out string commandLine)
  => commandLine = "adb connect " + ipAddress;


    public static void GetStopADBServer(out string commandLine)
  => commandLine = "adb kill-server";



    public static void GetConnectedDevicesList(out string commandLine)
    {
        commandLine = "adb devices";
    }

    public static void GetConnectedDevicesListWithInfo(out string commandLine)
    {
        commandLine = "adb devices -l";
    }


    public static void GetRebootDeviceCommand(out string commandLine)
    {
        commandLine = "adb reboot";
    }
    

    public static void GetDeviceUniqueId(out string commandLine)
    {
        commandLine = "adb get-serialno";
    }
    
    public static void GetPixelDensityOfScreen(out string commandLine)
    {
        commandLine = "adb shell wm density";
    }
    public static void GetSetChangePixelDensity(int density, out string commandLine)
    {
        commandLine = "adb shell wm density "+ density;
    }
    public static void GetSetChangePixelResolution(int width, int height, out string commandLine)
    {
        commandLine = "adb shell wm size "+ width + "×"+ height;
    }

    public static void GetCompleteInfo_OnCurrentDisplayInformation(out string commandLine)
        => commandLine = "adb shell dumpsys display";

    public static void GetCompleteInfo_OnCurrentBatteryState(out string commandLine)
        => commandLine = "adb shell dumpsys display";
    public static void GetCompleteInfo_OnCurrentBatteryStatInfoState(out string commandLine)
         => commandLine = "adb shell dumpsys batterystats";

    public static void GetScreenResolution(out string commandLine)
        => commandLine = "adb shell wm size";

    public static void GetCompleteInfo_OnOpenApps(out string commandLine)
    => commandLine = "adb shell dumpsys package packages";
    public static void GetCompleteInfo_ActivityOfCurrentOpenedApplication(out string commandLine)
  => commandLine = "adb shell dumpsys window windows";

    public static void GetListOf_BackgroundRunningService(out string commandLine)
  => commandLine = "adb shell service list";

    public static void GetListOf_FeatureAvailableInDevice(out string commandLine)
  => commandLine = "adb shell pm list features";



    public static void GetListOf_InstallApplication(out string commandLine)
    => commandLine = "adb shell pm list packages";
    public static void GetListOf_UninstallApplication(out string commandLine)
    => commandLine = "adb shell pm list packages -u";
    public static void GetListOf_EnableApplication(out string commandLine)
    => commandLine = "adb shell pm list packages -e";
    public static void GetListOf_DisableApplication(out string commandLine)
    => commandLine = "adb shell pm list packages -d";
    public static void GetListOf_SystemApplication(out string commandLine)
    => commandLine = "adb shell pm list packages -s";
    public static void GetListOf_ThirdPartyAndDeveloperApplication(out string commandLine)
    => commandLine = "adb shell pm list packages -3";


    public static void GetCompleteInfo_IpConnectionInformation(out string commandLine)
  => commandLine = "adb shell netstat";


    public static void TakeScreenshotOnSDCard(out string commandLine)
    {
        commandLine = "adb shell screencap /sdcard/screenshot.png";
    }
    public static void TakeScreenshotOnSDCard(string sdLocalPath, out string commandLine)
    {
        //commandLine = "adb shell screencap /sdcard/screenshot.png";
        commandLine = "adb shell screencap /sdcard/"+ sdLocalPath + ".png";
    }

    public static void StopScreenRecord() {
        //Send key event CTRL+C or COMMAND+C2
    }
    public static void StartScreenRecord(int bitrate, float timetoRecord, string path, out string commandLine)
    {
        commandLine = "adb shell screenrecord";
        //adb shell screenrecord –size 1440 x 2960 /sdcard/movie.mp4
        //adb shell screenrecord –time-limit 36 /sdcard/movie.mp4
        //adb shell screenrecord –bit-rate 1500000 /sdcard/movie.mp4
    }
   

}

public class ADBEmulatorBuilder
{

    public static void SetBatteryLevel(out string commandLine)
        => commandLine = "adb shell wm size";
    public static void SetBatteryStatus(short value0to100, out string commandLine)
        => commandLine = "adb shell dumpsys battery set level " + value0to100;
    public static void ResetBatteryStatus(short BatteryStatus, out string commandLine)
        => commandLine = "adb shell dumpsys battery set status "+ BatteryStatus;
    public static void SetUsbStatus(bool trueIs1, out string commandLine)
        => commandLine = "adb shell dumpsys battery set usb " + (trueIs1 ? 1 : 0);

    public enum BatteryStatus { unknown, charging, discharging };
}

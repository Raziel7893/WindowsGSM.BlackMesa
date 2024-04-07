# BlackMesa - Not Working dueto ... I don't know why
🧩 Plugin for WindowsGSM to run a dedicated server for Black Mesa

## PLEASE ⭐STAR⭐ THE REPO IF YOU LIKE IT! THANKS!

### IMPORTANT POINTS:
- You need to do **Portforwarding**, if you want people outside of your house to be able to connect
- If you want your Server to be Listed: (default is LAN/IP-Connect ONLY!)
  - Link the Server to your Account: Edit Config => **Server GSLT** (https://steamcommunity.com/dev/managegameservers?l=german App ID )
  - **install the SteamClient( START IT ONCE**, no login, no autostart, just install and start it once)
  - go to the Server.cfg (WindowsGSM Click on **Browse => Server Files**, then go **\bms\cfg** and open **server.cfg** with Editor)
    - Excange "sv_lan" from 1 to 0 

### WindowsGSM Installation: 
1. Download  WindowsGSM https://windowsgsm.com/ 
2. Create a Folder at a Location you wan't all Server to be Installed and Run.
3. Drag WindowsGSM.Exe into previously created folder and execute it.

### Plugin Installation:
1. Download [latest](https://https://github.com/Raziel7893/WindowsGSM.BlackMesa/releases/latest) release
2. Either Extract then Move the folder **BlackMesa.cs** to **WindowsGSM/plugins** 
    1. Press on the Puzzle Icon in the left bottom side and press **[RELOAD PLUGINS]** or restart WindowsGSM
3. Or Press on the Puzzle Icon in the left bottom side and press **[IMPORT PLUGIN]** and choose the downloaded .zip

### Configuration
Modify the server config file to adjust settings(Brose=>Server Files): serverfiles\bms\cfg

### Official Documentation
🗃️ Didn't find any documentation yet. Please Let me know if you came accros one

### The Game
🕹️ https://store.steampowered.com/app/362890/Black_Mesa/

### Dedicated server info
🖥️ https://steamdb.info/app/346680/info/

### Port Forwarding (YOU NEED THIS, TO BE ABLE TO CONNECT FROM THE INTERNET(only for servers/pcs at home):
- If You don't know How: Google: YourRouterBrand + Portforwarding
- 27015 UDP - **Default Game Port**(look in the 7th column in WindowsGSM), 
  - this one is needed to be forwarded in your Router!
- 27015 TCP - **QueryPort** default, in theory the QueryPort should not be needed as PortForward

### Support
[WGSM](https://discord.com/channels/590590698907107340/645730252672335893)

### Give Love!
[Buy me a coffee](https://ko-fi.com/raziel7893)

[Paypal](https://paypal.me/raziel7893)

### License
This project is licensed under the MIT License - see the <a href="https://github.com/raziel7893/WindowsGSM.BlackMesa/blob/main/LICENSE">LICENSE.md</a> file for details

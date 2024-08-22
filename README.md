# Mir4-ClientEmulator
Network Client Emulator for Mir4 Global version, written in C# by AlSch092 @Github. 

![attck](https://github.com/user-attachments/assets/3aaf7133-67af-4e65-bd2f-1f204b8a16f9)  

This project was started in 2022 and retired in 2024.  

## Features:  
- Auto-farming/collecting  
- Auto-kill monsters  
- Map teleport    
- Player detection  
- Ban evasion from "hidden objects"
- Security tooling & game pentest tools such as Protobuf message encoder  

## How-to:  
This project uses login/session tokens to log in, since the game normally uses a web login/HTTP request chain (web login fetches the session token for ingame login). You will need to manually verify accounts (ingame captcha solve) and collect a working login token for your account, along with the `deviceId` for that account. You can also try adding a captcha-solving solution to automate this process. Each account has a static deviceId along with a login token which changes every 24h (or 72h if your character is above level 70). This can be collected by using an HTTPS analyzer such as Fiddler and viewing the `/auth/verify` POST request. Once you've collected your login token & deviceId, a "profile" can be filled out following the template in the `Profiles` folder, and you can then launch the executable program at the command line in the following format:

`Mir4ClientEmulator.exe <profile.ini path>`  

Alternatively, you can manually fill out the fields in the main form and click the "Connect" button.

## Requirements:
1. Copy the `Data` folder into the same folder as the compiled executable. The program will throw exceptions if this is not completed. I suggest a folder named `Profiles` is also present, which is where account profiles will reside.

## Note:  
This program handles all network actions but does not encrypt data: you will need to update & use my other project, `Mir4Encryption`, to successfully encrypt data. Please place the encryption .dll into same folder as this project's executable.  

## Resource usage:  
This project can be be runs thousands of times at once on a single machine and be used for load & security testing.

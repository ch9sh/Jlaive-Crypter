# Jlaive

Jlaive is an antivirus evasion tool that can convert executables into undetectable batch files. Obfuscated .NET assemblies are not guaranteed to work.

Join the Discord server for discussion and enquiries: https://discord.gg/Qzyq3Dqn82.

![image](https://media.discordapp.net/attachments/959762900443070485/987900379863846962/Untitled.png)

## Features
- .NET/Native (x64) support
- AES/XOR encryption
- Compression
- Anti Debug
- Anti VM
- Melt file (self delete)
- Bind files
- AMSI bypass
- ETW bypass
- API unhooking

## Screenshots

![image](https://media.discordapp.net/attachments/961905736139554876/982925324071338014/unknown.png)
![image](https://media.discordapp.net/attachments/961905736139554876/982925618377281536/unknown.png)

Demo video with [AsyncRat](https://github.com/NYAN-x-CAT/AsyncRAT-C-Sharp) vs Microsoft Defender: https://vimeo.com/717794371

## Donate
XMR: 47sQ8jVWGtb8iA5zJnnHmfFmu8GwibMs94JbhtutW9HNeYx9UAxWUNNF3NfE79pGm8bCBCFaF3R6CQEYADoF5Uv38m25SNt

## Known issues

- `Hidden` option does not work on Windows Terminal.
- Not compatible with Python EXEs.

## To-do

- Remove the use of `Add-Type` for decryption and decompression

## Credits

C# RunPE: [https://github.com/nettitude/RunPE](https://github.com/nettitude/RunPE)

SharpUnhooker: [https://github.com/GetRektBoy724/SharpUnhooker](https://github.com/GetRektBoy724/SharpUnhooker)

## Disclaimer
This project was made for educational purposes only. I am not responsible if you choose to use this illegally/maliciously.

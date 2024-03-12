# How to add to your services.msc
1- open CMD as administrator

2- Write `cd C:\Windows\Microsoft.NET\FrameWork\<Your version here>`

3- Then `InstallUtil.exe ProjectFolder\Monitor\bin\Debug\Monitor.exe`

This has added the service successfully to your services.msc. 

To run it: Press WIN + R simultainously then write `services.msc` search for `Workload Monitor` then start it.

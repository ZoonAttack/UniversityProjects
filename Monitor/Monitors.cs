using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
namespace Monitor
{
    internal class Monitors
    {
        readonly Utility util = new Utility();
        /// <summary>
        /// Monitors CPU usage
        /// </summary>
        public void CPUMONITOR()
        {
            using (var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true))
            {
                var value = Math.Round(cpuCounter.NextValue(), 2).ToString();
                Thread.Sleep(1000);
                value = Math.Round(cpuCounter.NextValue(), 2).ToString();
                util.LogData($"CPU Usage : {value}%");
            }
        }
        /// <summary>
        /// Monitors Available RAM GBs
        /// </summary>
        public void MEMORYMONITOR()
        {
            using (var MemoryCounter = new PerformanceCounter("Memory", "Available Bytes"))
            {
                var AvailabileBytes = (long)MemoryCounter.NextValue();
                var AvailableGB = Math.Round(AvailabileBytes / (1024 * 1024 * 1024.0), 2).ToString(); //Bytes to GB
                util.LogData($"Memory Available: {AvailableGB}GB");
            }
        }
        /// <summary>
        /// Monitors available free space in each physical drive
        /// </summary>
        public void DISKUSAGE()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {

                if (drive.IsReady) util.LogData($"{drive.Name} Size: {Math.Round(drive.AvailableFreeSpace / (1024 * 1024 * 1024.0), 2)}GB");
            }
        }
        /// <summary>
        /// Monitors Upload and download speeds
        /// </summary>
        public void NETWORKUSAGE()
        {
            string instance = new PerformanceCounterCategory("Network Interface").GetInstanceNames()[0];
            var SentBytesCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);
            var ReceivedBytesCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);
            SentBytesCounter.NextValue();
            ReceivedBytesCounter.NextValue();
            Thread.Sleep(1000);
            double bytesSent = Math.Round(SentBytesCounter.NextValue() / (1024 * 1024.0), 2); //in MBps
            double bytesReceived = Math.Round(ReceivedBytesCounter.NextValue() / (1024 * 1024.0), 2); //in MBps
            util.LogData($"Upload Speed : {bytesSent}MBps\nDownload Speed: {bytesReceived}MBps");

        }
    }
}

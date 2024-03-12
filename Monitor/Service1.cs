using System;
using System.ServiceProcess;
using System.Timers;
namespace Monitor
{
    public partial class Service1 : ServiceBase
    {
        System.Timers.Timer timer;
        System.Timers.Timer emailTimer;
        Monitors monitoring;
        Utility util;
        public Service1()
        {
            InitializeComponent();
            monitoring = new Monitors();
            util = new Utility();
            timer = new System.Timers.Timer();
            emailTimer = new System.Timers.Timer();
        }

        protected override void OnStart(string[] args)
        {
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000;
            timer.Enabled = true;
            emailTimer.Elapsed += new ElapsedEventHandler(OnElapsedEmailTime);
            emailTimer.Interval = 3600_000; //An hour
            emailTimer.Enabled = true;
        }

        protected override void OnStop()
        {
            util.LogData("Service has stopped at: " + DateTime.Now.ToString("F"));
        }
        public void OnElapsedEmailTime(object sender, ElapsedEventArgs e)
        {
            util.SendEmail("sender email", "recipient email", AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.ToShortDateString().Replace('/', '_') + ".txt");

        }
        public void OnElapsedTime(object sender, ElapsedEventArgs e)
        {
            util.LogData($"-----------------------Data Taken on " + DateTime.Now.ToString("F"));
            monitoring.CPUMONITOR();
            monitoring.MEMORYMONITOR();
            monitoring.DISKUSAGE();
            monitoring.NETWORKUSAGE();
        }
       
    }
}

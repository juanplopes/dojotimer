using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace DojoTimer.Helpers
{
    public class Semaphore
    {
        bool Active;
        string SemaphorePort;
        Options options;
        SerialPort sp;

        public Semaphore(Options options)
        {
            this.options = options;
            if (options.UseSemaphore)
            {
                OpenConnection();
            }
        }

        private void OpenConnection()
        {
            sp = new SerialPort(options.SemaphorePort, options.SemaphoreBaudRate);
            try
            {
                sp.Open();
                Active = true;
                SemaphorePort = options.SemaphorePort;
            }
            catch (SystemException ex)
            {
                System.Console.WriteLine(ex);
                Active = false;
            }
        }

        private void CloseConnection()
        {
            sp.Close();
            Active = false;
        }

        public void ShowResult(bool result)
        {
            if (!Active && options.UseSemaphore)
            {
                OpenConnection();
            }
            if (Active && !options.UseSemaphore)
            {
                CloseConnection();
            }
            if (Active && options.UseSemaphore && !SemaphorePort.Equals(options.SemaphorePort))
            {
                CloseConnection();
                OpenConnection();
            }

            if (Active && sp.IsOpen)
            {
                char[] spSend = { (result ? options.GreenSignalChar : options.RedSignalChar) };
                sp.Write(spSend, 0, spSend.Length);
                sp.DiscardInBuffer();
                sp.DiscardOutBuffer();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _TestThread
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        Thread TestThread = null;

        private void _TestThread()
        {
            int n = 0;

            while (true)
            {
                n++;

                TxtBoxLog.Invoke(new Action(() =>
                {
                    TxtBoxLog.AppendText($"{n}");
                    TxtBoxLog.AppendText(Environment.NewLine);
                    TxtBoxLog.ScrollToCaret();
                }));

                Debug.WriteLine(n);

                Thread.Sleep(500);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (TestThread == null)
            {
                TestThread = new Thread(_TestThread);

                TxtBoxLog.Invoke(new Action(() =>
                {
                    TxtBoxLog.AppendText($"Thread Declaration State : {TestThread.ThreadState}");
                    TxtBoxLog.AppendText(Environment.NewLine);
                    TxtBoxLog.ScrollToCaret();
                }));

                Debug.WriteLine($"Thread Declaration State : {TestThread.ThreadState}");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TxtBoxLog.Invoke(new Action(() =>
            {
                TxtBoxLog.AppendText($"Thread Start State : {TestThread.ThreadState}");
                TxtBoxLog.AppendText(Environment.NewLine);
                TxtBoxLog.ScrollToCaret();
            }));

            Debug.WriteLine($"Thread Start State : {TestThread.ThreadState}");

            TestThread.Start();

            TxtBoxLog.Invoke(new Action(() =>
            {
                TxtBoxLog.AppendText($"Thread Start State : {TestThread.ThreadState}");
                TxtBoxLog.AppendText(Environment.NewLine);
                TxtBoxLog.ScrollToCaret();
            }));

            Debug.WriteLine($"Thread Start State : {TestThread.ThreadState}");
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            TxtBoxLog.Invoke(new Action(() =>
            {
                TxtBoxLog.AppendText($"{TestThread.ThreadState}");
                TxtBoxLog.AppendText(Environment.NewLine);
                TxtBoxLog.ScrollToCaret();
            }));
            //Debug.WriteLine(TestThread.ThreadState);

            TestThread.Suspend();

            TxtBoxLog.Invoke(new Action(() =>
            {
                TxtBoxLog.AppendText($"{TestThread.ThreadState}");
                TxtBoxLog.AppendText(Environment.NewLine);
                TxtBoxLog.ScrollToCaret();
            }));
            //Debug.WriteLine(TestThread.ThreadState);
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            TxtBoxLog.Invoke(new Action(() =>
            {
                TxtBoxLog.AppendText($"{TestThread.ThreadState}"); 
                TxtBoxLog.AppendText(Environment.NewLine);
                TxtBoxLog.ScrollToCaret();
            }));
            //Debug.WriteLine(TestThread.ThreadState);

            TestThread.Resume();

            TxtBoxLog.Invoke(new Action(() =>
            {
                TxtBoxLog.AppendText($"{TestThread.ThreadState}");
                TxtBoxLog.AppendText(Environment.NewLine);
                TxtBoxLog.ScrollToCaret();
            }));
            //Debug.WriteLine(TestThread.ThreadState);
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            TxtBoxLog.Invoke(new Action(() =>
            {
                TxtBoxLog.AppendText($"{TestThread.ThreadState}");
                TxtBoxLog.AppendText(Environment.NewLine);
                TxtBoxLog.ScrollToCaret();
            }));
            //Debug.WriteLine(TestThread.ThreadState);

            TestThread.Abort();

            TxtBoxLog.Invoke(new Action(() =>
            {
                TxtBoxLog.AppendText($"{TestThread.ThreadState}");
                TxtBoxLog.AppendText(Environment.NewLine);
                TxtBoxLog.ScrollToCaret();
            }));
            //Debug.WriteLine(TestThread.ThreadState);
        }
    }
}

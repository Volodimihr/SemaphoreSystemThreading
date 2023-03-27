namespace Exam_SysProcesses_WinForms_Threads_Karvatyuk
{
    public partial class SysProForm : Form
    {
        private Random random = null;
        private List<ProgressBar> progressBarList = null;
        private List<Label> labelList = null;
        private Semaphore semaphore = null;
        private bool isRunning = false;

        private bool IsRunning
        {
            get { return isRunning; }
            set
            {
                if (value != isRunning)
                {
                    isRunning = value;
                    btnStart.Enabled = !value;
                    numUDSeconds.Enabled = !value;
                    label2.Visible = !value;
                }
            }
        }

        public SysProForm()
        {
            InitializeComponent();

            random = new Random();
            progressBarList = new List<ProgressBar>();
            labelList = new List<Label>();
            semaphore = new Semaphore(3, 3);
            btnStart.Enabled = false;
            isRunning = false;
        }

        private void SysProForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (progressBarList.Count < 10 && numUDSeconds.Value != 0 && !isRunning)
            {
                int x = e.X;
                int y = e.Y;

                int seconds = random.Next((int)numUDSeconds.Value) + 1;

                if (label2.Visible)
                    label2.Visible = false;

                Label label = new Label()
                {
                    Location = new Point(x + 200, y),
                    Text = seconds.ToString()
                };

                ProgressBar progressBar = new ProgressBar()
                {
                    Location = new Point(x, y),
                    Width = 200,
                    Height = 20,
                    Value = 0,
                    Minimum = 0,
                    Maximum = seconds
                };

                Controls.Add(progressBar);
                Controls.Add(label);

                progressBarList.Add(progressBar);
                labelList.Add(label);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (progressBarList.Count != 0)
                IsRunning = true;

            for (int i = 0; i < progressBarList.Count; i++)
            {
                Thread thread = new Thread(Progression) { IsBackground = true };
                thread.Start(i);
            }
        }

        private void Progression(object index)
        {
            semaphore.WaitOne();
            int i = (int)index;
            ProgressBar? progressBar = progressBarList[i] as ProgressBar;
            int max = progressBar.Maximum;
            for (int j = 0; j < max; j++)
            {
                Tick(progressBar);
                Thread.Sleep(1000);
            }
            Remover(i);
            semaphore.Release();
        }

        private void Tick(ProgressBar bar)
        {
            if (bar.InvokeRequired)
            {
                bar.Invoke(new Action(() => Tick(bar)));
                return;
            }
            bar.Increment(1);
        }

        private void Remover(int index)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Remover(index)));
                return;
            }
            Controls.Remove(progressBarList[index]);
            Controls.Remove(labelList[index]);

            if (Controls.Count == 4)
            {
                progressBarList.Clear();
                labelList.Clear();
                IsRunning = false;
            }
        }

        private void numUDSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (numUDSeconds.Value == 0) btnStart.Enabled = false;
            else btnStart.Enabled = true;
        }
    }
}
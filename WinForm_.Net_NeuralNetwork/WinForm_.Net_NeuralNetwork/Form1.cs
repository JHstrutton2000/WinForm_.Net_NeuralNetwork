using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinForm_.Net_NeuralNetwork
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        double Wec, Wed, Wee;
        double Wa, Wb, Wc, Wd, We, Wf;
        double p0A, p0B, outA;
        double ia, ib;
        double error, expA;
        double learningRate = 1;
        double thresh = 0.001;


        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            myTimer.Tick += new EventHandler(TimerTick);
            myTimer.Start();
            InitializeComponent();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (myTimer.Enabled && Math.Abs(error) > thresh)
            {
                Errors.Text = error.ToString();

                FeedForward(sender, e);
                updateErrors();
                updateWeights(sender, e);
            }
            else
            {
                myTimer.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Wa = double.Parse(WeightA.Text);
                Wb = double.Parse(WeightB.Text);
                Wc = double.Parse(WeightC.Text);
                Wd = double.Parse(WeightD.Text);
                We = double.Parse(WeightE.Text);
                Wf = double.Parse(WeightF.Text);

                ia = double.Parse(InNeuronA.Text);
                ib = double.Parse(InNeuronB.Text);

                expA = double.Parse(ExpectedLabel.Text);

                thresh = double.Parse(Errorthresh.Text);
                learningRate = double.Parse(learningRateInput.Text);
            }
            catch { }

        }

        void updateErrors()
        {
            error = expA - outA;
            Wee = outA * (1 - outA) * error;

            Wec = p0A * (1 - p0A) * We * Wee;
            Wed = p0B * (1 - p0B) * Wf * Wee;


            OuError.Text = Wee.ToString();
            Pr0ErrorA.Text = Wec.ToString();
            Pr0ErrorB.Text = Wed.ToString();
        }

        private void updateWeights(object sender, EventArgs e)
        {

            Wa += learningRate * Wec * ia;
            Wb += learningRate * Wed * ia;
            Wc += learningRate * Wec * ib;
            Wd += learningRate * Wed * ib;
            We += learningRate * Wee * p0A;
            Wf += learningRate * Wee * p0B;

            WeightA.Text = Wa.ToString();
            WeightB.Text = Wb.ToString();
            WeightC.Text = Wc.ToString();
            WeightD.Text = Wd.ToString();
            WeightE.Text = We.ToString();
            WeightF.Text = Wf.ToString();
        }

        private double sigmoid(double input)
        {
            return 1 / (1 + Math.Pow(Math.E, -input));
        }

        private void randomWeights(object sender, EventArgs e)
        {
            Wa = 2 * rand.NextDouble() - 1;
            Wb = 2 * rand.NextDouble() - 1;
            Wc = 2 * rand.NextDouble() - 1;
            Wd = 2 * rand.NextDouble() - 1;
            We = 2 * rand.NextDouble() - 1;
            Wf = 2 * rand.NextDouble() - 1;

            WeightA.Text = Wa.ToString();
            WeightB.Text = Wb.ToString();
            WeightC.Text = Wc.ToString();
            WeightD.Text = Wd.ToString();
            WeightE.Text = We.ToString();
            WeightF.Text = Wf.ToString();
        }

        private void FeedForward(object sender, EventArgs e)
        {
            if (InNeuronA.Text != "" && InNeuronB.Text != "")
            {
                Pr0NeuronA.Text = "";
                Pr0NeuronB.Text = "";
                OuNeuronA.Text = "";

                if (Pr0NeuronA.Text != "")
                    p0A = double.Parse(Pr0NeuronA.Text);
                else
                    p0A = 0;

                if (Pr0NeuronB.Text != "")
                    p0B = double.Parse(Pr0NeuronB.Text);
                else
                    p0B = 0;


                p0A += (ia * Wa);
                p0A += (ib * Wc);
                p0A = sigmoid(p0A);

                p0B += (ia * Wb);
                p0B += (ib * Wd);
                p0B = sigmoid(p0B);

                if (OuNeuronA.Text != "")
                    outA = double.Parse(OuNeuronA.Text);
                else
                    outA = 0;

                outA += p0A * We;
                outA += p0B * Wf;
                outA = sigmoid(outA);

                Pr0NeuronA.Text = p0A.ToString();
                Pr0NeuronB.Text = p0B.ToString();
                OuNeuronA.Text = outA.ToString();
            }
        }

        private void randomizeInputs(object sender, EventArgs e)
        {
            InNeuronA.Text = (2 * rand.NextDouble() - 1).ToString();
            InNeuronB.Text = (2 * rand.NextDouble() - 1).ToString();
        }

        private void Train(object sender, EventArgs e)
        {
            FeedForward(sender, e);
            updateErrors();
            updateWeights(sender, e);
        }

        private void NeuronAChanged(object sender, EventArgs e)
        {
            if (InNeuronA.Text != "-")
            {
                ia = double.Parse(InNeuronA.Text);
            }
        }

        private void NeuronBChanged(object sender, EventArgs e)
        {
            if (InNeuronB.Text != "-")
            {
                ib = double.Parse(InNeuronB.Text);
            }
        }

        private void WeightA_TextChanged(object sender, EventArgs e)
        {
            if (WeightA.Text != "-")
            {
                Wa = double.Parse(WeightA.Text);
            }
        }

        private void WeightB_TextChanged(object sender, EventArgs e)
        {
            if (WeightB.Text != "-")
            {
                Wb = double.Parse(WeightB.Text);
            }
        }

        private void WeightC_TextChanged(object sender, EventArgs e)
        {
            if (WeightC.Text != "-")
            {
                Wc = double.Parse(WeightC.Text);
            }
        }

        private void WeightD_TextChanged(object sender, EventArgs e)
        {
            if (WeightD.Text != "-")
            {
                Wd = double.Parse(WeightD.Text);
            }
        }

        private void WeightE_TextChanged(object sender, EventArgs e)
        {
            if (WeightE.Text != "-")
            {
                We = double.Parse(WeightE.Text);
            }
        }

        private void WeightF_TextChanged(object sender, EventArgs e)
        {
            if (WeightF.Text != "-")
            {
                Wf = double.Parse(WeightF.Text);
            }
        }

        private void StartTraining_Click(object sender, EventArgs e)
        {
            FeedForward(sender, e);
            updateErrors();
            myTimer.Enabled = true;
        }
        private void StopTraining_Click(object sender, EventArgs e)
        {
            myTimer.Enabled = false;
        }

        private void Errorthresh_TextChanged(object sender, EventArgs e)
        {
            thresh = double.Parse(Errorthresh.Text);
        }

        private void learningRateInput_TextChanged(object sender, EventArgs e)
        {
            learningRate = double.Parse(learningRateInput.Text);
        }

        private void ExpectedA_TextChanged(object sender, EventArgs e)
        {
            expA = double.Parse(ExpectedA0.Text);
        }
    }
}